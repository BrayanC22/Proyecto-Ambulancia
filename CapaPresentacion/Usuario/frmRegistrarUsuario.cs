using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Usuario;

namespace CapaPresentacion.Usuario
{
    public partial class frmRegistrarUsuario : Form
    {
        clsUsuario clsUsuario = new clsUsuario();
        String RutaImagen ="";

        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clsUsuario.Nombre = txtNombre.Text;
            clsUsuario.Apellido = txtApellidos.Text;
            clsUsuario.Cedula = txtCedula.Text;
            clsUsuario.Usuario = txtUsuario.Text;
            clsUsuario.Password = txtConfirmaPass.Text;
            clsUsuario.RutaImagen = validarImagen(this.RutaImagen);
            
            MessageBox.Show(clsUsuario.registrarUsuario());
            limpiarDatos();
            this.Close();
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String imagen = openFileDialog1.FileName;

                    this.RutaImagen = imagen;
                    pboxPerfil.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo no es válido: "+ex);
            }
        }

        public String validarImagen(String Imagen)
        {
            String ruta;
            if (Imagen.Equals(""))
            {
                ruta = Path.Combine(Environment.CurrentDirectory, "..\\..\\Resourses\\A-Usuario.png");

            }
            else
            {
                ruta = Imagen;
            }

            return ruta;
        }

        public void validarNumeros(KeyPressEventArgs k)
        {
            if (Char.IsDigit(k.KeyChar) || Char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }
            else k.Handled = true;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);
        }

        private void frmRegistrarUsuario_Shown(object sender, EventArgs e)
        {
            pboxPerfil.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "..\\..\\Resources\\A-Usuario.png"));
            txtNombre.Focus();
        }
        private void limpiarDatos()
        {
            txtApellidos.Text = "";
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtConfirmaPass.Text = "";
            this.RutaImagen = "";

        }


    }
}
