
namespace SGClubRaquetaSNL
{
    partial class Form_Reservas
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
            this.lblEligeSocio = new System.Windows.Forms.Label();
            this.cbSocio = new System.Windows.Forms.ComboBox();
            this.lblDniSocio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.mtbCCC = new System.Windows.Forms.MaskedTextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCCC = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.labelDniSocio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.nupMinutos = new System.Windows.Forms.NumericUpDown();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.nupHora = new System.Windows.Forms.NumericUpDown();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cbPista = new System.Windows.Forms.ComboBox();
            this.lblPista = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHora)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEligeSocio
            // 
            this.lblEligeSocio.AutoSize = true;
            this.lblEligeSocio.Location = new System.Drawing.Point(47, 32);
            this.lblEligeSocio.Name = "lblEligeSocio";
            this.lblEligeSocio.Size = new System.Drawing.Size(72, 13);
            this.lblEligeSocio.TabIndex = 0;
            this.lblEligeSocio.Text = "Elige al socio:";
            // 
            // cbSocio
            // 
            this.cbSocio.FormattingEnabled = true;
            this.cbSocio.Location = new System.Drawing.Point(136, 29);
            this.cbSocio.Name = "cbSocio";
            this.cbSocio.Size = new System.Drawing.Size(121, 21);
            this.cbSocio.TabIndex = 1;
            this.cbSocio.SelectedIndexChanged += new System.EventHandler(this.cbSocio_SelectedIndexChanged);
            // 
            // lblDniSocio
            // 
            this.lblDniSocio.AutoSize = true;
            this.lblDniSocio.Location = new System.Drawing.Point(359, 32);
            this.lblDniSocio.Name = "lblDniSocio";
            this.lblDniSocio.Size = new System.Drawing.Size(59, 13);
            this.lblDniSocio.TabIndex = 2;
            this.lblDniSocio.Text = "DNI Socio:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.mtbCCC);
            this.panel1.Controls.Add(this.tbApellido);
            this.panel1.Controls.Add(this.mtbTelefono);
            this.panel1.Controls.Add(this.tbDireccion);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblCCC);
            this.panel1.Controls.Add(this.lblApellidos);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 161);
            this.panel1.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(493, 107);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(148, 20);
            this.tbEmail.TabIndex = 11;
            // 
            // mtbCCC
            // 
            this.mtbCCC.Location = new System.Drawing.Point(493, 68);
            this.mtbCCC.Mask = "ES00-0000-0000-00-0000000000";
            this.mtbCCC.Name = "mtbCCC";
            this.mtbCCC.ReadOnly = true;
            this.mtbCCC.Size = new System.Drawing.Size(148, 20);
            this.mtbCCC.TabIndex = 10;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(493, 27);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.ReadOnly = true;
            this.tbApellido.Size = new System.Drawing.Size(148, 20);
            this.tbApellido.TabIndex = 9;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(113, 107);
            this.mtbTelefono.Mask = "000-000-000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.ReadOnly = true;
            this.mtbTelefono.Size = new System.Drawing.Size(140, 20);
            this.mtbTelefono.TabIndex = 8;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(113, 68);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.ReadOnly = true;
            this.tbDireccion.Size = new System.Drawing.Size(140, 20);
            this.tbDireccion.TabIndex = 7;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(113, 27);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(140, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(424, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblCCC
            // 
            this.lblCCC.AutoSize = true;
            this.lblCCC.Location = new System.Drawing.Point(424, 71);
            this.lblCCC.Name = "lblCCC";
            this.lblCCC.Size = new System.Drawing.Size(28, 13);
            this.lblCCC.TabIndex = 4;
            this.lblCCC.Text = "CCC";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(424, 30);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(35, 110);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(35, 71);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // labelDniSocio
            // 
            this.labelDniSocio.AutoSize = true;
            this.labelDniSocio.Location = new System.Drawing.Point(429, 32);
            this.labelDniSocio.Name = "labelDniSocio";
            this.labelDniSocio.Size = new System.Drawing.Size(0, 13);
            this.labelDniSocio.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pbFoto);
            this.panel2.Controls.Add(this.btnReservar);
            this.panel2.Controls.Add(this.nupMinutos);
            this.panel2.Controls.Add(this.lblPuntos);
            this.panel2.Controls.Add(this.nupHora);
            this.panel2.Controls.Add(this.lblHoraInicio);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.cbPista);
            this.panel2.Controls.Add(this.lblPista);
            this.panel2.Location = new System.Drawing.Point(12, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 158);
            this.panel2.TabIndex = 6;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(542, 17);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(147, 120);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 9;
            this.pbFoto.TabStop = false;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(340, 93);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(77, 36);
            this.btnReservar.TabIndex = 8;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // nupMinutos
            // 
            this.nupMinutos.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupMinutos.Location = new System.Drawing.Point(170, 103);
            this.nupMinutos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupMinutos.Name = "nupMinutos";
            this.nupMinutos.Size = new System.Drawing.Size(31, 20);
            this.nupMinutos.TabIndex = 7;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(154, 105);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(10, 13);
            this.lblPuntos.TabIndex = 6;
            this.lblPuntos.Text = ":";
            // 
            // nupHora
            // 
            this.nupHora.Location = new System.Drawing.Point(113, 103);
            this.nupHora.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.nupHora.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nupHora.Name = "nupHora";
            this.nupHora.Size = new System.Drawing.Size(35, 20);
            this.nupHora.TabIndex = 5;
            this.nupHora.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(35, 105);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(57, 13);
            this.lblHoraInicio.TabIndex = 4;
            this.lblHoraInicio.Text = "Hora inicio";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(113, 60);
            this.dtpFecha.MinDate = new System.DateTime(2021, 11, 16, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(140, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(35, 67);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // cbPista
            // 
            this.cbPista.FormattingEnabled = true;
            this.cbPista.Location = new System.Drawing.Point(113, 17);
            this.cbPista.Name = "cbPista";
            this.cbPista.Size = new System.Drawing.Size(140, 21);
            this.cbPista.TabIndex = 1;
            this.cbPista.SelectedIndexChanged += new System.EventHandler(this.cbPista_SelectedIndexChanged);
            // 
            // lblPista
            // 
            this.lblPista.AutoSize = true;
            this.lblPista.Location = new System.Drawing.Point(35, 25);
            this.lblPista.Name = "lblPista";
            this.lblPista.Size = new System.Drawing.Size(30, 13);
            this.lblPista.TabIndex = 0;
            this.lblPista.Text = "Pista";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnPagar);
            this.panel3.Controls.Add(this.dgvReservas);
            this.panel3.Location = new System.Drawing.Point(13, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 201);
            this.panel3.TabIndex = 7;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(339, 154);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(93, 38);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(85, 13);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(603, 120);
            this.dgvReservas.TabIndex = 0;
            // 
            // Form_Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 617);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelDniSocio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDniSocio);
            this.Controls.Add(this.cbSocio);
            this.Controls.Add(this.lblEligeSocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Reservas";
            this.Text = "Form_Reservas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHora)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEligeSocio;
        private System.Windows.Forms.ComboBox cbSocio;
        private System.Windows.Forms.Label lblDniSocio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.MaskedTextBox mtbCCC;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCCC;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label labelDniSocio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.NumericUpDown nupMinutos;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.NumericUpDown nupHora;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cbPista;
        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}