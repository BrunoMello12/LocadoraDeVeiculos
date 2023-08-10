namespace LocadoraDeVeiculos.WinFormsApp.ModuloAluguel
{
    partial class TelaEnviarEmailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            txtSenhaEmail = new TextBox();
            txtMensagem = new TextBox();
            label5 = new Label();
            txtAssunto = new TextBox();
            label4 = new Label();
            txtEmailFuncionario = new TextBox();
            label3 = new Label();
            txtEmailCliente = new TextBox();
            txtMostrarPdf = new TextBox();
            label2 = new Label();
            btnSelecionarPdf = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 16);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 147;
            label6.Text = "Destinatario: ";
            // 
            // txtSenhaEmail
            // 
            txtSenhaEmail.Location = new Point(112, 92);
            txtSenhaEmail.Margin = new Padding(4);
            txtSenhaEmail.Name = "txtSenhaEmail";
            txtSenhaEmail.PlaceholderText = "senha do email";
            txtSenhaEmail.Size = new Size(260, 23);
            txtSenhaEmail.TabIndex = 3;
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(112, 172);
            txtMensagem.Margin = new Padding(4);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.ScrollBars = ScrollBars.Both;
            txtMensagem.Size = new Size(260, 55);
            txtMensagem.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 175);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 144;
            label5.Text = "Mensagem:";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(112, 132);
            txtAssunto.Margin = new Padding(4);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(260, 23);
            txtAssunto.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 135);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 142;
            label4.Text = "Assunto:";
            // 
            // txtEmailFuncionario
            // 
            txtEmailFuncionario.Location = new Point(112, 52);
            txtEmailFuncionario.Margin = new Padding(4);
            txtEmailFuncionario.Name = "txtEmailFuncionario";
            txtEmailFuncionario.PlaceholderText = "email ";
            txtEmailFuncionario.Size = new Size(260, 23);
            txtEmailFuncionario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 140;
            label3.Text = "Funcionário:";
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(112, 13);
            txtEmailCliente.Margin = new Padding(4);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.PlaceholderText = "email do cliente";
            txtEmailCliente.Size = new Size(260, 23);
            txtEmailCliente.TabIndex = 1;
            // 
            // txtMostrarPdf
            // 
            txtMostrarPdf.Location = new Point(112, 235);
            txtMostrarPdf.Margin = new Padding(4);
            txtMostrarPdf.Name = "txtMostrarPdf";
            txtMostrarPdf.ReadOnly = true;
            txtMostrarPdf.Size = new Size(260, 23);
            txtMostrarPdf.TabIndex = 138;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 238);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 137;
            label2.Text = "Selecionar PDF:";
            // 
            // btnSelecionarPdf
            // 
            btnSelecionarPdf.BackColor = Color.IndianRed;
            btnSelecionarPdf.Location = new Point(112, 266);
            btnSelecionarPdf.Margin = new Padding(4);
            btnSelecionarPdf.Name = "btnSelecionarPdf";
            btnSelecionarPdf.Size = new Size(260, 26);
            btnSelecionarPdf.TabIndex = 6;
            btnSelecionarPdf.Text = "Buscar";
            btnSelecionarPdf.UseVisualStyleBackColor = false;
            btnSelecionarPdf.Click += btnSelecionarPdf_Click_1;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.IndianRed;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(222, 326);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(76, 34);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(304, 326);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 34);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // TelaEnviarEmailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(392, 372);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label6);
            Controls.Add(txtSenhaEmail);
            Controls.Add(txtMensagem);
            Controls.Add(label5);
            Controls.Add(txtAssunto);
            Controls.Add(label4);
            Controls.Add(txtEmailFuncionario);
            Controls.Add(label3);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtMostrarPdf);
            Controls.Add(label2);
            Controls.Add(btnSelecionarPdf);
            Name = "TelaEnviarEmailForm";
            Text = "Enviar Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtSenhaEmail;
        private TextBox txtMensagem;
        private Label label5;
        private TextBox txtAssunto;
        private Label label4;
        private TextBox txtEmailFuncionario;
        private Label label3;
        private TextBox txtEmailCliente;
        private TextBox txtMostrarPdf;
        private Label label2;
        private Button btnSelecionarPdf;
        private Button btnGravar;
        private Button btnCancelar;
    }
}