namespace cadProdutos.Views.Categorias
{
    partial class FrmListar
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
            flpItens = new FlowLayoutPanel();
            btBusca = new Button();
            txtBusca = new TextBox();
            btCadastrar = new Button();
            SuspendLayout();
            // 
            // flpItens
            // 
            flpItens.Location = new Point(12, 64);
            flpItens.Name = "flpItens";
            flpItens.Size = new Size(776, 367);
            flpItens.TabIndex = 0;
            // 
            // btBusca
            // 
            btBusca.Location = new Point(475, 21);
            btBusca.Name = "btBusca";
            btBusca.Size = new Size(96, 32);
            btBusca.TabIndex = 1;
            btBusca.Text = "Buscar";
            btBusca.UseVisualStyleBackColor = true;
            btBusca.Click += btBusca_Click;
            // 
            // txtBusca
            // 
            txtBusca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusca.Location = new Point(208, 27);
            txtBusca.Name = "txtBusca";
            txtBusca.RightToLeft = RightToLeft.No;
            txtBusca.Size = new Size(261, 23);
            txtBusca.TabIndex = 2;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(336, 418);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(75, 23);
            btCadastrar.TabIndex = 3;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // FrmListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(btCadastrar);
            Controls.Add(txtBusca);
            Controls.Add(btBusca);
            Controls.Add(flpItens);
            Name = "FrmListar";
            Text = "Categorias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpItens;
        private Button btBusca;
        private TextBox txtBusca;
        private Button btCadastrar;
    }
}