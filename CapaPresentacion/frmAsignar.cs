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
    public partial class frmAsignar : Form
    {
        List<Object> lst_ambulancia_tmp;
        ClsAmbulancia Ambulancia1;
       

        public frmAsignar()
        {
            InitializeComponent();
        }

        public frmAsignar(ClsAmbulancia Ambulancia1)
        {
            InitializeComponent();

            this.Ambulancia1 = Ambulancia1;
            this.lst_ambulancia_tmp = Ambulancia1.listar();
         
            cmdregistrar.Enabled = false;

        }

        public void llenar_datagridview_ambulancia()
        {
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var ambulancia in lst_ambulancia_tmp)
            {
                System.Type type = ambulancia.GetType();

                Int16 Id_Ambulancia = (Int16)type.GetProperty("Id_Ambulancia").GetValue(ambulancia);
                String modelo = (String)type.GetProperty("modelo").GetValue(ambulancia);
                String tipoAmbulancia = (String)type.GetProperty("tipoAmbulancia").GetValue(ambulancia);
                String placa = (String)type.GetProperty("placa").GetValue(ambulancia);
                String matricula = (String)type.GetProperty("matricula").GetValue(ambulancia);

                dgv_listarTodos.Rows.Add(Id_Ambulancia, modelo, tipoAmbulancia, placa, matricula);
            }

        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            llenar_datagridview_ambulancia();
        }

        private void cmdregistrar_Click(object sender, EventArgs e)
        {
            String msj = "";

            try
            {
                // = NumAmbulanciaR.Text;
              

                msj = Ambulancia1.registrar();
                MessageBox.Show(msj);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmEst = new frmMenu();
            frmEst.Show();
        }
    }
}
