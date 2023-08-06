using LocadoraDeVeiculos.Dominio.ModuloCobranca;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCondutor
{
    public class RepositorioCondutorEmOrm : RepositorioBaseEmOrm<Condutor>, IRepositorioCondutor
    {
        public RepositorioCondutorEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {
        }

        public Condutor SelecionarPorNome(string nome)
        {
            return registros.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Condutor> SelecionarTodos(bool incluirCliente = false)
        {
            if (incluirCliente)
                return registros.Include(x => x.Cliente).ToList();

            return registros.ToList();
        }
    }
}
