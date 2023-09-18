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
    public partial class ModificarArticulo : Form
    {
        private ArticuloNegocio negocioArticulo;
        private Articulo articuloActual;

        public ModificarArticulo()
        {
            InitializeComponent();
            negocioArticulo = new ArticuloNegocio();
            articuloActual = new Articulo();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string codigo = tbCod.Text;

            if (!string.IsNullOrWhiteSpace(codigo))
            {
                try
                {
                    Articulo articulo = negocioArticulo.BuscarPorCodigo(codigo);

                    if (articulo != null)
                    {
                        tbName.Text = articulo.Nombre;
                        tbDesc.Text = articulo.Descripcion;
                        cbBrand.Text = articulo.IdMarca.Descripcion;
                        cbCat.Text = articulo.IdCategoria.Descripcion;
                        tbPrice.Text = articulo.Precio.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ese articulo no existe");
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el artículo: " + ex.Message);
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un codigo valido.");
            }
        }
        private void LimpiarCampos()
        {
            tbName.Clear();
            tbDesc.Clear();
            //cbBrand.Clear();
            //cbCat.Clear();
            tbPrice.Clear();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (articuloActual != null)
            {
                try
                {
                    articuloActual.Codigo = tbCod.Text;
                    articuloActual.Nombre = tbName.Text;
                    articuloActual.Descripcion = tbDesc.Text;
                    articuloActual.IdMarca = new Marca();
                    articuloActual.IdMarca.Descripcion = cbBrand.Text;
                    articuloActual.IdCategoria = new Categoria();
                    articuloActual.IdCategoria.Descripcion = cbCat.Text;
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    articuloActual.IdMarca.Id = marcaNegocio.obtenerId(cbBrand.Text);
                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                    articuloActual.IdCategoria.Id = categoriaNegocio.obtenerId(cbCat.Text);
                    MessageBox.Show(articuloActual.IdCategoria.Id.ToString() + " " + articuloActual.IdCategoria.Id.ToString());

                    if (decimal.TryParse(tbPrice.Text, out decimal precio))
                    {
                        articuloActual.Precio = precio;
                    }
                    else
                    {
                        MessageBox.Show("El valor de Precio no es válido.");
                        return;
                    }

                    negocioArticulo.Modificar(articuloActual);

                    MessageBox.Show("El artículo se ha modificado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el artículo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Primero debe buscar un artículo antes de modificarlo.");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarArticulo_Load(object sender, EventArgs e)
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
    }
}
