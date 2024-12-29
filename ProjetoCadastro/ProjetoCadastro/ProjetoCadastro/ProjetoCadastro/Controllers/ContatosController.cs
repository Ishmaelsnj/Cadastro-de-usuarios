using ProjetoCadastro.Data;
using ProjetoCadastro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using ProjetoCadastro.DTOs;
using AutoMapper;

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

        // Tela para exibir todos os contatos
        public async Task<IActionResult> Index()
        {
            var contatos = await _context.Contatos.Include(c => c.Telefones).ToListAsync();
            return View(contatos);
        }

        // Tela para criar um novo contato
        public IActionResult Create()
        {
            var contato = new ContatoModel();
            contato.Telefones.Add(new TelefoneModel()); // Adicionar um telefone vazio por padrão
            return View(contato);
        }

        // Criação do contato (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateContatoDto contato)
        {
            if (ModelState.IsValid)
            {
                ContatoModel contatoModel = _mapper.Map<ContatoModel>(contato);
                // Salvar o contato primeiro para gerar o ID
                _context.Contatos.Add(contatoModel);
                await _context.SaveChangesAsync();  // Salva o contato e gera o Id                

                TempData["Mensagem"] = "Contato salvo com sucesso!";
                return RedirectToAction(nameof(Index));  // Redirecionar para a lista de contatos
            }

            // Caso o modelo não seja válido, retornar a view com erros de validação
            return View(contato);
        }


        // Tela para editar um contato
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

        // Atualização do contato (POST)
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
                    // Atualizar o contato
                    _context.Update(contato);

                    // Gerenciar telefones
                    foreach (var telefone in contato.Telefones)
                    {
                        if (telefone.Id == 0)
                        {
                            // Novo telefone
                            _context.Telefones.Add(telefone);
                        }
                        else
                        {
                            // Telefone existente
                            _context.Telefones.Update(telefone);
                        }
                    }

                    // Remover telefones que foram excluídos na view
                    var telefonesDb = _context.Telefones.Where(t => t.ContatoId == contato.Id).ToList();
                    foreach (var telefoneDb in telefonesDb)
                    {
                        if (!contato.Telefones.Any(t => t.Id == telefoneDb.Id))
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

        // Verifica se o contato existe
        private bool ContatoExists(int id)
        {
            return _context.Contatos.Any(e => e.Id == id);
        }

        // Ação para excluir o contato
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
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

    }
}
