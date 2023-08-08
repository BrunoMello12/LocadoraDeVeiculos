using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloParceiro
{
    public interface IRepositorioParceiro : IRepositorio<Parceiro>
    {
        public Parceiro SelecionarPorNome(string nome);
    }
}
