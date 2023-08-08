using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel
{
    public interface IRepositorioAutomovel : IRepositorio<Automovel>
    {
        public Automovel SelecionarPorId(Guid id, bool incluirGrupoDoAutomovel = false);
        public List<Automovel> SelecionarTodos(bool incluirGrupoDoAutomovel = false);
    }
}
