namespace cadProdutos.Views.Categorias
{
    partial class ProdControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            label2 = new Label();
            lblpreco = new Label();
            btExcluir = new Button();
            txtNome = new TextBox();
            numPreco = new NumericUpDown();
            RS = new Label();
            ((System.ComponentModel.ISupportInitialize)numPreco).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(30, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(38, 15);
            lblId.TabIndex = 0;
            lblId.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 65);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // lblpreco
            // 
            lblpreco.AutoSize = true;
            lblpreco.Location = new Point(30, 113);
            lblpreco.Name = "lblpreco";
            lblpreco.Size = new Size(37, 15);
            lblpreco.TabIndex = 2;
            lblpreco.Text = "Preço";
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(208, 159);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(104, 62);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(372, 23);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // numPreco
            // 
            numPreco.DecimalPlaces = 2;
            numPreco.Location = new Point(169, 111);
            numPreco.Maximum = new decimal(new int[] { 268435456, 1042612833, 542101086, 0 });
            numPreco.Name = "numPreco";
            numPreco.Size = new Size(307, 23);
            numPreco.TabIndex = 5;
            numPreco.TextAlign = HorizontalAlignment.Right;
            numPreco.ValueChanged += numPreco_ValueChanged;
            // 
            // RS
            // 
            RS.AutoSize = true;
            RS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RS.Location = new Point(134, 108);
            RS.Name = "RS";
            RS.Size = new Size(29, 21);
            RS.TabIndex = 6;
            RS.Text = "R$";
            // 
            // ProdControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(RS);
            Controls.Add(numPreco);
            Controls.Add(txtNome);
            Controls.Add(btExcluir);
            Controls.Add(lblpreco);
            Controls.Add(label2);
            Controls.Add(lblId);
            Name = "ProdControl";
            Size = new Size(497, 205);
            ((System.ComponentModel.ISupportInitialize)numPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label label2;
        private Label lblpreco;
        private Button btExcluir;
        private TextBox txtNome;
        private NumericUpDown numPreco;
        private Label RS;
    }
}
