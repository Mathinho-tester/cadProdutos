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
    public partial class FrmCadastrar : Form
    {
        CategoriaPresenter presenter;
        public FrmCadastrar(CategoriaPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Categoria novaCategoria = new Categoria()
            {
                Nome = txtnome.Text
            };
            if (presenter.Cadastrar(novaCategoria))
            {
                MessageBox.Show("Categoria cadastrada com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao salvar a categoria.");
            }
        }
    }
}
