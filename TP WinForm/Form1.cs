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
    public partial class Form1 : Form
    {
        List<Articulo> catalogo = new List<Articulo>();
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
    }
}
