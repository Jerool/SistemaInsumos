namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    partial class FRMProducto
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtcantidadinsumo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cmbinsumo = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbmunidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(240, 417);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(180, 42);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar producto";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cantidad de insumo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Insumo";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.ForeColor = System.Drawing.Color.White;
            this.Precio.Location = new System.Drawing.Point(37, 139);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(46, 17);
            this.Precio.TabIndex = 22;
            this.Precio.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(178, 139);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 20;
            // 
            // txtcantidadinsumo
            // 
            this.txtcantidadinsumo.Location = new System.Drawing.Point(178, 260);
            this.txtcantidadinsumo.Name = "txtcantidadinsumo";
            this.txtcantidadinsumo.Size = new System.Drawing.Size(120, 20);
            this.txtcantidadinsumo.TabIndex = 19;
            this.txtcantidadinsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadinsumo_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(178, 101);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(120, 20);
            this.txtnombre.TabIndex = 17;
            // 
            // cmbinsumo
            // 
            this.cmbinsumo.FormattingEnabled = true;
            this.cmbinsumo.Location = new System.Drawing.Point(178, 219);
            this.cmbinsumo.Name = "cmbinsumo";
            this.cmbinsumo.Size = new System.Drawing.Size(121, 21);
            this.cmbinsumo.TabIndex = 26;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(498, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(450, 407);
            this.listBox1.TabIndex = 27;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(10, 417);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 42);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar insumo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbmunidad
            // 
            this.cbmunidad.FormattingEnabled = true;
            this.cbmunidad.Items.AddRange(new object[] {
            "PACK",
            "GRAMOS",
            "KILOGRAMOS",
            "MILILITROS",
            "LITROS",
            "CENTIMETROS",
            "METROS"});
            this.cbmunidad.Location = new System.Drawing.Point(178, 302);
            this.cbmunidad.Name = "cbmunidad";
            this.cbmunidad.Size = new System.Drawing.Size(121, 21);
            this.cbmunidad.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Unidad de medida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Rubro";
            // 
            // txtRubro
            // 
            this.txtRubro.Location = new System.Drawing.Point(179, 346);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(120, 20);
            this.txtRubro.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(85, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Cantidad producto";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(179, 179);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(120, 20);
            this.txtCantidadProducto.TabIndex = 34;
            this.txtCantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadProducto_KeyPress);
            // 
            // FRMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRubro);
            this.Controls.Add(this.cbmunidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbinsumo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtcantidadinsumo);
            this.Controls.Add(this.txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMProducto";
            this.Text = "FRMProducto";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtcantidadinsumo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cmbinsumo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbmunidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidadProducto;
    }
}