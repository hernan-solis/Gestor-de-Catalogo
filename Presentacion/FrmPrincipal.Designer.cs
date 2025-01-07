namespace Presentacion
{
    partial class FrmPrincipal
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxImagenPrincipal = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.gbxArticuloSeleccionado = new System.Windows.Forms.GroupBox();
            this.gbxNuevo = new System.Windows.Forms.GroupBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.gbxBuscador = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mspMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPrincipal)).BeginInit();
            this.gbxArticuloSeleccionado.SuspendLayout();
            this.gbxNuevo.SuspendLayout();
            this.gbxBuscador.SuspendLayout();
            this.mspMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.Location = new System.Drawing.Point(117, 79);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(617, 335);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxImagenPrincipal
            // 
            this.pbxImagenPrincipal.Location = new System.Drawing.Point(740, 79);
            this.pbxImagenPrincipal.Name = "pbxImagenPrincipal";
            this.pbxImagenPrincipal.Size = new System.Drawing.Size(334, 335);
            this.pbxImagenPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenPrincipal.TabIndex = 1;
            this.pbxImagenPrincipal.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(16, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(16, 42);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(16, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.Location = new System.Drawing.Point(375, 51);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(110, 20);
            this.lblArticulos.TabIndex = 5;
            this.lblArticulos.Text = "ARTICULOS";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(830, 51);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(176, 20);
            this.lblImagen.TabIndex = 6;
            this.lblImagen.Text = "IMAGEN ASOCIADA";
            // 
            // gbxArticuloSeleccionado
            // 
            this.gbxArticuloSeleccionado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxArticuloSeleccionado.Controls.Add(this.btnEliminar);
            this.gbxArticuloSeleccionado.Controls.Add(this.btnModificar);
            this.gbxArticuloSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArticuloSeleccionado.Location = new System.Drawing.Point(4, 209);
            this.gbxArticuloSeleccionado.Name = "gbxArticuloSeleccionado";
            this.gbxArticuloSeleccionado.Size = new System.Drawing.Size(105, 130);
            this.gbxArticuloSeleccionado.TabIndex = 7;
            this.gbxArticuloSeleccionado.TabStop = false;
            this.gbxArticuloSeleccionado.Text = "Articulo Seleccionado";
            this.gbxArticuloSeleccionado.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbxNuevo
            // 
            this.gbxNuevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxNuevo.Controls.Add(this.btnAgregar);
            this.gbxNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNuevo.Location = new System.Drawing.Point(4, 114);
            this.gbxNuevo.Name = "gbxNuevo";
            this.gbxNuevo.Size = new System.Drawing.Size(105, 66);
            this.gbxNuevo.TabIndex = 5;
            this.gbxNuevo.TabStop = false;
            this.gbxNuevo.Text = "Articulo Nuevo";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(13, 22);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(49, 13);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(190, 22);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(51, 13);
            this.lblCriterio.TabIndex = 9;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(371, 22);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(39, 13);
            this.lblFiltro.TabIndex = 10;
            this.lblFiltro.Text = "Filtro:";
            // 
            // cbxCampo
            // 
            this.cbxCampo.BackColor = System.Drawing.SystemColors.Window;
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(68, 16);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(97, 21);
            this.cbxCampo.TabIndex = 0;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(247, 16);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(99, 21);
            this.cbxCriterio.TabIndex = 1;
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(416, 17);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(143, 20);
            this.tbxFiltro.TabIndex = 2;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            this.tbxFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxFiltro_KeyUp);
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gbxBuscador.Controls.Add(this.btnBuscar);
            this.gbxBuscador.Controls.Add(this.cbxCampo);
            this.gbxBuscador.Controls.Add(this.tbxFiltro);
            this.gbxBuscador.Controls.Add(this.lblCampo);
            this.gbxBuscador.Controls.Add(this.cbxCriterio);
            this.gbxBuscador.Controls.Add(this.lblCriterio);
            this.gbxBuscador.Controls.Add(this.lblFiltro);
            this.gbxBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBuscador.Location = new System.Drawing.Point(93, 426);
            this.gbxBuscador.Name = "gbxBuscador";
            this.gbxBuscador.Size = new System.Drawing.Size(661, 48);
            this.gbxBuscador.TabIndex = 3;
            this.gbxBuscador.TabStop = false;
            this.gbxBuscador.Text = "Buscador";
            this.gbxBuscador.Enter += new System.EventHandler(this.gbxFiltro_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(580, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mspMenuPrincipal
            // 
            this.mspMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mspMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mspMenuPrincipal.Name = "mspMenuPrincipal";
            this.mspMenuPrincipal.Size = new System.Drawing.Size(1079, 24);
            this.mspMenuPrincipal.TabIndex = 8;
            this.mspMenuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1079, 487);
            this.Controls.Add(this.gbxBuscador);
            this.Controls.Add(this.gbxNuevo);
            this.Controls.Add(this.gbxArticuloSeleccionado);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblArticulos);
            this.Controls.Add(this.pbxImagenPrincipal);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.mspMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mspMenuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Catalogo - Ventana Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPrincipal)).EndInit();
            this.gbxArticuloSeleccionado.ResumeLayout(false);
            this.gbxNuevo.ResumeLayout(false);
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            this.mspMenuPrincipal.ResumeLayout(false);
            this.mspMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxImagenPrincipal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.GroupBox gbxArticuloSeleccionado;
        private System.Windows.Forms.GroupBox gbxNuevo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.GroupBox gbxBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MenuStrip mspMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
    }
}