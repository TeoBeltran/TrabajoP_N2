namespace TP_WinForm
{
    partial class ModificarCategorias
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
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNuevaDesc = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNuevaDesc = new System.Windows.Forms.TextBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(38, 48);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 8;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelNuevaDesc
            // 
            this.labelNuevaDesc.AutoSize = true;
            this.labelNuevaDesc.Location = new System.Drawing.Point(18, 31);
            this.labelNuevaDesc.Name = "labelNuevaDesc";
            this.labelNuevaDesc.Size = new System.Drawing.Size(63, 13);
            this.labelNuevaDesc.TabIndex = 12;
            this.labelNuevaDesc.Text = "Descripcion";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.buttonCancelar.Location = new System.Drawing.Point(122, 166);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.buttonModificar.Location = new System.Drawing.Point(41, 166);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 13;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNuevaDesc);
            this.groupBox1.Controls.Add(this.tbNuevaDesc);
            this.groupBox1.Location = new System.Drawing.Point(41, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 77);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // tbNuevaDesc
            // 
            this.tbNuevaDesc.Location = new System.Drawing.Point(85, 28);
            this.tbNuevaDesc.Name = "tbNuevaDesc";
            this.tbNuevaDesc.Size = new System.Drawing.Size(240, 20);
            this.tbNuevaDesc.TabIndex = 10;
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(104, 45);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(121, 21);
            this.cbCat.TabIndex = 16;
            // 
            // ModificarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 286);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonModificar);
            this.Name = "ModificarCategorias";
            this.Text = "ModificarCategorias";
            this.Load += new System.EventHandler(this.ModificarCategorias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNuevaDesc;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNuevaDesc;
        private System.Windows.Forms.ComboBox cbCat;
    }
}