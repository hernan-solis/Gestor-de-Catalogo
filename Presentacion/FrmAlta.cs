﻿using AccesoDatos;
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
using System.Globalization;

namespace Presentacion
{
    public partial class FrmAlta : Form
    {
        public FrmAlta()
        {
            InitializeComponent();
        }

        private Articulo articulo { get; set; }

        public FrmAlta(Articulo articuloSeleccionado) 
        {
            InitializeComponent();
            articulo = articuloSeleccionado;
            Text = "Modificacion";

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria= (Categoria)cbxCategoria.SelectedItem;
                articulo.ImagenUrl = tbxImagenUrl.Text;

                if (txbPrecio.Text != "")
                {
                    articulo.Precio = float.Parse(txbPrecio.Text.Replace(".", ","));
                }
                else 
                {
                    articulo.Precio = 0;
                }
                

                if (articulo.Id == 0)
                {
                    articuloNegocio.agregarArticulo(articulo);
                }
                else 
                {
                    articuloNegocio.modificarArticulo(articulo);
                }
  
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            Close();

        }

        private void pbxImagen_Click(object sender, EventArgs e)
        {

        }

        private void tbxImagenUrl_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cargarImagen(pbxImagen, tbxImagenUrl.Text);

            try
            {
                cargarDesplegables();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            if (articulo == null)
            {
                articulo = new Articulo();
            }
            else
            {
                try
                {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;


                    tbxImagenUrl.Text = articulo.ImagenUrl;
                    txbPrecio.Text = articulo.Precio.ToString();

                    cargarImagen(pbxImagen, tbxImagenUrl.Text);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
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

        private void tbxImagenUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            cargarImagen(pbxImagen, tbxImagenUrl.Text);
        }

        private void tbxImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(pbxImagen, tbxImagenUrl.Text);
        }

        private void cargarDesplegables() 
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio(); 
            cbxMarca.Items.Clear();

            CategoriaNegocio categoriaNegorio = new CategoriaNegocio();
            cbxCategoria.Items.Clear();
                
            try
            {
                cbxMarca.DataSource = marcaNegocio.listarMarca();
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.ValueMember = "Id";
                cbxMarca.SelectedIndex = 0;

                cbxCategoria.DataSource = categoriaNegorio.ListarCaterogia();
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        
        }

    }
}
