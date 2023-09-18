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
    public partial class ModificarMarca : Form
    {
        private MarcaNegocio marcaNegocio;
        private Marca marcaActual;
        public ModificarMarca()
        {
            InitializeComponent();
        }

        private void ModificarMarca_Load(object sender, EventArgs e)
        {
            try
            {
                marcaNegocio = new MarcaNegocio();
                cbBrand.DataSource = marcaNegocio.ListarM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = cbBrand.Text;
                string nueva = tbNuevaBrand.Text;
                marcaNegocio.Modificar(descripcion, nueva);
                MessageBox.Show("Se modificó correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la categoria: " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
