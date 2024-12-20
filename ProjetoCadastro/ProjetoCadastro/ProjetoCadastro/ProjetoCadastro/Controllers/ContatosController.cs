using ProjetoCadastro.Data;
using ProjetoCadastro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace ProjetoCadastro.Controllers
{
    public class ContatosController : Controller
    {
        private readonly AppDbContext _context;

        public ContatosController(AppDbContext context)
        {
            _context = context;
        }

        // Tela para exibir todos os contatos
        public async Task<IActionResult> Index()
        {
            var contatos = await _context.Contatos.ToListAsync();
            return View(contatos);
        }

        // Tela para criar um novo contato
        public IActionResult Create()
        {
            return View();
        }

        // Criação do contato (POST)
        [HttpPost]
        public async Task<IActionResult> Create(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contato);
                await _context.SaveChangesAsync();
                TempData["Mensagem"] = "Contato salvo com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        // Tela para editar um contato
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = await _context.Contatos.FindAsync(id);
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
                    _context.Update(contato);
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

        // Ação para excluir o contato (POST)
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contato = await _context.Contatos.FindAsync(id);
            if (contato != null)
            {
                _context.Contatos.Remove(contato);
                await _context.SaveChangesAsync();
            }

            TempData["Mensagem"] = "Contato excluído com sucesso!";
            return RedirectToAction("Index", "Contatos"); // Redireciona de volta para a lista de contatos
        }
    }
}
