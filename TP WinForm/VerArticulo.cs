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
    public partial class VerArticulo : Form
    {
        private ArticuloNegocio negocioArticulo;
        public VerArticulo()
        {
            InitializeComponent();
            negocioArticulo = new ArticuloNegocio();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        tbBrand.Text = articulo.IdMarca.Descripcion;
                        tbCat.Text = articulo.IdCategoria.Descripcion;
                        tbPrice.Text = articulo.Precio.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ese articulo no existe");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el artículo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un codigo valido.");
            }
        }
    }
}
