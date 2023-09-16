using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TP_WinForm
{
    public partial class Listar : Form
    {
        private List<Articulo> catalogo;
        public Listar(List<Articulo> catalogo)
        {
            InitializeComponent();
            this.catalogo = catalogo;
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                catalogo = negocio.listar();
                dgvArticulo.DataSource = catalogo;
            }
            catch (Exception)
            {
                MessageBox.Show("error listar articulos");
            }
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
        }
    }
}
