﻿namespace TP_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMarcasTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMarcasTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.modMarcasTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCategoriasTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCatTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.modCatTSP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB2 = new System.Windows.Forms.ToolStripButton();
            this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoTSP,
            this.marcasTSP,
            this.categoriasTSP});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoTSP
            // 
            this.archivoTSP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTSP,
            this.modificarTSP,
            this.eliminarTSP,
            this.listarTSP,
            this.verDetalleToolStripMenuItem});
            this.archivoTSP.Name = "archivoTSP";
            this.archivoTSP.Size = new System.Drawing.Size(66, 20);
            this.archivoTSP.Text = "&Articulos";
            // 
            // agregarTSP
            // 
            this.agregarTSP.Name = "agregarTSP";
            this.agregarTSP.Size = new System.Drawing.Size(180, 22);
            this.agregarTSP.Text = "Agregar";
            this.agregarTSP.Click += new System.EventHandler(this.agregarTSP_Click);
            // 
            // modificarTSP
            // 
            this.modificarTSP.Name = "modificarTSP";
            this.modificarTSP.Size = new System.Drawing.Size(180, 22);
            this.modificarTSP.Text = "Modificar";
            this.modificarTSP.Click += new System.EventHandler(this.modificarTSP_Click);
            // 
            // eliminarTSP
            // 
            this.eliminarTSP.Name = "eliminarTSP";
            this.eliminarTSP.Size = new System.Drawing.Size(180, 22);
            this.eliminarTSP.Text = "Eliminar";
            // 
            // listarTSP
            // 
            this.listarTSP.Name = "listarTSP";
            this.listarTSP.Size = new System.Drawing.Size(180, 22);
            this.listarTSP.Text = "Listar";
            this.listarTSP.Click += new System.EventHandler(this.listarTSP_Click);
            // 
            // marcasTSP
            // 
            this.marcasTSP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarMarcasTSP,
            this.agregarMarcasTSP,
            this.modMarcasTSP});
            this.marcasTSP.Name = "marcasTSP";
            this.marcasTSP.Size = new System.Drawing.Size(57, 20);
            this.marcasTSP.Text = "Marcas";
            // 
            // listarMarcasTSP
            // 
            this.listarMarcasTSP.Name = "listarMarcasTSP";
            this.listarMarcasTSP.Size = new System.Drawing.Size(166, 22);
            this.listarMarcasTSP.Text = "Listar Marcas";
            this.listarMarcasTSP.Click += new System.EventHandler(this.listarMarcasTSP_Click);
            // 
            // agregarMarcasTSP
            // 
            this.agregarMarcasTSP.Name = "agregarMarcasTSP";
            this.agregarMarcasTSP.Size = new System.Drawing.Size(166, 22);
            this.agregarMarcasTSP.Text = "Agregar marcas";
            this.agregarMarcasTSP.Click += new System.EventHandler(this.agregarMarcasTSP_Click);
            // 
            // modMarcasTSP
            // 
            this.modMarcasTSP.DoubleClickEnabled = true;
            this.modMarcasTSP.Name = "modMarcasTSP";
            this.modMarcasTSP.Size = new System.Drawing.Size(166, 22);
            this.modMarcasTSP.Text = "Modificar marcas";
            this.modMarcasTSP.Click += new System.EventHandler(this.modMarcasTSP_Click);
            // 
            // categoriasTSP
            // 
            this.categoriasTSP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarCategoriasTSP,
            this.agregarCatTSP,
            this.modCatTSP});
            this.categoriasTSP.Name = "categoriasTSP";
            this.categoriasTSP.Size = new System.Drawing.Size(75, 20);
            this.categoriasTSP.Text = "Categorias";
            // 
            // listarCategoriasTSP
            // 
            this.listarCategoriasTSP.Name = "listarCategoriasTSP";
            this.listarCategoriasTSP.Size = new System.Drawing.Size(182, 22);
            this.listarCategoriasTSP.Text = "Listar categorias";
            this.listarCategoriasTSP.Click += new System.EventHandler(this.listarCategoriasTSP_Click);
            // 
            // agregarCatTSP
            // 
            this.agregarCatTSP.Name = "agregarCatTSP";
            this.agregarCatTSP.Size = new System.Drawing.Size(182, 22);
            this.agregarCatTSP.Text = "Agregar Categorias";
            this.agregarCatTSP.Click += new System.EventHandler(this.agregarCatTSP_Click);
            // 
            // modCatTSP
            // 
            this.modCatTSP.Name = "modCatTSP";
            this.modCatTSP.Size = new System.Drawing.Size(182, 22);
            this.modCatTSP.Text = "Modificar categorias";
            this.modCatTSP.Click += new System.EventHandler(this.modCatTSP_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB1,
            this.toolStripSeparator1,
            this.TSB2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(982, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB1
            // 
            this.TSB1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB1.Image = ((System.Drawing.Image)(resources.GetObject("TSB1.Image")));
            this.TSB1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB1.Name = "TSB1";
            this.TSB1.Size = new System.Drawing.Size(23, 22);
            this.TSB1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB2
            // 
            this.TSB2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB2.Image = ((System.Drawing.Image)(resources.GetObject("TSB2.Image")));
            this.TSB2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB2.Name = "TSB2";
            this.TSB2.Size = new System.Drawing.Size(23, 22);
            this.TSB2.Text = "toolStripButton3";
            // 
            // verDetalleToolStripMenuItem
            // 
            this.verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            this.verDetalleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verDetalleToolStripMenuItem.Text = "Ver detalle";
            this.verDetalleToolStripMenuItem.Click += new System.EventHandler(this.verDetalleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 613);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoTSP;
        private System.Windows.Forms.ToolStripMenuItem marcasTSP;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB2;
        private System.Windows.Forms.ToolStripMenuItem modificarTSP;
        private System.Windows.Forms.ToolStripMenuItem eliminarTSP;
        private System.Windows.Forms.ToolStripMenuItem listarTSP;
        private System.Windows.Forms.ToolStripMenuItem modMarcasTSP;
        private System.Windows.Forms.ToolStripMenuItem categoriasTSP;
        private System.Windows.Forms.ToolStripMenuItem modCatTSP;
        private System.Windows.Forms.ToolStripMenuItem agregarTSP;
        private System.Windows.Forms.ToolStripMenuItem listarMarcasTSP;
        private System.Windows.Forms.ToolStripMenuItem listarCategoriasTSP;
        private System.Windows.Forms.ToolStripMenuItem agregarMarcasTSP;
        private System.Windows.Forms.ToolStripMenuItem agregarCatTSP;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
    }
}

