
namespace CapaPresentacion
{
    partial class FrmConsultarConductores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarConductores));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.lblIngreseLicencia = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnaCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaLicencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(358, 358);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 27);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(465, 358);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 27);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(308, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(148, 23);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(142, 20);
            this.txtLicencia.TabIndex = 8;
            // 
            // lblIngreseLicencia
            // 
            this.lblIngreseLicencia.AutoSize = true;
            this.lblIngreseLicencia.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreseLicencia.Location = new System.Drawing.Point(40, 26);
            this.lblIngreseLicencia.Name = "lblIngreseLicencia";
            this.lblIngreseLicencia.Size = new System.Drawing.Size(95, 13);
            this.lblIngreseLicencia.TabIndex = 7;
            this.lblIngreseLicencia.Text = "Ingrese la licencia:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCedula,
            this.columnaNombre,
            this.columnaApellido,
            this.columnaDireccion,
            this.columnaLicencia});
            this.dataGridView1.Location = new System.Drawing.Point(43, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 274);
            this.dataGridView1.TabIndex = 6;
            // 
            // columnaCedula
            // 
            this.columnaCedula.HeaderText = "Cédula";
            this.columnaCedula.Name = "columnaCedula";
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            // 
            // columnaApellido
            // 
            this.columnaApellido.HeaderText = "Apellido";
            this.columnaApellido.Name = "columnaApellido";
            // 
            // columnaDireccion
            // 
            this.columnaDireccion.HeaderText = "Dirección";
            this.columnaDireccion.Name = "columnaDireccion";
            // 
            // columnaLicencia
            // 
            this.columnaLicencia.HeaderText = "Licencia";
            this.columnaLicencia.Name = "columnaLicencia";
            // 
            // FrmConsultarConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 404);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.lblIngreseLicencia);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmConsultarConductores";
            this.Text = "FrmConsultarConductores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.Label lblIngreseLicencia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaLicencia;
    }
}