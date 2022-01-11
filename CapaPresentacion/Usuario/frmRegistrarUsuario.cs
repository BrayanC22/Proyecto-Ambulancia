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
            
            if (datosLlenos())
            {
                clsUsuario.Nombre = txtNombre.Text;
                clsUsuario.Apellido = txtApellidos.Text;
                clsUsuario.Cedula = txtCedula.Text;
                clsUsuario.Usuario = txtUsuario.Text;
                clsUsuario.Password = txtConfirmaPass.Text;

                validarImagen(this.RutaImagen);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pboxPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                clsUsuario.RutaImagen = ms.GetBuffer();

                // Devuelve un valor booleano para verificar el registro y un String con el mensaje obteenido
                Tuple<String, bool> resultado = clsUsuario.registrarUsuario();

                MessageBox.Show(resultado.Item1, "Resultado de registro");
                if (resultado.Item2)
                {
                    limpiarDatos();
                    this.Close();
                }
                else
                {
                    txtNombre.Focus();
                }
            }
            else
            {
                txtNombre.Focus();
                MessageBox.Show("¡Atención!:\n\n- Ingrese todos los datos solicitados\n- Verifique que la cédula sea correcta", "Error de datos");
            }
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo de imagen (*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
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
                MessageBox.Show("El archivo no es válido");
                Console.Write(ex);
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
        private bool datosLlenos()
        {
            bool estanllenos = true;
            if (txtApellidos.Text.Equals("") || txtNombre.Text.Equals("") || (txtCedula.Text.Length<10) || txtUsuario.Text.Equals("")) {
                estanllenos = false;
            }

            return estanllenos;
        }


        private bool nivelSeguridad(string password)
        {
            bool validado = false;
            bool mayuscula = false;
            bool minuscula = false; 
            bool numero = false;
            bool carespecial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsLower(password, i))
                {
                    minuscula = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    numero = true;
                }
                else
                {
                    carespecial = true;
                }
            }

            if (mayuscula && minuscula && numero && carespecial && password.Length >= 8)
            {
                lblNivelSeguridad.BackColor = Color.Green;
                validado = true;

            }
            else
            {
                lblNivelSeguridad.BackColor = Color.Red;
                validado = false;
            }


            return validado;
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (nivelSeguridad(txtPass.Text))
            {
                txtConfirmaPass.ReadOnly = false;
            }
        }

        private void txtConfirmaPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPass.Text.Equals(txtConfirmaPass.Text)){
                lblPassIdenticas.Text = "¡Todo listo!";
                btnRegistrar.Enabled = true;
            }
            else
            {
                lblPassIdenticas.Text = "Las contraseñas no coinciden";
            }
        }
    }
}
