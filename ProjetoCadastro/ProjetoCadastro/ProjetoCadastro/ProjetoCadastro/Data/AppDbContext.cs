using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Models;

namespace ProjetoCadastro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
