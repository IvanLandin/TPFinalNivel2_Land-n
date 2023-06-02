using App_Catalogo_Dominio;
using AppCatalogo_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Catalogo
{
    public partial class frmAgregarMarca : Form
    {
        private Marca marca = null;

        /// <summary>
        /// Constructor. Inicializa el formulario para añadir una marca a la lista.
        /// </summary>
        public frmAgregarMarca()
        {
            InitializeComponent();
            this.txtReadMarca.Visible = false;
            this.lblReadMarca.Visible = false;
            this.lblMarca.Location = new Point(12, 19);
            this.txtMarca.Location = new Point(12, 35);
            this.Size = new Size(260, 140);
        }

        /// <summary>
        /// Constructor. Inicializa el formulario para modificar la marca pasada por parámetro.
        /// </summary>
        /// <param name="marca"></param>
        public frmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            this.Text = "Modificar marca";
            this.lblMarca.Text = "Nuevo nombre de marca: ";
        }

        /// <summary>
        /// Añade o modifica la marca según corresponda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (this.marca == null)
                    this.marca = new Marca();

                if(txtMarca.Text.Length > 0)
                {
                    marca.Descripcion = txtMarca.Text;

                    if (marca.Id != 0)
                    {
                        if (negocio.Modificar(marca))
                            MessageBox.Show("¡Modificada exitosamente!");
                        else
                            MessageBox.Show("La marca ya se encuentra en la base de datos.");
                    }
                    else
                    {
                        if (negocio.Agregar(marca))
                            MessageBox.Show("¡Agregada exitosamente!");
                        else
                            MessageBox.Show("La marca ya se encuentra en la base de datos.");
                    }

                    this.Close();
                }
                else
                    MessageBox.Show("Error. El campo a completar es obligatorio.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Si el formulario es utilizado para modificar una marca, se inicializa uno de los cuadros de texto para que contenga la información actual de la marca.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            if(this.marca != null)
            {
                this.txtReadMarca.Text = marca.Descripcion.ToString();
            }
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
