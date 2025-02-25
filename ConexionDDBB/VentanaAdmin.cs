using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConexionDDBB
{
    public partial class VentanaAdmin : Form
    {

        private string _usuario;
        public VentanaAdmin(string usuario)
        {
            InitializeComponent();
            ListarUsuarios();
            _usuario = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaVideojuegos formAdmin = new VentanaVideojuegos(); // Abre la ventana de administración
            formAdmin.ShowDialog();
        }


        private void ListarUsuarios()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT NombreUsuario, Email, EsAdministrador, Baneado FROM usuarios";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreUsuario.Text;
            string email = txtEmail.Text;
            string contraseña = txtContrasena.Text;
            bool esAdmin = chkEsAdmin.Checked;
            bool baneado = chkBaneado.Checked;


            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un usuario.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO usuarios (NombreUsuario, Email, EsAdministrador, Baneado) VALUES (@nombre, @email, @esAdmin, @baneado)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@esAdmin", esAdmin);
                    command.Parameters.AddWithValue("@baneado", baneado);
                    command.ExecuteNonQuery();
                }
            }

            ListarUsuarios();
            MessageBox.Show("Usuario agregado exitosamente.");
            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionUsuarios"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string nombre = row.Cells["NombreUsuario"].Value.ToString();
                    string contrasena = row.Cells["Contrasena"].Value.ToString();
                    string email = row.Cells["Email"].Value.ToString();
                    int esAdmin = Convert.ToInt32(row.Cells["EsAdministrador"].Value);
                    int baneado = Convert.ToInt32(row.Cells["Baneado"].Value);

                    string query = "UPDATE usuarios SET Contrasena = @contrasena, Email = @email, EsAdministrador = @esAdmin, Baneado = @baneado WHERE NombreUsuario = @nombre";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@contrasena", contrasena);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@esAdmin", esAdmin);
                        command.Parameters.AddWithValue("@baneado", baneado);
                        command.ExecuteNonQuery();
                    }
                }
            }

            ListarUsuarios();
            MessageBox.Show("Cambios guardados exitosamente.");
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay usuarios para eliminar.");
                return;
            }

            String nombreUsuario = dataGridView1.SelectedRows[0].Cells["NombreUsuario"].Value.ToString();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM usuarios WHERE NombreUsuario = @nombreUsuario";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.ExecuteNonQuery();
                }
            }

            ListarUsuarios();
            MessageBox.Show("Usuario eliminado");

        }
          

        private void btnCerrar_Click(object sender, EventArgs e)
        {
                Form2 inicio = new Form2(_usuario); // Abre la ventana de inicio
                inicio.ShowDialog();
            
        } 
    
    } 

}