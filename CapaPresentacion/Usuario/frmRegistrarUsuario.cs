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
        public clsUsuario clsUsuario = new clsUsuario();
        String RutaImagen ="";

        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }
        public String RegistrarUsuario(clsUsuario clsUsuario)
        {
            String Mensaje = "";
                Tuple<String, bool> resultado = clsUsuario.registrarUsuario();
                Mensaje =resultado.Item1;
                if (resultado.Item2)
                {
                    limpiarDatos();
                    this.Close();
                }
                else
                {
                    txtNombre.Focus();
                }
            return Mensaje;
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

                MessageBox.Show(RegistrarUsuario(clsUsuario), "Resultado de registro");

            }
            else
            {
                txtNombre.Focus();
                MessageBox.Show("¡Atención!:\n\n- Ingrese todos los datos solicitados", "Error de datos");
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
            String Mayuscula ="mayuscula, "; String Minus ="minuscula, "; String Num = "numeros, "; String Caracter = "caracter especial, "; String Longitud="Al menos 8 caracteres";
            bool validado = false; bool mayuscula = false; bool minuscula = false; bool numero = false;  bool carespecial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    Mayuscula = "";
                    mayuscula = true;
                }
                else if (Char.IsLower(password, i))
                {
                    Minus = "";
                    minuscula = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    Num = "";
                    numero = true;
                }
                else
                {
                    Caracter = "";
                    carespecial = true;
                }
            }

            if (mayuscula && minuscula && numero && carespecial && password.Length >= 8)
            {
                lblNivelSeguridad.BackColor = Color.Green;
                validado = true;
                Longitud = "";
                lblSeguridad.Text = "";
                txtConfirmaPass.Enabled = true;
                txtConfirmaPass.ReadOnly = false;

            }
            else
            {
                lblNivelSeguridad.BackColor = Color.Red;
                lblSeguridad.Text = "Debe incluir: " + Mayuscula + Minus + Num + Caracter + Longitud;
                validado = false;
                txtConfirmaPass.Enabled = false;
                txtConfirmaPass.ReadOnly = true;
            }
            return validado;
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            nivelSeguridad(txtPass.Text);
        }

        private void txtConfirmaPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPass.Text.Equals(txtConfirmaPass.Text) || !nivelSeguridad(txtPass.Text))
            {
                lblPassIdenticas.Text = "¡Todo listo!";
                btnRegistrar.Enabled = true;
            }
            else
            {
                lblPassIdenticas.Text = "Las contraseñas no coinciden";
            }
        }

        private void txtPass_MouseHover(object sender, EventArgs e)
        {
            MostrarContra(txtPass);
        }

        private void MostrarContra(TextBox txt)
        {
            txt.UseSystemPasswordChar = false;
        }

        private void OcultarContra(TextBox txt)
        {
            txt.UseSystemPasswordChar = true;
        }

        private void txtPass_MouseLeave(object sender, EventArgs e)
        {
            OcultarContra(txtPass);
        }

        private void txtConfirmaPass_MouseHover(object sender, EventArgs e)
        {
            MostrarContra(txtConfirmaPass);
        }

        private void txtConfirmaPass_MouseLeave(object sender, EventArgs e)
        {
            OcultarContra(txtConfirmaPass);
        }
    }
}
