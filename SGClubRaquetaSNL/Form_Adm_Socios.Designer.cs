
namespace SGClubRaquetaSNL
{
    partial class Form_Adm_Socios
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
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCuentaCorriente = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbDomicilio = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mtbCuentaCorriente = new System.Windows.Forms.MaskedTextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(103, 37);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(103, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(103, 115);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(103, 157);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 3;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(103, 197);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(103, 239);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblCuentaCorriente
            // 
            this.lblCuentaCorriente.AutoSize = true;
            this.lblCuentaCorriente.Location = new System.Drawing.Point(103, 279);
            this.lblCuentaCorriente.Name = "lblCuentaCorriente";
            this.lblCuentaCorriente.Size = new System.Drawing.Size(83, 13);
            this.lblCuentaCorriente.TabIndex = 6;
            this.lblCuentaCorriente.Text = "CuentaCorriente";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(215, 30);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(198, 20);
            this.tbDni.TabIndex = 7;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(215, 70);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(198, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(215, 112);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(198, 20);
            this.tbApellidos.TabIndex = 9;
            // 
            // tbDomicilio
            // 
            this.tbDomicilio.Location = new System.Drawing.Point(215, 154);
            this.tbDomicilio.Name = "tbDomicilio";
            this.tbDomicilio.Size = new System.Drawing.Size(198, 20);
            this.tbDomicilio.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(215, 236);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(198, 20);
            this.tbEmail.TabIndex = 12;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(215, 194);
            this.mtbTelefono.Mask = "000000000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(198, 20);
            this.mtbTelefono.TabIndex = 13;
            // 
            // mtbCuentaCorriente
            // 
            this.mtbCuentaCorriente.Location = new System.Drawing.Point(215, 276);
            this.mtbCuentaCorriente.Mask = "ES00-0000-0000-00-0000000000";
            this.mtbCuentaCorriente.Name = "mtbCuentaCorriente";
            this.mtbCuentaCorriente.Size = new System.Drawing.Size(198, 20);
            this.mtbCuentaCorriente.TabIndex = 14;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(578, 52);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 35);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(578, 115);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 39);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(578, 186);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(578, 256);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(75, 36);
            this.btnMostrarTodos.TabIndex = 18;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // dgvSocios
            // 
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Location = new System.Drawing.Point(12, 334);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.Size = new System.Drawing.Size(766, 146);
            this.dgvSocios.TabIndex = 19;
            // 
            // Form_Adm_Socios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(790, 509);
            this.Controls.Add(this.dgvSocios);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.mtbCuentaCorriente);
            this.Controls.Add(this.mtbTelefono);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbDomicilio);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblCuentaCorriente);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Name = "Form_Adm_Socios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Adm_Socios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCuentaCorriente;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbDomicilio;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.MaskedTextBox mtbCuentaCorriente;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvSocios;
    }
}