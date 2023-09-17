using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForm
{
    public partial class ListarCategorias : Form
    {
        private List<Categoria> categorias;
        public ListarCategorias(List<Categoria> categorias)
        {
            InitializeComponent();
            this.categorias = categorias;
        }

        private void ListarCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                CategoriaNegocio negocioM = new CategoriaNegocio();
                categorias = negocioM.ListarC();
                dgvCategorias.DataSource = categorias;
            }
            catch (Exception)
            {
                MessageBox.Show("error listar categorias");
            }
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            Categoria seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
        }
    }
}
