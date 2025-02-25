using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexionDDBB
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ListarUsuarios(); // Cargar los usuarios al abrir la ventana
        }

        private void ListarUsuarios()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT NombreUsuario, Email, EsAdministrador, Baneado FROM Usuarios";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Limpiar las etiquetas antes de mostrar los nuevos usuarios
                    flowLayoutUsuarios.Controls.Clear();

                    // Recorrer los usuarios y mostrarlos como etiquetas
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Label lblUsuario = new Label
                        {
                            Text = $"Nombre: {row["NombreUsuario"]}, Email: {row["Email"]}, Admin: {row["EsAdministrador"]}, Baneado: {row["Baneado"]}",
                            AutoSize = true,
                            Font = new System.Drawing.Font("MS PGothic", 9.0F, System.Drawing.FontStyle.Bold),
                            Margin = new Padding(5)
                        };

                        flowLayoutUsuarios.Controls.Add(lblUsuario);
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreUsuario.Text;
            string email = txtEmail.Text;
            string contrasena = txtContrasena.Text;
            bool esAdmin = chkEsAdmin.Checked;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un usuario.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Usuarios (NombreUsuario, Email, Contrasena, EsAdministrador) VALUES (@nombre, @correo, @contrasena, @esAdmin)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@correo", email);
                    command.Parameters.AddWithValue("@contrasena", contrasena);
                    command.Parameters.AddWithValue("@esAdmin", esAdmin);
                    command.ExecuteNonQuery();
                }
            }

            ListarUsuarios();
            MessageBox.Show("Usuario agregado exitosamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (flowLayoutUsuarios.Controls.Count == 0)
            {
                MessageBox.Show("No hay usuarios para editar.");
                return;
            }

            string nombre = txtNombreUsuario.Text;
            string email = txtEmail.Text;
            bool esAdmin = chkEsAdmin.Checked;
            bool esBaneado = chkBaneado.Checked;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de editar un usuario.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Usuarios SET Email = @correo, EsAdministrador = @esAdmin,  Baneado = @baneado WHERE NombreUsuario = @nombre";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@correo", email);
                    command.Parameters.AddWithValue("@esAdmin", esAdmin);
                    command.Parameters.AddWithValue("@baneado", esBaneado);
                    command.ExecuteNonQuery();
                }
            }

            ListarUsuarios();
            MessageBox.Show("Usuario editado exitosamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (flowLayoutUsuarios.Controls.Count == 0)
            {
                MessageBox.Show("No hay usuarios para eliminar.");
                return;
            }

            string nombre = txtNombreUsuario.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Usuarios WHERE NombreUsuario = @nombre";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.ExecuteNonQuery();
                }
            }

            ListarUsuarios();
            MessageBox.Show("Usuario eliminado exitosamente.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkEsAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBaneado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        // Manejo de selección de usuario (si es necesario)
        /*private void FlowLayoutPanelUsuarios_Click(object sender, EventArgs e)
        {
            
        }*/
    }
}




