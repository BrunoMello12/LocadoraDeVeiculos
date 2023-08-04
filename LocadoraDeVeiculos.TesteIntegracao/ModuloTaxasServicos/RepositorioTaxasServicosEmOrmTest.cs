using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloTaxasServicos;
using LocadoraDeVeiculos.TesteIntegracao.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.TesteIntegracao.ModuloTaxasServicos
{
    [TestClass]
    public class RepositorioTaxasServicosEmOrmTest : TestesIntegracaoBase
    {
        [TestMethod]
        public void Deve_Inserir_Taxas_ou_Servicos()
        {
            var taxa = Builder<TaxasServicos>.CreateNew().Build();
            taxa.PrecoDiaria = true;
            repositorioTaxasServicos.Inserir(taxa);

            repositorioFuncionario.SelecionarPorId(taxa.Id).Should().Be(taxa);
        }

        [TestMethod]
        public void Deve_Editar_Taxas_ou_Servicos()
        {
            var funcionarioId = Builder<Funcionario>.CreateNew().Persist().Id;

            var funcionario = repositorioFuncionario.SelecionarPorId(funcionarioId);
            funcionario.Nome = "Cleiton";

            repositorioFuncionario.Editar(funcionario);

            repositorioFuncionario.SelecionarPorId(funcionario.Id)
                .Should().Be(funcionario);
        }

        [TestMethod]
        public void Deve_excluir_Taxas_ou_Servicos()
        {
            var funcionario = Builder<Funcionario>.CreateNew().Persist();
            repositorioFuncionario.Excluir(funcionario);

            repositorioFuncionario.SelecionarPorId(funcionario.Id).Should().BeNull();
        }

        [TestMethod]
        public void Deve_selecionar_todos_Taxas_ou_Servicos()
        {
            var funcionario1 = Builder<Funcionario>.CreateNew().Persist();
            var funcionario2 = Builder<Funcionario>.CreateNew().Persist();

            var funcionarios = repositorioFuncionario.SelecionarTodos();

            funcionarios.Should().ContainInOrder(funcionario1, funcionario2);
            funcionarios.Should().HaveCount(2);
        }

        [TestMethod]
        public void Deve_selecionar_Taxas_ou_Servicos_por_nome()
        {
            var funcionario = Builder<Funcionario>.CreateNew().Persist();

            var funcionarioEncontrado = repositorioFuncionario.SelecionarPorNome(funcionario.Nome);

            funcionarioEncontrado.Should().Be(funcionario);
        }

        [TestMethod]
        public void Deve_selecionar_Taxas_ou_Servicos_por_id()
        {
            var taxa = Builder<TaxasServicos>.CreateNew().Persist();

            var taxaEncontrada = repositorioFuncionario.SelecionarPorId(taxa.Id);
          
            taxaEncontrada.Should().Be(taxa);
        }
    }
}
