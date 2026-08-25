using cadProdutos.Presenters;
using CadProdutos.Data;
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
    public partial class FrmListar : Form
    {
        Contexto db;
        CategoriaPresenter presenter;

        public FrmListar()
        {
            InitializeComponent();
            db = new Contexto();
            presenter = new CategoriaPresenter(db);
            Atualizar();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        public void Atualizar()
        {
            List<Categoria> lista = presenter.Buscar(txtBusca.Text);

            flpItens.Controls.Clear();
            foreach (Categoria c in lista)
            {
                CategoriaControl ctr = new CategoriaControl(this, presenter, c);
                flpItens.Controls.Add(ctr);
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar f = new FrmCadastrar(presenter);
            f.ShowDialog();
            Atualizar();
        }
    }
}
