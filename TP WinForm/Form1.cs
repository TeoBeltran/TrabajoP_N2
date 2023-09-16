using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_WinForm;
using dominio;

namespace TP_WinForm
{
    public partial class Form1 : Form
    {
        List<Articulo> catalogo = new List<Articulo>();
        List<Marca> maicraf = new List<Marca>();
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarTSP_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmArticulo))
                {
                    return;
                }
            }

            frmArticulo ventana = new frmArticulo(catalogo);
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void listarTSP_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Listar))
                {
                    return;
                }
            }

            Listar ventana = new Listar(catalogo);
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listarMarcasTSP_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListarMarcas))
                {
                    return;
                }
            }

            ListarMarcas ventana = new ListarMarcas(maicraf);
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
