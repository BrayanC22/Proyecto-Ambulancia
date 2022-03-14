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

namespace CapaPresentacion.Solicitudes
{
    public partial class frmHistorialPagos : Form
    {
        List<Object> lst_Solicitudes;
        clsSolicitudes clsSolicitud = new clsSolicitudes();

        public frmHistorialPagos()
        {
            InitializeComponent();
            LlenarDGVSolicitudes();
        }



        public void LlenarDGVSolicitudes()
        {
            lst_Solicitudes = clsSolicitud.listarSolicitudes();
            dgv_Solicitudes.Rows.Clear();
            dgv_Solicitudes.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var solicitud in lst_Solicitudes)
            {
                System.Type type = solicitud.GetType();
                String id_solicitud = (String)type.GetProperty("id_solicitud").GetValue(solicitud);
                String cedulaCliente = (String)type.GetProperty("cedulaCliente").GetValue(solicitud);
                String nombreCliente = (String)type.GetProperty("nombreCliente").GetValue(solicitud);
                String hospitalOrigen = (String)type.GetProperty("hospitalOrigen").GetValue(solicitud);
                String HospitalDestino = (String)type.GetProperty("HospitalDestino").GetValue(solicitud);
                String placaAmbulancia = (String)type.GetProperty("placaAmbulancia").GetValue(solicitud);
                String descripcionSolicitud = (String)type.GetProperty("descripcionSolicitud").GetValue(solicitud);
                String totalPagar = (String)type.GetProperty("totalPagar").GetValue(solicitud);
                dgv_Solicitudes.Rows.Add(id_solicitud,cedulaCliente,nombreCliente,hospitalOrigen,HospitalDestino,placaAmbulancia,descripcionSolicitud,totalPagar);
            }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmPagos solicitudes = new frmPagos();
            solicitudes.ShowDialog();
            
        }
    }
}
