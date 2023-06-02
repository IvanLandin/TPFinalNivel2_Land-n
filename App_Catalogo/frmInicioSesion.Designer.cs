namespace App_Catalogo
{
    partial class frmInicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.pbxFachera = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.llblRegistrarse = new System.Windows.Forms.LinkLabel();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.btnHelper = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFachera)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxFachera
            // 
            this.pbxFachera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxFachera.Image = global::App_Catalogo.Properties.Resources.Untitled_41;
            this.pbxFachera.Location = new System.Drawing.Point(-2, -1);
            this.pbxFachera.Name = "pbxFachera";
            this.pbxFachera.Size = new System.Drawing.Size(180, 307);
            this.pbxFachera.TabIndex = 0;
            this.pbxFachera.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(184, 69);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(70, 21);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(184, 144);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(107, 21);
            this.lblContrasenia.TabIndex = 0;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(188, 93);
            this.txtUsuario.MaxLength = 23;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(326, 26);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.White;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(188, 169);
            this.txtContrasenia.MaxLength = 20;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(297, 26);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.Text = "1234";
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // llblRegistrarse
            // 
            this.llblRegistrarse.AutoSize = true;
            this.llblRegistrarse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRegistrarse.Location = new System.Drawing.Point(185, 212);
            this.llblRegistrarse.Name = "llblRegistrarse";
            this.llblRegistrarse.Size = new System.Drawing.Size(81, 16);
            this.llblRegistrarse.TabIndex = 4;
            this.llblRegistrarse.TabStop = true;
            this.llblRegistrarse.Text = "Registrarse...";
            this.llblRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegistrarse_LinkClicked);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.White;
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.Location = new System.Drawing.Point(398, 263);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(116, 30);
            this.btnInicioSesion.TabIndex = 6;
            this.btnInicioSesion.Text = "Iniciar sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // btnHelper
            // 
            this.btnHelper.BackColor = System.Drawing.Color.White;
            this.btnHelper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelper.Location = new System.Drawing.Point(491, 169);
            this.btnHelper.Name = "btnHelper";
            this.btnHelper.Size = new System.Drawing.Size(23, 26);
            this.btnHelper.TabIndex = 3;
            this.btnHelper.Text = "?";
            this.btnHelper.UseVisualStyleBackColor = false;
            this.btnHelper.Click += new System.EventHandler(this.btnHelper_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(188, 263);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(526, 305);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHelper);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.llblRegistrarse);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pbxFachera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbxFachera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxFachera;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.LinkLabel llblRegistrarse;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Button btnHelper;
        private System.Windows.Forms.Button btnSalir;
    }
}