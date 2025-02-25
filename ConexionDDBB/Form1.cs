using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexionDDBB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña para verificar acceso.");
                return;
            }

            // Verificar si el usuario es administrador
            if (EsAdministrador(usuario, contrasena))
            {
                Form3 formAdmin = new Form3(); // Instancia la nueva ventana
                formAdmin.ShowDialog(); // Abre la ventana de administrador como modal
            }
            else
            {
                MessageBox.Show("Acceso denegado. Solo los administradores pueden acceder a esta ventana.");
            }
        }

        private bool EsAdministrador(string usuario, string contrasena)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT EsAdministrador FROM Usuarios WHERE NombreUsuario = @usuario AND Contrasena = @contrasena";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasena", contrasena);

                    object result = command.ExecuteScalar();

                    if (result != null && Convert.ToBoolean(result))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "Iniciando proceso de login...";
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Complete ambos campos.");
                    return;
                }

                // Obtener la cadena de conexión desde App.config
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                lblMensaje.Text = "Conectando a la base de datos...";

                // Conectar a la base de datos
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    lblMensaje.Text = "Conexión exitosa.";

                    // Consulta SQL para verificar usuario, contraseña y si está baneado
                    string query = "SELECT Baneado FROM Usuarios WHERE NombreUsuario = @usuario AND Contrasena = @contrasena";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@contrasena", contraseña);

                        object result = command.ExecuteScalar(); // Devuelve Baneado o null si no se encuentra el usuario

                        if (result != null)
                        {
                            bool baneado = Convert.ToBoolean(result);

                            if (baneado)
                            {
                                MessageBox.Show("Tu cuenta está baneada. No puedes acceder.");
                            }
                            else
                            {
                                Form2 form2 = new Form2(usuario);
                                this.Hide();
                                form2.ShowDialog();
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos.");
            }
        }


        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete ambos campos antes de registrar un usuario.");
                return;
            }

            InsertarUsuario(usuario, contraseña);
        }

        private void InsertarUsuario(string usuario, string contraseña)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verificar si el usuario ya existe
                    string checkQuery = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @usuario";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@usuario", usuario);
                        int userExists = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (userExists > 0)
                        {
                            MessageBox.Show("El usuario ya existe en la base de datos.");
                            return;
                        }
                    }

                    // Insertar un nuevo usuario
                    string query = "INSERT INTO Usuarios (NombreUsuario, Contrasena) VALUES (@usuario, @contrasena)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@contrasena", contraseña);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario agregado exitosamente a la base de datos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar usuario: " + ex.Message);
                }
            }
        }

        private void usuarioBaneado()
        {

        }
    }
}


