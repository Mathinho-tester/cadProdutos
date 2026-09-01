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
    public partial class CategoriaControl : UserControl
    {
        Categoria cat;
        FrmListar grid;
        CategoriaPresenter presenter;

        public CategoriaControl(FrmListar grid, CategoriaPresenter presenter, Categoria cat)
        {
            InitializeComponent();
            this.cat = cat;
            this.grid = grid;
            this.presenter = presenter;

            lblId.Text = $"#{cat.Id} ({cat.Produto.Count} " + $"produto{(cat.Produto.Count ==1 ? "" : "S")}";
            lblNome.Text = cat.Nome;
            if(cat.Produto.Count > 0)
            {
                btExcluir.Enabled = false;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Deseja realmente excluir a categoria '{cat.Nome}'?", "Confirmação",
                                                                                          MessageBoxButtons.YesNo,
                                                                                          MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (presenter.Remover(cat))
                {
                    MessageBox.Show("Categoria removida!");
                    grid.Atualizar();
                }
                else
                {
                    MessageBox.Show("Erro ao remover categoria!");
                }


            }

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            FrmEditar f = new FrmEditar(presenter, cat);
            f.ShowDialog();
            grid.Atualizar();
        }
    }
}
