namespace cadProdutos.Views.Categorias
{
    partial class FrmEditar
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
            lblId = new Label();
            lblNome = new Label();
            produtos = new Label();
            btCadastrarProd = new Button();
            txtNome = new TextBox();
            flpProds = new FlowLayoutPanel();
            btSalvar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(56, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(38, 15);
            lblId.TabIndex = 0;
            lblId.Text = "label1";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(56, 45);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(38, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "label2";
            // 
            // produtos
            // 
            produtos.Anchor = AnchorStyles.Right;
            produtos.AutoSize = true;
            produtos.Location = new Point(100, 97);
            produtos.Name = "produtos";
            produtos.Size = new Size(55, 15);
            produtos.TabIndex = 2;
            produtos.Text = "produtos";
            // 
            // btCadastrarProd
            // 
            btCadastrarProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btCadastrarProd.Location = new Point(233, 93);
            btCadastrarProd.Name = "btCadastrarProd";
            btCadastrarProd.Size = new Size(130, 23);
            btCadastrarProd.TabIndex = 3;
            btCadastrarProd.Text = "Novo Produto";
            btCadastrarProd.UseVisualStyleBackColor = true;
            btCadastrarProd.Click += btCadastrarProd_Click;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(100, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(290, 23);
            txtNome.TabIndex = 4;
            // 
            // flpProds
            // 
            flpProds.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flpProds.AutoScroll = true;
            flpProds.Location = new Point(12, 115);
            flpProds.Name = "flpProds";
            flpProds.Size = new Size(378, 222);
            flpProds.TabIndex = 5;
            // 
            // btSalvar
            // 
            btSalvar.Anchor = AnchorStyles.Bottom;
            btSalvar.Location = new Point(158, 346);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 6;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // FrmEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 381);
            Controls.Add(btSalvar);
            Controls.Add(flpProds);
            Controls.Add(txtNome);
            Controls.Add(btCadastrarProd);
            Controls.Add(produtos);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "FrmEditar";
            Text = "FrmEditar";
            Load += FrmEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label produtos;
        private Button btCadastrarProd;
        private TextBox txtNome;
        private FlowLayoutPanel flpProds;
        private Button btSalvar;
    }
}