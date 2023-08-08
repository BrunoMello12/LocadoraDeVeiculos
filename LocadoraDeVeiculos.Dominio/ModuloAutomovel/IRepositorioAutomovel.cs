using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel
{
    public interface IRepositorioAutomovel : IRepositorio<Automovel>
    {
        public List<Automovel> SelecionarPorGrupo(GrupoAutomoveis grupoAutomovel);
        public Automovel SelecionarPorId(Guid id, bool incluirGrupoDoAutomovel = false);
        public List<Automovel> SelecionarTodos(bool incluirGrupoDoAutomovel = false);
    }
}
