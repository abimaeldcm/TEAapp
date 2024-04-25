using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TEAapp.Models;

namespace TEAapp.Data.Configurations
{
    public class AdministradorConfiguration : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.ToTable("Administradores");

            builder.Property(a => a.Id).IsRequired();

            builder.Property(a => a.NomeCompleto)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(a => a.CPF)
                   .IsRequired()
                   .HasMaxLength(14);

            builder.Property(a => a.Senha)
                   .IsRequired();

            builder.Property(a => a.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(a => a.DataNascimento)
                   .IsRequired();

            builder.Property(a => a.Telefone)
                   .HasMaxLength(20);

            builder.Property(a => a.Endereco)
                   .HasMaxLength(200);
        }
    }
}
