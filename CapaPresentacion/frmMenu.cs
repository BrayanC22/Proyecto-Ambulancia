using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Close();
        }

        private void pboxAmbulancia_Click(object sender, EventArgs e)
        {
            guardarAmbulancia.Show();
            this.Close();
        }

        private void pboxConductor_Click(object sender, EventArgs e)
        {
            conductores.Show();
            this.Close();
        }

        private void pboxCliente_Click(object sender, EventArgs e)
        {
            cliente.Show();
            this.Close();
        }

        private void btnAmbulancia_Click(object sender, EventArgs e)
        {
            guardarAmbulancia.Show();
            this.Close();
        }

        private void btnConductor_Click(object sender, EventArgs e)
        {
            conductores.Show();
            this.Close();
        }
    }
}
