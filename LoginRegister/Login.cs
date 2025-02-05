using System;
using System.Drawing;
using System.Windows.Forms;
using DashboardApp;  // Asegúrate de importar el namespace correcto

namespace LoginRegister
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Ruta completa del archivo GIF
            string gifPath = @"C:\Users\USER\OneDrive\Desktop\MedicionGastos\Side Plexus Particles Free White Background Videos, No Copyright .gif";

            // Verifica si el archivo GIF existe en la ruta especificada
            if (System.IO.File.Exists(gifPath))
            {
                // Crea un PictureBox para mostrar el GIF
                PictureBox backgroundGif = new PictureBox
                {
                    Image = Image.FromFile(gifPath),  // Carga el GIF
                    SizeMode = PictureBoxSizeMode.StretchImage,  // Ajusta el GIF para que cubra todo el formulario
                    Dock = DockStyle.Fill,  // El PictureBox ocupa todo el formulario
                    BackColor = Color.Transparent  // Fondo transparente para que se vea el GIF
                };

                // Añade el PictureBox al formulario
                this.Controls.Add(backgroundGif);

                // Asegura que los controles como los botones estén visibles encima del GIF
                this.Registrobtn.BringToFront();
                this.loginbtn.BringToFront();
                this.UsernameTB.BringToFront();
                this.PasswordTB.BringToFront();
            }
        }

        // Método para manejar el clic en el botón "Registrobtn"
        private void Registrobtn_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de registro (SignUp)
            SignUp signUpForm = new SignUp();

            // Muestra el formulario de registro
            signUpForm.Show();

            // Oculta el formulario de inicio de sesión
            this.Hide();
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            // Código adicional si necesitas manejar cambios en el campo de contraseña
        }

        // Método para manejar el clic en el botón "loginbtn"
        private void loginbtn_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar tu lógica de validación de usuario y contraseña.
            string username = UsernameTB.Text;
            string password = PasswordTB.Text;

            if (username == "admin" && password == "1234") // Reemplaza con tu lógica real
            {
                try
                {
                    // Crear una instancia del formulario Form1 desde el namespace DashboardApp
                    Form1 dashboard = new Form1();

                    // Mostrar la Dashboard
                    dashboard.Show();

                    // Ocultar el formulario de login
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el Dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}




