
namespace WindowsFormsApp2
{
    partial class formCambiar
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
            this.btnBack = new System.Windows.Forms.Button();
            this.listEmpleado = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbNombre = new System.Windows.Forms.MaskedTextBox();
            this.mtbApellido = new System.Windows.Forms.MaskedTextBox();
            this.mtbNum = new System.Windows.Forms.MaskedTextBox();
            this.mtbRFC = new System.Windows.Forms.MaskedTextBox();
            this.mtbCuenta = new System.Windows.Forms.MaskedTextBox();
            this.mtbCURP = new System.Windows.Forms.MaskedTextBox();
            this.mtbNSS = new System.Windows.Forms.MaskedTextBox();
            this.mtbNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.mtbEmail = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mtbDomicilio = new System.Windows.Forms.MaskedTextBox();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(659, 344);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "REGRESAR";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listEmpleado
            // 
            this.listEmpleado.FormattingEnabled = true;
            this.listEmpleado.ItemHeight = 16;
            this.listEmpleado.Location = new System.Drawing.Point(583, 16);
            this.listEmpleado.Name = "listEmpleado";
            this.listEmpleado.Size = new System.Drawing.Size(205, 148);
            this.listEmpleado.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID EMPLEADO";
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Location = new System.Drawing.Point(173, 12);
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(178, 22);
            this.tbEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Recuerde que una vez cambiado no se puede recuperar la informacion anterior del e" +
    "mpleado";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(404, 344);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(94, 23);
            this.btnCambiar.TabIndex = 18;
            this.btnCambiar.Text = "CAMBIAR";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = " Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(340, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 56;
            this.label14.Text = "Telefono";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(340, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 55;
            this.label15.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Banco";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Domicilio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "RFC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "NSS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "CURP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Departamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "NACIMIENTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Numero de empleado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(93, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Puesto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(93, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Numero de cuenta";
            // 
            // mtbNombre
            // 
            this.mtbNombre.Location = new System.Drawing.Point(173, 42);
            this.mtbNombre.Mask = "AAAAAAAAAAAA";
            this.mtbNombre.Name = "mtbNombre";
            this.mtbNombre.Size = new System.Drawing.Size(140, 22);
            this.mtbNombre.TabIndex = 3;
            // 
            // mtbApellido
            // 
            this.mtbApellido.Location = new System.Drawing.Point(173, 82);
            this.mtbApellido.Name = "mtbApellido";
            this.mtbApellido.Size = new System.Drawing.Size(140, 22);
            this.mtbApellido.TabIndex = 4;
            // 
            // mtbNum
            // 
            this.mtbNum.Location = new System.Drawing.Point(173, 121);
            this.mtbNum.Name = "mtbNum";
            this.mtbNum.Size = new System.Drawing.Size(140, 22);
            this.mtbNum.TabIndex = 5;
            // 
            // mtbRFC
            // 
            this.mtbRFC.Location = new System.Drawing.Point(173, 203);
            this.mtbRFC.Mask = "AAAAAAAAAAAAA";
            this.mtbRFC.Name = "mtbRFC";
            this.mtbRFC.Size = new System.Drawing.Size(140, 22);
            this.mtbRFC.TabIndex = 7;
            // 
            // mtbCuenta
            // 
            this.mtbCuenta.Location = new System.Drawing.Point(173, 344);
            this.mtbCuenta.Name = "mtbCuenta";
            this.mtbCuenta.Size = new System.Drawing.Size(140, 22);
            this.mtbCuenta.TabIndex = 10;
            // 
            // mtbCURP
            // 
            this.mtbCURP.Location = new System.Drawing.Point(438, 47);
            this.mtbCURP.Mask = "AAAAAAAAAAAAAAAA";
            this.mtbCURP.Name = "mtbCURP";
            this.mtbCURP.Size = new System.Drawing.Size(139, 22);
            this.mtbCURP.TabIndex = 11;
            // 
            // mtbNSS
            // 
            this.mtbNSS.Location = new System.Drawing.Point(438, 82);
            this.mtbNSS.Mask = "9999999999";
            this.mtbNSS.Name = "mtbNSS";
            this.mtbNSS.Size = new System.Drawing.Size(139, 22);
            this.mtbNSS.TabIndex = 12;
            this.mtbNSS.ValidatingType = typeof(int);
            // 
            // mtbNacimiento
            // 
            this.mtbNacimiento.Location = new System.Drawing.Point(438, 125);
            this.mtbNacimiento.Mask = "00/00/0000";
            this.mtbNacimiento.Name = "mtbNacimiento";
            this.mtbNacimiento.Size = new System.Drawing.Size(139, 22);
            this.mtbNacimiento.TabIndex = 13;
            this.mtbNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // mtbEmail
            // 
            this.mtbEmail.Location = new System.Drawing.Point(438, 209);
            this.mtbEmail.Name = "mtbEmail";
            this.mtbEmail.Size = new System.Drawing.Size(139, 22);
            this.mtbEmail.TabIndex = 15;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(438, 263);
            this.mtbTelefono.Mask = "000-000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(139, 22);
            this.mtbTelefono.TabIndex = 16;
            // 
            // mtbDomicilio
            // 
            this.mtbDomicilio.Location = new System.Drawing.Point(173, 255);
            this.mtbDomicilio.Name = "mtbDomicilio";
            this.mtbDomicilio.Size = new System.Drawing.Size(140, 22);
            this.mtbDomicilio.TabIndex = 8;
            // 
            // cbBanco
            // 
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Items.AddRange(new object[] {
            "Banco Azteca",
            "Banorte",
            "BBVA"});
            this.cbBanco.Location = new System.Drawing.Point(173, 303);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(140, 24);
            this.cbBanco.TabIndex = 9;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Items.AddRange(new object[] {
            "Sistemas",
            "Administracion",
            "Servicio a Clientes"});
            this.cbDepartamento.Location = new System.Drawing.Point(438, 164);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(195, 24);
            this.cbDepartamento.TabIndex = 60;
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Items.AddRange(new object[] {
            "Supervisor",
            "Calidad",
            "Pasante"});
            this.cbPuesto.Location = new System.Drawing.Point(173, 160);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(161, 24);
            this.cbPuesto.TabIndex = 61;
            // 
            // formCambiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.cbBanco);
            this.Controls.Add(this.mtbDomicilio);
            this.Controls.Add(this.mtbTelefono);
            this.Controls.Add(this.mtbEmail);
            this.Controls.Add(this.mtbNacimiento);
            this.Controls.Add(this.mtbNSS);
            this.Controls.Add(this.mtbCURP);
            this.Controls.Add(this.mtbCuenta);
            this.Controls.Add(this.mtbRFC);
            this.Controls.Add(this.mtbNum);
            this.Controls.Add(this.mtbApellido);
            this.Controls.Add(this.mtbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.btnBack);
            this.Name = "formCambiar";
            this.Text = "Editar datos de Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox listEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbNombre;
        private System.Windows.Forms.MaskedTextBox mtbApellido;
        private System.Windows.Forms.MaskedTextBox mtbNum;
        private System.Windows.Forms.MaskedTextBox mtbRFC;
        private System.Windows.Forms.MaskedTextBox mtbCuenta;
        private System.Windows.Forms.MaskedTextBox mtbCURP;
        private System.Windows.Forms.MaskedTextBox mtbNSS;
        private System.Windows.Forms.MaskedTextBox mtbNacimiento;
        private System.Windows.Forms.MaskedTextBox mtbEmail;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.MaskedTextBox mtbDomicilio;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.ComboBox cbPuesto;
    }
}