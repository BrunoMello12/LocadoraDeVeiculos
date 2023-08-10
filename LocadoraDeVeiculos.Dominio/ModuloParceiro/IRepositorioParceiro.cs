using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloParceiro
{
    public interface IRepositorioParceiro : IRepositorio<Parceiro>
    {
        public List<Parceiro> SelecionarTodos(bool incluirCupons = false);
        public Parceiro SelecionarPorNome(string nome);
    }
}
