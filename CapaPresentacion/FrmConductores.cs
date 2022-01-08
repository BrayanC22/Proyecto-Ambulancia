using System;
using CapaNegocio.Conductor;
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
        public FrmConductores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

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

                msj = chofer.registrar();
                MessageBox.Show(msj);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            chofer.eliminar(txtCedula.Text);
            limpiarCampos();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.TextLength == 10)
            {
                chofer.Cedula = txtCedula.Text;
                lstConductor=chofer.buscar(chofer.Cedula);
                
                try
                {

                    foreach (var o in lstConductor)
                    {
                        Type type = o.GetType();

                        String cedula = (String)type.GetProperty("cedula").GetValue(o);
                        String nombre = (String)type.GetProperty("nombre").GetValue(o);
                        String apellido = (String)type.GetProperty("apellido").GetValue(o);
                        String edad = ((short)type.GetProperty("edad").GetValue(o)).ToString();
                        String domicilio = (String)type.GetProperty("domicilio").GetValue(o);
                        String sexo = (String)type.GetProperty("sexo").GetValue(o);
                        String licencia = (String)type.GetProperty("licencia").GetValue(o);

                        // dgvUsuarios.Rows.Add(cedula, nombre, apellido, edad,
                        //  direccion, sexo, nacionalidad, rol, contraseña);
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
                        btnEliminar.Enabled = true;
                        lblEliminar.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
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
                btnEliminar.Enabled = false;
                lblEliminar.Enabled = false;
            }
        }

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
    }
}
