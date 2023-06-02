using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Catalogo_Dominio;
using AppCatalogo_Negocio;

namespace App_Catalogo
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botón de ayuda. Muestra información pertinente a la contraseña.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelper_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por motivos de prueba, la contraseña es '1234'.");
        }

        /// <summary>
        /// Autentifica los datos ingresados para el inicio de sesión.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador(txtUsuario.Text, txtContrasenia.Text);

            if (admin.Contrasenia == "1234" && txtUsuario.Text != "")
            {
                AdministradorNegocio.AdminActual = admin.NombreUsuario;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Usuario y/o contraseña incorrectos. Por favor, intente nuevamente.");
        }

        /// <summary>
        /// Imposibilita la utilización de espacios en la casilla de texto de usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        /// <summary>
        /// Ejecuta en el navegador la ventana de registro de usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Permite presionar la tecla Enter para iniciar sesión.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInicioSesion_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
