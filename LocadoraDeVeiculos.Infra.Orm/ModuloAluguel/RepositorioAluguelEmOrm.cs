using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAluguel
{
    public class RepositorioAluguelEmOrm : RepositorioBaseEmOrm<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {
        }
    }
}
