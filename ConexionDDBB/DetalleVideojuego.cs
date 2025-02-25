using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexionDDBB
{
    public partial class DetalleVideojuego : Form
    {
        private string _usuario;

        public DetalleVideojuego(String nombre, decimal precio, String descripcion, String urlImagen, String usuario)
        {
            InitializeComponent();
            comboBox1.Text = $"{usuario}";
            _usuario = usuario;
            this.Load += new EventHandler(DetalleVideojuego_Load);

        }

        private void DetalleVideojuego_Load(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(_usuario))
            {
                comboBox1.Items.Insert(0, _usuario); // Agrega el usuario al inicio de la lista.
            }

            comboBox1.SelectedItem = _usuario; // Selecciona el nombre de usuario como predeterminado.
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Verificar si el usuario es administrador
            if (EsAdministrador(_usuario))
            {
                comboBox1.Items.Add("Administrar Usuarios");
                comboBox1.Items.Add("Administrar Videojuegos");
            }
            CargarVideojuegos();
        }

        // Método para verificar si el usuario es administrador
        private bool EsAdministrador(string usuario)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT EsAdministrador FROM Usuarios WHERE NombreUsuario = @usuario";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);

                    object result = command.ExecuteScalar();
                    return result != null && Convert.ToBoolean(result);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Administrar Usuarios")
            {
                VentanaAdmin formAdmin = new VentanaAdmin(_usuario); // Abre la ventana de administración
                formAdmin.ShowDialog();
            }
            if (comboBox1.SelectedItem.ToString() == "Administrar Videojuegos")
            {
                VentanaVideojuegos formAdmin = new VentanaVideojuegos(); // Abre la ventana de administración
                formAdmin.ShowDialog();
            }
        }

        private Image CargarImagenDesdeURL(string url)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(url);
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(data))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                return Properties.Resources.blue; // Imagen por defecto si falla la carga
            }
        }

        private void CargarVideojuegos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionVideojuegos"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Nombre, Precio, Descripcion, Url FROM videojuegos";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    panelDatosJuego.Controls.Clear(); // Limpiar juegos anteriores

                    while (reader.Read())
                    {
                        string nombre = reader.GetString("Nombre");
                        decimal precio = reader.GetDecimal("Precio");
                        string descripcion = reader.GetString("Descripcion");
                        string urlImagen = reader.GetString("Url");


                        imagenJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                        imagenJuego.Image=CargarImagenDesdeURL(urlImagen);

                        nombreGame = new Label
                        {
                            Text= nombre
                        };

                        precioGame = new Label
                        {
                            Text = "Precio: $" + precio
                        };
                        // Crear un panel para el juego
                        /*Panel panelJuego = new Panel
                        {
                            Size = new Size(200, 300),
                            BorderStyle = BorderStyle.FixedSingle,
                            Padding = new Padding(5)
                        };*/

                        textBox1 = new TextBox
                        {
                            Text = descripcion
                        };

                    }
                }
            }
        }

        
    }
}
