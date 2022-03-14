using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Login;
using CapaPresentacion.Usuario;

namespace CapaPresentacion
{
    public partial class frmMenu : Form
    {
        frmCliente cliente = new frmCliente();
        frmGuardarAmbulancia guardarAmbulancia = new frmGuardarAmbulancia();
        FrmConductores conductores = new FrmConductores();
  


        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            cliente.Show();
            this.Hide();
        }

        private void pboxAmbulancia_Click(object sender, EventArgs e)
        {
            guardarAmbulancia.Show();
            this.Hide();
        }

        private void pboxConductor_Click(object sender, EventArgs e)
        {
            conductores.Show();
            this.Hide();
        }

        private void pboxCliente_Click(object sender, EventArgs e)
        {
            cliente.Show();
            this.Hide();
        }

        private void btnAmbulancia_Click(object sender, EventArgs e)
        {
            guardarAmbulancia.Show();
            this.Hide();
        }

        private void btnConductor_Click(object sender, EventArgs e)
        {
            conductores.Show();
            this.Hide();
        }



        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void BtnConductor_Click_1(object sender, EventArgs e)
        {
            conductores.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guardarAmbulancia.Show();
            this.Hide();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmConsultarUsuario frmConsultar = new frmConsultarUsuario();
            frmConsultar.ShowDialog();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
