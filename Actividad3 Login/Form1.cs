using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3_Login
{
    public partial class frmLogin : Form
    {
        private N_Login negocioLogin = new N_Login();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
          
            
            try
            {
                string usuario = txtUser.Text.Trim();
                string contraseña = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(usuario) ||
                    string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Ingrese usuario y contraseña.");
                    return;
                }

                E_Usuario usuarioAutenticado =
                    negocioLogin.Autenticar(usuario, contraseña);

                if (usuarioAutenticado != null)
                {
                    Form2 principal =
                        new Form2(usuarioAutenticado.Nombre);

                    principal.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al iniciar sesión: " + ex.Message
                );
            }
       
        }
    }
}
