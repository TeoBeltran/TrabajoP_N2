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
    public partial class AgregarArticulo : Form
    {
        private List<Articulo> catalogo;
        public AgregarArticulo(List<Articulo> catalogo)
        {
            InitializeComponent();
            this.catalogo = catalogo;
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cbBrand.DataSource = marcaNegocio.ListarM();
                cbCat.DataSource = categoriaNegocio.ListarC();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();
            ArticuloNegocio negocio= new ArticuloNegocio();

            try
            {
                nuevoArticulo.Codigo = tbCod.Text;
                nuevoArticulo.Nombre = tbName.Text;
                nuevoArticulo.Descripcion = tbDesc.Text;
                nuevoArticulo.IdMarca= (Marca)cbBrand.SelectedItem;
                nuevoArticulo.IdCategoria = (Categoria)cbCat.SelectedItem;
                nuevoArticulo.Precio = int.Parse(tbPrice.Text);

                negocio.agregar(nuevoArticulo);
                MessageBox.Show("Articulo agregado!");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            tbCod.Clear();
            tbName.Clear();
            tbDesc.Clear();
            //cbBrand.Clear();
            //cbCat.Clear();
            tbPrice.Clear();
        }
    }
}
