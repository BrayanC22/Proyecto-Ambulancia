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

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        ClsAmbulancia Al;
        ClsCliente Cl;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCliente llamar = new frmCliente();
            llamar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGuardarAmbulancia llamar2 = new frmGuardarAmbulancia();
            llamar2.Show();
            this.Hide();
        }
    }
}
