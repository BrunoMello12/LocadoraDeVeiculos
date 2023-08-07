using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloCobranca;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.TesteIntegracao.Compartilhado;

namespace LocadoraDeVeiculos.TestesIntegracao.ModuloPlanoDeCobranca
{
    [TestClass]
    public class RepositorioPlanoDeCobrancaEmOrmTest : TestesIntegracaoBase
    {
        [TestMethod]
        public void Deve_inserir_PlanoDeCobranca()
        {
            //arrange
            var cobranca = Builder<Cobranca>.CreateNew().Build();

            cobranca.GrupoAutomoveis = Builder<GrupoAutomoveis>.CreateNew().Build();

            //action
            repositorioCobranca.Inserir(cobranca);

            //assert
            repositorioCobranca.SelecionarPorId(cobranca.Id).Should().Be(cobranca);
        }
    }
}
