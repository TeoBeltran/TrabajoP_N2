namespace TP_WinForm
{
    partial class frmArticulo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCod = new System.Windows.Forms.Label();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelCat = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCod);
            this.groupBox1.Controls.Add(this.cbCat);
            this.groupBox1.Controls.Add(this.tbCod);
            this.groupBox1.Controls.Add(this.cbBrand);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.labelCat);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelBrand);
            this.groupBox1.Controls.Add(this.tbDesc);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.labelDesc);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Location = new System.Drawing.Point(27, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 244);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(24, 31);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(40, 13);
            this.labelCod.TabIndex = 13;
            this.labelCod.Text = "Código";
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(91, 163);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(107, 21);
            this.cbCat.TabIndex = 24;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(91, 28);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(107, 20);
            this.tbCod.TabIndex = 10;
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(91, 128);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(107, 21);
            this.cbBrand.TabIndex = 23;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(91, 60);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(107, 20);
            this.tbName.TabIndex = 15;
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(24, 166);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(54, 13);
            this.labelCat.TabIndex = 22;
            this.labelCat.Text = "Categoría";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Nombre";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(24, 131);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(37, 13);
            this.labelBrand.TabIndex = 21;
            this.labelBrand.Text = "Marca";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(91, 95);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(107, 20);
            this.tbDesc.TabIndex = 17;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(24, 203);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(37, 13);
            this.labelPrice.TabIndex = 20;
            this.labelPrice.Text = "Precio";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(24, 98);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(63, 13);
            this.labelDesc.TabIndex = 18;
            this.labelDesc.Text = "Descripcion";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(91, 200);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(107, 20);
            this.tbPrice.TabIndex = 19;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(24, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(90, 25);
            this.labelTitulo.TabIndex = 30;
            this.labelTitulo.Text = "Artículo:";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.buttonAgregar.Location = new System.Drawing.Point(174, 298);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 32;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 383);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmArticulo";
            this.Text = "frmArticulo";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAgregar;
    }
}