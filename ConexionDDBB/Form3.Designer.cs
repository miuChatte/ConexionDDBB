using System.Windows.Forms;

using System.Collections.Generic; // Para manejar colecciones de usuarios

namespace ConexionDDBB
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtNombreUsuario;
        private TextBox txtEmail;
        private TextBox txtContrasena;
        private CheckBox chkEsAdmin;
        private CheckBox chkBaneado;

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutUsuarios;// Contenedor para los Labels de usuarios

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.chkEsAdmin = new System.Windows.Forms.CheckBox();
            this.chkBaneado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutUsuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.Lavender;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(12, 40);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(150, 13);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Lavender;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(12, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 13);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.Lavender;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContrasena.Location = new System.Drawing.Point(12, 148);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(150, 13);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkEsAdmin
            // 
            this.chkEsAdmin.AutoSize = true;
            this.chkEsAdmin.BackColor = System.Drawing.Color.Transparent;
            this.chkEsAdmin.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEsAdmin.ForeColor = System.Drawing.Color.White;
            this.chkEsAdmin.Location = new System.Drawing.Point(118, 186);
            this.chkEsAdmin.Name = "chkEsAdmin";
            this.chkEsAdmin.Size = new System.Drawing.Size(139, 17);
            this.chkEsAdmin.TabIndex = 4;
            this.chkEsAdmin.Text = "Es Administrador";
            this.chkEsAdmin.UseVisualStyleBackColor = false;
            this.chkEsAdmin.CheckedChanged += new System.EventHandler(this.chkEsAdmin_CheckedChanged);
            // 
            // chkBaneado
            // 
            this.chkBaneado.AutoSize = true;
            this.chkBaneado.BackColor = System.Drawing.Color.Transparent;
            this.chkBaneado.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBaneado.ForeColor = System.Drawing.Color.White;
            this.chkBaneado.Location = new System.Drawing.Point(15, 186);
            this.chkBaneado.Name = "chkBaneado";
            this.chkBaneado.Size = new System.Drawing.Size(83, 17);
            this.chkBaneado.TabIndex = 12;
            this.chkBaneado.Text = "Baneado";
            this.chkBaneado.UseVisualStyleBackColor = false;
            this.chkBaneado.CheckedChanged += new System.EventHandler(this.chkBaneado_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 220);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(118, 220);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 30);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(224, 220);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(330, 220);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña:";
            // 
            // flowLayoutUsuarios
            // 
            this.flowLayoutUsuarios.AutoScroll = true;
            this.flowLayoutUsuarios.Location = new System.Drawing.Point(219, 12);
            this.flowLayoutUsuarios.Name = "flowLayoutUsuarios";
            this.flowLayoutUsuarios.Size = new System.Drawing.Size(318, 150);
            this.flowLayoutUsuarios.TabIndex = 0;
            this.flowLayoutUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutUsuarios_Paint);
            // 
            // Form3
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 367);
            this.Controls.Add(this.flowLayoutUsuarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkEsAdmin);
            this.Controls.Add(this.chkBaneado);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombreUsuario);
            this.Name = "Form3";
            this.Text = "Administración de Usuarios";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}