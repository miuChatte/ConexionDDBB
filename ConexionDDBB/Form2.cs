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
    public partial class Form2 : Form
    {
        private string _usuario;

        public Form2(string usuario)
        {
            InitializeComponent();

            comboBox1.Text = $"{usuario}";
            _usuario = usuario;
            this.Load += new EventHandler(Form2_Load);
        }

        private void Form2_Load(object sender, EventArgs e)
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

        // Evento para manejar la selección en el ComboBox
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
                    flowLayoutPanel2.Controls.Clear(); // Limpiar juegos anteriores

                    while (reader.Read())
                    {
                        string nombre = reader.GetString("Nombre");
                        decimal precio = reader.GetDecimal("Precio");
                        string descripcion = reader.GetString("Descripcion");
                        string urlImagen = reader.GetString("Url");

                        // Crear un panel para el juego
                        Panel panelJuego = new Panel
                        {
                            Size = new Size(200, 300),
                            BorderStyle = BorderStyle.FixedSingle,
                            Padding = new Padding(5)
                        };

                        // Cargar imagen desde URL
                        PictureBox pictureBox = new PictureBox
                        {
                            Size = new Size(190, 150),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Image = CargarImagenDesdeURL(urlImagen)
                        };

                        // Etiqueta para el nombre
                        Label lblNombre = new Label
                        {
                            Text = nombre,
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            AutoSize = true
                        };

                        // Etiqueta para el precio
                        Label lblPrecio = new Label
                        {
                            Text = "Precio: $" + precio,
                            Font = new Font("Arial", 9, FontStyle.Regular),
                            AutoSize = true
                        };

                        // Etiqueta para la descripción
                        Label lblDescripcion = new Label
                        {
                            Text = descripcion,
                            Font = new Font("Arial", 8, FontStyle.Italic),
                            AutoSize = true
                        };


                        // Agregar evento de clic al panel
                        panelJuego.Click += (s, e) =>
                        {
                            DetalleVideojuego detallesForm = new DetalleVideojuego(nombre, precio, descripcion, urlImagen, _usuario);
                            detallesForm.ShowDialog();
                        };

                        // Agregar elementos al panel
                        panelJuego.Controls.Add(pictureBox);
                        panelJuego.Controls.Add(lblNombre);
                        panelJuego.Controls.Add(lblPrecio);
                        panelJuego.Controls.Add(lblDescripcion);

                        // Posicionar los elementos en el panel
                        pictureBox.Location = new Point(5, 5);
                        lblNombre.Location = new Point(5, 160);
                        lblPrecio.Location = new Point(5, 180);
                        lblDescripcion.Location = new Point(5, 200);

                        // Agregar panel al FlowLayoutPanel
                        flowLayoutPanel2.Controls.Add(panelJuego);
                    }
                }
            }
        }
    }
}
/*using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ConexionDDBB
{
    public partial class Form2 : Form
    {
        private string _usuario;

        public Form2(string usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            comboBox1.Text = _usuario;
            this.Load += new EventHandler(Form2_Load);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(_usuario))
            {
                comboBox1.Items.Insert(0, _usuario);
            }

            comboBox1.SelectedItem = _usuario;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Verificar si el usuario es administrador
            if (EsAdministrador(_usuario))
            {
                comboBox1.Items.Add("Administrar Usuarios");
                btnAdminVideojuegos.Visible = true; // Mostrar el botón para admins
            }
            else
            {
                btnAdminVideojuegos.Visible = false; // Ocultar para usuarios normales
            }

            // Cargar los videojuegos en el FlowLayoutPanel
            CargarVideojuegos();
        }

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
                    flowLayoutPanel2.Controls.Clear(); // Limpiar juegos anteriores

                    while (reader.Read())
                    {
                        string nombre = reader.GetString("Nombre");
                        string precio = reader.GetString("Precio");
                        string descripcion = reader.GetString("Descripcion");
                        string urlImagen = reader.GetString("Url");

                        // Crear un panel para el juego
                        Panel panelJuego = new Panel
                        {
                            Size = new Size(200, 300),
                            BorderStyle = BorderStyle.FixedSingle,
                            Padding = new Padding(5)
                        };

                        // Cargar imagen desde URL
                        PictureBox pictureBox = new PictureBox
                        {
                            Size = new Size(190, 150),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Image = CargarImagenDesdeURL(urlImagen)
                        };

                        // Etiqueta para el nombre
                        Label lblNombre = new Label
                        {
                            Text = nombre,
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            AutoSize = true
                        };

                        // Etiqueta para el precio
                        Label lblPrecio = new Label
                        {
                            Text = "Precio: $" + precio,
                            Font = new Font("Arial", 9, FontStyle.Regular),
                            AutoSize = true
                        };

                        // Etiqueta para la descripción
                        Label lblDescripcion = new Label
                        {
                            Text = descripcion,
                            Font = new Font("Arial", 8, FontStyle.Italic),
                            AutoSize = true
                        };

                        // Agregar elementos al panel
                        panelJuego.Controls.Add(pictureBox);
                        panelJuego.Controls.Add(lblNombre);
                        panelJuego.Controls.Add(lblPrecio);
                        panelJuego.Controls.Add(lblDescripcion);

                        // Posicionar los elementos en el panel
                        pictureBox.Location = new Point(5, 5);
                        lblNombre.Location = new Point(5, 160);
                        lblPrecio.Location = new Point(5, 180);
                        lblDescripcion.Location = new Point(5, 200);

                        // Agregar panel al FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(panelJuego);
                    }
                }
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
                return Properties.Resources.imagen_default; // Imagen por defecto si falla la carga
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnAdminVideojuegos_Click(object sender, EventArgs e)
        {
            VentanaVideojuegos ventanaVideojuegos = new VentanaVideojuegos();
            ventanaVideojuegos.ShowDialog();
        }
    }
}
*/

