namespace LocadoraDeVeiculos.WinFormsApp.ModuloParceiro
{
    partial class TelaParceiroForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            txtNome = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.IndianRed;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(120, 58);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(76, 34);
            btnGravar.TabIndex = 102;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(202, 58);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 34);
            btnCancelar.TabIndex = 101;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(69, 21);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Inserir...";
            txtNome.Size = new Size(209, 23);
            txtNome.TabIndex = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 24);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 99;
            label5.Text = "Nome:";
            // 
            // TelaParceiroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(290, 104);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Name = "TelaParceiroForm";
            Text = "Cadastro de Parceiros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtNome;
        private Label label5;
    }
}