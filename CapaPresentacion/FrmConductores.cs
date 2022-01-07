using System;
using CapaNegocio.Conductor;
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
    public partial class FrmConductores : Form
    {
        ClsConductores chofer = new ClsConductores();
        public FrmConductores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String msj = "";

            try
            {
                chofer.Cedula = txtCedula.Text;
                chofer.Nombre = txtNombre.Text;
                chofer.Apellido = txtApellido.Text;
                chofer.Edad = Int16.Parse(txtEdad.Text);
                chofer.Domicilio = txtDireccion.Text;
                if (rButtonFemenino.Checked.Equals(true))
                {
                    chofer.Sexo = rButtonFemenino.Text;
                }
                if (rButtonMasculino.Checked.Equals(true))
                {
                    chofer.Sexo = rButtonMasculino.Text;
                }
                chofer.Licencia = txtLicencia.Text;

                msj = chofer.registrar();
                MessageBox.Show(msj);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
