using System.Windows.Forms;

namespace App_Catalogo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mstPrincipal = new System.Windows.Forms.MenuStrip();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnMarcaCategoria = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tablessPrincipal = new App_Catalogo.TablessControl();
            this.tabArticulos = new System.Windows.Forms.TabPage();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.gpbBusquedaAvanzada = new System.Windows.Forms.GroupBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.dgvListaArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tabMarcaCategoria = new System.Windows.Forms.TabPage();
            this.splitMarcaCategoria = new System.Windows.Forms.SplitContainer();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtFiltroMarca = new System.Windows.Forms.TextBox();
            this.dgvListaMarcas = new System.Windows.Forms.DataGridView();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtFiltroCategoria = new System.Windows.Forms.TextBox();
            this.dgvListaCategorias = new System.Windows.Forms.DataGridView();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.mstPrincipal.SuspendLayout();
            this.tablessPrincipal.SuspendLayout();
            this.tabArticulos.SuspendLayout();
            this.gpbBusquedaAvanzada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.tabMarcaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMarcaCategoria)).BeginInit();
            this.splitMarcaCategoria.Panel1.SuspendLayout();
            this.splitMarcaCategoria.Panel2.SuspendLayout();
            this.splitMarcaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // mstPrincipal
            // 
            this.mstPrincipal.BackColor = System.Drawing.Color.White;
            this.mstPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.tsmSistema});
            this.mstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstPrincipal.Name = "mstPrincipal";
            this.mstPrincipal.Size = new System.Drawing.Size(887, 24);
            this.mstPrincipal.TabIndex = 1;
            this.mstPrincipal.Text = "menuStrip1";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Categorías";
            // 
            // todasToolStripMenuItem
            // 
            this.todasToolStripMenuItem.Name = "todasToolStripMenuItem";
            this.todasToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.todasToolStripMenuItem.Text = "Todas";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasToolStripMenuItem1});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // todasToolStripMenuItem1
            // 
            this.todasToolStripMenuItem1.Name = "todasToolStripMenuItem1";
            this.todasToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.todasToolStripMenuItem1.Text = "Todas";
            // 
            // tsmSistema
            // 
            this.tsmSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSalir});
            this.tsmSistema.Name = "tsmSistema";
            this.tsmSistema.Size = new System.Drawing.Size(60, 20);
            this.tsmSistema.Text = "Sistema";
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(96, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(682, 4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Bienvenido...";
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.Color.White;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArticulos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Location = new System.Drawing.Point(3, 27);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(88, 84);
            this.btnArticulos.TabIndex = 2;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnMarcaCategoria
            // 
            this.btnMarcaCategoria.BackColor = System.Drawing.Color.White;
            this.btnMarcaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarcaCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcaCategoria.Location = new System.Drawing.Point(3, 113);
            this.btnMarcaCategoria.Name = "btnMarcaCategoria";
            this.btnMarcaCategoria.Size = new System.Drawing.Size(88, 84);
            this.btnMarcaCategoria.TabIndex = 3;
            this.btnMarcaCategoria.Text = "Gestor de marcas y categorías";
            this.btnMarcaCategoria.UseVisualStyleBackColor = false;
            this.btnMarcaCategoria.Click += new System.EventHandler(this.btnMarcaCategoria_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::App_Catalogo.Properties.Resources._6165767;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 416);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 49);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tablessPrincipal
            // 
            this.tablessPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablessPrincipal.Controls.Add(this.tabArticulos);
            this.tablessPrincipal.Controls.Add(this.tabMarcaCategoria);
            this.tablessPrincipal.Location = new System.Drawing.Point(93, 24);
            this.tablessPrincipal.Name = "tablessPrincipal";
            this.tablessPrincipal.SelectedIndex = 0;
            this.tablessPrincipal.Size = new System.Drawing.Size(794, 445);
            this.tablessPrincipal.TabIndex = 4;
            // 
            // tabArticulos
            // 
            this.tabArticulos.BackColor = System.Drawing.Color.Tan;
            this.tabArticulos.Controls.Add(this.lblFiltro);
            this.tabArticulos.Controls.Add(this.txtFiltro);
            this.tabArticulos.Controls.Add(this.gpbBusquedaAvanzada);
            this.tabArticulos.Controls.Add(this.dgvListaArticulos);
            this.tabArticulos.Controls.Add(this.pbxArticulo);
            this.tabArticulos.Controls.Add(this.btnEliminar);
            this.tabArticulos.Controls.Add(this.btnAgregar);
            this.tabArticulos.Controls.Add(this.btnModificar);
            this.tabArticulos.Location = new System.Drawing.Point(4, 22);
            this.tabArticulos.Name = "tabArticulos";
            this.tabArticulos.Padding = new System.Windows.Forms.Padding(3);
            this.tabArticulos.Size = new System.Drawing.Size(786, 419);
            this.tabArticulos.TabIndex = 0;
            this.tabArticulos.Text = "tabArticulos";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(3, 12);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(98, 15);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Busqueda rápida:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(6, 30);
            this.txtFiltro.MaximumSize = new System.Drawing.Size(350, 20);
            this.txtFiltro.MinimumSize = new System.Drawing.Size(156, 20);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(156, 23);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // gpbBusquedaAvanzada
            // 
            this.gpbBusquedaAvanzada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBusquedaAvanzada.BackColor = System.Drawing.Color.Transparent;
            this.gpbBusquedaAvanzada.Controls.Add(this.lblFiltroAvanzado);
            this.gpbBusquedaAvanzada.Controls.Add(this.txtFiltroAvanzado);
            this.gpbBusquedaAvanzada.Controls.Add(this.lblCampo);
            this.gpbBusquedaAvanzada.Controls.Add(this.btnBusqueda);
            this.gpbBusquedaAvanzada.Controls.Add(this.cbxCampo);
            this.gpbBusquedaAvanzada.Controls.Add(this.cbxCriterio);
            this.gpbBusquedaAvanzada.Controls.Add(this.lblCriterio);
            this.gpbBusquedaAvanzada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusquedaAvanzada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbBusquedaAvanzada.Location = new System.Drawing.Point(175, 6);
            this.gpbBusquedaAvanzada.Name = "gpbBusquedaAvanzada";
            this.gpbBusquedaAvanzada.Size = new System.Drawing.Size(603, 77);
            this.gpbBusquedaAvanzada.TabIndex = 2;
            this.gpbBusquedaAvanzada.TabStop = false;
            this.gpbBusquedaAvanzada.Text = "Busqueda Avanzada";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(6, 32);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(37, 15);
            this.lblFiltroAvanzado.TabIndex = 0;
            this.lblFiltroAvanzado.Text = "Filtro:";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.BackColor = System.Drawing.Color.White;
            this.txtFiltroAvanzado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(49, 30);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(195, 23);
            this.txtFiltroAvanzado.TabIndex = 1;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(250, 17);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(49, 15);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo:";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.White;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(479, 26);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(89, 32);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "&Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // cbxCampo
            // 
            this.cbxCampo.BackColor = System.Drawing.Color.White;
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(306, 14);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(150, 23);
            this.cbxCampo.TabIndex = 2;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.BackColor = System.Drawing.Color.White;
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(306, 48);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(150, 23);
            this.cbxCriterio.TabIndex = 3;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(251, 51);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 15);
            this.lblCriterio.TabIndex = 0;
            this.lblCriterio.Text = "Criterio:";
            // 
            // dgvListaArticulos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaArticulos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListaArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaArticulos.Location = new System.Drawing.Point(6, 89);
            this.dgvListaArticulos.MinimumSize = new System.Drawing.Size(580, 0);
            this.dgvListaArticulos.MultiSelect = false;
            this.dgvListaArticulos.Name = "dgvListaArticulos";
            this.dgvListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArticulos.Size = new System.Drawing.Size(580, 289);
            this.dgvListaArticulos.TabIndex = 3;
            this.dgvListaArticulos.SelectionChanged += new System.EventHandler(this.dgvListaArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(588, 89);
            this.pbxArticulo.MaximumSize = new System.Drawing.Size(217, 317);
            this.pbxArticulo.MinimumSize = new System.Drawing.Size(170, 170);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(190, 190);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 11;
            this.pbxArticulo.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(168, 385);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(6, 385);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(87, 385);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 25);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tabMarcaCategoria
            // 
            this.tabMarcaCategoria.BackColor = System.Drawing.Color.Tan;
            this.tabMarcaCategoria.Controls.Add(this.splitMarcaCategoria);
            this.tabMarcaCategoria.Location = new System.Drawing.Point(4, 22);
            this.tabMarcaCategoria.Name = "tabMarcaCategoria";
            this.tabMarcaCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarcaCategoria.Size = new System.Drawing.Size(786, 419);
            this.tabMarcaCategoria.TabIndex = 1;
            this.tabMarcaCategoria.Text = "tabMarcaCategoria";
            // 
            // splitMarcaCategoria
            // 
            this.splitMarcaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMarcaCategoria.BackColor = System.Drawing.Color.Tan;
            this.splitMarcaCategoria.Location = new System.Drawing.Point(0, 0);
            this.splitMarcaCategoria.Name = "splitMarcaCategoria";
            // 
            // splitMarcaCategoria.Panel1
            // 
            this.splitMarcaCategoria.Panel1.Controls.Add(this.lblMarca);
            this.splitMarcaCategoria.Panel1.Controls.Add(this.txtFiltroMarca);
            this.splitMarcaCategoria.Panel1.Controls.Add(this.dgvListaMarcas);
            this.splitMarcaCategoria.Panel1.Controls.Add(this.btnEliminarMarca);
            this.splitMarcaCategoria.Panel1.Controls.Add(this.btnAgregarMarca);
            this.splitMarcaCategoria.Panel1.Controls.Add(this.btnModificarMarca);
            this.splitMarcaCategoria.Panel1MinSize = 300;
            // 
            // splitMarcaCategoria.Panel2
            // 
            this.splitMarcaCategoria.Panel2.Controls.Add(this.lblCategoria);
            this.splitMarcaCategoria.Panel2.Controls.Add(this.txtFiltroCategoria);
            this.splitMarcaCategoria.Panel2.Controls.Add(this.dgvListaCategorias);
            this.splitMarcaCategoria.Panel2.Controls.Add(this.btnEliminarCategoria);
            this.splitMarcaCategoria.Panel2.Controls.Add(this.btnAgregarCategoria);
            this.splitMarcaCategoria.Panel2.Controls.Add(this.btnModificarCategoria);
            this.splitMarcaCategoria.Panel2MinSize = 300;
            this.splitMarcaCategoria.Size = new System.Drawing.Size(790, 423);
            this.splitMarcaCategoria.SplitterDistance = 300;
            this.splitMarcaCategoria.SplitterWidth = 8;
            this.splitMarcaCategoria.TabIndex = 0;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(6, 3);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(150, 15);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Busqueda de marca rápida:";
            // 
            // txtFiltroMarca
            // 
            this.txtFiltroMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroMarca.BackColor = System.Drawing.Color.White;
            this.txtFiltroMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroMarca.Location = new System.Drawing.Point(6, 21);
            this.txtFiltroMarca.MaximumSize = new System.Drawing.Size(350, 20);
            this.txtFiltroMarca.MinimumSize = new System.Drawing.Size(156, 20);
            this.txtFiltroMarca.Name = "txtFiltroMarca";
            this.txtFiltroMarca.Size = new System.Drawing.Size(260, 23);
            this.txtFiltroMarca.TabIndex = 1;
            this.txtFiltroMarca.TextChanged += new System.EventHandler(this.txtFiltroMarca_TextChanged);
            // 
            // dgvListaMarcas
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaMarcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaMarcas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListaMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaMarcas.Location = new System.Drawing.Point(6, 47);
            this.dgvListaMarcas.MultiSelect = false;
            this.dgvListaMarcas.Name = "dgvListaMarcas";
            this.dgvListaMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaMarcas.Size = new System.Drawing.Size(291, 332);
            this.dgvListaMarcas.TabIndex = 2;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarMarca.BackColor = System.Drawing.Color.White;
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.Location = new System.Drawing.Point(168, 385);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 25);
            this.btnEliminarMarca.TabIndex = 5;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = false;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarMarca.BackColor = System.Drawing.Color.White;
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.Location = new System.Drawing.Point(6, 385);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 25);
            this.btnAgregarMarca.TabIndex = 3;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarMarca.BackColor = System.Drawing.Color.White;
            this.btnModificarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMarca.Location = new System.Drawing.Point(87, 385);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(75, 25);
            this.btnModificarMarca.TabIndex = 4;
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.UseVisualStyleBackColor = false;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(0, 3);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(166, 15);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Busqueda de categoría rápida:";
            // 
            // txtFiltroCategoria
            // 
            this.txtFiltroCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroCategoria.BackColor = System.Drawing.Color.White;
            this.txtFiltroCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroCategoria.Location = new System.Drawing.Point(3, 21);
            this.txtFiltroCategoria.MaximumSize = new System.Drawing.Size(350, 20);
            this.txtFiltroCategoria.MinimumSize = new System.Drawing.Size(250, 20);
            this.txtFiltroCategoria.Name = "txtFiltroCategoria";
            this.txtFiltroCategoria.Size = new System.Drawing.Size(250, 23);
            this.txtFiltroCategoria.TabIndex = 1;
            this.txtFiltroCategoria.TextChanged += new System.EventHandler(this.txtFiltroCategoria_TextChanged);
            // 
            // dgvListaCategorias
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCategorias.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListaCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaCategorias.Location = new System.Drawing.Point(3, 47);
            this.dgvListaCategorias.MultiSelect = false;
            this.dgvListaCategorias.Name = "dgvListaCategorias";
            this.dgvListaCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCategorias.Size = new System.Drawing.Size(440, 332);
            this.dgvListaCategorias.TabIndex = 2;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.Location = new System.Drawing.Point(165, 385);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 25);
            this.btnEliminarCategoria.TabIndex = 5;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.White;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(3, 385);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 25);
            this.btnAgregarCategoria.TabIndex = 3;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarCategoria.BackColor = System.Drawing.Color.White;
            this.btnModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategoria.Location = new System.Drawing.Point(84, 385);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(75, 25);
            this.btnModificarCategoria.TabIndex = 4;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(887, 468);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tablessPrincipal);
            this.Controls.Add(this.btnMarcaCategoria);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.mstPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstPrincipal;
            this.MinimumSize = new System.Drawing.Size(903, 507);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de artículos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mstPrincipal.ResumeLayout(false);
            this.mstPrincipal.PerformLayout();
            this.tablessPrincipal.ResumeLayout(false);
            this.tabArticulos.ResumeLayout(false);
            this.tabArticulos.PerformLayout();
            this.gpbBusquedaAvanzada.ResumeLayout(false);
            this.gpbBusquedaAvanzada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.tabMarcaCategoria.ResumeLayout(false);
            this.splitMarcaCategoria.Panel1.ResumeLayout(false);
            this.splitMarcaCategoria.Panel1.PerformLayout();
            this.splitMarcaCategoria.Panel2.ResumeLayout(false);
            this.splitMarcaCategoria.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMarcaCategoria)).EndInit();
            this.splitMarcaCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmSistema;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnMarcaCategoria;
        private TablessControl tablessPrincipal;
        private System.Windows.Forms.TabPage tabArticulos;
        private System.Windows.Forms.TabPage tabMarcaCategoria;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.GroupBox gpbBusquedaAvanzada;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.DataGridView dgvListaArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.SplitContainer splitMarcaCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtFiltroMarca;
        private System.Windows.Forms.DataGridView dgvListaMarcas;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtFiltroCategoria;
        private System.Windows.Forms.DataGridView dgvListaCategorias;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasToolStripMenuItem1;
        private Button btnSalir;
    }
}

