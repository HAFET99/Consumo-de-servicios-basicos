using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // Puedes agregar código aquí si necesitas realizar algo al cargar el formulario
        }

        // Método para manejar el clic en el botón "SignUpbtn"
        private void signupbtn_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto (con los nombres correctos de los controles)
            string firstName = fnameTB.Text;  // Nombre
            string lastName = lnameTB.Text;   // Apellidos
            string username = usernameTB.Text;  // Nombre de usuario
            string password = PasswordTB.Text;  // Contraseña
            string confirmPassword = PasswordTB2.Text;  // Confirmación de contraseña
            string email = EmailTB.Text;  // Correo electrónico

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que las contraseñas coincidan
            if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Aquí iría la lógica para guardar al usuario en la base de datos (esto lo haremos después)

            // Si el registro fue exitoso, mostrar el mensaje
            MessageBox.Show("¡Te has registrado con éxito!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Después de mostrar el mensaje, redirigir al usuario al formulario de login
            this.Hide();  // Oculta el formulario de registro
            Login loginForm = new Login();  // Crea una nueva instancia del formulario de Login
            loginForm.Show();  // Muestra el formulario de Login
        }
    }
}


