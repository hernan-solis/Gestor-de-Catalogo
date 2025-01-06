namespace Presentacion
{
    partial class FrmCategoria
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
            this.gbxCategoriaNueva = new System.Windows.Forms.GroupBox();
            this.tbxAgregar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbxCategoriaSeleccionada = new System.Windows.Forms.GroupBox();
            this.lblCategoriaSeleccionada = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbxEditar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.tbxBuscador = new System.Windows.Forms.TextBox();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.gbxCategoriaNueva.SuspendLayout();
            this.gbxCategoriaSeleccionada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategoriaNueva
            // 
            this.gbxCategoriaNueva.BackColor = System.Drawing.SystemColors.Control;
            this.gbxCategoriaNueva.Controls.Add(this.tbxAgregar);
            this.gbxCategoriaNueva.Controls.Add(this.btnAgregar);
            this.gbxCategoriaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategoriaNueva.Location = new System.Drawing.Point(50, 297);
            this.gbxCategoriaNueva.Name = "gbxCategoriaNueva";
            this.gbxCategoriaNueva.Size = new System.Drawing.Size(231, 100);
            this.gbxCategoriaNueva.TabIndex = 15;
            this.gbxCategoriaNueva.TabStop = false;
            this.gbxCategoriaNueva.Text = "Categoria Nueva";
            // 
            // tbxAgregar
            // 
            this.tbxAgregar.Location = new System.Drawing.Point(94, 49);
            this.tbxAgregar.Name = "tbxAgregar";
            this.tbxAgregar.Size = new System.Drawing.Size(128, 20);
            this.tbxAgregar.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(0, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbxCategoriaSeleccionada
            // 
            this.gbxCategoriaSeleccionada.BackColor = System.Drawing.SystemColors.Control;
            this.gbxCategoriaSeleccionada.Controls.Add(this.lblCategoriaSeleccionada);
            this.gbxCategoriaSeleccionada.Controls.Add(this.btnEditar);
            this.gbxCategoriaSeleccionada.Controls.Add(this.tbxEditar);
            this.gbxCategoriaSeleccionada.Controls.Add(this.btnEliminar);
            this.gbxCategoriaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategoriaSeleccionada.Location = new System.Drawing.Point(19, 120);
            this.gbxCategoriaSeleccionada.Name = "gbxCategoriaSeleccionada";
            this.gbxCategoriaSeleccionada.Size = new System.Drawing.Size(281, 139);
            this.gbxCategoriaSeleccionada.TabIndex = 14;
            this.gbxCategoriaSeleccionada.TabStop = false;
            this.gbxCategoriaSeleccionada.Text = "Categoria Seleccionada:";
            // 
            // lblCategoriaSeleccionada
            // 
            this.lblCategoriaSeleccionada.AutoSize = true;
            this.lblCategoriaSeleccionada.Location = new System.Drawing.Point(152, 0);
            this.lblCategoriaSeleccionada.Name = "lblCategoriaSeleccionada";
            this.lblCategoriaSeleccionada.Size = new System.Drawing.Size(111, 13);
            this.lblCategoriaSeleccionada.TabIndex = 10;
            this.lblCategoriaSeleccionada.Text = "Cat. Seleccionada";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.Location = new System.Drawing.Point(31, 51);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tbxEditar
            // 
            this.tbxEditar.Location = new System.Drawing.Point(122, 54);
            this.tbxEditar.Name = "tbxEditar";
            this.tbxEditar.Size = new System.Drawing.Size(128, 20);
            this.tbxEditar.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(31, 98);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(427, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(87, 20);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Categoria";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(341, 42);
            this.dgvCategoria.MultiSelect = false;
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.Size = new System.Drawing.Size(235, 383);
            this.dgvCategoria.TabIndex = 12;
            this.dgvCategoria.SelectionChanged += new System.EventHandler(this.dgvCategoria_SelectionChanged);
            // 
            // tbxBuscador
            // 
            this.tbxBuscador.Location = new System.Drawing.Point(378, 441);
            this.tbxBuscador.Name = "tbxBuscador";
            this.tbxBuscador.Size = new System.Drawing.Size(180, 20);
            this.tbxBuscador.TabIndex = 11;
            this.tbxBuscador.TextChanged += new System.EventHandler(this.tbxBuscador_TextChanged);
            this.tbxBuscador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxBuscador_KeyUp);
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.Location = new System.Drawing.Point(295, 445);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(77, 16);
            this.lblBuscador.TabIndex = 10;
            this.lblBuscador.Text = "Buscador:";
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(639, 471);
            this.Controls.Add(this.gbxCategoriaNueva);
            this.Controls.Add(this.gbxCategoriaSeleccionada);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.tbxBuscador);
            this.Controls.Add(this.lblBuscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCategoria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.gbxCategoriaNueva.ResumeLayout(false);
            this.gbxCategoriaNueva.PerformLayout();
            this.gbxCategoriaSeleccionada.ResumeLayout(false);
            this.gbxCategoriaSeleccionada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategoriaNueva;
        private System.Windows.Forms.TextBox tbxAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbxCategoriaSeleccionada;
        private System.Windows.Forms.Label lblCategoriaSeleccionada;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox tbxEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.TextBox tbxBuscador;
        private System.Windows.Forms.Label lblBuscador;
    }
}