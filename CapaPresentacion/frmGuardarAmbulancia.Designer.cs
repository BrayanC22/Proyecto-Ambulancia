
namespace CapaPresentacion
{
    partial class frmGuardarAmbulancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuardarAmbulancia));
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModelo = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblModuloConductores = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtconsultar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.cmdregistrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(363, 197);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtplaca.MaxLength = 8;
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(145, 20);
            this.txtplaca.TabIndex = 36;
            this.toolTip1.SetToolTip(this.txtplaca, "Verifique que su placa no se repita");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Matricula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tipo Ambulancia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Modelo:";
            // 
            // comboBoxModelo
            // 
            this.comboBoxModelo.FormattingEnabled = true;
            this.comboBoxModelo.Items.AddRange(new object[] {
            "Dodge Ram 4000",
            "Chevrolet Silverado 3500",
            "Chevrolet Heavy Duty",
            "Ford F-350",
            "Ford F-550"});
            this.comboBoxModelo.Location = new System.Drawing.Point(363, 124);
            this.comboBoxModelo.Name = "comboBoxModelo";
            this.comboBoxModelo.Size = new System.Drawing.Size(145, 21);
            this.comboBoxModelo.TabIndex = 55;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Asistenciales",
            "No asistenciales"});
            this.comboBoxTipo.Location = new System.Drawing.Point(363, 162);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(145, 21);
            this.comboBoxTipo.TabIndex = 56;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(363, 232);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricula.MaxLength = 8;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(145, 20);
            this.txtMatricula.TabIndex = 57;
            this.toolTip1.SetToolTip(this.txtMatricula, "Verifique que su matricula no se repita");
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.White;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.btn_regresar.Location = new System.Drawing.Point(26, 275);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(129, 46);
            this.btn_regresar.TabIndex = 45;
            this.btn_regresar.Text = "REGRESAR";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(734, 30);
            this.label5.TabIndex = 148;
            this.label5.Text = "Los Rápidos S.A.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModuloConductores
            // 
            this.lblModuloConductores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(75)))), ((int)(((byte)(56)))));
            this.lblModuloConductores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuloConductores.ForeColor = System.Drawing.Color.Black;
            this.lblModuloConductores.Location = new System.Drawing.Point(193, 29);
            this.lblModuloConductores.Name = "lblModuloConductores";
            this.lblModuloConductores.Size = new System.Drawing.Size(542, 30);
            this.lblModuloConductores.TabIndex = 151;
            this.lblModuloConductores.Text = "MÓDULO AMBULANCIA";
            this.lblModuloConductores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.txtconsultar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_regresar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-2, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 399);
            this.panel1.TabIndex = 152;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = global::CapaPresentacion.Properties.Resources.add__1_;
            this.btnRegistrar.Location = new System.Drawing.Point(5, 95);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(197, 49);
            this.btnRegistrar.TabIndex = 90;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtconsultar
            // 
            this.txtconsultar.BackColor = System.Drawing.Color.Transparent;
            this.txtconsultar.FlatAppearance.BorderSize = 0;
            this.txtconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtconsultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtconsultar.ForeColor = System.Drawing.Color.White;
            this.txtconsultar.Image = global::CapaPresentacion.Properties.Resources.output_onlinepngtools__2___1_;
            this.txtconsultar.Location = new System.Drawing.Point(0, 145);
            this.txtconsultar.Margin = new System.Windows.Forms.Padding(2);
            this.txtconsultar.Name = "txtconsultar";
            this.txtconsultar.Size = new System.Drawing.Size(196, 54);
            this.txtconsultar.TabIndex = 43;
            this.txtconsultar.Text = "CONSULTAR";
            this.txtconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.txtconsultar.UseVisualStyleBackColor = false;
            this.txtconsultar.Click += new System.EventHandler(this.txtconsultar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Image = global::CapaPresentacion.Properties.Resources.BorrarDatos;
            this.btn_eliminar.Location = new System.Drawing.Point(-2, 203);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(194, 51);
            this.btn_eliminar.TabIndex = 44;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(702, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 150;
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
            this.btnMinimizar.Location = new System.Drawing.Point(666, -4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 149;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // cmdregistrar
            // 
            this.cmdregistrar.BackColor = System.Drawing.Color.Gray;
            this.cmdregistrar.FlatAppearance.BorderSize = 0;
            this.cmdregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdregistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cmdregistrar.Image = global::CapaPresentacion.Properties.Resources.floppy_disk__2_;
            this.cmdregistrar.Location = new System.Drawing.Point(363, 294);
            this.cmdregistrar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdregistrar.Name = "cmdregistrar";
            this.cmdregistrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdregistrar.Size = new System.Drawing.Size(164, 46);
            this.cmdregistrar.TabIndex = 41;
            this.cmdregistrar.Text = "GUARDAR";
            this.cmdregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdregistrar.UseVisualStyleBackColor = false;
            this.cmdregistrar.Click += new System.EventHandler(this.cmdregistrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.ModuloAmbulancia;
            this.pictureBox2.Location = new System.Drawing.Point(26, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 153;
            this.pictureBox2.TabStop = false;
            // 
            // frmGuardarAmbulancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(732, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblModuloConductores);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.comboBoxModelo);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.cmdregistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGuardarAmbulancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGuardarAmbulancia";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button txtconsultar;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Button cmdregistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModelo;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblModuloConductores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}