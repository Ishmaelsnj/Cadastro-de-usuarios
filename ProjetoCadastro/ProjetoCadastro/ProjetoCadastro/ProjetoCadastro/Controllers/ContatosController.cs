using ProjetoCadastro.Data;
using ProjetoCadastro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using ProjetoCadastro.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace ProjetoCadastro.Controllers
{
    public class ContatosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;


        public ContatosController(AppDbContext context, IMapper mapper = null)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var contatos = await _context.Contatos.Include(c => c.Telefones).ToListAsync();
            return View(contatos);
        }

        public IActionResult Create()
        {
            var contato = new CreateContatoDto();
            return View(contato);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateContatoDto contato)
        {
            if (ModelState.IsValid)
            {
                ContatoModel contatoModel = _mapper.Map<ContatoModel>(contato);

                _context.Contatos.Add(contatoModel);
                await _context.SaveChangesAsync();                

                TempData["Mensagem"] = "Contato salvo com sucesso!";
                return RedirectToAction(nameof(Index));
            }

            return View(contato);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = await _context.Contatos.Include(c => c.Telefones).FirstOrDefaultAsync(c => c.Id == id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ContatoModel contato)
        {
            if (id != contato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contato);

                    foreach (var telefone in contato.Telefones)
                    {
                        if (telefone.Id == 0)
                        {
                            _context.Telefones.Add(telefone);
                        }
                        else
                        {
                            var telefoneDb = await _context.Telefones.FindAsync(telefone.Id);
                            if (telefoneDb != null)
                            {
                                telefoneDb.Numero = telefone.Numero;
                                telefoneDb.TipoTelefone = telefone.TipoTelefone;
                                _context.Telefones.Update(telefoneDb);
                            }
                        }
                    }
                    List<int> contatosRestantes= new List<int>();
                    contato.Telefones.ForEach(x => contatosRestantes.Add(x.Id));
                    var telefonesDb = _context.Telefones.Where(t => t.ContatoId == contato.Id).ToList();
                    foreach (var telefoneDb in telefonesDb)
                    {
                        if (!contatosRestantes.Any(id => id == telefoneDb.Id))
                        {
                            _context.Telefones.Remove(telefoneDb);
                        }
                    }
                    await _context.SaveChangesAsync();

                    TempData["Mensagem"] = "Contato atualizado com sucesso!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContatoExists(contato.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(contato);
        }
        private bool ContatoExists(int id)
        {
            return _context.Contatos.Any(e => e.Id == id);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contato = await _context.Contatos.Include(c => c.Telefones).FirstOrDefaultAsync(c => c.Id == id);
            if (contato != null)
            {
                _context.Telefones.RemoveRange(contato.Telefones);
                _context.Contatos.Remove(contato);
                await _context.SaveChangesAsync();
            }

            TempData["Mensagem"] = "Contato excluído com sucesso!";
            return RedirectToAction(nameof(Index));
        }

            public async Task<IActionResult> Delete(int id)
        {
            var contato = await _context.Contatos.FirstOrDefaultAsync(c => c.Id == id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }

        public async Task<IActionResult> ConsultaContato(string searchTerm)
        {
            IQueryable<ContatoModel> query = _context.Contatos;

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                if (int.TryParse(searchTerm, out int id))
                {
                    query = query.Where(c => c.Id == id);
                }
                else
                {
                    query = query.Where(c => c.Nome.Contains(searchTerm));
                }
            }
            var contatos = await query.ToListAsync();
            return View(contatos);
        }


    }
}
