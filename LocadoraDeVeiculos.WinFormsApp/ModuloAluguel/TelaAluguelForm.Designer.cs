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
            txtValorTotal = new TextBox();
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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // cbCupom
            // 
            cbCupom.Enabled = false;
            cbCupom.FormattingEnabled = true;
            cbCupom.Location = new Point(704, 154);
            cbCupom.Margin = new Padding(5, 6, 5, 6);
            cbCupom.Name = "cbCupom";
            cbCupom.Size = new Size(205, 38);
            cbCupom.TabIndex = 92;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(18, 352);
            tabControl1.Margin = new Padding(5, 6, 5, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(919, 338);
            tabControl1.TabIndex = 91;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chListTaxas);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Margin = new Padding(5, 6, 5, 6);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5, 6, 5, 6);
            tabPage1.Size = new Size(911, 295);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Taxas Selecionadas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chListTaxas
            // 
            chListTaxas.CheckOnClick = true;
            chListTaxas.Enabled = false;
            chListTaxas.FormattingEnabled = true;
            chListTaxas.Location = new Point(26, 30);
            chListTaxas.Margin = new Padding(5, 6, 5, 6);
            chListTaxas.Name = "chListTaxas";
            chListTaxas.Size = new Size(861, 196);
            chListTaxas.TabIndex = 0;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(225, 730);
            txtValorTotal.Margin = new Padding(5, 6, 5, 6);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(205, 35);
            txtValorTotal.TabIndex = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 736);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 30);
            label2.TabIndex = 89;
            label2.Text = "Valor Total Previsto:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(51, 270);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(194, 30);
            label13.TabIndex = 88;
            label13.Text = "Devolução Prevista:";
            // 
            // dtDevolucaoPrevista
            // 
            dtDevolucaoPrevista.Enabled = false;
            dtDevolucaoPrevista.Format = DateTimePickerFormat.Short;
            dtDevolucaoPrevista.Location = new Point(249, 264);
            dtDevolucaoPrevista.Margin = new Padding(5, 6, 5, 6);
            dtDevolucaoPrevista.Name = "dtDevolucaoPrevista";
            dtDevolucaoPrevista.Size = new Size(205, 35);
            dtDevolucaoPrevista.TabIndex = 87;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(97, 212);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(144, 30);
            label12.TabIndex = 86;
            label12.Text = "Data Locação:";
            // 
            // dtLocacao
            // 
            dtLocacao.Enabled = false;
            dtLocacao.Format = DateTimePickerFormat.Short;
            dtLocacao.Location = new Point(249, 206);
            dtLocacao.Margin = new Padding(5, 6, 5, 6);
            dtLocacao.Name = "dtLocacao";
            dtLocacao.Size = new Size(205, 35);
            dtLocacao.TabIndex = 85;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(508, 108);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(192, 30);
            label11.TabIndex = 84;
            label11.Text = "KM do Automóvel: ";
            // 
            // cbAutomovel
            // 
            cbAutomovel.FormattingEnabled = true;
            cbAutomovel.Location = new Point(707, 40);
            cbAutomovel.Margin = new Padding(5, 6, 5, 6);
            cbAutomovel.Name = "cbAutomovel";
            cbAutomovel.Size = new Size(205, 38);
            cbAutomovel.TabIndex = 83;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(573, 46);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(125, 30);
            label10.TabIndex = 82;
            label10.Text = "Automóvel: ";
            // 
            // cbCondutor
            // 
            cbCondutor.FormattingEnabled = true;
            cbCondutor.Location = new Point(812, -87);
            cbCondutor.Margin = new Padding(5, 6, 5, 6);
            cbCondutor.Name = "cbCondutor";
            cbCondutor.Size = new Size(205, 38);
            cbCondutor.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(692, -81);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 30);
            label9.TabIndex = 80;
            label9.Text = "Condutor: ";
            // 
            // cbPlanoDeCobranca
            // 
            cbPlanoDeCobranca.FormattingEnabled = true;
            cbPlanoDeCobranca.Location = new Point(249, 148);
            cbPlanoDeCobranca.Margin = new Padding(5, 6, 5, 6);
            cbPlanoDeCobranca.Name = "cbPlanoDeCobranca";
            cbPlanoDeCobranca.Size = new Size(205, 38);
            cbPlanoDeCobranca.TabIndex = 79;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 154);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(199, 30);
            label8.TabIndex = 78;
            label8.Text = "Plano de Cobrança: ";
            // 
            // cbGrupoAutomoveis
            // 
            cbGrupoAutomoveis.FormattingEnabled = true;
            cbGrupoAutomoveis.Location = new Point(249, 90);
            cbGrupoAutomoveis.Margin = new Padding(5, 6, 5, 6);
            cbGrupoAutomoveis.Name = "cbGrupoAutomoveis";
            cbGrupoAutomoveis.Size = new Size(205, 38);
            cbGrupoAutomoveis.TabIndex = 77;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 96);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(226, 30);
            label4.TabIndex = 76;
            label4.Text = "Grupo de Automóveis: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(603, 162);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 30);
            label7.TabIndex = 75;
            label7.Text = "Cupom: ";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(249, 32);
            cbCliente.Margin = new Padding(5, 6, 5, 6);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(205, 38);
            cbCliente.TabIndex = 74;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(155, 40);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 30);
            label6.TabIndex = 73;
            label6.Text = "Cliente:";
            // 
            // txtKmAutomovel
            // 
            txtKmAutomovel.Location = new Point(707, 98);
            txtKmAutomovel.Margin = new Padding(5, 6, 5, 6);
            txtKmAutomovel.Name = "txtKmAutomovel";
            txtKmAutomovel.Size = new Size(205, 35);
            txtKmAutomovel.TabIndex = 72;
            // 
            // cbFuncionario
            // 
            cbFuncionario.FormattingEnabled = true;
            cbFuncionario.Location = new Point(354, -95);
            cbFuncionario.Margin = new Padding(5, 6, 5, 6);
            cbFuncionario.Name = "cbFuncionario";
            cbFuncionario.Size = new Size(205, 38);
            cbFuncionario.TabIndex = 71;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(572, 834);
            btnGravar.Margin = new Padding(5, 6, 5, 6);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(130, 68);
            btnGravar.TabIndex = 70;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(712, 834);
            btnCancelar.Margin = new Padding(5, 6, 5, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 68);
            btnCancelar.TabIndex = 69;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, -87);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 68;
            label1.Text = "Funcionário:";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 807);
            Controls.Add(cbCupom);
            Controls.Add(tabControl1);
            Controls.Add(txtValorTotal);
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
            Name = "TelaAluguelForm";
            Text = "TelaAluguelForm";
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
        private TextBox txtValorTotal;
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
    }
}