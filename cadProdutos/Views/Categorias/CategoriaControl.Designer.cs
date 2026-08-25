namespace cadProdutos.Views.Categorias
{
    partial class CategoriaControl
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
            lblNome = new Label();
            btEditar = new Button();
            btExcluir = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Location = new Point(31, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(226, 22);
            lblId.TabIndex = 0;
            lblId.Text = "LBLID";
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(31, 60);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(136, 32);
            lblNome.TabIndex = 1;
            lblNome.Text = "LBLNOME";
            lblNome.UseCompatibleTextRendering = true;
            // 
            // btEditar
            // 
            btEditar.Location = new Point(263, 19);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(89, 29);
            btEditar.TabIndex = 2;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(263, 58);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(89, 30);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // CategoriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "CategoriaControl";
            Size = new Size(367, 100);
            ResumeLayout(false);
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Button btEditar;
        private Button btExcluir;
    }
}
