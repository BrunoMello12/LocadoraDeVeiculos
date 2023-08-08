using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloParceiro
{
    internal class MapeadorParceiroOrm : IEntityTypeConfiguration<Parceiro>
    {
        public void Configure(EntityTypeBuilder<Parceiro> builder)
        {
            builder.ToTable("TBParceiro");

            builder.Property(x => x.Id).IsRequired().ValueGeneratedNever();

            builder.Property(x => x.Nome).HasColumnType("varchar(MAX)").IsRequired();
        }
    }
}
