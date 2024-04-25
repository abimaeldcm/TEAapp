using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TEAapp.Models;

namespace TEAapp.Data.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medicos");

            builder.Property(m => m.CRM).IsRequired();

            builder.Property(m => m.Especialidades).IsRequired();

        }
    }
}
