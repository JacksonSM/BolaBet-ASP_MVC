using BolaBet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BolaBet.Infra.Data.EntitiesConfiguration
{
    class ApostadorConfiguration : IEntityTypeConfiguration<Apostador>
    {
        public void Configure(EntityTypeBuilder<Apostador> builder)
        {
            builder.ToTable("APOSTADORES");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .UseIdentityColumn();


            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Usuario)
                .HasColumnName("USUARIO")
               .HasMaxLength(30)
               .IsRequired();

            builder.Property(p => p.Senha)
                .HasColumnName("SENHA")
               .HasMaxLength(8)
               .IsRequired();

            builder.Property(p => p.Saldo)
                .HasColumnName("SALDO");
        }
    }
}
