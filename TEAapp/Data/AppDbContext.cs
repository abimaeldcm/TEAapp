using Microsoft.EntityFrameworkCore;
using TEAapp.Data.Configurations;
using TEAapp.Models;

namespace TEAapp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pessoa> Administradores { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            modelBuilder.ApplyConfiguration(new MedicoConfiguration());
            modelBuilder.ApplyConfiguration(new AdministradorConfiguration());
        }

    }
}
