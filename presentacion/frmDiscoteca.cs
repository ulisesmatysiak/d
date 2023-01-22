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
    public partial class frmDiscoteca : Form
    {
        private List<Disco> listaDisco;
        public frmDiscoteca()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmDiscos discos = new frmDiscos();
            discos.ShowDialog();
        }

        private void frmDiscoteca_Load(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            listaDisco = negocio.listar();
            dgvDiscoteca.DataSource = listaDisco;
            dgvDiscoteca.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaDisco[0].UrlImagen);
        }

        private void dgvDiscoteca_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscoteca.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboDiscoteca.Load(imagen);
            }
            catch (Exception)
            {
                pboDiscoteca.Load("https://crawfordroofing.com.au/wp-content/uploads/2018/04/No-image-available.jpg");
            }
        }
    }
}
