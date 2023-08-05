using FluentAssertions;
using FluentResults;
using FluentResults.Extensions.FluentAssertions;
using FluentValidation.Results;
using LocadoraDeVeiculos.Aplicacao.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using Moq;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace LocadoraDeVeiculos.TestesUnitarios.Aplicacao.ModuloCupom
{
    [TestClass]
    public class ServicoCupomTest
    {
        Mock<IRepositorioCupom> repositorioCupomMoq;
        Mock<IValidadorCupom> validadorMoq;

        private ServicoCupom servicoCupom;

        Cupom cupom;
        Parceiro parceiro;

        public ServicoCupomTest()
        {
            repositorioCupomMoq = new Mock<IRepositorioCupom>();
            validadorMoq = new Mock<IValidadorCupom>();
            servicoCupom = new ServicoCupom(repositorioCupomMoq.Object, validadorMoq.Object);
            parceiro = new Parceiro("Jorge");

            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente ("Mariana"));

            cupom = new Cupom("CUPOM10", 200, new DateTime(24/02/2024), parceiro, clientes);
        }

        [TestMethod]
        public void Deve_inserir_cupom_caso_ele_for_validp() 
        {
            Result resultado = servicoCupom.Inserir(cupom);

            resultado.Should().BeSuccess();
            repositorioCupomMoq.Verify(x => x.Inserir(cupom), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_inserir_cupom_caso_ela_seja_invalida()
        {
            validadorMoq.Setup(x => x.Validate(It.IsAny<Cupom>()))
                .Returns(() =>
                {
                    var resultado = new ValidationResult();
                    resultado.Errors.Add(new ValidationFailure("Nome", "Nome não pode ter caracteres especiais"));
                    return resultado;
                });

            var resultado = servicoCupom.Inserir(cupom);
    
            resultado.Should().BeFailure();
            repositorioCupomMoq.Verify(x => x.Inserir(cupom), Times.Never());
        }

        [TestMethod]
        public void Nao_deve_inserir_cupom_caso_o_nome_ja_esteja_cadastrado()
        {
            string nomeCupom = "CUPOM10";
            repositorioCupomMoq.Setup(x => x.SelecionarPorNome(nomeCupom))
                .Returns(() =>
                {
                    return new Cupom(nomeCupom);
                });

            var resultado = servicoCupom.Inserir(cupom);

            resultado.Should().BeFailure();
            resultado.Reasons[0].Message.Should().Be($"Este nome '{nomeCupom}' já está sendo utilizado");
            repositorioCupomMoq.Verify(x => x.Inserir(cupom), Times.Never());
        }

        [TestMethod]
        public void Deve_tratar_erro_caso_ocorra_falha_ao_tentar_inserir_Cupom() 
        {
            repositorioCupomMoq.Setup(x => x.Inserir(It.IsAny<Cupom>()))
                .Throws(() =>
                {
                    return new Exception();
                });

            Result resultado = servicoCupom.Inserir(cupom);

            resultado.Should().BeFailure();
            resultado.Reasons[0].Message.Should().Be("Falha ao tentar inserir cupom.");
        }

        [TestMethod]
        public void Deve_editar_cupom_caso_ele_for_valido() 
        {       
            cupom = new Cupom("CUPOM1000");

            Result resultado = servicoCupom.Editar(cupom);

            resultado.Should().BeSuccess();
            repositorioCupomMoq.Verify(x => x.Editar(cupom), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_editar_cupom_caso_ele_seja_invalido()
        {
            validadorMoq.Setup(x => x.Validate(It.IsAny<Cupom>()))
                .Returns(() =>
                {
                    var resultado = new ValidationResult();
                    resultado.Errors.Add(new ValidationFailure("Nome", "Nome não pode ter caracteres especiais"));
                    return resultado;
                });

            var resultado = servicoCupom.Editar(cupom);
          
            resultado.Should().BeFailure();
            repositorioCupomMoq.Verify(x => x.Editar(cupom), Times.Never());
        }

        [TestMethod]
        public void Deve_editar_cupom_com_o_mesmo_nome() 
        {
            Guid id = Guid.NewGuid();

            repositorioCupomMoq.Setup(x => x.SelecionarPorNome("CUPOM10"))
                 .Returns(() =>
                 {
                     return new Cupom(id, "CUPOM10");
                 });

            Cupom outroCupom = new Cupom(id, "CUPOM10");

            var resultado = servicoCupom.Editar(outroCupom);

            resultado.Should().BeSuccess();

            repositorioCupomMoq.Verify(x => x.Editar(outroCupom), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_editar_cupom_caso_o_nome_ja_esteja_cadastrado()
        {
            //arrange
            repositorioCupomMoq.Setup(x => x.SelecionarPorNome("CUPOM10"))
                 .Returns(() =>
                 {
                     return new Cupom("CUPOM10");
                 });

            Cupom novoCupom = new Cupom("CUPOM10");

            var resultado = servicoCupom.Editar(novoCupom);

            resultado.Should().BeFailure();

            repositorioCupomMoq.Verify(x => x.Editar(novoCupom), Times.Never());
        }

        [TestMethod]
        public void Deve_tratar_erro_caso_ocorra_falha_ao_tentar_editar_cupom()
        {
            repositorioCupomMoq.Setup(x => x.Editar(It.IsAny<Cupom>()))
                .Throws(() =>
                {
                    return new Exception();
                });

            Result resultado = servicoCupom.Editar(cupom);

            resultado.Should().BeFailure();
            resultado.Errors[0].Message.Should().Be("Falha ao tentar editar Cupom.");
        }

        [TestMethod]
        public void Deve_excluir_cupom_caso_ele_esteja_cadastrado() 
        {
            var cupom = new Cupom("CUPOM10");

            repositorioCupomMoq.Setup(x => x.Existe(cupom))
               .Returns(() =>
               {
                   return true;
               });

            var resultado = servicoCupom.Excluir(cupom);

            resultado.Should().BeSuccess();
            repositorioCupomMoq.Verify(x => x.Excluir(cupom), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_excluir_cupom_caso_ele_nao_esteja_cadastrado() 
        {
            var cupom = new Cupom("CUPOM10");

            repositorioCupomMoq.Setup(x => x.Existe(cupom))
               .Returns(() =>
               {
                   return false;
               });

            var resultado = servicoCupom.Excluir(cupom);

            resultado.Should().BeFailure();
            repositorioCupomMoq.Verify(x => x.Excluir(cupom), Times.Never());
        }

        //[TestMethod]
        //public void Deve_tratar_erro_caso_ocorra_falha_ao_tentar_excluir_cupom()
        //{
        //    var cupom = new Cupom("CUPOM10");

        //    repositorioCupomMoq.Setup(x => x.Existe(cupom))
        //      .Throws(() =>
        //      {
        //          return SqlExeptionCreator.NewSqlException();
        //      });

        //    Result resultado = servicoCupom.Excluir(cupom);

        //    resultado.Should().BeFailure();
        //    resultado.Reasons[0].Message.Should().Be("Falha ao tentar excluir Cupom");
        //}
    }
}
