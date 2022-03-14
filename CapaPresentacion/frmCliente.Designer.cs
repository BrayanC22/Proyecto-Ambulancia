
namespace CapaPresentacion
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.textCC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCargarImagen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txtconsultar = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.cmdregistrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblModuloConductores = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCC
            // 
            this.textCC.Location = new System.Drawing.Point(504, 365);
            this.textCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCC.MaxLength = 3;
            this.textCC.Name = "textCC";
            this.textCC.Size = new System.Drawing.Size(57, 22);
            this.textCC.TabIndex = 80;
            this.textCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCC_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(281, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 26);
            this.label9.TabIndex = 79;
            this.label9.Text = "Codigo Cliente:";
            // 
            // buttonCargarImagen
            // 
            this.buttonCargarImagen.BackColor = System.Drawing.Color.Transparent;
            this.buttonCargarImagen.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.buttonCargarImagen.FlatAppearance.BorderSize = 0;
            this.buttonCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargarImagen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarImagen.Location = new System.Drawing.Point(747, 248);
            this.buttonCargarImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCargarImagen.Name = "buttonCargarImagen";
            this.buttonCargarImagen.Size = new System.Drawing.Size(191, 44);
            this.buttonCargarImagen.TabIndex = 78;
            this.buttonCargarImagen.Text = "Cargar Imagen";
            this.buttonCargarImagen.UseVisualStyleBackColor = false;
            this.buttonCargarImagen.Click += new System.EventHandler(this.buttonCargarImagen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(747, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(281, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 26);
            this.label8.TabIndex = 76;
            this.label8.Text = "Sexo:";
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFemenino.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemenino.Location = new System.Drawing.Point(576, 273);
            this.radioButtonFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(128, 31);
            this.radioButtonFemenino.TabIndex = 75;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = false;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMasculino.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMasculino.Location = new System.Drawing.Point(402, 276);
            this.radioButtonMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(133, 31);
            this.radioButtonMasculino.TabIndex = 74;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = false;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Gray;
            this.btn_regresar.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(36, 396);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(174, 56);
            this.btn_regresar.TabIndex = 73;
            this.btn_regresar.Text = "REGRESAR ";
            this.btn_regresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Image = global::CapaPresentacion.Properties.Resources.data_analytics__1_;
            this.btn_eliminar.Location = new System.Drawing.Point(7, 283);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(256, 68);
            this.btn_eliminar.TabIndex = 72;
            this.btn_eliminar.Text = "ELIMINAR           ";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txtconsultar
            // 
            this.txtconsultar.BackColor = System.Drawing.Color.Transparent;
            this.txtconsultar.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.txtconsultar.FlatAppearance.BorderSize = 0;
            this.txtconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtconsultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconsultar.Image = global::CapaPresentacion.Properties.Resources.output_onlinepngtools__2___1_;
            this.txtconsultar.Location = new System.Drawing.Point(3, 201);
            this.txtconsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtconsultar.Name = "txtconsultar";
            this.txtconsultar.Size = new System.Drawing.Size(260, 70);
            this.txtconsultar.TabIndex = 71;
            this.txtconsultar.Text = "  CONSULTAR";
            this.txtconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.txtconsultar.UseVisualStyleBackColor = false;
            this.txtconsultar.Click += new System.EventHandler(this.txtconsultar_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(439, 244);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(193, 22);
            this.txtdireccion.TabIndex = 68;
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress);
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(504, 323);
            this.txtedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtedad.MaxLength = 3;
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(57, 22);
            this.txtedad.TabIndex = 67;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(439, 187);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(193, 22);
            this.txtapellidos.TabIndex = 66;
            this.txtapellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidos_KeyPress);
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(439, 143);
            this.txtnombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(193, 22);
            this.txtnombres.TabIndex = 65;
            this.txtnombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombres_KeyPress);
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(439, 101);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcedula.MaxLength = 10;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(193, 22);
            this.txtcedula.TabIndex = 64;
            this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // cmdregistrar
            // 
            this.cmdregistrar.BackColor = System.Drawing.Color.Gray;
            this.cmdregistrar.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.cmdregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdregistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdregistrar.Image = global::CapaPresentacion.Properties.Resources.floppy_disk__2_;
            this.cmdregistrar.Location = new System.Drawing.Point(544, 432);
            this.cmdregistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdregistrar.Name = "cmdregistrar";
            this.cmdregistrar.Size = new System.Drawing.Size(223, 56);
            this.cmdregistrar.TabIndex = 70;
            this.cmdregistrar.Text = "GUARDAR";
            this.cmdregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmdregistrar.UseVisualStyleBackColor = false;
            this.cmdregistrar.Click += new System.EventHandler(this.cmdregistrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(277, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 26);
            this.label6.TabIndex = 63;
            this.label6.Text = "Domicilio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(281, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 62;
            this.label4.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(277, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 61;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(277, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 59;
            this.label1.Text = "Cédula: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-1, -1);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(979, 37);
            this.label5.TabIndex = 87;
            this.label5.Text = "Los Rápidos S.A.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModuloConductores
            // 
            this.lblModuloConductores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblModuloConductores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuloConductores.ForeColor = System.Drawing.Color.Black;
            this.lblModuloConductores.Location = new System.Drawing.Point(256, 36);
            this.lblModuloConductores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuloConductores.Name = "lblModuloConductores";
            this.lblModuloConductores.Size = new System.Drawing.Size(722, 37);
            this.lblModuloConductores.TabIndex = 88;
            this.lblModuloConductores.Text = "MÓDULO CLIENTE";
            this.lblModuloConductores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtconsultar);
            this.panel1.Controls.Add(this.btn_regresar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Location = new System.Drawing.Point(-4, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 481);
            this.panel1.TabIndex = 89;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = global::CapaPresentacion.Properties.Resources.add__1_;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 129);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(263, 60);
            this.btnRegistrar.TabIndex = 90;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(935, -1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 37);
            this.btnCerrar.TabIndex = 92;
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
            this.btnMinimizar.Location = new System.Drawing.Point(887, -5);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 37);
            this.btnMinimizar.TabIndex = 91;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 516);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.cmdregistrar);
            this.Controls.Add(this.lblModuloConductores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonCargarImagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButtonFemenino);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCargarImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button txtconsultar;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Button cmdregistrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblModuloConductores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
    }
}