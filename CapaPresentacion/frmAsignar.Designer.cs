
namespace CapaPresentacion
{
    partial class frmAsignar
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
            this.dgv_listarTodos = new System.Windows.Forms.DataGridView();
            this.id_ambulancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAmbulancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtnunplaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumAmbulanciaR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdregistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listarTodos
            // 
            this.dgv_listarTodos.AllowUserToAddRows = false;
            this.dgv_listarTodos.AllowUserToDeleteRows = false;
            this.dgv_listarTodos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listarTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ambulancia,
            this.modelo,
            this.tipoAmbulancia,
            this.placa,
            this.matricula});
            this.dgv_listarTodos.Location = new System.Drawing.Point(21, 96);
            this.dgv_listarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_listarTodos.Name = "dgv_listarTodos";
            this.dgv_listarTodos.ReadOnly = true;
            this.dgv_listarTodos.RowHeadersWidth = 51;
            this.dgv_listarTodos.RowTemplate.Height = 24;
            this.dgv_listarTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listarTodos.Size = new System.Drawing.Size(603, 93);
            this.dgv_listarTodos.TabIndex = 82;
            // 
            // id_ambulancia
            // 
            this.id_ambulancia.HeaderText = "Numero Ambulancia";
            this.id_ambulancia.Name = "id_ambulancia";
            this.id_ambulancia.ReadOnly = true;
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
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Location = new System.Drawing.Point(386, 58);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(57, 25);
            this.btnbuscar.TabIndex = 81;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // txtnunplaca
            // 
            this.txtnunplaca.Location = new System.Drawing.Point(254, 63);
            this.txtnunplaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtnunplaca.MaxLength = 8;
            this.txtnunplaca.Name = "txtnunplaca";
            this.txtnunplaca.Size = new System.Drawing.Size(128, 20);
            this.txtnunplaca.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(159, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Ingrese su placa: ";
            // 
            // NumAmbulanciaR
            // 
            this.NumAmbulanciaR.Location = new System.Drawing.Point(657, 141);
            this.NumAmbulanciaR.Margin = new System.Windows.Forms.Padding(2);
            this.NumAmbulanciaR.MaxLength = 8;
            this.NumAmbulanciaR.Name = "NumAmbulanciaR";
            this.NumAmbulanciaR.Size = new System.Drawing.Size(88, 20);
            this.NumAmbulanciaR.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(642, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Numero de Ambulancia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(323, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "ASIGNAR AMBULANCIAS";
            // 
            // cmdregistrar
            // 
            this.cmdregistrar.BackColor = System.Drawing.Color.Transparent;
            this.cmdregistrar.FlatAppearance.BorderSize = 0;
            this.cmdregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdregistrar.Image = global::CapaPresentacion.Properties.Resources.guardar2;
            this.cmdregistrar.Location = new System.Drawing.Point(367, 424);
            this.cmdregistrar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdregistrar.Name = "cmdregistrar";
            this.cmdregistrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdregistrar.Size = new System.Drawing.Size(76, 56);
            this.cmdregistrar.TabIndex = 86;
            this.cmdregistrar.Text = "Registrar";
            this.cmdregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdregistrar.UseVisualStyleBackColor = false;
            this.cmdregistrar.Click += new System.EventHandler(this.cmdregistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(274, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "ASIGNAR CONDUCTORES";
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Transparent;
            this.btnregresar.FlatAppearance.BorderSize = 0;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Location = new System.Drawing.Point(632, 439);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(130, 29);
            this.btnregresar.TabIndex = 88;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // frmAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 520);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdregistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumAmbulanciaR);
            this.Controls.Add(this.dgv_listarTodos);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtnunplaca);
            this.Controls.Add(this.label1);
            this.Name = "frmAsignar";
            this.Text = "frmAsignar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ambulancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAmbulancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtnunplaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumAmbulanciaR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdregistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnregresar;
    }
}