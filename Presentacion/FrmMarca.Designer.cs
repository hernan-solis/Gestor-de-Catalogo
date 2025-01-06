namespace Presentacion
{
    partial class FrmMarca
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.tbxBuscador = new System.Windows.Forms.TextBox();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxEditar = new System.Windows.Forms.TextBox();
            this.gbxMarcaSeleccionada = new System.Windows.Forms.GroupBox();
            this.lblMarcaSeleccionada = new System.Windows.Forms.Label();
            this.gbxMarcaNueva = new System.Windows.Forms.GroupBox();
            this.tbxAgregar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.gbxMarcaSeleccionada.SuspendLayout();
            this.gbxMarcaNueva.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAgregar.Click += new System.EventHandler(this.Agregar_Click);
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
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.Location = new System.Drawing.Point(288, 453);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(77, 16);
            this.lblBuscador.TabIndex = 3;
            this.lblBuscador.Text = "Buscador:";
            // 
            // tbxBuscador
            // 
            this.tbxBuscador.Location = new System.Drawing.Point(371, 449);
            this.tbxBuscador.Name = "tbxBuscador";
            this.tbxBuscador.Size = new System.Drawing.Size(180, 20);
            this.tbxBuscador.TabIndex = 4;
            this.tbxBuscador.TextChanged += new System.EventHandler(this.tbxBuscador_TextChanged);
            this.tbxBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBuscador_KeyPress);
            this.tbxBuscador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxBuscador_KeyUp);
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(334, 50);
            this.dgvMarca.MultiSelect = false;
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.Size = new System.Drawing.Size(235, 383);
            this.dgvMarca.TabIndex = 5;
            this.dgvMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvMarca.SelectionChanged += new System.EventHandler(this.dgvMarca_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(420, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(58, 20);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Marca";
            // 
            // tbxEditar
            // 
            this.tbxEditar.Location = new System.Drawing.Point(122, 54);
            this.tbxEditar.Name = "tbxEditar";
            this.tbxEditar.Size = new System.Drawing.Size(128, 20);
            this.tbxEditar.TabIndex = 7;
            // 
            // gbxMarcaSeleccionada
            // 
            this.gbxMarcaSeleccionada.BackColor = System.Drawing.SystemColors.Control;
            this.gbxMarcaSeleccionada.Controls.Add(this.lblMarcaSeleccionada);
            this.gbxMarcaSeleccionada.Controls.Add(this.btnEditar);
            this.gbxMarcaSeleccionada.Controls.Add(this.tbxEditar);
            this.gbxMarcaSeleccionada.Controls.Add(this.btnEliminar);
            this.gbxMarcaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMarcaSeleccionada.Location = new System.Drawing.Point(12, 128);
            this.gbxMarcaSeleccionada.Name = "gbxMarcaSeleccionada";
            this.gbxMarcaSeleccionada.Size = new System.Drawing.Size(262, 139);
            this.gbxMarcaSeleccionada.TabIndex = 8;
            this.gbxMarcaSeleccionada.TabStop = false;
            this.gbxMarcaSeleccionada.Text = "Marca Seleccionada:";
            // 
            // lblMarcaSeleccionada
            // 
            this.lblMarcaSeleccionada.AutoSize = true;
            this.lblMarcaSeleccionada.Location = new System.Drawing.Point(130, 0);
            this.lblMarcaSeleccionada.Name = "lblMarcaSeleccionada";
            this.lblMarcaSeleccionada.Size = new System.Drawing.Size(123, 13);
            this.lblMarcaSeleccionada.TabIndex = 10;
            this.lblMarcaSeleccionada.Text = "Marca Seleccionada";
            // 
            // gbxMarcaNueva
            // 
            this.gbxMarcaNueva.BackColor = System.Drawing.SystemColors.Control;
            this.gbxMarcaNueva.Controls.Add(this.tbxAgregar);
            this.gbxMarcaNueva.Controls.Add(this.btnAgregar);
            this.gbxMarcaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMarcaNueva.Location = new System.Drawing.Point(43, 305);
            this.gbxMarcaNueva.Name = "gbxMarcaNueva";
            this.gbxMarcaNueva.Size = new System.Drawing.Size(231, 100);
            this.gbxMarcaNueva.TabIndex = 9;
            this.gbxMarcaNueva.TabStop = false;
            this.gbxMarcaNueva.Text = "Marca Nueva";
            // 
            // tbxAgregar
            // 
            this.tbxAgregar.Location = new System.Drawing.Point(94, 49);
            this.tbxAgregar.Name = "tbxAgregar";
            this.tbxAgregar.Size = new System.Drawing.Size(128, 20);
            this.tbxAgregar.TabIndex = 11;
            this.tbxAgregar.TextChanged += new System.EventHandler(this.tbxAgregar_TextChanged);
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(634, 481);
            this.Controls.Add(this.gbxMarcaNueva);
            this.Controls.Add(this.gbxMarcaSeleccionada);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.tbxBuscador);
            this.Controls.Add(this.lblBuscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMarca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.gbxMarcaSeleccionada.ResumeLayout(false);
            this.gbxMarcaSeleccionada.PerformLayout();
            this.gbxMarcaNueva.ResumeLayout(false);
            this.gbxMarcaNueva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.TextBox tbxBuscador;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxEditar;
        private System.Windows.Forms.GroupBox gbxMarcaSeleccionada;
        private System.Windows.Forms.Label lblMarcaSeleccionada;
        private System.Windows.Forms.GroupBox gbxMarcaNueva;
        private System.Windows.Forms.TextBox tbxAgregar;
    }
}