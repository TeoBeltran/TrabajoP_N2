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
    public partial class frmArticulo : Form
    {
        private List<Articulo> catalogo;
        public frmArticulo(List<Articulo> catalogo)
        {
            InitializeComponent();
            this.catalogo = catalogo;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //Articulo nuevoArticulo = new Articulo
            //{
            //    codigo = tbCod.Text,
            //    nombre = tbName.Text,
            //    descripcion = tbDesc.Text,
            //    marca = cbBrand.Text,
            //    categoria = cbCat.Text,
            //    img = AAA;
            //    precio = Convert.ToDecimal(tbPrice.Text)
            //};

            // Agregar el artículo a la lista.
            //catalogo.Add(nuevoArticulo);

            MessageBox.Show("Articulo agregado!");
            this.Close();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            cbBrand.Items.Add("Adidas");
            cbBrand.Items.Add("Nike");
            cbCat.Items.Add("Prendas");
            cbCat.Items.Add("Accesorios");
        }

    }
}
