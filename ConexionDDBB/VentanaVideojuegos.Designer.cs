namespace ConexionDDBB
{
    partial class VentanaVideojuegos
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombreVideojuego = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ventanaPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecio.Location = new System.Drawing.Point(60, 149);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(54, 13);
            this.lblPrecio.TabIndex = 35;
            this.lblPrecio.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(60, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nombre de videojuego:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Lavender;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescripcion.Location = new System.Drawing.Point(60, 220);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(150, 13);
            this.txtDescripcion.TabIndex = 33;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Lavender;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(60, 165);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(150, 13);
            this.txtPrecio.TabIndex = 32;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreVideojuego
            // 
            this.txtNombreVideojuego.BackColor = System.Drawing.Color.Lavender;
            this.txtNombreVideojuego.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreVideojuego.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVideojuego.Location = new System.Drawing.Point(60, 112);
            this.txtNombreVideojuego.Name = "txtNombreVideojuego";
            this.txtNombreVideojuego.Size = new System.Drawing.Size(150, 13);
            this.txtNombreVideojuego.TabIndex = 31;
            this.txtNombreVideojuego.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreVideojuego.TextChanged += new System.EventHandler(this.txtNombreVideojuego_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(875, 299);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(433, 290);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(167, 30);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(60, 299);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(84, 550);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(230, 30);
            this.btnUsuarios.TabIndex = 38;
            this.btnUsuarios.Text = "Administracion Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(750, 550);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 37;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 188);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ventanaPrincipal
            // 
            this.ventanaPrincipal.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventanaPrincipal.Location = new System.Drawing.Point(856, 550);
            this.ventanaPrincipal.Name = "ventanaPrincipal";
            this.ventanaPrincipal.Size = new System.Drawing.Size(242, 30);
            this.ventanaPrincipal.TabIndex = 41;
            this.ventanaPrincipal.Text = "Volver a catalogo ->";
            this.ventanaPrincipal.UseVisualStyleBackColor = true;
            this.ventanaPrincipal.Click += new System.EventHandler(this.button2_Click);
            // 
            // VentanaVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConexionDDBB.Properties.Resources.FQ4TdQIWQAAoQ1n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 644);
            this.Controls.Add(this.ventanaPrincipal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombreVideojuego);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "VentanaVideojuegos";
            this.Text = "VentanaVideojuegos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombreVideojuego;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ventanaPrincipal;
    }
}