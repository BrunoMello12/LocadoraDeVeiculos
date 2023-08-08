using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCobranca;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        Aluguel aluguel;

        public TelaAluguelForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Aluguel ObterAluguel()
        {
            aluguel.Funcionario = (Funcionario)cbFuncionario.SelectedItem;
            aluguel.Cliente = (Cliente)cbCliente.SelectedItem;
            aluguel.GrupoAutomoveis = (GrupoAutomoveis)cbGrupoAutomoveis.SelectedItem;
            aluguel.Cobranca = (Cobranca)cbPlanoDeCobranca.SelectedItem;
            aluguel.DataLocacao = DateTime.Parse(dtLocacao.Text);
            aluguel.DevolucaoPrevista = DateTime.Parse(dtDevolucaoPrevista.Text);
            aluguel.Condutor = (Condutor)cbCondutor.SelectedItem;
            aluguel.Automovel = (Automovel)cbAutomovel.SelectedItem;
            aluguel.KmAutomovel = Convert.ToDecimal(txtKmAutomovel.Text);

            //if(txtCupom != null)
            //{
            //    aluguel.Cupom = txtCupom.Text as Cupom;
            //}

            return aluguel;
        }
    }
}
