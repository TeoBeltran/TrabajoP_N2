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
        public ModificarArticulo()
        {
            InitializeComponent();
            negocioArticulo = new ArticuloNegocio();
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
                        MessageBox.Show("Error");
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void LimpiarCampos()
        {
            tbName.Clear();
            tbDesc.Clear();
            tbBrand.Clear();
            tbCat.Clear();
            tbPrice.Clear();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
