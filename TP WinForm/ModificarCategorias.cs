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
using System.Xml.Linq;

namespace TP_WinForm
{
    public partial class ModificarCategorias : Form
    {
        private CategoriaNegocio categoriaNegocio;
        private Categoria categoriaActual;
        public ModificarCategorias()
        {
            InitializeComponent();
        }

        private void ModificarCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                categoriaNegocio = new CategoriaNegocio();
                cbCat.DataSource = categoriaNegocio.ListarC();
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
                string descripcion = cbCat.Text;
                string nueva = tbNuevaDesc.Text;
                categoriaNegocio.Modificar(descripcion, nueva);
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
