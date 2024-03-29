﻿using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCobranca;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.Dominio.ModuloTaxasServicos;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        Aluguel aluguel;
        List<TaxasServicos> taxasServicos;

        bool telaCarregada = false;

        public event GravarRegistroDelegate<Aluguel> onGravarRegistro;


        public TelaAluguelForm(List<Funcionario> funcionarios, List<Cliente> clientes, List<GrupoAutomoveis> grupoAutomoveis, List<Cobranca> planoCobrancas, List<Condutor> condutores, List<Automovel> automoveis, List<Cupom> cupons, List<TaxasServicos> taxasServicos)
        {
            InitializeComponent();
            this.ConfigurarDialog();

            CarregarFuncionario(funcionarios);
            CarregarCliente(clientes);
            CarregarGrupoAutomoveis(grupoAutomoveis);
            CarregarPlanoCobranca(planoCobrancas);
            CarregarCondutor(condutores);
            CarregarAutomoveis(automoveis);
            CarregarCupons(cupons);
            this.taxasServicos = taxasServicos;
        }

        private void CarregarAutomoveis(List<Automovel> automoveis)
        {
            cbCondutor.Items.Clear();

            foreach (Automovel automovel in automoveis)
            {
                cbCondutor.Items.Add(automovel);
            }
        }

        public Aluguel ObterAluguel()
        {
            decimal kmAutomovel;

            aluguel.Funcionario = (Funcionario)cbFuncionario.SelectedItem;
            aluguel.Cliente = (Cliente)cbCliente.SelectedItem;
            aluguel.GrupoAutomoveis = (GrupoAutomoveis)cbGrupoAutomoveis.SelectedItem;
            aluguel.Cobranca = (Cobranca)cbPlanoDeCobranca.SelectedItem;
            aluguel.DataLocacao = dtLocacao.Value.Date;
            aluguel.DevolucaoPrevista = dtDevolucaoPrevista.Value.Date;
            aluguel.Condutor = (Condutor)cbCondutor.SelectedItem;
            aluguel.Automovel = (Automovel)cbAutomovel.SelectedItem;

            decimal.TryParse(txtKmAutomovel.Text, out kmAutomovel);
            aluguel.KmAutomovel = kmAutomovel;

            if (cbCupom != null)
            {
                aluguel.Cupom = (Cupom)cbCupom.SelectedItem;
            }

            aluguel.ListaTaxasSelecionadas = ObterItensMarcados();

            return aluguel;
        }

        public void ConfigurarAluguel(Aluguel aluguel)
        {
            this.aluguel = aluguel;

            cbFuncionario.SelectedItem = aluguel.Funcionario;
            cbCliente.SelectedItem = aluguel.Cliente;
            cbGrupoAutomoveis.SelectedItem = aluguel.GrupoAutomoveis;
            cbPlanoDeCobranca.SelectedItem = aluguel.Cobranca;
            cbCondutor.SelectedItem = aluguel.Condutor;
            cbAutomovel.SelectedItem = aluguel.Automovel;
            dtLocacao.MinDate = aluguel.DataLocacao;
            dtDevolucaoPrevista.MinDate = aluguel.DevolucaoPrevista;
            txtKmAutomovel.Text = aluguel.KmAutomovel.ToString();


            if (aluguel.Cupom != null)
            {
                cbCupom.SelectedItem = this.aluguel.Cupom;
            }

            CarregarTaxasServicos();

            int i = 0;

            for (int j = 0; j < chListTaxas.Items.Count; j++)
            {
                TaxasServicos taxa = (TaxasServicos)chListTaxas.Items[j];

                if (aluguel.ListaTaxasSelecionadas.Contains(taxa))
                    chListTaxas.SetItemChecked(i, true);

                i++;
            }

            telaCarregada = true;

            txtValorTotal.Text = aluguel.ValorTotalPrevisto.ToString();
        }

        public List<TaxasServicos> ObterItensMarcados()
        {
            return chListTaxas.CheckedItems.Cast<TaxasServicos>().ToList();
        }

        private void RealizarCalculoValorTotal()
        {
            aluguel = ObterAluguel();

            aluguel.CalcularValorTotal();

            txtValorTotal.Text = aluguel.ValorTotalPrevisto.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.aluguel = ObterAluguel();

            Result resultado = onGravarRegistro(aluguel);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void cbPlanoDeCobranca_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dtLocacao.Enabled = true;
            dtDevolucaoPrevista.Enabled = true;
            cbCupom.Enabled = true;
            chListTaxas.Enabled = true;

            if (telaCarregada)
                RealizarCalculoValorTotal();
        }

        private void chListTaxas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (telaCarregada)
                RealizarCalculoValorTotal();
        }

        private void cbCupom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (telaCarregada)
                RealizarCalculoValorTotal();
        }

        private void dtLocacao_ValueChanged(object sender, EventArgs e)
        {
            if (telaCarregada)
                RealizarCalculoValorTotal();
        }

        private void dtDevolucaoPrevista_ValueChanged(object sender, EventArgs e)
        {
            if (telaCarregada)
                RealizarCalculoValorTotal();
        }

        private void cbAutomovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (telaCarregada)
                RealizarCalculoValorTotal();

            Automovel automovel = cbAutomovel.SelectedItem as Automovel;

            txtKmAutomovel.Text = automovel.KmAutomovel.ToString();
        }

        private void CarregarTaxasServicos()
        {
            chListTaxas.Items.Clear();

            foreach (var taxa in taxasServicos)
            {
                chListTaxas.Items.Add(taxa);
            }
        }

        private void CarregarCupons(List<Cupom> cupons)
        {
            cbCupom.Items.Clear();

            foreach (Cupom cupom in cupons)
            {
                cbCupom.Items.Add(cupom);
            }
        }

        private void CarregarCondutor(List<Condutor> condutores)
        {
            cbCondutor.Items.Clear();

            foreach (Condutor condutor in condutores)
            {
                cbCondutor.Items.Add(condutor);
            }
        }

        private void CarregarPlanoCobranca(List<Cobranca> planoCobrancas)
        {
            cbPlanoDeCobranca.Items.Clear();

            foreach (Cobranca planoCobranca in planoCobrancas)
            {
                cbPlanoDeCobranca.Items.Add(planoCobranca);
            }
        }

        private void CarregarGrupoAutomoveis(List<GrupoAutomoveis> grupoAutomoveis)
        {
            cbGrupoAutomoveis.Items.Clear();

            foreach (GrupoAutomoveis grupoAutomovel in grupoAutomoveis)
            {
                cbGrupoAutomoveis.Items.Add(grupoAutomovel);
            }
        }

        private void CarregarCliente(List<Cliente> clientes)
        {
            cbCliente.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                cbCliente.Items.Add(cliente);
            }
        }

        private void CarregarFuncionario(List<Funcionario> funcionarios)
        {
            cbFuncionario.Items.Clear();

            foreach (Funcionario funcionario in funcionarios)
            {
                cbFuncionario.Items.Add(funcionario);
            }
        }

    }
}
