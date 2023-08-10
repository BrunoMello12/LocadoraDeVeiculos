using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloAluguel
{
    public interface IRepositorioAluguel : IRepositorio<Aluguel>
    {
        public Aluguel SelecionarPorId(Guid id, bool incluirCupom = false);

        public List<Aluguel> SelecionarTodos(bool incluirCupom = false);
    }
}
