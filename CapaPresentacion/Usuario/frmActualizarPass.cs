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
    public partial class frmActualizarPass : Form
    {
        clsUsuario clsUsuario = new clsUsuario();
        public frmActualizarPass(List<Object>lst_Usuarios)
        {
            InitializeComponent();
            
            foreach (var usuario in lst_Usuarios)
            {
                System.Type type = usuario.GetType();
                lblNombreAdmin.Text = (String)type.GetProperty("nombre").GetValue(usuario);
                lblRol.Text = (String)type.GetProperty("cargo").GetValue(usuario);
                byte[] foto = (byte[])type.GetProperty("foto").GetValue(usuario);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(foto);
                pboxFotoAdmin.Image = Image.FromStream(ms);
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            List<object> lst_Usuarios= clsUsuario.listarUsuario();

            foreach (var usuario in lst_Usuarios)
            {

                System.Type type = usuario.GetType();
                String Nusuario = (String)type.GetProperty("nombreUsuario").GetValue(usuario);
                if (Nusuario.Equals(lblNombreAdmin.Text))
                {
                    String IdUsuario = (String)type.GetProperty("id_usuario").GetValue(usuario);
                    String password = (String)type.GetProperty("Password").GetValue(usuario);
                    if (txtOldPass.Equals(password)) {
                        clsUsuario.Password = txtConfirmaPass.Text;
                        MessageBox.Show(clsUsuario.ActualizarPass());
                    }
                }
            }
        }
    }
}
