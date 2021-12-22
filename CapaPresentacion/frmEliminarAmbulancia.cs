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
        ClsAmbulancia Al;
        List<Object> lst_ambulancia_tmp;


        public frmEliminarAmbulancia()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }
        public frmEliminarAmbulancia(ClsAmbulancia Al)
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.Al = Al;
            btn_eliminar.Enabled = false;
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_listarTodos.Rows.Clear();
                dgv_listarTodos.Refresh();
                lst_ambulancia_tmp = Al.buscar(txtnunplaca.Text);

                foreach (var ambulancia in lst_ambulancia_tmp)
                {
                    if (ambulancia != null)
                    {
                        System.Type type = ambulancia.GetType();

                        String modelo = (String)type.GetProperty("modelo").GetValue(ambulancia);
                        String tipoAmbulancia = (String)type.GetProperty("tipoAmbulancia").GetValue(ambulancia);
                        String placa = (String)type.GetProperty("placa").GetValue(ambulancia);
                        String matricula = (String)type.GetProperty("matricula").GetValue(ambulancia);
                        String fechaActivacion = (String)type.GetProperty("fechaActivacion").GetValue(ambulancia);
                        String estado = (String)type.GetProperty("estado").GetValue(ambulancia);
                        String observacion = (String)type.GetProperty("observacion").GetValue(ambulancia);



                        dgv_listarTodos.Rows.Add(modelo, tipoAmbulancia, placa, matricula, fechaActivacion, estado, observacion);


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
            Al.eliminar(txtnunplaca.Text);
            btn_eliminar.Enabled = false;
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGuardarAmbulancia frmEst = new frmGuardarAmbulancia(Al);
            frmEst.Show();
        }
    }
}
