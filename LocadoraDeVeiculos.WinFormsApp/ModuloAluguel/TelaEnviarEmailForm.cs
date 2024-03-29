﻿using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System.Net.Mail;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAluguel
{
    public partial class TelaEnviarEmailForm : Form
    {

        private string caminhoDoArquivoPDF = "";

        public TelaEnviarEmailForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();

            txtSenhaEmail.PasswordChar = '*';
            txtSenhaEmail.MaxLength = 20;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage emailMensagem = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                emailMensagem.From = new MailAddress(txtEmailFuncionario.Text);
                emailMensagem.To.Add(txtEmailCliente.Text);
                emailMensagem.Subject = txtAssunto.Text;
                emailMensagem.Body = txtMensagem.Text;

                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential(txtEmailFuncionario.Text, txtSenhaEmail.Text);
                sc.EnableSsl = true;
                sc.Send(emailMensagem);
                MessageBox.Show("Email Enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelecionarPdf_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoDoArquivoPDF = openFileDialog.FileName;

                txtMostrarPdf.Text = caminhoDoArquivoPDF;
            }
        }
    }
}
