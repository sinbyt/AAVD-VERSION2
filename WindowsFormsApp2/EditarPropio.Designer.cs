
namespace WindowsFormsApp2
{
    partial class EditarPropio
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.mtbCP = new System.Windows.Forms.MaskedTextBox();
            this.mtbNum = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.DTPAlta = new System.Windows.Forms.DateTimePicker();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.tbColonia = new System.Windows.Forms.TextBox();
            this.tbMunicipio = new System.Windows.Forms.TextBox();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.tbCuenta = new System.Windows.Forms.TextBox();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.tbRFC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbCURP = new System.Windows.Forms.MaskedTextBox();
            this.mtbNSS = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DTPNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(645, 261);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(194, 22);
            this.tbEmail.TabIndex = 78;
            // 
            // mtbCP
            // 
            this.mtbCP.Location = new System.Drawing.Point(283, 434);
            this.mtbCP.Mask = "00000";
            this.mtbCP.Name = "mtbCP";
            this.mtbCP.Size = new System.Drawing.Size(195, 22);
            this.mtbCP.TabIndex = 85;
            // 
            // mtbNum
            // 
            this.mtbNum.Location = new System.Drawing.Point(283, 351);
            this.mtbNum.Mask = "99999";
            this.mtbNum.Name = "mtbNum";
            this.mtbNum.Size = new System.Drawing.Size(195, 22);
            this.mtbNum.TabIndex = 81;
            this.mtbNum.ValidatingType = typeof(int);
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(645, 299);
            this.mtbTelefono.Mask = "(999)000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(194, 22);
            this.mtbTelefono.TabIndex = 80;
            // 
            // DTPAlta
            // 
            this.DTPAlta.Location = new System.Drawing.Point(645, 490);
            this.DTPAlta.Name = "DTPAlta";
            this.DTPAlta.Size = new System.Drawing.Size(195, 22);
            this.DTPAlta.TabIndex = 88;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "    Aguascalientes",
            "    Baja California",
            "    Baja California Sur",
            "    Campeche",
            "    Chiapas",
            "    Chihuahua",
            "    Coahuila de Zaragoza",
            "    Colima",
            "    Durango",
            "    Estado de México",
            "    Guanajuato",
            "    Guerrero",
            "    Hidalgo",
            "    Jalisco",
            "    Michoacán de Ocampo",
            "    Morelos",
            "    Nayarit",
            "    Nuevo León",
            "    Oaxaca",
            "    Puebla",
            "    Querétaro",
            "    Quintana Roo",
            "    San Luis Potosí",
            "    Sinaloa",
            "    Sonora",
            "    Tabasco",
            "    Tamaulipas",
            "    Tlaxcala",
            "    Veracruz de Ignacio de la Llave",
            "    Yucatán",
            "    Zacatecas"});
            this.cbEstado.Location = new System.Drawing.Point(645, 353);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(194, 24);
            this.cbEstado.TabIndex = 82;
            // 
            // tbColonia
            // 
            this.tbColonia.Location = new System.Drawing.Point(283, 393);
            this.tbColonia.Name = "tbColonia";
            this.tbColonia.Size = new System.Drawing.Size(195, 22);
            this.tbColonia.TabIndex = 83;
            // 
            // tbMunicipio
            // 
            this.tbMunicipio.Location = new System.Drawing.Point(645, 398);
            this.tbMunicipio.Name = "tbMunicipio";
            this.tbMunicipio.Size = new System.Drawing.Size(194, 22);
            this.tbMunicipio.TabIndex = 84;
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Items.AddRange(new object[] {
            "Supervisor",
            "Calidad",
            "Pasante"});
            this.cbPuesto.Location = new System.Drawing.Point(283, 208);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(195, 24);
            this.cbPuesto.TabIndex = 76;
            // 
            // cbBanco
            // 
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Items.AddRange(new object[] {
            "Banco Azteca",
            "Banorte",
            "BBVA"});
            this.cbBanco.Location = new System.Drawing.Point(645, 445);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(195, 24);
            this.cbBanco.TabIndex = 86;
            // 
            // tbCuenta
            // 
            this.tbCuenta.Location = new System.Drawing.Point(283, 487);
            this.tbCuenta.Name = "tbCuenta";
            this.tbCuenta.Size = new System.Drawing.Size(195, 22);
            this.tbCuenta.TabIndex = 87;
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(283, 311);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(195, 22);
            this.tbCalle.TabIndex = 79;
            // 
            // tbRFC
            // 
            this.tbRFC.Location = new System.Drawing.Point(283, 258);
            this.tbRFC.Name = "tbRFC";
            this.tbRFC.Size = new System.Drawing.Size(195, 22);
            this.tbRFC.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 72;
            this.label9.Text = "CURP";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(283, 108);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(195, 22);
            this.tbApellidos.TabIndex = 74;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(283, 157);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(195, 22);
            this.tbID.TabIndex = 75;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(283, 55);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(195, 22);
            this.tbNombre.TabIndex = 73;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtbCURP);
            this.groupBox1.Controls.Add(this.mtbNSS);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.DTPNacimiento);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cbDepartamento);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(129, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 562);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de datos del empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 339);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 17);
            this.label18.TabIndex = 39;
            this.label18.Text = "Numero domicilio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Calle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puesto";
            // 
            // mtbCURP
            // 
            this.mtbCURP.Location = new System.Drawing.Point(515, 44);
            this.mtbCURP.Mask = "AAAA 999999 AAA AAAAA";
            this.mtbCURP.Name = "mtbCURP";
            this.mtbCURP.Size = new System.Drawing.Size(195, 22);
            this.mtbCURP.TabIndex = 2;
            // 
            // mtbNSS
            // 
            this.mtbNSS.Location = new System.Drawing.Point(515, 96);
            this.mtbNSS.Mask = "000-00-0000";
            this.mtbNSS.Name = "mtbNSS";
            this.mtbNSS.Size = new System.Drawing.Size(195, 22);
            this.mtbNSS.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "Colonia";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 422);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 17);
            this.label20.TabIndex = 44;
            this.label20.Text = "Codigo Postal";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(386, 483);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 17);
            this.label21.TabIndex = 47;
            this.label21.Text = "Fecha de alta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Numero de cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "NSS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(372, 386);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Municipio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(372, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Email";
            // 
            // DTPNacimiento
            // 
            this.DTPNacimiento.Location = new System.Drawing.Point(515, 150);
            this.DTPNacimiento.Name = "DTPNacimiento";
            this.DTPNacimiento.Size = new System.Drawing.Size(195, 22);
            this.DTPNacimiento.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(372, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Telefono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(376, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Banco";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 25);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "ACEPTAR";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Items.AddRange(new object[] {
            "Sistemas",
            "Administracion",
            "Servicio a Clientes"});
            this.cbDepartamento.Location = new System.Drawing.Point(515, 196);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(195, 24);
            this.cbDepartamento.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(372, 341);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 17);
            this.label19.TabIndex = 41;
            this.label19.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Departamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // EditarPropio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 620);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.mtbCP);
            this.Controls.Add(this.mtbNum);
            this.Controls.Add(this.mtbTelefono);
            this.Controls.Add(this.DTPAlta);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.tbColonia);
            this.Controls.Add(this.tbMunicipio);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.cbBanco);
            this.Controls.Add(this.tbCuenta);
            this.Controls.Add(this.tbCalle);
            this.Controls.Add(this.tbRFC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditarPropio";
            this.Text = "Editar tu informacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.MaskedTextBox mtbCP;
        private System.Windows.Forms.MaskedTextBox mtbNum;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.DateTimePicker DTPAlta;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox tbColonia;
        private System.Windows.Forms.TextBox tbMunicipio;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.TextBox tbCuenta;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.TextBox tbRFC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbCURP;
        private System.Windows.Forms.MaskedTextBox mtbNSS;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DTPNacimiento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}