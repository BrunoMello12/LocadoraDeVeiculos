using LocadoraDeVeiculos.Dominio.ModuloTaxasServicos;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloTaxasServicos
{
    public class RepositorioTaxasServicosEmOrm : RepositorioBaseEmOrm<TaxasServicos>, IRepositorioTaxasServicos
    {
        public RepositorioTaxasServicosEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {

        }

        public TaxasServicos SelecionarPorNome(string nome)
        {
            return registros.FirstOrDefault(x => x.Nome == nome);
        }
    }
}
