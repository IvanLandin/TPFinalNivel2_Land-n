using App_Catalogo_Dominio;
using AppCatalogo_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Catalogo
{
    public partial class frmCategoria : Form
    {
        private Categoria categoria = null;

        /// <summary>
        /// Constructor. Inicializa el formulario para añadir una categoría a la lista.
        /// </summary>
        public frmCategoria()
        {
            InitializeComponent();
            this.txtReadCategoria.Visible = false;
            this.lblReadCategoria.Visible = false;
            this.lblCategoria.Location = new Point(12, 19);
            this.txtCategoria.Location = new Point(12, 35);
            this.Size = new Size(260, 140);
        }

        /// <summary>
        /// Constructor. Inicializa el formulario para modificar la categoría pasada por parámetro.
        /// </summary>
        /// <param name="categoria"></param>
        public frmCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            this.Text = "Modificar categoría";
            this.lblCategoria.Text = "Nuevo nombre de categoría: ";
        }

        /// <summary>
        /// Añade o modifica la categoría según corresponda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (this.categoria == null)
                    this.categoria = new Categoria();

                if (txtCategoria.Text.Length > 0)
                {
                    categoria.Descripcion = txtCategoria.Text;

                    if (categoria.Id != 0)
                    {
                        if (negocio.Modificar(categoria))
                            MessageBox.Show("¡Modificada exitosamente!");
                        else
                            MessageBox.Show("La categoría ya se encuentra en la base de datos.");
                    }
                    else
                    {
                        if (negocio.Agregar(categoria))
                            MessageBox.Show("¡Agregada exitosamente!");
                        else
                            MessageBox.Show("La categoría ya se encuentra en la base de datos.");
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
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Si el formulario es utilizado para modificar una categoría, se inicializa uno de los cuadros de texto para que contenga la información actual de la categoría.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            if (this.categoria != null)
            {
                this.txtReadCategoria.Text = categoria.Descripcion.ToString();
            }
        }
    }
}
