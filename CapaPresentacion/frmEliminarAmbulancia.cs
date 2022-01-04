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
    public partial class frmEliminarAmbulancia : Form
    {
        ClsAmbulancia Ambulancia1;
        List<Object> lst_ambulancia_tmp;


        public frmEliminarAmbulancia()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }
        public frmEliminarAmbulancia(ClsAmbulancia Ambulancia1)
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.Ambulancia1 = Ambulancia1;
            btn_eliminar.Enabled = false;
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_listarTodos.Rows.Clear();
                dgv_listarTodos.Refresh();
                lst_ambulancia_tmp = Ambulancia1.buscar(txtnunplaca.Text);

                foreach (var ambulancia in lst_ambulancia_tmp)
                {
                    if (ambulancia != null)
                    {
                        System.Type type = ambulancia.GetType();

                        String modelo = (String)type.GetProperty("modelo").GetValue(ambulancia);
                        String tipoAmbulancia = (String)type.GetProperty("tipoAmbulancia").GetValue(ambulancia);
                        String placa = (String)type.GetProperty("placa").GetValue(ambulancia);
                        String matricula = (String)type.GetProperty("matricula").GetValue(ambulancia);
                      


                        dgv_listarTodos.Rows.Add(modelo, tipoAmbulancia, placa, matricula);


                        btn_eliminar.Enabled = true;

                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No se ha registrado una ambulancia con esa placa.");
            }
        }

   

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Ambulancia1.eliminar(txtnunplaca.Text);
            btn_eliminar.Enabled = false;
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGuardarAmbulancia frmEst = new frmGuardarAmbulancia(Ambulancia1);
            frmEst.Show();
        }
    }
}
