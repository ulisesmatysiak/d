using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmDiscos : Form
    {
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Disco nuevo = new Disco();
            DiscoNegocio negocio = new DiscoNegocio();  

            try
            {
                nuevo.Titulo = txtbTitulo.Text;
                nuevo.Fecha = dtpFecha.Value;
                nuevo.CantidadCanciones = int.Parse(numCanciones.Text);
                nuevo.UrlImagen = txtbImagen.Text;
                nuevo.Genero = (Estilo)cboEstilo.SelectedItem;
                nuevo.Formato = (Edicion)cboFormato.SelectedItem;
                negocio.agregar(nuevo);

                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmDiscos_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            try
            {               
                cboEstilo.DataSource = estiloNegocio.listar();
                cboFormato.DataSource = edicionNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
