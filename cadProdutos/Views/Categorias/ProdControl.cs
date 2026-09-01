using CadProdutos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cadProdutos.Views.Categorias
{
    public partial class ProdControl : UserControl
    {
        Produto prod;
        FrmEditar form;
        bool pronto;
        public ProdControl(FrmEditar form, Produto prod)
        {
            InitializeComponent();
            this.form = form;
            this.prod = prod;
            lblId.Text = $"#{(prod.Id == null ? "--" : prod.Id)}";
            txtNome.Text = prod.Nome;
            numPreco.Value = (decimal)prod.Preco;
            pronto = true;
        }

        void EditarProduto()
        {
            if (!pronto) return;
            prod.Nome = txtNome.Text;
            prod.Preco = (double)numPreco.Value;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            EditarProduto();
        }

        private void numPreco_ValueChanged(object sender, EventArgs e)
        {
            EditarProduto();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                $"Deseja mesmo excluir o prodto '{prod.Nome}'?", 
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                form.ExcluirProduto(this, prod);
            }
        }
    }
}
