
namespace CapaPresentacion.Usuario
{
    partial class frmRegistrarUsuario
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ContenedorPrincipal = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.GroupRegistroUsuario = new System.Windows.Forms.GroupBox();
            this.lblSeguridad = new System.Windows.Forms.Label();
            this.lblPassIdenticas = new System.Windows.Forms.Label();
            this.lblNivelSeguridad = new System.Windows.Forms.Label();
            this.btnSeleccionarFoto = new System.Windows.Forms.Button();
            this.pboxPerfil = new System.Windows.Forms.PictureBox();
            this.txtConfirmaPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pboxFotoAdmin = new System.Windows.Forms.PictureBox();
            this.lblNombreAdmin = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rMasculino = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cboxCargo = new System.Windows.Forms.ComboBox();
            this.ContenedorPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GroupRegistroUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPerfil)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFotoAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Seleccionar...";
            // 
            // ContenedorPrincipal
            // 
            this.ContenedorPrincipal.Controls.Add(this.btnRegistrar);
            this.ContenedorPrincipal.Controls.Add(this.groupBox1);
            this.ContenedorPrincipal.Controls.Add(this.lblPassIdenticas);
            this.ContenedorPrincipal.Controls.Add(this.GroupRegistroUsuario);
            this.ContenedorPrincipal.Controls.Add(this.btnCerrar);
            this.ContenedorPrincipal.Controls.Add(this.btnMinimizar);
            this.ContenedorPrincipal.Controls.Add(this.label7);
            this.ContenedorPrincipal.Controls.Add(this.label10);
            this.ContenedorPrincipal.Controls.Add(this.panel1);
            this.ContenedorPrincipal.Controls.Add(this.btnLimpiar);
            this.ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ContenedorPrincipal.Name = "ContenedorPrincipal";
            this.ContenedorPrincipal.Size = new System.Drawing.Size(809, 438);
            this.ContenedorPrincipal.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxCargo);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rMasculino);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(237, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 266);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PERSONALES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.txtNombre.Location = new System.Drawing.Point(87, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.txtApellidos.Location = new System.Drawing.Point(87, 105);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(170, 23);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.White;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.txtCedula.Location = new System.Drawing.Point(87, 145);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(170, 23);
            this.txtCedula.TabIndex = 9;
            // 
            // GroupRegistroUsuario
            // 
            this.GroupRegistroUsuario.BackColor = System.Drawing.Color.Transparent;
            this.GroupRegistroUsuario.Controls.Add(this.btnSeleccionarFoto);
            this.GroupRegistroUsuario.Controls.Add(this.lblSeguridad);
            this.GroupRegistroUsuario.Controls.Add(this.lblNivelSeguridad);
            this.GroupRegistroUsuario.Controls.Add(this.txtConfirmaPass);
            this.GroupRegistroUsuario.Controls.Add(this.txtPass);
            this.GroupRegistroUsuario.Controls.Add(this.pboxPerfil);
            this.GroupRegistroUsuario.Controls.Add(this.txtUsuario);
            this.GroupRegistroUsuario.Controls.Add(this.label6);
            this.GroupRegistroUsuario.Controls.Add(this.label5);
            this.GroupRegistroUsuario.Controls.Add(this.label4);
            this.GroupRegistroUsuario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GroupRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupRegistroUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupRegistroUsuario.ForeColor = System.Drawing.Color.Black;
            this.GroupRegistroUsuario.Location = new System.Drawing.Point(515, 83);
            this.GroupRegistroUsuario.Name = "GroupRegistroUsuario";
            this.GroupRegistroUsuario.Size = new System.Drawing.Size(286, 266);
            this.GroupRegistroUsuario.TabIndex = 17;
            this.GroupRegistroUsuario.TabStop = false;
            this.GroupRegistroUsuario.Text = "DATOS DE CUENTA";
            // 
            // lblSeguridad
            // 
            this.lblSeguridad.Font = new System.Drawing.Font("Cambria", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguridad.ForeColor = System.Drawing.Color.Crimson;
            this.lblSeguridad.Location = new System.Drawing.Point(100, 219);
            this.lblSeguridad.Name = "lblSeguridad";
            this.lblSeguridad.Size = new System.Drawing.Size(170, 18);
            this.lblSeguridad.TabIndex = 18;
            this.lblSeguridad.Text = ".";
            // 
            // lblPassIdenticas
            // 
            this.lblPassIdenticas.AutoSize = true;
            this.lblPassIdenticas.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassIdenticas.Location = new System.Drawing.Point(370, 343);
            this.lblPassIdenticas.Name = "lblPassIdenticas";
            this.lblPassIdenticas.Size = new System.Drawing.Size(0, 12);
            this.lblPassIdenticas.TabIndex = 17;
            // 
            // lblNivelSeguridad
            // 
            this.lblNivelSeguridad.Location = new System.Drawing.Point(270, 198);
            this.lblNivelSeguridad.Name = "lblNivelSeguridad";
            this.lblNivelSeguridad.Size = new System.Drawing.Size(10, 16);
            this.lblNivelSeguridad.TabIndex = 15;
            // 
            // btnSeleccionarFoto
            // 
            this.btnSeleccionarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarFoto.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarFoto.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(86, 113);
            this.btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(124, 26);
            this.btnSeleccionarFoto.TabIndex = 14;
            this.btnSeleccionarFoto.Text = "FOTO DE PERFIL";
            this.btnSeleccionarFoto.UseVisualStyleBackColor = true;
            // 
            // pboxPerfil
            // 
            this.pboxPerfil.Location = new System.Drawing.Point(100, 23);
            this.pboxPerfil.Name = "pboxPerfil";
            this.pboxPerfil.Size = new System.Drawing.Size(96, 91);
            this.pboxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPerfil.TabIndex = 13;
            this.pboxPerfil.TabStop = false;
            // 
            // txtConfirmaPass
            // 
            this.txtConfirmaPass.BackColor = System.Drawing.Color.White;
            this.txtConfirmaPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmaPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmaPass.Enabled = false;
            this.txtConfirmaPass.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmaPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.txtConfirmaPass.Location = new System.Drawing.Point(100, 237);
            this.txtConfirmaPass.Name = "txtConfirmaPass";
            this.txtConfirmaPass.ReadOnly = true;
            this.txtConfirmaPass.Size = new System.Drawing.Size(170, 23);
            this.txtConfirmaPass.TabIndex = 12;
            this.txtConfirmaPass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.txtPass.Location = new System.Drawing.Point(100, 196);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(170, 23);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.txtUsuario.Location = new System.Drawing.Point(100, 156);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(170, 23);
            this.txtUsuario.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.Location = new System.Drawing.Point(304, 372);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 40);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "CONFIRMAR";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(776, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 16;
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
            this.btnMinimizar.Location = new System.Drawing.Point(741, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 15;
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
            this.label7.TabIndex = 13;
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
            this.label10.TabIndex = 10;
            this.label10.Text = "MÓDULO DE USUARIOS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblNombreAdmin);
            this.panel1.Controls.Add(this.pboxFotoAdmin);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 438);
            this.panel1.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(518, 372);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(200, 40);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "LIMPIAR DATOS";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = false;
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
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cargo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Género:";
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
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(0, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(232, 40);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "CONSULTAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 40);
            this.button2.TabIndex = 23;
            this.button2.Text = "REGISTRAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // rMasculino
            // 
            this.rMasculino.AutoSize = true;
            this.rMasculino.Location = new System.Drawing.Point(84, 217);
            this.rMasculino.Name = "rMasculino";
            this.rMasculino.Size = new System.Drawing.Size(99, 21);
            this.rMasculino.TabIndex = 13;
            this.rMasculino.TabStop = true;
            this.rMasculino.Text = "Masculino";
            this.rMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(179, 217);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 21);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Femenino";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // cboxCargo
            // 
            this.cboxCargo.FormattingEnabled = true;
            this.cboxCargo.Location = new System.Drawing.Point(87, 183);
            this.cboxCargo.Name = "cboxCargo";
            this.cboxCargo.Size = new System.Drawing.Size(170, 25);
            this.cboxCargo.TabIndex = 19;
            // 
            // frmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 438);
            this.Controls.Add(this.ContenedorPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR USUARIO";
            this.Shown += new System.EventHandler(this.frmRegistrarUsuario_Shown);
            this.ContenedorPrincipal.ResumeLayout(false);
            this.ContenedorPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupRegistroUsuario.ResumeLayout(false);
            this.GroupRegistroUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPerfil)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFotoAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel ContenedorPrincipal;
        private System.Windows.Forms.GroupBox GroupRegistroUsuario;
        private System.Windows.Forms.Label lblSeguridad;
        private System.Windows.Forms.Label lblPassIdenticas;
        private System.Windows.Forms.Label lblNivelSeguridad;
        private System.Windows.Forms.Button btnSeleccionarFoto;
        private System.Windows.Forms.PictureBox pboxPerfil;
        private System.Windows.Forms.TextBox txtConfirmaPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rMasculino;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNombreAdmin;
        private System.Windows.Forms.PictureBox pboxFotoAdmin;
        private System.Windows.Forms.ComboBox cboxCargo;
    }
}