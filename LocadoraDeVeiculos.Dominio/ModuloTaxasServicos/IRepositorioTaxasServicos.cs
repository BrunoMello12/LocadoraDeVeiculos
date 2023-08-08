using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxasServicos
{
    public interface IRepositorioTaxasServicos : IRepositorio<TaxasServicos>
    {
        public TaxasServicos SelecionarPorNome(string nome);

    }
}
