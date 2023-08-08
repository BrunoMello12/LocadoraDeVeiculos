using LocadoraDeVeiculos.Dominio.ModuloFuncionario;

namespace LocadorDeVeiculos.TesteUnitarios.Dominio.ModuloFuncionario
{
    [TestClass]
    public class FuncionarioTeste
    {
        Funcionario funcionario;

        public FuncionarioTeste()
        {
            funcionario = new Funcionario(new Guid(), "Gabriel", DateTime.Now, 2500);
        }
    }
}
