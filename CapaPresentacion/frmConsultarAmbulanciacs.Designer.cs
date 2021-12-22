
namespace CapaPresentacion
{
    partial class frmConsultarAmbulanciacs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.dgv_listarTodos = new System.Windows.Forms.DataGridView();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAmbulancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaActivacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_todos = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtnunplaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxObservacion = new System.Windows.Forms.RichTextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAñoActivacion = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxTipoAmbulancia = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonactualizar.FlatAppearance.BorderSize = 0;
            this.buttonactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonactualizar.Location = new System.Drawing.Point(697, 280);
            this.buttonactualizar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(130, 25);
            this.buttonactualizar.TabIndex = 101;
            this.buttonactualizar.Text = "Actualizar Datos";
            this.buttonactualizar.UseVisualStyleBackColor = false;
            this.buttonactualizar.Click += new System.EventHandler(this.buttonactualizar_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Transparent;
            this.btnregresar.FlatAppearance.BorderSize = 0;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Location = new System.Drawing.Point(697, 339);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(130, 29);
            this.btnregresar.TabIndex = 79;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // dgv_listarTodos
            // 
            this.dgv_listarTodos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listarTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelo,
            this.tipoAmbulancia,
            this.placa,
            this.matricula,
            this.fechaActivacion,
            this.estado,
            this.observacion});
            this.dgv_listarTodos.Location = new System.Drawing.Point(10, 65);
            this.dgv_listarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_listarTodos.Name = "dgv_listarTodos";
            this.dgv_listarTodos.ReadOnly = true;
            this.dgv_listarTodos.RowHeadersWidth = 51;
            this.dgv_listarTodos.RowTemplate.Height = 24;
            this.dgv_listarTodos.Size = new System.Drawing.Size(847, 175);
            this.dgv_listarTodos.TabIndex = 78;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 130;
            // 
            // tipoAmbulancia
            // 
            this.tipoAmbulancia.HeaderText = "Tipo Ambulancia";
            this.tipoAmbulancia.Name = "tipoAmbulancia";
            this.tipoAmbulancia.ReadOnly = true;
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // fechaActivacion
            // 
            this.fechaActivacion.HeaderText = "Año de Activacion";
            this.fechaActivacion.Name = "fechaActivacion";
            this.fechaActivacion.ReadOnly = true;
            this.fechaActivacion.Width = 80;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // observacion
            // 
            this.observacion.HeaderText = "Observacion";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Width = 180;
            // 
            // btn_todos
            // 
            this.btn_todos.BackColor = System.Drawing.Color.Transparent;
            this.btn_todos.FlatAppearance.BorderSize = 0;
            this.btn_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todos.Location = new System.Drawing.Point(722, 29);
            this.btn_todos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(130, 24);
            this.btn_todos.TabIndex = 77;
            this.btn_todos.Text = "Mostrar Todos";
            this.btn_todos.UseVisualStyleBackColor = false;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Location = new System.Drawing.Point(516, 23);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(57, 25);
            this.btnbuscar.TabIndex = 76;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtnunplaca
            // 
            this.txtnunplaca.Location = new System.Drawing.Point(384, 26);
            this.txtnunplaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtnunplaca.MaxLength = 8;
            this.txtnunplaca.Name = "txtnunplaca";
            this.txtnunplaca.Size = new System.Drawing.Size(128, 20);
            this.txtnunplaca.TabIndex = 75;
            this.txtnunplaca.TextChanged += new System.EventHandler(this.txtnunplaca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(289, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Ingrese su placa: ";
            // 
            // richTextBoxObservacion
            // 
            this.richTextBoxObservacion.Location = new System.Drawing.Point(527, 320);
            this.richTextBoxObservacion.Name = "richTextBoxObservacion";
            this.richTextBoxObservacion.Size = new System.Drawing.Size(121, 48);
            this.richTextBoxObservacion.TabIndex = 115;
            this.richTextBoxObservacion.Text = "";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(274, 348);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(121, 20);
            this.txtMatricula.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(419, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 110;
            this.label8.Text = "Observacion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(418, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 109;
            this.label7.Text = "Estado:";
            // 
            // txtAñoActivacion
            // 
            this.txtAñoActivacion.Location = new System.Drawing.Point(527, 262);
            this.txtAñoActivacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtAñoActivacion.Name = "txtAñoActivacion";
            this.txtAñoActivacion.Size = new System.Drawing.Size(121, 20);
            this.txtAñoActivacion.TabIndex = 108;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(274, 320);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(121, 20);
            this.txtplaca.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(418, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Año de Activacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(165, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Matricula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(165, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(165, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Tipo Ambulancia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(165, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Modelo:";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(274, 258);
            this.textBoxModelo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(121, 20);
            this.textBoxModelo.TabIndex = 116;
            // 
            // textBoxTipoAmbulancia
            // 
            this.textBoxTipoAmbulancia.Location = new System.Drawing.Point(274, 288);
            this.textBoxTipoAmbulancia.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTipoAmbulancia.Name = "textBoxTipoAmbulancia";
            this.textBoxTipoAmbulancia.Size = new System.Drawing.Size(121, 20);
            this.textBoxTipoAmbulancia.TabIndex = 117;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(527, 292);
            this.textBoxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(121, 20);
            this.textBoxEstado.TabIndex = 118;
            // 
            // frmConsultarAmbulanciacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(863, 411);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxTipoAmbulancia);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.richTextBoxObservacion);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAñoActivacion);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonactualizar);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.dgv_listarTodos);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtnunplaca);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultarAmbulanciacs";
            this.Text = "frmConsultarAmbulanciacs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.DataGridView dgv_listarTodos;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtnunplaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxObservacion;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAñoActivacion;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxTipoAmbulancia;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAmbulancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaActivacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
    }
}