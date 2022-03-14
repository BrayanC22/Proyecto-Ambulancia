using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Pagos;
using CapaPresentacion.Solicitudes;

namespace CapaPresentacion
{
    public partial class frmPagos : Form
    {
        clsSolicitudes cls = new clsSolicitudes();
        public frmPagos()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cls.CedulaCliente = txtCedula.Text;
            cls.NombreCliente = lblNombre.Text;
            cls.HospitalOrigen = txtOrigen.Text;
            cls.HospitalDestino = txtDestino.Text;
            cls.PlacaAmbulancia = txtPlaca.Text;
            cls.DescripcionSolicitud = txtDescripcion.Text;
            cls.TotalPagar = float.Parse(txtPago.Text);

            MessageBox.Show(RegistrarPago(cls), "Resultado de registro");
        }

        public String RegistrarPago(clsSolicitudes cls)
        {
            String Mensaje = "";
            Tuple<String, bool> resultado = cls.registrarSolicitud();
            Mensaje = resultado.Item1;
            if (resultado.Item2)
            {
                this.Close();
            }
            else
            {
                txtCedula.Focus();
            }
            return Mensaje;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmHistorialPagos historialPagos = new frmHistorialPagos();
            historialPagos.ShowDialog();
            
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
