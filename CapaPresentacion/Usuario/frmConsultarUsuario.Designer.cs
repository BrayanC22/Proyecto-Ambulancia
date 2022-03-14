
namespace CapaPresentacion.Usuario
{
    partial class frmConsultarUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblIngreseCedula = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNombreAdmin = new System.Windows.Forms.Label();
            this.pboxFotoAdmin = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFotoAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.dgv_Usuarios);
            this.panel1.Controls.Add(this.btnVerTodos);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.lblIngreseCedula);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 438);
            this.panel1.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gray;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(349, 358);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 39);
            this.btnModificar.TabIndex = 98;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gray;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(527, 358);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 39);
            this.btnEliminar.TabIndex = 97;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AllowUserToAddRows = false;
            this.dgv_Usuarios.AllowUserToDeleteRows = false;
            this.dgv_Usuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreUsuario,
            this.Cedula,
            this.Nombre,
            this.Cargo});
            this.dgv_Usuarios.Location = new System.Drawing.Point(236, 143);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            this.dgv_Usuarios.Size = new System.Drawing.Size(570, 192);
            this.dgv_Usuarios.TabIndex = 96;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "Usuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.Color.Gray;
            this.btnVerTodos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVerTodos.FlatAppearance.BorderSize = 0;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.Image = global::CapaPresentacion.Properties.Resources.all__1_;
            this.btnVerTodos.Location = new System.Drawing.Point(674, 79);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(100, 39);
            this.btnVerTodos.TabIndex = 95;
            this.btnVerTodos.Text = "Todos";
            this.btnVerTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVerTodos.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.job__1_;
            this.btnBuscar.Location = new System.Drawing.Point(557, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 39);
            this.btnBuscar.TabIndex = 94;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(394, 90);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(142, 20);
            this.txtUsuario.TabIndex = 93;
            // 
            // lblIngreseCedula
            // 
            this.lblIngreseCedula.AutoSize = true;
            this.lblIngreseCedula.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreseCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseCedula.Location = new System.Drawing.Point(241, 92);
            this.lblIngreseCedula.Name = "lblIngreseCedula";
            this.lblIngreseCedula.Size = new System.Drawing.Size(147, 17);
            this.lblIngreseCedula.TabIndex = 92;
            this.lblIngreseCedula.Text = "Nombre de usuario";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(779, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Black;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimizar.IconSize = 25;
            this.btnMinimizar.Location = new System.Drawing.Point(744, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(809, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "Los Rápidos S.A.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(75)))), ((int)(((byte)(56)))));
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(232, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(577, 35);
            this.label10.TabIndex = 18;
            this.label10.Text = "MÓDULO DE USUARIOS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblNombreAdmin);
            this.panel2.Controls.Add(this.pboxFotoAdmin);
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 438);
            this.panel2.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 40);
            this.button2.TabIndex = 23;
            this.button2.Text = "REGISTRAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(0, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(232, 40);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "CONSULTAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(106, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 38);
            this.label11.TabIndex = 21;
            this.label11.Text = "Administrador";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreAdmin
            // 
            this.lblNombreAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAdmin.ForeColor = System.Drawing.Color.White;
            this.lblNombreAdmin.Location = new System.Drawing.Point(106, 44);
            this.lblNombreAdmin.Name = "lblNombreAdmin";
            this.lblNombreAdmin.Size = new System.Drawing.Size(107, 60);
            this.lblNombreAdmin.TabIndex = 20;
            this.lblNombreAdmin.Text = "YERMIN LINO SANCHEZ";
            this.lblNombreAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pboxFotoAdmin
            // 
            this.pboxFotoAdmin.Location = new System.Drawing.Point(12, 44);
            this.pboxFotoAdmin.Name = "pboxFotoAdmin";
            this.pboxFotoAdmin.Size = new System.Drawing.Size(90, 98);
            this.pboxFotoAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFotoAdmin.TabIndex = 19;
            this.pboxFotoAdmin.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.Location = new System.Drawing.Point(12, 372);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(200, 40);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "REGRESAR";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 438);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR USUARIO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFotoAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNombreAdmin;
        private System.Windows.Forms.PictureBox pboxFotoAdmin;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblIngreseCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
    }
}