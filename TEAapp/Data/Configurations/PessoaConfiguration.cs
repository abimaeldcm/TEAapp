using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TEAapp.Models;

namespace TEAapp.Data.Configurations
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoas"); 

            builder.HasKey(p => p.Id);

            builder.Property(p => p.NomeCompleto)
                   .IsRequired()
                   .HasMaxLength(100); 

            builder.Property(p => p.CPF)
                   .IsRequired()
                   .HasMaxLength(14); 

            builder.Property(p => p.Senha)
                   .IsRequired();

            builder.Property(p => p.Email)
                   .IsRequired()
                   .HasMaxLength(100); 

            builder.Property(p => p.DataNascimento)
                   .IsRequired();

            builder.Property(p => p.Telefone)
                   .HasMaxLength(20); 

            builder.Property(p => p.Endereco)
                   .HasMaxLength(200); 
        }
    }
    
}
