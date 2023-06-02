using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using App_Catalogo_Dominio;
using AppCatalogo_Negocio;
using System.Data.SqlClient;
using System.Net;

namespace App_Catalogo
{
    public partial class frmAgregarArticulo : Form
    {
        Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor. Inicializa el formulario para modificar el artículo pasado por parámetro.
        /// </summary>
        /// <param name="articulo"></param>
        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.Text = "Modificar artículo";
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
        /// Añade o modifica el artículo según corresponda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(this.articulo == null)
                    this.articulo = new Articulo();

                if (txtPrecio.Text.Length > 0 && txtNombre.Text.Length > 0 && txtCodigo.Text.Length > 0)
                {
                    articulo.CodigoArticulo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.Imagen = txtImagen.Text;
                    articulo.Precio = SqlMoney.Parse(txtPrecio.Text);
                    articulo.Marca = (Marca)cbxMarca.SelectedItem;
                    articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;

                    if (articulo.Id != 0)
                    {
                        negocio.Modificar(articulo);
                        MessageBox.Show("¡Modificado exitosamente!");
                    }
                    else
                    {
                        negocio.Agregar(articulo);
                        MessageBox.Show("¡Agregado exitosamente!");
                    }

                    if (archivo != null && !(txtImagen.Text.ToLower().Contains("http")))
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpeta_imagenes"] + archivo.SafeFileName);

                    this.Close();
                }
                else
                    MessageBox.Show("Error. Los campos 'Código de artículo', 'Nombre' y 'Precio' son obligatorios.");
                    
            }
            catch (SqlException)
            {
                MessageBox.Show("Error. La cantidad máxima de caracteres del URL es de 1000.");
                txtImagen.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Carga los datos predeterminados al formulario o, en caso de ser utilizado para modificar un artículo, precarga sus datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            MarcaNegocio marca = new MarcaNegocio();

            try
            {
                cbxCategoria.DataSource = categoria.Listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                cbxMarca.DataSource = marca.Listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                if(this.articulo != null)
                {
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.Imagen;
                    CargarImagen(articulo.Imagen);
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Carga la imágen al PictureBox del formulario por medio del string que recibe por parámetro.
        /// </summary>
        /// <param name="imagen"></param>
        private void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (WebException)
            {
                pbxArticulo.Load(@"..\..\Resources\Placeholder_view_vector.svg.png");
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/1024px-Placeholder_view_vector.svg.png");
            }
        }

        /// <summary>
        /// Programa la opción para que el usuario carge una imágen local, en vez de utilizar una url de internet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImagenLocal_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();

            archivo.Filter = "jpg|*.jpg;|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                CargarImagen(archivo.FileName);
            }
        }

        /// <summary>
        /// Imposibilita el uso de otros caracteres que no sean los numéricos o la coma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsNumber((char)e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',');
        }

        /// <summary>
        /// Se ejecuta la carga de la imagen al abandonar el foco de la casilla de texto de imagen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtImagen.Text);
        }
    }
}
