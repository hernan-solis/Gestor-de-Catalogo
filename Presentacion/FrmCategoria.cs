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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
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
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                dgvCategoria.DataSource = categoriaNegocio.ListarCaterogia();

                dgvCategoria.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {
            actualizarLblCategoriaSeleccionada();
        }
        private void actualizarLblCategoriaSeleccionada() 
        {
            try
            {
                Categoria categoriaActual = new Categoria();

                if (dgvCategoria.CurrentRow != null)
                {
                    categoriaActual = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    lblCategoriaSeleccionada.Text = categoriaActual.ToString();
                }
                else
                {
                    lblCategoriaSeleccionada.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
             
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada = new Categoria();
            try
            {
                if (dgvCategoria.CurrentRow != null)
                {

                    DialogResult resulato = MessageBox.Show("Si eliminas una Categoria que ya esté asociada a un articulo, no se podrá acceder más a dicho articulo. Desea continuar?", "Alerta Eliminacion Permanente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resulato == DialogResult.Yes)
                    {
                        categoriaSeleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;

                        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                        categoriaNegocio.eliminarCategoria(categoriaSeleccionada);

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbxAgregar.Text != "")
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                categoriaNegocio.agregarCategoria(tbxAgregar.Text);

                tbxAgregar.Text = "";

                cargarDB();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoriaSeleccionada = new Categoria();

                if (dgvCategoria.CurrentRow != null)
                {
                    categoriaSeleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;

                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                    categoriaNegocio.editarCategoria(categoriaSeleccionada, tbxEditar.Text);

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

        private void tbxBuscador_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }
        private void filtrar()
        {
            Categoria categoriaSeleccionada = new Categoria();

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            String cadena = tbxBuscador.Text;
            dgvCategoria.DataSource = categoriaNegocio.filtrarCategoria(cadena);

            if (dgvCategoria.CurrentRow != null)
            {
                categoriaSeleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                lblCategoriaSeleccionada.Text = categoriaSeleccionada.Descripcion;
            }
            else
            {
                lblCategoriaSeleccionada.Text = "";
            }

        }

        private void tbxBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }
    }
}
