using CapaNegocio.Conductor;
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
    public partial class FrmConsultarConductores : Form
    {
        ClsConductores chofer;
        List<Object> lst_conductor_tmp;
        

        public FrmConsultarConductores()
        {
            InitializeComponent();
        }

        public FrmConsultarConductores(ClsConductores chofer)
        {
            InitializeComponent();
            this.chofer = chofer;
            this.lst_conductor_tmp = chofer.listar();
            llenar_datagridview_conductores();
        }

        public void llenar_datagridview_conductores()
        {
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var conductor in lst_conductor_tmp)
            {
                System.Type type = conductor.GetType();

                String cedula = (String)type.GetProperty("cedula").GetValue(conductor);
                String nombre = (String)type.GetProperty("nombre").GetValue(conductor);
                String apellido = (String)type.GetProperty("apellido").GetValue(conductor);
                Int16 edad = (Int16)type.GetProperty("edad").GetValue(conductor);
                String domicilio = (String)type.GetProperty("domicilio").GetValue(conductor);
                String sexo = (String)type.GetProperty("sexo").GetValue(conductor);
                String licencia = (String)type.GetProperty("licencia").GetValue(conductor);

                dgv_listarTodos.Rows.Add(cedula, nombre, apellido, edad, domicilio, sexo, licencia);
            }

        }
    }
}
