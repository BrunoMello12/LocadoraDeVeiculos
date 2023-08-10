using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCobranca;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.Dominio.ModuloTaxasServicos;
using LocadoraDeVeiculos.TesteIntegracao.Compartilhado;

namespace LocadoraDeVeiculos.TestesIntegracao.ModuloPlanoDeCobranca
{
    [TestClass]
    public class RepositorioAluguelEmOrmTest : TestesIntegracaoBase
    {

        [TestMethod]
        public void Deve_inserir_Aluguel()
        {
            var parceiro = Builder<Parceiro>.CreateNew().Build();
            var cliente = Builder<Cliente>.CreateNew().Build();
            var grupoAutomoveis = Builder<GrupoAutomoveis>.CreateNew().Build();
            var cupom = Builder<Cupom>.CreateNew().Build();
            cupom.Parceiro = parceiro;
            var automovel = Builder<Automovel>.CreateNew().Build();
            automovel.GrupoDoAutomovel = grupoAutomoveis;
            var taxasServicos = Builder<TaxasServicos>.CreateNew().Build();
            var funcionario = Builder<Funcionario>.CreateNew().Build();
            var condutor = Builder<Condutor>.CreateNew().Build();
            condutor.Cliente = cliente;
            var cobranca = Builder<Cobranca>.CreateNew().Build();
            cobranca.GrupoAutomoveis = grupoAutomoveis;
            var aluguel = Builder<Aluguel>.CreateNew().Build();
            aluguel.Condutor = condutor;
            aluguel.Cobranca = cobranca;
            aluguel.Cliente = cliente;
            aluguel.Automovel = automovel;
            aluguel.ListaTaxasSelecionadas.Add(taxasServicos);
            aluguel.GrupoAutomoveis = grupoAutomoveis;
            aluguel.Funcionario = funcionario;
            aluguel.Cupom = cupom;


            //action
            repositorioAluguel.Inserir(aluguel);

            contextoPersistencia.GravarDados();

            //assert
            repositorioAluguel.SelecionarPorId(aluguel.Id).Should().Be(aluguel);
        }
    }
}

