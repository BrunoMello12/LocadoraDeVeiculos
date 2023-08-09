namespace LocadoraDeVeiculos.WinFormsApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            cbCupom = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            chListTaxas = new CheckedListBox();
            label2 = new Label();
            label13 = new Label();
            dtDevolucaoPrevista = new DateTimePicker();
            label12 = new Label();
            dtLocacao = new DateTimePicker();
            label11 = new Label();
            cbAutomovel = new ComboBox();
            label10 = new Label();
            cbCondutor = new ComboBox();
            label9 = new Label();
            cbPlanoDeCobranca = new ComboBox();
            label8 = new Label();
            cbGrupoAutomoveis = new ComboBox();
            label4 = new Label();
            label7 = new Label();
            cbCliente = new ComboBox();
            label6 = new Label();
            txtKmAutomovel = new TextBox();
            cbFuncionario = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtValorTotal = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // cbCupom
            // 
            cbCupom.Enabled = false;
            cbCupom.FormattingEnabled = true;
            cbCupom.Location = new Point(412, 77);
            cbCupom.Name = "cbCupom";
            cbCupom.Size = new Size(121, 23);
            cbCupom.TabIndex = 92;
            cbCupom.SelectedIndexChanged += cbCupom_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(10, 154);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(536, 169);
            tabControl1.TabIndex = 91;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chListTaxas);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(528, 141);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Taxas Selecionadas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chListTaxas
            // 
            chListTaxas.CheckOnClick = true;
            chListTaxas.Enabled = false;
            chListTaxas.FormattingEnabled = true;
            chListTaxas.Location = new Point(15, 15);
            chListTaxas.Name = "chListTaxas";
            chListTaxas.Size = new Size(504, 94);
            chListTaxas.TabIndex = 0;
            chListTaxas.SelectedIndexChanged += chListTaxas_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 340);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 89;
            label2.Text = "Valor Total Previsto:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(296, 109);
            label13.Name = "label13";
            label13.Size = new Size(110, 15);
            label13.TabIndex = 88;
            label13.Text = "Devolução Prevista:";
            // 
            // dtDevolucaoPrevista
            // 
            dtDevolucaoPrevista.Enabled = false;
            dtDevolucaoPrevista.Format = DateTimePickerFormat.Short;
            dtDevolucaoPrevista.Location = new Point(412, 106);
            dtDevolucaoPrevista.Name = "dtDevolucaoPrevista";
            dtDevolucaoPrevista.Size = new Size(121, 23);
            dtDevolucaoPrevista.TabIndex = 87;
            dtDevolucaoPrevista.ValueChanged += dtDevolucaoPrevista_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(57, 106);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 86;
            label12.Text = "Data Locação:";
            // 
            // dtLocacao
            // 
            dtLocacao.Enabled = false;
            dtLocacao.Format = DateTimePickerFormat.Short;
            dtLocacao.Location = new Point(145, 103);
            dtLocacao.Name = "dtLocacao";
            dtLocacao.Size = new Size(121, 23);
            dtLocacao.TabIndex = 85;
            dtLocacao.ValueChanged += dtLocacao_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(296, 54);
            label11.Name = "label11";
            label11.Size = new Size(110, 15);
            label11.TabIndex = 84;
            label11.Text = "KM do Automóvel: ";
            // 
            // cbAutomovel
            // 
            cbAutomovel.FormattingEnabled = true;
            cbAutomovel.Location = new Point(412, 20);
            cbAutomovel.Name = "cbAutomovel";
            cbAutomovel.Size = new Size(121, 23);
            cbAutomovel.TabIndex = 83;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(334, 23);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 82;
            label10.Text = "Automóvel: ";
            // 
            // cbCondutor
            // 
            cbCondutor.FormattingEnabled = true;
            cbCondutor.Location = new Point(474, -44);
            cbCondutor.Name = "cbCondutor";
            cbCondutor.Size = new Size(121, 23);
            cbCondutor.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(404, -40);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 80;
            label9.Text = "Condutor: ";
            // 
            // cbPlanoDeCobranca
            // 
            cbPlanoDeCobranca.FormattingEnabled = true;
            cbPlanoDeCobranca.Location = new Point(145, 74);
            cbPlanoDeCobranca.Name = "cbPlanoDeCobranca";
            cbPlanoDeCobranca.Size = new Size(121, 23);
            cbPlanoDeCobranca.TabIndex = 79;
            cbPlanoDeCobranca.SelectedIndexChanged += cbPlanoDeCobranca_SelectedIndexChanged_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 77);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 78;
            label8.Text = "Plano de Cobrança: ";
            // 
            // cbGrupoAutomoveis
            // 
            cbGrupoAutomoveis.FormattingEnabled = true;
            cbGrupoAutomoveis.Location = new Point(145, 45);
            cbGrupoAutomoveis.Name = "cbGrupoAutomoveis";
            cbGrupoAutomoveis.Size = new Size(121, 23);
            cbGrupoAutomoveis.TabIndex = 77;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 48);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 76;
            label4.Text = "Grupo de Automóveis: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 81);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 75;
            label7.Text = "Cupom: ";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(145, 16);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(121, 23);
            cbCliente.TabIndex = 74;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 20);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 73;
            label6.Text = "Cliente:";
            // 
            // txtKmAutomovel
            // 
            txtKmAutomovel.Location = new Point(412, 49);
            txtKmAutomovel.Name = "txtKmAutomovel";
            txtKmAutomovel.Size = new Size(121, 23);
            txtKmAutomovel.TabIndex = 72;
            // 
            // cbFuncionario
            // 
            cbFuncionario.FormattingEnabled = true;
            cbFuncionario.Location = new Point(206, -48);
            cbFuncionario.Name = "cbFuncionario";
            cbFuncionario.Size = new Size(121, 23);
            cbFuncionario.TabIndex = 71;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(330, 388);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(76, 34);
            btnGravar.TabIndex = 70;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(411, 388);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 34);
            btnCancelar.TabIndex = 69;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, -44);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 68;
            label1.Text = "Funcionário:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.IndianRed;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(389, 329);
            button1.Name = "button1";
            button1.Size = new Size(76, 34);
            button1.TabIndex = 94;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.IndianRed;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(471, 329);
            button2.Name = "button2";
            button2.Size = new Size(76, 34);
            button2.TabIndex = 93;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(127, 336);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.PlaceholderText = "R$";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(121, 23);
            txtValorTotal.TabIndex = 95;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(559, 375);
            Controls.Add(txtValorTotal);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(cbCupom);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(label13);
            Controls.Add(dtDevolucaoPrevista);
            Controls.Add(label12);
            Controls.Add(dtLocacao);
            Controls.Add(label11);
            Controls.Add(cbAutomovel);
            Controls.Add(label10);
            Controls.Add(cbCondutor);
            Controls.Add(label9);
            Controls.Add(cbPlanoDeCobranca);
            Controls.Add(label8);
            Controls.Add(cbGrupoAutomoveis);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(cbCliente);
            Controls.Add(label6);
            Controls.Add(txtKmAutomovel);
            Controls.Add(cbFuncionario);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "TelaAluguelForm";
            Text = "Cadastro de Aluguel";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCupom;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckedListBox chListTaxas;
        private Label label2;
        private Label label13;
        private DateTimePicker dtDevolucaoPrevista;
        private Label label12;
        private DateTimePicker dtLocacao;
        private Label label11;
        private ComboBox cbAutomovel;
        private Label label10;
        private ComboBox cbCondutor;
        private Label label9;
        private ComboBox cbPlanoDeCobranca;
        private Label label8;
        private ComboBox cbGrupoAutomoveis;
        private Label label4;
        private Label label7;
        private ComboBox cbCliente;
        private Label label6;
        private TextBox txtKmAutomovel;
        private ComboBox cbFuncionario;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox txtValorTotal;
    }
}