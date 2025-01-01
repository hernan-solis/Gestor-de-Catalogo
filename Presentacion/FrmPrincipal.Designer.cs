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
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPrincipal)).BeginInit();
            this.gbxArticuloSeleccionado.SuspendLayout();
            this.gbxNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 40);
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
            this.pbxImagenPrincipal.Location = new System.Drawing.Point(626, 40);
            this.pbxImagenPrincipal.Name = "pbxImagenPrincipal";
            this.pbxImagenPrincipal.Size = new System.Drawing.Size(334, 335);
            this.pbxImagenPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenPrincipal.TabIndex = 1;
            this.pbxImagenPrincipal.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(59, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(6, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(119, 41);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Location = new System.Drawing.Point(261, 14);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(47, 13);
            this.lblArticulos.TabIndex = 5;
            this.lblArticulos.Text = "Articulos";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(754, 14);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(89, 13);
            this.lblImagen.TabIndex = 6;
            this.lblImagen.Text = "Imagen Asociada";
            // 
            // gbxArticuloSeleccionado
            // 
            this.gbxArticuloSeleccionado.Controls.Add(this.btnEliminar);
            this.gbxArticuloSeleccionado.Controls.Add(this.btnModificar);
            this.gbxArticuloSeleccionado.Location = new System.Drawing.Point(334, 411);
            this.gbxArticuloSeleccionado.Name = "gbxArticuloSeleccionado";
            this.gbxArticuloSeleccionado.Size = new System.Drawing.Size(200, 100);
            this.gbxArticuloSeleccionado.TabIndex = 7;
            this.gbxArticuloSeleccionado.TabStop = false;
            this.gbxArticuloSeleccionado.Text = "Articulo Seleccionado";
            this.gbxArticuloSeleccionado.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbxNuevo
            // 
            this.gbxNuevo.Controls.Add(this.btnAgregar);
            this.gbxNuevo.Location = new System.Drawing.Point(12, 411);
            this.gbxNuevo.Name = "gbxNuevo";
            this.gbxNuevo.Size = new System.Drawing.Size(200, 100);
            this.gbxNuevo.TabIndex = 5;
            this.gbxNuevo.TabStop = false;
            this.gbxNuevo.Text = "Articulo Nuevo";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 570);
            this.Controls.Add(this.gbxNuevo);
            this.Controls.Add(this.gbxArticuloSeleccionado);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblArticulos);
            this.Controls.Add(this.pbxImagenPrincipal);
            this.Controls.Add(this.dgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}