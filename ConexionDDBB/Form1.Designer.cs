using System.Drawing;
using System.Windows.Forms;

namespace ConexionDDBB
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnLogin;
        private Button btnSalir;
        private Label lblMensaje;
        private Label lblBienvenida;
        private Button btnCerrarSesion;
        private Button btnRegistrarUsuario;



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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(120, 30);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(120, 70);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(200, 22);
            this.txtContraseña.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(120, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(205, 110);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(120, 140);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(160, 23);
            this.btnRegistrarUsuario.TabIndex = 4;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(120, 150);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(200, 20);
            this.lblMensaje.TabIndex = 4;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(120, 30);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(200, 20);
            this.lblBienvenida.TabIndex = 5;
            this.lblBienvenida.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(120, 70);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 23);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(54, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 211);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnCerrarSesion);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}