﻿using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCobranca;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;

namespace LocadorDeVeiculos.TesteUnitarios.Dominio.ModuloGrupoAutomoveis
{
    [TestClass]
    public class GrupoAutomoveisTeste
    {
        GrupoAutomoveis grupoAutomoveis;
        Automovel automovel1;
        Cobranca cobranca01;

        public GrupoAutomoveisTeste()
        {
            grupoAutomoveis = new GrupoAutomoveis("Teste");
            automovel1 = new Automovel(5000, "Ford", "AAA-3333", "Verde", "Chevette", TipoCombustivelEnum.Diesel, 50, 2002);
            cobranca01 = new Cobranca(grupoAutomoveis, TipoPlanoEnum.PlanoDiario, 20, 10);
        }

        [TestMethod]
        public void Teste_Permitir_Inserir_Automoveis()
        {
            // arrange
            var automovel2 = new Automovel(5000, "Ford", "AAA-1234", "Verde", "Marca", TipoCombustivelEnum.Gasolina, 50, 2002);
            var automovel3 = new Automovel(5000, "Ford", "BBB-1234", "Branco", "Marca", TipoCombustivelEnum.Gasolina, 50, 2002);

            // act
            grupoAutomoveis.listaDeAutomoveis.Add(automovel1);
            grupoAutomoveis.listaDeAutomoveis.Add(automovel2);
            grupoAutomoveis.listaDeAutomoveis.Add(automovel3);

            // assert
            grupoAutomoveis.listaDeAutomoveis.Count.Should().Be(3);

        }

        [TestMethod]
        public void Teste_Permitir_Inserir_Cobrancas()
        {
            //arrange
            var cobranca02 = new Cobranca(grupoAutomoveis, TipoPlanoEnum.PlanoControlador, 50, 20);
            var cobranca03 = new Cobranca(grupoAutomoveis, TipoPlanoEnum.PlanoControlador, 40, 90);

            // act
            grupoAutomoveis.listaDeCobrancas.Add(cobranca01);
            grupoAutomoveis.listaDeCobrancas.Add(cobranca02);
            grupoAutomoveis.listaDeCobrancas.Add(cobranca03);

            // assert
            grupoAutomoveis.listaDeCobrancas.Count.Should().Be(3);
        }

        [TestMethod]
        public void ListaCobrancas_Deve_ser_diferente_de_null()
        {
            grupoAutomoveis.listaDeCobrancas.Should().NotBeNull();
        }

        [TestMethod]
        public void ListaAutomoveis_Deve_ser_diferente_de_null()
        {
            grupoAutomoveis.listaDeAutomoveis.Should().NotBeNull();
        }

        [TestMethod]
        public void Nao_deve_adicionar_automoveis_iguais_na_ListaDeAutomoveis()
        {
            //action
            grupoAutomoveis.AdicionarAutomovel(automovel1);
            grupoAutomoveis.AdicionarAutomovel(automovel1);

            //assert
            grupoAutomoveis.listaDeAutomoveis.Should().HaveCount(1);
        }

        [TestMethod]
        public void Nao_deve_adicionar_Cobrancas_iguais_na_ListaDeCobrancas()
        {
            //action
            grupoAutomoveis.AdicionarCobranca(cobranca01);
            grupoAutomoveis.AdicionarCobranca(cobranca01);

            //assert
            grupoAutomoveis.listaDeCobrancas.Should().HaveCount(1);
        }
    }
}
