using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnClass.Domain.Models;

namespace OnClass.Infra.Mappings
{
    public class InstrutorDisciplinaMap : IEntityTypeConfiguration<InstrutorDisciplina>
    {
        public void Configure(EntityTypeBuilder<InstrutorDisciplina> builder)
        {
            builder.ToTable("INSTRUTOR_DISCIPLINA");
            builder.HasKey(k => new { k.Id }).HasName("ID_INSTRUTOR_DISCIPLINA");
            builder.Property(p => p.Id).HasColumnName("ID");

            builder.Property(p => p.InstrutorId).HasColumnName("INSTRUTOR_ID");
            builder.HasOne<Estudante>().WithMany().HasForeignKey(f => f.InstrutorId);

            builder.Property(p => p.DisciplinaId).HasColumnName("DISCIPLINA_ID");
            builder.HasOne<Disciplina>().WithMany().HasForeignKey(f => f.DisciplinaId);
        }
    }
}
