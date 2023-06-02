using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Catalogo_Dominio;
using AppCatalogo_Negocio;
using static System.Net.Mime.MediaTypeNames;

namespace App_Catalogo
{
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        private List<Marca> listaMarcas;
        private List<Categoria> listaCategorias;

        public frmPrincipal()
        {
            InitializeComponent();
            Cargar();
        }

        /// <summary>
        /// Asigna las listas correspondientes a los DataGridView.
        /// </summary>
        private void Cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                listaArticulos = articuloNegocio.Listar();
                dgvListaArticulos.DataSource = listaArticulos;

                listaMarcas = marcaNegocio.Listar();
                dgvListaMarcas.DataSource = listaMarcas;
                CargarItemsMenu(marcasToolStripMenuItem, listaMarcas);

                listaCategorias = categoriaNegocio.Listar();
                dgvListaCategorias.DataSource = listaCategorias;
                CargarItemsMenu(categoriasToolStripMenuItem, listaCategorias);

                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Carga dinámicamente la lista de categorías a un ToolStripMenuItem pasado por parámetro.
        /// </summary>
        /// <param name="tstMenu"></param>
        /// <param name="lista"></param>
        private void CargarItemsMenu(ToolStripMenuItem tstMenu, List<Categoria> lista)
        {
            int len = lista.Count + 1;
            ToolStripMenuItem[] items = new ToolStripMenuItem[len];

            for (int i = 0; i < len; i++)
            {
                items[i] = new ToolStripMenuItem();
                if (i != len - 1)
                    items[i].Text = lista[i].ToString();
                else
                    items[i].Text = "Todas";
                items[i].Click += new EventHandler(ItemMenuClickHandler);
            }

            tstMenu.DropDownItems.Clear();
            tstMenu.DropDownItems.AddRange(items);
        }

        /// <summary>
        /// Carga dinámicamente la lista de marcas a un ToolStripMenuItem pasado por parámetro.
        /// </summary>
        /// <param name="tstMenu"></param>
        /// <param name="lista"></param>
        private void CargarItemsMenu(ToolStripMenuItem tstMenu, List<Marca> lista)
        {
            int len = lista.Count + 1;
            ToolStripMenuItem[] items = new ToolStripMenuItem[len];

            for (int i = 0; i < len; i++)
            {
                items[i] = new ToolStripMenuItem(); items[i] = new ToolStripMenuItem();
                if (i != len - 1)
                    items[i].Text = lista[i].ToString();
                else
                    items[i].Text = "Todas";
                items[i].Click += new EventHandler(ItemMenuClickHandler);
            }

            tstMenu.DropDownItems.Clear();
            tstMenu.DropDownItems.AddRange(items);
        }
        
        /// <summary>
        /// Da comportamiento al elemento de menú creado dinamicamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemMenuClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            List<Articulo> listaFiltrada;

            string filtro = clickedItem.Text;

            if (filtro != "Todas")
                listaFiltrada = listaArticulos.FindAll(x => x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = listaArticulos;

            dgvListaArticulos.DataSource = null;
            dgvListaArticulos.DataSource = listaFiltrada;
            btnArticulos_Click(sender, e);
            OcultarColumnas();
        }

        /// <summary>
        /// Carga una imágen pasada por parámetro como string al PictureBox principal.
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
        /// Carga la foto relacionada al elemento seleccionado en el DataGridView de artículos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.Imagen);
            }
        }

        /// <summary>
        /// Oculta las columnas que no necesiten ser mostradas en el DataGridView de artículos.
        /// </summary>
        private void OcultarColumnas()
        {
            dgvListaArticulos.Columns["Imagen"].Visible = false;
            dgvListaArticulos.Columns["Id"].Visible = false;
            dgvListaMarcas.Columns["Id"].Visible = false;
            dgvListaCategorias.Columns["Id"].Visible = false;
        }

        /// <summary>
        /// Ejecuta la apertura del formulario de carga de artículos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregarArticulo = new frmAgregarArticulo();
            agregarArticulo.ShowDialog();
            Cargar();
        }

        /// <summary>
        /// Ejecuta la apertura del formulario de modificación de artículos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo articuloSeleccionado;
                articuloSeleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;

                frmAgregarArticulo modificarArticulo = new frmAgregarArticulo(articuloSeleccionado);
                modificarArticulo.ShowDialog();
                Cargar();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("No es posible realizar la acción, ya que no se encuentra seleccionado ningún artículo.");
            }
        }

        /// <summary>
        /// Elimina un artículo de la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                if (MessageBox.Show("¿Desea eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.Id);
                    Cargar();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No es posible realizar la acción, ya que no se encuentra seleccionado ningún artículo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Inicia la búsqueda rápida de artículos en la lista de artículos, de acuerdo al texto ingresado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.CodigoArticulo.ToUpper().Contains(filtro.ToUpper()) || x.Precio.ToString().ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = listaArticulos;

            dgvListaArticulos.DataSource = null;
            dgvListaArticulos.DataSource = listaFiltrada;
            OcultarColumnas();
        }

        /// <summary>
        /// Valida que los campos necesarios esten seleccionados para comenzar la búsqueda avanzada de artículos.
        /// </summary>
        /// <returns> Si alguna de las condiciones no se cumple, true. Si está todo en orden, false.</returns>
        private bool ValidarFiltro()
        {
            bool retorno = false;

            if (cbxCampo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione el campo a filtrar.");
                retorno = true;
            }
            if (cbxCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione el criterio de búsqueda.");
                retorno = true;
            }
            if (cbxCampo.SelectedItem != null)
            {
                if (cbxCampo.SelectedItem.ToString() == "Precio" && (!(ValidarNumeros(txtFiltroAvanzado.Text)) || string.IsNullOrEmpty(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("El campo 'Precio' solo admite valores numéricos.");
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Valida que los caracteres que componen la cadena pasada por parámetro sean números o no.
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns> Si son números, true. Caso contrario, false.</returns>
        private bool ValidarNumeros(string cadena)
        {
            bool retorno = true;

            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Inicia la búsqueda avanzada de artículos en la lista de artículos, según los criterios especificados por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> articulos = new List<Articulo>();

            try
            {
                if (ValidarFiltro())
                    return;

                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                articulos = negocio.Listar(campo, criterio, filtro);
                dgvListaArticulos.DataSource = articulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Asigna los datos iniciales de ComboBox y nombre de usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Bienvenido {AdministradorNegocio.AdminActual}";

            Cargar();

            cbxCampo.Items.Add("Código");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripción");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Categoría");
            cbxCampo.Items.Add("Precio");
        }

        /// <summary>
        /// Modifica el contenido del ComboBox de criterio de búsqueda avanzada según el campo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a...");
                cbxCriterio.Items.Add("Menor a...");
                cbxCriterio.Items.Add("Igual a...");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con...");
                cbxCriterio.Items.Add("Termina con...");
                cbxCriterio.Items.Add("Contiene...");
            }
        }

        /// <summary>
        /// Cierra el formulario principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Pregunta al usuario por confirmación para cerrar el formulario principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        /// <summary>
        /// Hace visible la pestaña de artículos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArticulos_Click(object sender, EventArgs e)
        {
            tablessPrincipal.SelectedTab = tabArticulos;
        }

        /// <summary>
        /// Hace visible la pestaña de gestión de marcas y categorías.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarcaCategoria_Click(object sender, EventArgs e)
        {
            tablessPrincipal.SelectedTab = tabMarcaCategoria;
        }

        /// <summary>
        /// Elimina la marca seleccionada de la lista de marcas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {
                if (MessageBox.Show("¿Desea eliminar la marca?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvListaMarcas.CurrentRow.DataBoundItem;
                    if (!negocio.Eliminar(seleccionado.Id))
                        MessageBox.Show("La marca no pudo ser borrada, ya que se encuentra asociada a un artículo.");
                    Cargar();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No es posible realizar la acción, ya que no se encuentra seleccionada ninguna marca.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Modifica la marca seleccionada de la lista de marcas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marcaSeleccionada;
                marcaSeleccionada = (Marca)dgvListaMarcas.CurrentRow.DataBoundItem;

                frmAgregarMarca modificarMarca = new frmAgregarMarca(marcaSeleccionada);
                modificarMarca.ShowDialog();
                Cargar();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No es posible realizar la acción, ya que no se encuentra seleccionada ninguna marca.");
            }
        }

        /// <summary>
        /// Ejecuta el formulario para agregar una marca a la lista de marcas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca agregarMarca = new frmAgregarMarca();
            agregarMarca.ShowDialog();
            Cargar();
        }

        /// <summary>
        /// Elimina la categoría seleccionada de la lista de categorías.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;

            try
            {
                if (MessageBox.Show("¿Desea eliminar la categoría?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvListaCategorias.CurrentRow.DataBoundItem;
                    if (!negocio.Eliminar(seleccionado.Id))
                        MessageBox.Show("La categoría no pudo ser borrada, ya que se encuentra asociada a un artículo.");
                    Cargar();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No es posible realizar la acción, ya que no se encuentra seleccionada ninguna categoría.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Modifica la categoría seleccionada de la lista de categorías.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoriaSeleccionada;
                categoriaSeleccionada = (Categoria)dgvListaCategorias.CurrentRow.DataBoundItem;

                frmCategoria modificarCategoria = new frmCategoria(categoriaSeleccionada);
                modificarCategoria.ShowDialog();
                Cargar();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No es posible realizar la acción, ya que no se encuentra seleccionada ninguna categoría.");
            }
        }

        /// <summary>
        /// Ejecuta el formulario para agregar una categoría a la lista de categorías.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria agregarCategoria = new frmCategoria();
            agregarCategoria.ShowDialog();
            Cargar();
        }

        /// <summary>
        /// Inicia la búsqueda rápida de marcas en la lista de marcas, de acuerdo al texto ingresado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFiltroMarca_TextChanged(object sender, EventArgs e)
        {
            List<Marca> listaFiltrada;
            string filtro = txtFiltroMarca.Text;

            if (filtro.Length >= 3)
                listaFiltrada = listaMarcas.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = listaMarcas;

            dgvListaMarcas.DataSource = null;
            dgvListaMarcas.DataSource = listaFiltrada;
            OcultarColumnas();
        }

        /// <summary>
        /// Inicia la búsqueda rápida de categorías en la lista de categorías, de acuerdo al texto ingresado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFiltroCategoria_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> listaFiltrada;
            string filtro = txtFiltroCategoria.Text;

            if (filtro.Length >= 3)
                listaFiltrada = listaCategorias.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = listaCategorias;

            dgvListaCategorias.DataSource = null;
            dgvListaCategorias.DataSource = listaFiltrada;
            OcultarColumnas();
        }

        /// <summary>
        /// Cierra el formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
