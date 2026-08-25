using cadProdutos.Presenters;
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
    public partial class FrmEditar : Form
    {
        CategoriaPresenter presenter;
        Categoria cat;
        public FrmEditar(CategoriaPresenter presenter, Categoria cat)
        {
            InitializeComponent();
            this.presenter = presenter;
            this.cat = cat;

            lblId.Text = $"#{cat.Id}";
            lblNome.Text = cat.Nome;
/*teste*/

            foreach (Produto p in cat.Produto)
            {

            }
        }

        private void FrmEditar_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            cat.Nome = txtNome.Text;
            if (presenter.Editar(cat))
            {
                MessageBox.Show("Sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }
    }
}
