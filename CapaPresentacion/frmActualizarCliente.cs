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
    public partial class frmActualizarCliente : Form
    {
        String idnumero;
        String rutaimagen="";
        List<Object> lst_cliente_tmp;
        ClsCliente cliente = new ClsCliente();



        public frmActualizarCliente()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public frmActualizarCliente(string idnumero, ClsCliente cliente)
        {
            InitializeComponent();
            txtcedula.Enabled = false;
            txtnumcliente.Text = idnumero;
            this.cliente = cliente;
            this.idnumero = idnumero;
            obtenerDatos();
            txtnumcliente.Enabled = false;
            txtsexo.Enabled = false;

        }

        private void obtenerDatos()
        {
            List<Object> lst_cliente = cliente.listar();
            foreach (var clie in lst_cliente)
            {
                System.Type type = clie.GetType();
                Int16 Numerocliente = (Int16)type.GetProperty("Id_Cliente").GetValue(clie);
                if (int.Parse(this.idnumero) == Numerocliente)
                {

                    txtcedula.Text = (String)type.GetProperty("cedula").GetValue(clie);
                    txtnombres.Text = (String)type.GetProperty("nombre").GetValue(clie);
                    txtapellidos.Text = (String)type.GetProperty("apellido").GetValue(clie);
                    txtdireccion.Text = (String)type.GetProperty("domicilio").GetValue(clie);
                    //txtedad.Text = (String)type.GetProperty("edad").GetValue(clie);

                    txtsexo.Text = (String)type.GetProperty("sexo").GetValue(clie);
                    textCC.Text = (String)type.GetProperty("codigoCliente").GetValue(clie);
                    txtimagenruta.Text =(String)type.GetProperty("imagen").GetValue(clie);
                    this.rutaimagen = txtimagenruta.Text;
                    pictureBox1.Image = Image.FromFile(rutaimagen);
                }
            }
        }



        private void buttonActualizarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = cliente.actualizar_x_cedula(txtcedula.Text, txtnombres.Text, txtapellidos.Text, txtedad.Text, txtdireccion.Text, txtsexo.Text, this.rutaimagen, textCC.Text);
                MessageBox.Show("Los datos se actualizon correctamente");
                this.Hide();
                frmConsultarCliente cons = new frmConsultarCliente(cliente);
                cons.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la actualizacion verifique que los datos de matricula o placa no esten duplicados");
            }
        }

        private void buttonCargarImagen_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String imagen = openFileDialog1.FileName;
                    this.rutaimagen = imagen;
                    pictureBox1.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo no es un tipo de imagen valido");
            }
        }
    }
}