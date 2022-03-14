
namespace CapaPresentacion
{
    partial class frmActualizarAmbulancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarAmbulancia));
            this.buttonActualizarCambios = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModelo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxnumambuancia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblModuloConductores = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonActualizarCambios
            // 
            this.buttonActualizarCambios.BackColor = System.Drawing.Color.Transparent;
            this.buttonActualizarCambios.FlatAppearance.BorderSize = 0;
            this.buttonActualizarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarCambios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.buttonActualizarCambios.ForeColor = System.Drawing.Color.Black;
            this.buttonActualizarCambios.Image = global::CapaPresentacion.Properties.Resources.confirmarambulancia;
            this.buttonActualizarCambios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonActualizarCambios.Location = new System.Drawing.Point(540, 338);
            this.buttonActualizarCambios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActualizarCambios.Name = "buttonActualizarCambios";
            this.buttonActualizarCambios.Size = new System.Drawing.Size(238, 126);
            this.buttonActualizarCambios.TabIndex = 124;
            this.buttonActualizarCambios.Text = "Confirmar Cambios";
            this.buttonActualizarCambios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonActualizarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonActualizarCambios.UseVisualStyleBackColor = false;
            this.buttonActualizarCambios.Click += new System.EventHandler(this.buttonActualizarCambios_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(624, 283);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatricula.MaxLength = 8;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(192, 22);
            this.txtMatricula.TabIndex = 144;
            this.toolTip1.SetToolTip(this.txtMatricula, "Verifique que su matricula no exista");
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Asistenciales",
            "No asistenciales"});
            this.comboBoxTipo.Location = new System.Drawing.Point(624, 201);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(192, 24);
            this.comboBoxTipo.TabIndex = 143;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(624, 244);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtplaca.MaxLength = 8;
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(192, 22);
            this.txtplaca.TabIndex = 141;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 140;
            this.label4.Text = "Matricula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 139;
            this.label3.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 138;
            this.label2.Text = "Tipo Ambulancia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 137;
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
            this.comboBoxModelo.Location = new System.Drawing.Point(624, 160);
            this.comboBoxModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxModelo.Name = "comboBoxModelo";
            this.comboBoxModelo.Size = new System.Drawing.Size(192, 24);
            this.comboBoxModelo.TabIndex = 145;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxnumambuancia
            // 
            this.textBoxnumambuancia.Location = new System.Drawing.Point(624, 118);
            this.textBoxnumambuancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnumambuancia.MaxLength = 8;
            this.textBoxnumambuancia.Name = "textBoxnumambuancia";
            this.textBoxnumambuancia.Size = new System.Drawing.Size(192, 22);
            this.textBoxnumambuancia.TabIndex = 149;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 148;
            this.label6.Text = "Numero-Amb";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(938, -2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 37);
            this.btnCerrar.TabIndex = 155;
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
            this.btnMinimizar.Location = new System.Drawing.Point(890, -6);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 37);
            this.btnMinimizar.TabIndex = 154;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-1, -2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(982, 37);
            this.label5.TabIndex = 153;
            this.label5.Text = "Los Rápidos S.A.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModuloConductores
            // 
            this.lblModuloConductores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblModuloConductores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuloConductores.ForeColor = System.Drawing.Color.Black;
            this.lblModuloConductores.Location = new System.Drawing.Point(259, 35);
            this.lblModuloConductores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuloConductores.Name = "lblModuloConductores";
            this.lblModuloConductores.Size = new System.Drawing.Size(722, 37);
            this.lblModuloConductores.TabIndex = 156;
            this.lblModuloConductores.Text = "MÓDULO AMBULANCIA";
            this.lblModuloConductores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-6, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 443);
            this.panel1.TabIndex = 157;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = global::CapaPresentacion.Properties.Resources.add__1_;
            this.btnRegistrar.Location = new System.Drawing.Point(9, 186);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(275, 60);
            this.btnRegistrar.TabIndex = 90;
            this.btnRegistrar.Text = "ACTUALIZAR";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // frmActualizarAmbulancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblModuloConductores);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxnumambuancia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxModelo);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonActualizarCambios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmActualizarAmbulancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActualizarAmbulancia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonActualizarCambios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtMatricula;
        public System.Windows.Forms.ComboBox comboBoxTipo;
        public System.Windows.Forms.TextBox txtplaca;
        public System.Windows.Forms.ComboBox comboBoxModelo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBoxnumambuancia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblModuloConductores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrar;
    }
}