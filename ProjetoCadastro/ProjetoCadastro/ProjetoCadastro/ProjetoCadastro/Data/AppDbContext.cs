using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Models;

namespace ProjetoCadastro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<TelefoneModel> Telefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TelefoneModel>()
                .HasOne(t => t.Contato)
                .WithMany(c => c.Telefones)
                .HasForeignKey(t => t.ContatoId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
