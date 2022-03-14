using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Usuario;

namespace CapaPresentacion.Usuario
{
    public partial class frmConsultarUsuario : Form
    {
        clsUsuario clsUser= new clsUsuario();
        List<Object> lst_Usuarios;
        public frmConsultarUsuario()
        {
            InitializeComponent();
            LlenarDGVUsuario();
        }

        public void LlenarDGVUsuario()
        {
            lst_Usuarios = clsUser.listarUsuario();
            dgv_Usuarios.Rows.Clear();
            dgv_Usuarios.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var usuario in lst_Usuarios)
            {
                System.Type type = usuario.GetType();
                String IdUsuario = (String)type.GetProperty("id_usuario").GetValue(usuario);
                String Nusuario = (String)type.GetProperty("nombreUsuario").GetValue(usuario);
                String cedula = (String)type.GetProperty("cedula").GetValue(usuario);
                String nombre = (String)type.GetProperty("nombre").GetValue(usuario);
                String cargo = (String)type.GetProperty("cargo").GetValue(usuario);
                dgv_Usuarios.Rows.Add(IdUsuario, Nusuario, cedula, nombre, cargo);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
