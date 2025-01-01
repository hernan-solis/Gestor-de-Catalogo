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
            articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            articuloNegocio.eliminarArticulo(articuloSeleccionado);


            cargarBase();
        }
    }
}
