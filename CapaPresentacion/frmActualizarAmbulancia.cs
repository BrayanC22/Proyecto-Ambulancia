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
    public partial class frmActualizarAmbulancia : Form
    {
        String placa;
        List<Object> lst_alumnos_tmp;
        ClsAmbulancia Ambulancia1 = new ClsAmbulancia();

        public frmActualizarAmbulancia()
        {
            InitializeComponent();
            txtplaca.Enabled = false;
        }
        public frmActualizarAmbulancia(string placa, ClsAmbulancia Ambulancia1)
        {
            InitializeComponent();

            this.placa = placa;
            txtplaca.Enabled = false;
            this.lst_alumnos_tmp = Ambulancia1.listar();
        }



        private void buttonregresar_Click_1(object sender, EventArgs e)
        {
        }

        private void buttonActualizarCambios_Click(object sender, EventArgs e)
        {
            try
            {

               int resultado = Ambulancia1.actualizar_x_placa(comboBoxModelo.Text,comboBoxTipo.Text,txtplaca.Text,txtMatricula.Text);
                if (resultado == 0)
                {
                    MessageBox.Show("Los datos se actualizon correctamente");
                    this.Close();
                    frmConsultarAmbulanciacs frmconsultar = new frmConsultarAmbulanciacs(Ambulancia1);
                    frmconsultar.Show();

                }
                if (resultado == 1)
                {

                    MessageBox.Show("Error en la actualizacion");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
