using System;
using CapaNegocio;
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
    public partial class FrmConductores : Form
    {
        ClsConductores chofer = new ClsConductores();
        List<Object> lstConductor = new List<Object>();
        frmCliente metodosAux = new frmCliente(); //para llamar a los metodos 'SoloNumeros' y 'SoloLetras'
        
        public FrmConductores()
        {
            InitializeComponent();
        }

        public FrmConductores(String cedula)
        {
            InitializeComponent();
            llenarCamposParaModificar(cedula);
        }

        /// <summary>
        /// Este metodo se activa cuando regresa de la ventana consultarConductores, este metodo carga la informacion del conductor
        /// a modificar
        /// </summary>
        private void llenarCamposParaModificar(String cedula)
        {
            lstConductor=chofer.buscar(cedula);
            try
            {

                foreach (var conductor in lstConductor)
                {
                    Type type = conductor.GetType();

                    String cedulaO = (String)type.GetProperty("cedula").GetValue(conductor);
                    String nombre = (String)type.GetProperty("nombre").GetValue(conductor);
                    String apellido = (String)type.GetProperty("apellido").GetValue(conductor);
                    String edad = ((short)type.GetProperty("edad").GetValue(conductor)).ToString();
                    String domicilio = (String)type.GetProperty("domicilio").GetValue(conductor);
                    String sexo = (String)type.GetProperty("sexo").GetValue(conductor);
                    String licencia = (String)type.GetProperty("licencia").GetValue(conductor);

                    txtCedula.Text = cedulaO;
                    txtNombre.Text = nombre;
                    txtApellido.Text = apellido;
                    txtEdad.Text = edad;
                    txtDireccion.Text = domicilio;
                    if (sexo=="Masculino")
                    {
                        rButtonMasculino.Checked = true;
                        rButtonFemenino.Checked = false;
                    }
                    if (sexo == "Femenino")
                    {
                        rButtonFemenino.Checked = true;
                        rButtonMasculino.Checked = false;
                    }
                    txtLicencia.Text = licencia;
                    txtCedula.Enabled = false;
                    btnGuardar.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            btnGuardar.Text = "Actualizar";
        }

        /// <summary>
        /// Permite Registrar o Actualizar un conductor
        /// </summary>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String msj = "";

            try
            {
                chofer.Cedula = txtCedula.Text;
                chofer.Nombre = txtNombre.Text;
                chofer.Apellido = txtApellido.Text;
                chofer.Edad = Int16.Parse(txtEdad.Text);
                chofer.Domicilio = txtDireccion.Text;
                if (rButtonFemenino.Checked.Equals(true))
                {
                    chofer.Sexo = rButtonFemenino.Text;
                }
                if (rButtonMasculino.Checked.Equals(true))
                {
                    chofer.Sexo = rButtonMasculino.Text;
                }
                chofer.Licencia = txtLicencia.Text;

                if (btnGuardar.Text == "Actualizar")
                {
                    btnGuardar.Text = "Guardar";
                    if (chofer.actualizar_x_cedula() == 1)
                    {
                        MessageBox.Show("Datos modificados exitosamente");
                        btnGuardar.Enabled = false;
                        txtCedula.Enabled = true;
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar");
                    }
                }
                else
                {
                    msj = chofer.registrar();
                    MessageBox.Show(msj);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Carga automaticamente un chofer registrado con la cedula ingresada
        /// </summary>
        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.TextLength == 10)
            {
                chofer.Cedula = txtCedula.Text;
                lstConductor=chofer.buscar(chofer.Cedula);
                if (lstConductor.Count == 0)
                {
                    btnGuardar.Enabled = true;
                }
                else if(lstConductor.Count == 1)
                {
                    try
                    {

                        foreach (var conductor in lstConductor)
                        {
                            Type type = conductor.GetType();

                            String cedula = (String)type.GetProperty("cedula").GetValue(conductor);
                            String nombre = (String)type.GetProperty("nombre").GetValue(conductor);
                            String apellido = (String)type.GetProperty("apellido").GetValue(conductor);
                            String edad = ((short)type.GetProperty("edad").GetValue(conductor)).ToString();
                            String domicilio = (String)type.GetProperty("domicilio").GetValue(conductor);
                            String sexo = (String)type.GetProperty("sexo").GetValue(conductor);
                            String licencia = (String)type.GetProperty("licencia").GetValue(conductor);

                            txtCedula.Text = cedula;
                            txtNombre.Text = nombre;
                            txtApellido.Text = apellido;
                            txtEdad.Text = edad;
                            txtDireccion.Text = domicilio;
                            if (sexo == "Masculino")
                            {
                                rButtonMasculino.Checked = true;
                            }
                            else
                            {
                                rButtonFemenino.Checked = true;
                            }
                            txtLicencia.Text = licencia;
                            btnGuardar.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                
            }else if(txtCedula.TextLength == 9)
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
                txtDireccion.Text = "";
                rButtonMasculino.Checked = false;
                rButtonFemenino.Checked = false;
                txtLicencia.Text = "";
                btnGuardar.Enabled = false;
            }
        }

        /// <summary>
        /// Limpia los campos de entrada de información
        /// </summary>
        private void limpiarCampos()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            rButtonMasculino.Checked = false;
            rButtonFemenino.Checked = false;
            txtLicencia.Text = "";
        }

        /// <summary>
        /// Abre una ventana nueva para visualizar todos los registros
        /// </summary>
        public void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConsultarConductores frmConsultar = new FrmConsultarConductores(chofer);
            frmConsultar.Show();
        }


        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodosAux.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodosAux.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodosAux.SoloLetras(e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodosAux.SoloNumeros(e);
        }

        private void txtLicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodosAux.SoloNumeros(e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rButtonFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Botón que limpia los campos de ingreso
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        /// <summary>
        /// Retroceder al menú principal
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
            
        }
    }
}
