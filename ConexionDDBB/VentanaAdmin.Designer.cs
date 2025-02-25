namespace ConexionDDBB
{
    partial class VentanaAdmin
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
            this.chkBaneado = new System.Windows.Forms.CheckBox();
            this.chkEsAdmin = new System.Windows.Forms.CheckBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBaneado
            // 
            this.chkBaneado.AutoSize = true;
            this.chkBaneado.BackColor = System.Drawing.Color.Transparent;
            this.chkBaneado.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBaneado.ForeColor = System.Drawing.Color.White;
            this.chkBaneado.Location = new System.Drawing.Point(51, 281);
            this.chkBaneado.Name = "chkBaneado";
            this.chkBaneado.Size = new System.Drawing.Size(83, 17);
            this.chkBaneado.TabIndex = 13;
            this.chkBaneado.Text = "Baneado";
            this.chkBaneado.UseVisualStyleBackColor = false;
            // 
            // chkEsAdmin
            // 
            this.chkEsAdmin.AutoSize = true;
            this.chkEsAdmin.BackColor = System.Drawing.Color.Transparent;
            this.chkEsAdmin.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEsAdmin.ForeColor = System.Drawing.Color.White;
            this.chkEsAdmin.Location = new System.Drawing.Point(165, 281);
            this.chkEsAdmin.Name = "chkEsAdmin";
            this.chkEsAdmin.Size = new System.Drawing.Size(139, 17);
            this.chkEsAdmin.TabIndex = 14;
            this.chkEsAdmin.Text = "Es Administrador";
            this.chkEsAdmin.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(841, 508);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(841, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(404, 293);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(167, 30);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Guardar Cambios";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(50, 332);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(50, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(50, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nombre de Usuario:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.Lavender;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContrasena.Location = new System.Drawing.Point(50, 248);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(150, 13);
            this.txtContrasena.TabIndex = 21;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Lavender;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(50, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 13);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.Lavender;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(50, 140);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(150, 13);
            this.txtNombreUsuario.TabIndex = 19;
            this.txtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(50, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "Administracion Videojuegos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 188);
            this.dataGridView1.TabIndex = 41;
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConexionDDBB.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkEsAdmin);
            this.Controls.Add(this.chkBaneado);
            this.Name = "VentanaAdmin";
            this.Text = "VentanaAdmin";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkBaneado;
        private System.Windows.Forms.CheckBox chkEsAdmin;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}