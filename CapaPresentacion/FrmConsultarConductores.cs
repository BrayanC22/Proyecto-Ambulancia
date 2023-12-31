﻿using CapaNegocio;
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
        FrmConductores frmRegistrar = new FrmConductores();
        List<Object> lst_conductor_tmp;
        frmCliente metodosAux = new frmCliente(); //para llamar a los metodos 'SoloNumeros' y 'SoloLetras'


        /// <summary>
        /// Constructor para listar todos los conductores
        /// </summary>
        public FrmConsultarConductores(ClsConductores chofer)
        {
            InitializeComponent();
            this.chofer = chofer;
            this.lst_conductor_tmp = chofer.listar();
            llenar_datagridview_conductores();
        }

        /// <summary>
        /// Llena la tabla con los datos solicitados, sean uno o mas conductores.
        /// </summary>
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


        /// <summary>
        /// Regresa al menu principal
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();

        }

        /// <summary>
        /// Carga todos los conductores registrados
        /// </summary>
        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            this.lst_conductor_tmp = chofer.listar();
            llenar_datagridview_conductores();
        }

        /// <summary>
        /// Busca un conductor con la cedula especificada
        /// </summary>
        public void btnBuscar_Click(object sender, EventArgs e)
        {
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();

            if (txtCedula.TextLength == 10)
            {
                chofer.Cedula = txtCedula.Text;
                lst_conductor_tmp = chofer.buscar(chofer.Cedula);
                if (lst_conductor_tmp.Count == 0)
                {
                    MessageBox.Show("Cédula no registrada");
                }
                else
                {

                    try
                    {

                        foreach (var conductor in lst_conductor_tmp)
                        {
                            Type type = conductor.GetType();

                            String cedula = (String)type.GetProperty("cedula").GetValue(conductor);
                            String nombre = (String)type.GetProperty("nombre").GetValue(conductor);
                            String apellido = (String)type.GetProperty("apellido").GetValue(conductor);
                            String edad = ((short)type.GetProperty("edad").GetValue(conductor)).ToString();
                            String domicilio = (String)type.GetProperty("domicilio").GetValue(conductor);
                            String sexo = (String)type.GetProperty("sexo").GetValue(conductor);
                            String licencia = (String)type.GetProperty("licencia").GetValue(conductor);

                            dgv_listarTodos.Rows.Add(cedula, nombre, apellido, edad, domicilio, sexo, licencia);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                
            }
            else
            {
                MessageBox.Show("Faltan caracteres");
            }
           
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodosAux.SoloNumeros(e);
        }

        private void lblIngreseCedula_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Boton para ir al formulario de ingreso
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrar.Show();
        }

        /// <summary>
        /// Regresa a la ventana de ingreso de conductores pero con opciones especiales para modificar
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnModificar.Enabled = false;
            String cedula = (dgv_listarTodos.CurrentRow.Cells[0].Value.ToString());
            FrmConductores form1 = new FrmConductores(cedula);
            form1.Show();
            
            
        }

        /// <summary>
        /// Elimina el conductor seleccionado
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String cedula = (dgv_listarTodos.CurrentRow.Cells[0].Value.ToString());
            chofer.eliminar(cedula);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
