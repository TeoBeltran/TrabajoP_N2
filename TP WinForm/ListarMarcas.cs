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
    public partial class ListarMarcas : Form
    {
        private List<Marca> marcas;
        public ListarMarcas(List<Marca> marcas)
        {
            InitializeComponent();
            this.marcas = marcas;
        }

        private void ListarMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio negocioM = new MarcaNegocio();
                marcas = negocioM.ListarM();
                dgvMarcas.DataSource = marcas;
            }
            catch (Exception)
            {
                MessageBox.Show("error listar marcas");
            }
        }

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
        }
    }
}
