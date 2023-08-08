using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloFuncionario
{
    public class MapeadorFuncionarioOrm : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("TBFuncionario");

            builder.Property(x => x.Id).IsRequired().ValueGeneratedNever();

            builder.Property(x => x.Nome).HasColumnType("varchar(MAX)").IsRequired();

            builder.Property(x => x.Salario).HasColumnType("decimal").IsRequired();
        }
    }
}
