namespace IEFIProgramacion_2
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtReparacion = new System.Windows.Forms.TextBox();
            this.lblReparacion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblCosto_Total = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblFechaEgreso = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btCargarCelular = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dgvCelular = new System.Windows.Forms.DataGridView();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCelular)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(26, 60);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 20);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(123, 57);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(145, 26);
            this.txtMarca.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(123, 88);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(145, 26);
            this.txtModelo.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(26, 92);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // txtReparacion
            // 
            this.txtReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReparacion.Location = new System.Drawing.Point(123, 121);
            this.txtReparacion.Name = "txtReparacion";
            this.txtReparacion.Size = new System.Drawing.Size(145, 26);
            this.txtReparacion.TabIndex = 5;
            // 
            // lblReparacion
            // 
            this.lblReparacion.AutoSize = true;
            this.lblReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparacion.Location = new System.Drawing.Point(26, 124);
            this.lblReparacion.Name = "lblReparacion";
            this.lblReparacion.Size = new System.Drawing.Size(91, 20);
            this.lblReparacion.TabIndex = 4;
            this.lblReparacion.Text = "Reparacion";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(26, 159);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 20);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado: ";
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnico.Location = new System.Drawing.Point(26, 202);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(68, 20);
            this.lblTecnico.TabIndex = 8;
            this.lblTecnico.Text = "Tecnico:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(123, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 26);
            this.textBox1.TabIndex = 11;
            // 
            // LblCosto_Total
            // 
            this.LblCosto_Total.AutoSize = true;
            this.LblCosto_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCosto_Total.Location = new System.Drawing.Point(26, 234);
            this.LblCosto_Total.Name = "LblCosto_Total";
            this.LblCosto_Total.Size = new System.Drawing.Size(94, 20);
            this.LblCosto_Total.TabIndex = 10;
            this.LblCosto_Total.Text = "Costo Total:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(123, 263);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 26);
            this.textBox3.TabIndex = 15;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(13, 263);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(114, 20);
            this.lblFechaIngreso.TabIndex = 14;
            this.lblFechaIngreso.Text = "Fecha ingreso:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(123, 161);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(145, 21);
            this.cbEstado.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(123, 295);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 26);
            this.textBox4.TabIndex = 18;
            // 
            // lblFechaEgreso
            // 
            this.lblFechaEgreso.AutoSize = true;
            this.lblFechaEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEgreso.Location = new System.Drawing.Point(13, 295);
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(115, 20);
            this.lblFechaEgreso.TabIndex = 17;
            this.lblFechaEgreso.Text = "Fecha egreso: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(793, 60);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(145, 26);
            this.txtBuscar.TabIndex = 20;
            // 
            // btCargarCelular
            // 
            this.btCargarCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargarCelular.Location = new System.Drawing.Point(292, 55);
            this.btCargarCelular.Name = "btCargarCelular";
            this.btCargarCelular.Size = new System.Drawing.Size(150, 31);
            this.btCargarCelular.TabIndex = 21;
            this.btCargarCelular.Text = "Cargar celular";
            this.btCargarCelular.UseVisualStyleBackColor = true;
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(793, 92);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(150, 31);
            this.btBuscar.TabIndex = 22;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvCelular
            // 
            this.dgvCelular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCelular.Location = new System.Drawing.Point(28, 362);
            this.dgvCelular.Name = "dgvCelular";
            this.dgvCelular.Size = new System.Drawing.Size(971, 251);
            this.dgvCelular.TabIndex = 23;
            // 
            // cbTecnico
            // 
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(123, 201);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(145, 21);
            this.cbTecnico.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1030, 633);
            this.Controls.Add(this.cbTecnico);
            this.Controls.Add(this.dgvCelular);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btCargarCelular);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblFechaEgreso);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblCosto_Total);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtReparacion);
            this.Controls.Add(this.lblReparacion);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCelular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtReparacion;
        private System.Windows.Forms.Label lblReparacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblCosto_Total;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblFechaEgreso;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btCargarCelular;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dgvCelular;
        private System.Windows.Forms.ComboBox cbTecnico;
    }
}

