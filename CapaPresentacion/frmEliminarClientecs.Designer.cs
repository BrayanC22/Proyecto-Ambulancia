
namespace CapaPresentacion
{
    partial class frmEliminarClientecs
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
            this.btnregresar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_listarTodos = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.lblModuloConductores = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Gray;
            this.btnregresar.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnregresar.FlatAppearance.BorderSize = 0;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnregresar.Location = new System.Drawing.Point(27, 286);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(136, 43);
            this.btnregresar.TabIndex = 23;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Gray;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_eliminar.Location = new System.Drawing.Point(409, 329);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(120, 43);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "BORRAR";
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Gray;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnbuscar.Location = new System.Drawing.Point(560, 68);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(136, 43);
            this.btnbuscar.TabIndex = 21;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(409, 83);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(139, 20);
            this.txtcedula.TabIndex = 20;
            this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(212, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cédula a eliminar: ";
            // 
            // dgv_listarTodos
            // 
            this.dgv_listarTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.nombre,
            this.apellido,
            this.edad,
            this.domicilio,
            this.sexo,
            this.imagen,
            this.codigoCliente});
            this.dgv_listarTodos.Location = new System.Drawing.Point(207, 131);
            this.dgv_listarTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_listarTodos.Name = "dgv_listarTodos";
            this.dgv_listarTodos.ReadOnly = true;
            this.dgv_listarTodos.RowHeadersWidth = 51;
            this.dgv_listarTodos.RowTemplate.Height = 24;
            this.dgv_listarTodos.Size = new System.Drawing.Size(488, 181);
            this.dgv_listarTodos.TabIndex = 86;
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cédula";
            this.cedula.MinimumWidth = 6;
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 95;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombres";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellidos";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 125;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.MinimumWidth = 6;
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Width = 75;
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.MinimumWidth = 6;
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            this.domicilio.Width = 125;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.MinimumWidth = 6;
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 90;
            // 
            // imagen
            // 
            this.imagen.HeaderText = "Ruta de la imagen";
            this.imagen.MinimumWidth = 6;
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            this.imagen.Width = 130;
            // 
            // codigoCliente
            // 
            this.codigoCliente.HeaderText = "Codigo Cliente";
            this.codigoCliente.MinimumWidth = 6;
            this.codigoCliente.Name = "codigoCliente";
            this.codigoCliente.ReadOnly = true;
            this.codigoCliente.Width = 125;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(701, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 96;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Black;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimizar.IconSize = 25;
            this.btnMinimizar.Location = new System.Drawing.Point(665, -4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 95;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblModuloConductores
            // 
            this.lblModuloConductores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(75)))), ((int)(((byte)(56)))));
            this.lblModuloConductores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuloConductores.ForeColor = System.Drawing.Color.Black;
            this.lblModuloConductores.Location = new System.Drawing.Point(192, 29);
            this.lblModuloConductores.Name = "lblModuloConductores";
            this.lblModuloConductores.Size = new System.Drawing.Size(542, 30);
            this.lblModuloConductores.TabIndex = 94;
            this.lblModuloConductores.Text = "MÓDULO CLIENTE";
            this.lblModuloConductores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-1, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(734, 30);
            this.label5.TabIndex = 93;
            this.label5.Text = "Los Rápidos S.A.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnregresar);
            this.panel1.Location = new System.Drawing.Point(-2, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 414);
            this.panel1.TabIndex = 97;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = global::CapaPresentacion.Properties.Resources.job__1_;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 145);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(196, 49);
            this.btnRegistrar.TabIndex = 90;
            this.btnRegistrar.Text = "ELIMINAR ";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.ModuloClientes;
            this.pictureBox2.Location = new System.Drawing.Point(11, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // frmEliminarClientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lblModuloConductores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_listarTodos);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEliminarClientecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEliminarClientecs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_listarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCliente;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private System.Windows.Forms.Label lblModuloConductores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}