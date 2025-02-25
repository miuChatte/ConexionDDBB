using System;
using System.Collections;
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

namespace ConexionDDBB
{

    
    public partial class VentanaVideojuegos : Form
    {
        
        string url_img="";
        public VentanaVideojuegos()
        {
            InitializeComponent();
            ListarVideojuegos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombreVideojuego.Text;
            string descripcion = txtDescripcion.Text;
            string precio = txtPrecio.Text;
           

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(precio))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un usuario.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionVideojuegos"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO videojuegos (Nombre, Precio, Descripcion, Url) VALUES (@nombre, @precio, @descripcion, @url)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@url", url_img);
                    command.ExecuteNonQuery();
                }
            }

            ListarVideojuegos();
            MessageBox.Show("Juego agregado exitosamente.");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog()
            {
                Title ="Seleccionar imagen",
                Filter = "Archivos de imagen (*.png;*.jpg)|*.png;*.jpg",
                Multiselect = false

            };
            

            if(archivo.ShowDialog() == DialogResult.OK )
            {
                url_img= archivo.FileName;
                GuardarImagenEnBD(url_img);
            }
        }

        private void ListarVideojuegos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionVideojuegos"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Nombre, Precio, Descripcion, Url FROM videojuegos";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void GuardarImagenEnBD(string ruta)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionVideojuegos"].ConnectionString;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO videojuegos (nombre, precio, descripcion, url) VALUES (@nombre, @precio, @descripcion, @url)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", "Ejemplo");
                        cmd.Parameters.AddWithValue("@precio", 100);
                        cmd.Parameters.AddWithValue("@descripcion", "Descripción de prueba");
                        cmd.Parameters.AddWithValue("@url", ruta);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Imagen guardada correctamente en la base de datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la imagen: " + ex.Message);
            }
        }

        


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombreVideojuego_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Controls.Count == 0)
            {
                MessageBox.Show("No hay usuarios para eliminar.");
                return;
            }

            int idVideojuego = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionVideojuegos"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM videojuegos WHERE Id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", idVideojuego);
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Videojuego eliminado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el videojuego.");
                    }
                }

                ListarVideojuegos();

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionVideojuegos"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Ignorar filas nuevas sin datos
                    if (row.IsNewRow) continue;

                    // Obtener valores de la fila
                    int idVideojuego = Convert.ToInt32(row.Cells["Id"].Value);
                    string nuevoNombre = row.Cells["Nombre"].Value.ToString();
                    int nuevoPrecio = Convert.ToInt32(row.Cells["Precio"].Value);
                    string nuevaDescripcion = row.Cells["Descripcion"].Value.ToString();
                    string nuevaUrl = row.Cells["Url"].Value.ToString();

                    string query = "UPDATE videojuegos SET Nombre = @nombre, Precio = @precio, Descripcion = @descripcion, Url = @url WHERE Id = @id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idVideojuego);
                        command.Parameters.AddWithValue("@nombre", nuevoNombre);
                        command.Parameters.AddWithValue("@precio", nuevoPrecio);
                        command.Parameters.AddWithValue("@descripcion", nuevaDescripcion);
                        command.Parameters.AddWithValue("@url", nuevaUrl);

                        command.ExecuteNonQuery();
                    }
                }
            }

            // Refrescar la tabla después de actualizar
            ListarVideojuegos();
            MessageBox.Show("Todos los cambios se han guardado correctamente.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();*/
        }
    }
}
