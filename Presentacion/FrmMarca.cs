using AccesoDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }
        public Marca marcaSeleccionada { get; set; }
        private void FrmMarca_Load(object sender, EventArgs e)
        {
            try
            {
                cargarDB();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarDB()
        {
            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                dgvMarca.DataSource = marcaNegocio.listarMarca();

                dgvMarca.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMarca_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvMarca.CurrentRow != null)
            {
                marcaSeleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                lblMarcaSeleccionada.Text = marcaSeleccionada.Descripcion;
            }
            else 
            {
                lblMarcaSeleccionada.Text = "";
            }
        }

        private void tbxBuscador_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbxBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }
        private void filtrar() 
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            String cadena = tbxBuscador.Text;
            dgvMarca.DataSource = marcaNegocio.filtrarMarca(cadena);

            if (dgvMarca.CurrentRow != null)
            {
                marcaSeleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                lblMarcaSeleccionada.Text = marcaSeleccionada.Descripcion;
            }
            else
            {
                lblMarcaSeleccionada.Text = "";
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvMarca.CurrentRow != null)
                {
                    marcaSeleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;

                    MarcaNegocio marcaNegocio = new MarcaNegocio();

                    marcaNegocio.editarMarca(marcaSeleccionada, tbxEditar.Text);

                    tbxEditar.Text = "";

                    cargarDB();

                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (tbxAgregar.Text != "") 
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();

                marcaNegocio.agregarMarca(tbxAgregar.Text);

                tbxAgregar.Text = "";

                cargarDB();
            }
        }

        private void tbxAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMarca.CurrentRow != null)
                {

                    DialogResult resulato = MessageBox.Show("Si eliminas una Marca que ya esté asociada a un articulo, no se podrá acceder a dicho articulo. Desea continuar?", "Alerta Eliminacion Permanente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resulato == DialogResult.Yes) 
                    {
                        marcaSeleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;

                        MarcaNegocio marcaNegocio = new MarcaNegocio();

                        marcaNegocio.eliminarMarca(marcaSeleccionada);

                        tbxEditar.Text = "";

                        cargarDB();

                        
                        
                        
                    }

                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
    }
}
      
    
