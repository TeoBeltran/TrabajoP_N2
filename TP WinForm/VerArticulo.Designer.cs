namespace TP_WinForm
{
    partial class VerArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCat = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelCod = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.buttonCancelar.Location = new System.Drawing.Point(93, 350);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Salir";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCat);
            this.groupBox1.Controls.Add(this.tbBrand);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.tbDesc);
            this.groupBox1.Controls.Add(this.labelCat);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelBrand);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.labelDesc);
            this.groupBox1.Location = new System.Drawing.Point(93, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 208);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // tbCat
            // 
            this.tbCat.AutoSize = true;
            this.tbCat.Location = new System.Drawing.Point(80, 128);
            this.tbCat.Name = "tbCat";
            this.tbCat.Size = new System.Drawing.Size(54, 13);
            this.tbCat.TabIndex = 15;
            this.tbCat.Text = "Categoría";
            // 
            // tbBrand
            // 
            this.tbBrand.AutoSize = true;
            this.tbBrand.Location = new System.Drawing.Point(80, 93);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(37, 13);
            this.tbBrand.TabIndex = 14;
            this.tbBrand.Text = "Marca";
            // 
            // tbName
            // 
            this.tbName.AutoSize = true;
            this.tbName.Location = new System.Drawing.Point(80, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(44, 13);
            this.tbName.TabIndex = 11;
            this.tbName.Text = "Nombre";
            // 
            // tbPrice
            // 
            this.tbPrice.AutoSize = true;
            this.tbPrice.Location = new System.Drawing.Point(80, 165);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(37, 13);
            this.tbPrice.TabIndex = 13;
            this.tbPrice.Text = "Precio";
            // 
            // tbDesc
            // 
            this.tbDesc.AutoSize = true;
            this.tbDesc.Location = new System.Drawing.Point(80, 60);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(63, 13);
            this.tbDesc.TabIndex = 12;
            this.tbDesc.Text = "Descripcion";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(16, 128);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(54, 13);
            this.labelCat.TabIndex = 8;
            this.labelCat.Text = "Categoría";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nombre";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(16, 93);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(37, 13);
            this.labelBrand.TabIndex = 6;
            this.labelBrand.Text = "Marca";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(16, 165);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(37, 13);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Precio";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(16, 60);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(63, 13);
            this.labelDesc.TabIndex = 4;
            this.labelDesc.Text = "Descripcion";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(40, 36);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(196, 25);
            this.labelTitulo.TabIndex = 11;
            this.labelTitulo.Text = "Detalle del artículo:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.buttonBuscar.Location = new System.Drawing.Point(290, 72);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(90, 77);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(40, 13);
            this.labelCod.TabIndex = 8;
            this.labelCod.Text = "Código";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(136, 74);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(107, 20);
            this.tbCod.TabIndex = 9;
            // 
            // VerArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.tbCod);
            this.Name = "VerArticulo";
            this.Text = "VerArticulo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label tbName;
        private System.Windows.Forms.Label tbPrice;
        private System.Windows.Forms.Label tbDesc;
        private System.Windows.Forms.Label tbCat;
        private System.Windows.Forms.Label tbBrand;
    }
}