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
    public partial class Listar : Form
    {
        private List<Articulo> catalogo;
        public Listar(List<Articulo> catalogo)
        {
            InitializeComponent();
            this.catalogo = catalogo;
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                catalogo = negocio.listar();
                dgvArticulo.DataSource = catalogo;

                ImagenNegocio imagenNegocio = new ImagenNegocio();
                List<Imagen> imagens = new List<Imagen>();
                imagens = imagenNegocio.ListarI(1);
                if(imagens.Count > 0)
                {
                    pbxArticulo.Load(imagens[0].ImagenUrl);
                }
                else
                {
                    Imagen imagenV=new Imagen();
                    imagenV.ImagenUrl = "https://cuarteldelmetal.com/wp-content/uploads/2023/06/Captura-de-Pantalla-2023-06-29-a-las-21.32.14.png";
                    pbxArticulo.Load(imagenV.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;


                ImagenNegocio imagenNegocio = new ImagenNegocio();
                List<Imagen> imagens = new List<Imagen>();
                imagens = imagenNegocio.ListarI(seleccionado.Id);
                if (imagens.Count > 0)
                {
                    try
                    {
                        pbxArticulo.Load(imagens[0].ImagenUrl);
                    }
                    catch(System.Net.WebException ex)
                    {
                        Imagen imagenV = new Imagen();
                        imagenV.ImagenUrl = "https://cuarteldelmetal.com/wp-content/uploads/2023/06/Captura-de-Pantalla-2023-06-29-a-las-21.32.14.png";
                        pbxArticulo.Load(imagenV.ImagenUrl);
                    }
                }
                else
                {
                    Imagen imagenV = new Imagen();
                    imagenV.ImagenUrl = "https://cuarteldelmetal.com/wp-content/uploads/2023/06/Captura-de-Pantalla-2023-06-29-a-las-21.32.14.png";
                    pbxArticulo.Load(imagenV.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
