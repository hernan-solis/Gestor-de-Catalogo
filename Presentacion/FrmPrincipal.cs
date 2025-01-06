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
    public partial class FrmPrincipal : Form
    {
        private Articulo articuloSeleccionado;
        private List<Articulo> articulos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cargarBase();
            cargarListaCampo();
            cargarListaCriterio(cbxCampo.Text);
            
            
            
  
        }
        private void cargarBase() 
        {

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                
                articulos = articuloNegocio.listarArticulos();
                dgvArticulos.DataSource = articulos;
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "C2";
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void cargarImagen(PictureBox pbx, String url) 
        {
            try
            {
                pbx.Load(url);
            }
            catch (Exception ex)
            {
                pbx.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");

            }        
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            cargarImagen(pbxImagenPrincipal, articuloSeleccionado.ImagenUrl);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta();
            frmAlta.ShowDialog();
            cargarBase();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null && dgvArticulos.CurrentRow.Selected)
                {
                    articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    ArticuloNegocio articuloNegocio = new ArticuloNegocio();

                    DialogResult resultado = MessageBox.Show("Seguro desea eliminar el articulo seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        articuloNegocio.eliminarArticulo(articuloSeleccionado);
                    }

                    cargarBase();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
 
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvArticulos.CurrentRow != null && dgvArticulos.CurrentRow.Selected)
                {
                    Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    FrmAlta frmAlta = new FrmAlta(articuloSeleccionado);
                    frmAlta.ShowDialog();
                    cargarBase();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void gbxFiltro_Enter(object sender, EventArgs e)
        {

        }

        private void cargarListaCampo() 
        {
            List<String> campos = new List<String>();
            campos.Add("Codigo");
            campos.Add("Nombre");
            campos.Add("Descripcion");
            campos.Add("Marca");
            campos.Add("Categoria");
            campos.Add("Precio");

            cbxCampo.DataSource = campos;

        }
        private void cargarListaCriterio(String campo) 
        {
            List<String> listaCriterios = new List<String>();

            if (campo == "Precio")
            {
                listaCriterios.Add("Mayor a");
                listaCriterios.Add("Menor a");
                listaCriterios.Add("Igual a");
            }
            else 
            {
                listaCriterios.Add("Contiene");
                listaCriterios.Add("Empieza con");
                listaCriterios.Add("Termina con");
            }

            cbxCriterio.DataSource = listaCriterios;
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarListaCriterio(cbxCampo.Text);
        }

        private void tbxFiltro_KeyUp(object sender, KeyEventArgs e)
        {


            
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool soloNumeros(String cadena) 
        {
            int cantidadPuntos = cadena.Count(letra => letra == '.');
            int cantidadComas = cadena.Count(letra => letra == ',');

            if (cantidadPuntos > 1 || cantidadComas > 1)
            {
                MessageBox.Show("Precio: valor a filtrar erroneo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cadena == "," || cadena == ".")
            {
                MessageBox.Show("Precio: valor a filtrar erroneo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cadena.Contains(".") && cadena.Contains(",")) 
            {
                MessageBox.Show("Precio: valor a filtrar erroneo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                foreach (char caracter in cadena)
                {
                    if (caracter != '.' && caracter != ',' && caracter != '0' && caracter != '1' && caracter != '2' && caracter != '3' && caracter != '4' && caracter != '5' && caracter != '6' && caracter != '7' && caracter != '8' && caracter != '9')
                    {
                        MessageBox.Show("Precio: valor a filtrar erroneo","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            String campo = cbxCampo.Text;
            String criterio = cbxCriterio.Text;
            String filtro = tbxFiltro.Text;

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            if (campo == "Precio" && !soloNumeros(filtro)) 
            {
                return;
            }

            try
            {
                dgvArticulos.DataSource = articuloNegocio.filtrarArticulos(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }








        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por hernansolis.com");
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();

            frmMarca.ShowDialog();

            cargarBase();

        }
    }
}
