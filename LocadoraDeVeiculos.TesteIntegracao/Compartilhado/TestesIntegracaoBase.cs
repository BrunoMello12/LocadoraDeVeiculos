using FizzWare.NBuilder;
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
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using LocadoraDeVeiculos.Infra.Orm.ModuloAluguel;
using LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel;
using LocadoraDeVeiculos.Infra.Orm.ModuloCliente;
using LocadoraDeVeiculos.Infra.Orm.ModuloCobranca;
using LocadoraDeVeiculos.Infra.Orm.ModuloCondutor;
using LocadoraDeVeiculos.Infra.Orm.ModuloCupom;
using LocadoraDeVeiculos.Infra.Orm.ModuloFuncionario;
using LocadoraDeVeiculos.Infra.Orm.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.Infra.Orm.ModuloParceiro;
using LocadoraDeVeiculos.Infra.Orm.ModuloTaxasServicos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LocadoraDeVeiculos.TesteIntegracao.Compartilhado
{
    public class TestesIntegracaoBase
    {
        protected IRepositorioFuncionario repositorioFuncionario;
        protected IRepositorioCliente repositorioCliente;
        protected IRepositorioCondutor repositorioCondutor;
        protected IRepositorioCupom repositorioCupom;
        protected IRepositorioParceiro repositorioParceiro;
        protected IRepositorioTaxasServicos repositorioTaxasServicos;
        protected IRepositorioCobranca repositorioCobranca;
        protected IRepositorioAluguel repositorioAluguel;
        protected IRepositorioGrupoAutomoveis repositorioGrupoAutomoveis;
        protected IRepositorioAutomovel repositorioAutomovel;

        public TestesIntegracaoBase()
        {
            LimparTabelas();

            string connectionString = ObterConnectionString();

            var optionsBuilder = new DbContextOptionsBuilder<LocadoraDeVeiculosDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var dbContext = new LocadoraDeVeiculosDbContext(optionsBuilder.Options);

            repositorioFuncionario = new RepositorioFuncionarioEmOrm(dbContext);
            repositorioCliente = new RepositorioClienteEmOrm(dbContext);
            repositorioCondutor = new RepositorioCondutorEmOrm(dbContext);
            repositorioCupom = new RepositorioCupomEmOrm(dbContext);
            repositorioParceiro = new RepositorioParceiroEmOrm(dbContext);
            repositorioTaxasServicos = new RepositorioTaxasServicosEmOrm(dbContext);
            repositorioCobranca = new RepositorioCobrancaEmOrm(dbContext);
            repositorioAluguel = new RepositorioAluguelEmOrm(dbContext);
            repositorioGrupoAutomoveis = new RepositorioGrupoAutomoveisEmOrm(dbContext);
            repositorioAutomovel = new RepositorioAutomovelEmOrm(dbContext);


            BuilderSetup.SetCreatePersistenceMethod<Funcionario>(repositorioFuncionario.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Cliente>(repositorioCliente.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Condutor>(repositorioCondutor.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Cupom>(repositorioCupom.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Parceiro>(repositorioParceiro.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<TaxasServicos>(repositorioTaxasServicos.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Cobranca>(repositorioCobranca.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Aluguel>(repositorioAluguel.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<GrupoAutomoveis>(repositorioGrupoAutomoveis.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Automovel>(repositorioAutomovel.Inserir);
        }

        protected static void LimparTabelas()
        {
            string? connectionString = ObterConnectionString();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string sqlLimpezaTabela =
                @"
                

                DELETE FROM [DBO].[TBTAXASSERVICOS]

                DELETE FROM [DBO].[TBFUNCIONARIO]

                DELETE FROM [DBO].[TBCOBRANCA]

                DELETE FROM [DBO].[TBAUTOMOVEL]

                DELETE FROM [DBO].[TBGRUPOAUTOMOVEIS]

                DELETE FROM [DBO].[TBCONDUTOR]

                DELETE FROM [DBO].[TBCLIENTE]

                DELETE FROM [DBO].[TBCUPOM]

                DELETE FROM [DBO].[TBPARCEIRO];";

            SqlCommand comando = new SqlCommand(sqlLimpezaTabela, sqlConnection);

            sqlConnection.Open();

            comando.ExecuteNonQuery();

            sqlConnection.Close();
        }

        protected static string ObterConnectionString()
        {
            var configuracao = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");
            return connectionString;
        }
    }
}
