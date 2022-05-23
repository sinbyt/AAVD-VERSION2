
namespace WindowsFormsApp2
{
    partial class Recibo
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
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNetoLetra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNeto = new System.Windows.Forms.TextBox();
            this.tbRFC = new System.Windows.Forms.TextBox();
            this.tbCURP = new System.Windows.Forms.TextBox();
            this.tbNSS = new System.Windows.Forms.TextBox();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbDomicilio = new System.Windows.Forms.TextBox();
            this.tbRFCEMP = new System.Windows.Forms.TextBox();
            this.tbRazon = new System.Windows.Forms.TextBox();
            this.tbInicio = new System.Windows.Forms.MaskedTextBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(268, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 36);
            this.listBox3.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(352, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 59;
            this.label12.Text = "NSS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(473, 166);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 58;
            this.label13.Text = "CURP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(600, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 57;
            this.label14.Text = "RFC";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(206, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 17);
            this.label15.TabIndex = 56;
            this.label15.Text = "Nombre Empleado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Domicilio Fiscal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "RFC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(655, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "Inicio de operaciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Razon social";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Deducciones:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(412, 254);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(239, 132);
            this.listBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Percepciones:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(82, 254);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 132);
            this.listBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Periodo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Año:";
            // 
            // tbNetoLetra
            // 
            this.tbNetoLetra.Enabled = false;
            this.tbNetoLetra.Location = new System.Drawing.Point(542, 386);
            this.tbNetoLetra.Name = "tbNetoLetra";
            this.tbNetoLetra.Size = new System.Drawing.Size(234, 22);
            this.tbNetoLetra.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Pago neto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Datos de empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Datos de empresa";
            // 
            // tbNeto
            // 
            this.tbNeto.Enabled = false;
            this.tbNeto.Location = new System.Drawing.Point(333, 386);
            this.tbNeto.Name = "tbNeto";
            this.tbNeto.Size = new System.Drawing.Size(203, 22);
            this.tbNeto.TabIndex = 13;
            this.tbNeto.Text = "$";
            // 
            // tbRFC
            // 
            this.tbRFC.Location = new System.Drawing.Point(603, 196);
            this.tbRFC.Name = "tbRFC";
            this.tbRFC.Size = new System.Drawing.Size(100, 22);
            this.tbRFC.TabIndex = 10;
            // 
            // tbCURP
            // 
            this.tbCURP.Location = new System.Drawing.Point(476, 196);
            this.tbCURP.Name = "tbCURP";
            this.tbCURP.Size = new System.Drawing.Size(100, 22);
            this.tbCURP.TabIndex = 9;
            // 
            // tbNSS
            // 
            this.tbNSS.Location = new System.Drawing.Point(355, 196);
            this.tbNSS.Name = "tbNSS";
            this.tbNSS.Size = new System.Drawing.Size(100, 22);
            this.tbNSS.TabIndex = 8;
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Location = new System.Drawing.Point(209, 196);
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(122, 22);
            this.tbEmpleado.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbDomicilio
            // 
            this.tbDomicilio.Enabled = false;
            this.tbDomicilio.Location = new System.Drawing.Point(315, 91);
            this.tbDomicilio.Name = "tbDomicilio";
            this.tbDomicilio.Size = new System.Drawing.Size(159, 22);
            this.tbDomicilio.TabIndex = 4;
            // 
            // tbRFCEMP
            // 
            this.tbRFCEMP.Enabled = false;
            this.tbRFCEMP.Location = new System.Drawing.Point(480, 91);
            this.tbRFCEMP.Name = "tbRFCEMP";
            this.tbRFCEMP.Size = new System.Drawing.Size(163, 22);
            this.tbRFCEMP.TabIndex = 5;
            // 
            // tbRazon
            // 
            this.tbRazon.Enabled = false;
            this.tbRazon.Location = new System.Drawing.Point(142, 91);
            this.tbRazon.Name = "tbRazon";
            this.tbRazon.Size = new System.Drawing.Size(167, 22);
            this.tbRazon.TabIndex = 3;
            // 
            // tbInicio
            // 
            this.tbInicio.Location = new System.Drawing.Point(650, 91);
            this.tbInicio.Mask = "00/00/0000";
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.Size = new System.Drawing.Size(188, 22);
            this.tbInicio.TabIndex = 6;
            this.tbInicio.ValidatingType = typeof(System.DateTime);
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(379, 451);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(124, 41);
            this.btnPDF.TabIndex = 60;
            this.btnPDF.Text = "IMPRIMIR";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 503);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.tbInicio);
            this.Controls.Add(this.tbDomicilio);
            this.Controls.Add(this.tbRFCEMP);
            this.Controls.Add(this.tbRazon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNetoLetra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNeto);
            this.Controls.Add(this.tbRFC);
            this.Controls.Add(this.tbCURP);
            this.Controls.Add(this.tbNSS);
            this.Controls.Add(this.tbEmpleado);
            this.Name = "Recibo";
            this.Text = "Recibo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNetoLetra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNeto;
        private System.Windows.Forms.TextBox tbRFC;
        private System.Windows.Forms.TextBox tbCURP;
        private System.Windows.Forms.TextBox tbNSS;
        private System.Windows.Forms.TextBox tbEmpleado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbDomicilio;
        private System.Windows.Forms.TextBox tbRFCEMP;
        private System.Windows.Forms.TextBox tbRazon;
        private System.Windows.Forms.MaskedTextBox tbInicio;
        private System.Windows.Forms.Button btnPDF;
    }
}