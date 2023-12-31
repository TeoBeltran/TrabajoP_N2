﻿using System;
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
        List<Marca> marcas = new List<Marca>();
        List<Categoria> categorias=new List<Categoria>();

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarTSP_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(AgregarArticulo))
                {
                    return;
                }
            }

            AgregarArticulo ventana = new AgregarArticulo(catalogo);
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

            ListarMarcas ventana = new ListarMarcas(marcas);
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void listarCategoriasTSP_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListarCategorias))
                {
                    return;
                }
            }

            ListarCategorias ventana = new ListarCategorias(categorias);
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void modificarTSP_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModificarArticulo))
                {
                    return;
                }
            }

            ModificarArticulo ventana = new ModificarArticulo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void agregarMarcasTSP_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(AgregarMarcas))
                {
                    return;
                }
            }

            AgregarMarcas ventana = new AgregarMarcas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void agregarCatTSP_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(AgregarCategorias))
                {
                    return;
                }
            }

            AgregarCategorias ventana = new AgregarCategorias();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void modMarcasTSP_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModificarMarca))
                {
                    return;
                }
            }

            ModificarMarca ventana = new ModificarMarca();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void modCatTSP_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModificarCategorias))
                {
                    return;
                }
            }

            ModificarCategorias ventana = new ModificarCategorias();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(VerArticulo))
                {
                    return;
                }
            }

            VerArticulo ventana = new VerArticulo();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
