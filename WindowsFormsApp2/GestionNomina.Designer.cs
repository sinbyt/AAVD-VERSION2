
namespace WindowsFormsApp2
{
    partial class formNomina
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
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbPercepciones = new System.Windows.Forms.ComboBox();
            this.cbAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbPercepciones = new System.Windows.Forms.ListBox();
            this.cbDeducciones = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbDeducciones = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mtbISR = new System.Windows.Forms.MaskedTextBox();
            this.mtbIMSS = new System.Windows.Forms.MaskedTextBox();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMes.Location = new System.Drawing.Point(14, 45);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(66, 24);
            this.cbMes.TabIndex = 1;
            // 
            // cbPercepciones
            // 
            this.cbPercepciones.FormattingEnabled = true;
            this.cbPercepciones.Items.AddRange(new object[] {
            "Sueldo",
            "Bono"});
            this.cbPercepciones.Location = new System.Drawing.Point(22, 262);
            this.cbPercepciones.Name = "cbPercepciones";
            this.cbPercepciones.Size = new System.Drawing.Size(121, 24);
            this.cbPercepciones.TabIndex = 8;
            // 
            // cbAnio
            // 
            this.cbAnio.FormattingEnabled = true;
            this.cbAnio.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbAnio.Location = new System.Drawing.Point(95, 45);
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Size = new System.Drawing.Size(66, 24);
            this.cbAnio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de deducciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Deducciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "lista de percepciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Percepciones";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "año";
            // 
            // lbPercepciones
            // 
            this.lbPercepciones.FormattingEnabled = true;
            this.lbPercepciones.ItemHeight = 16;
            this.lbPercepciones.Location = new System.Drawing.Point(23, 321);
            this.lbPercepciones.Name = "lbPercepciones";
            this.lbPercepciones.Size = new System.Drawing.Size(180, 84);
            this.lbPercepciones.TabIndex = 10;
            // 
            // cbDeducciones
            // 
            this.cbDeducciones.FormattingEnabled = true;
            this.cbDeducciones.Items.AddRange(new object[] {
            "Llegada tarde",
            "Falta"});
            this.cbDeducciones.Location = new System.Drawing.Point(522, 278);
            this.cbDeducciones.Name = "cbDeducciones";
            this.cbDeducciones.Size = new System.Drawing.Size(121, 24);
            this.cbDeducciones.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.nuevoPuestoToolStripMenuItem,
            this.buscarNominaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 30);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // nuevoPuestoToolStripMenuItem
            // 
            this.nuevoPuestoToolStripMenuItem.Name = "nuevoPuestoToolStripMenuItem";
            this.nuevoPuestoToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.nuevoPuestoToolStripMenuItem.Text = "Nuevo Puesto";
            this.nuevoPuestoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPuestoToolStripMenuItem_Click);
            // 
            // buscarNominaToolStripMenuItem
            // 
            this.buscarNominaToolStripMenuItem.Name = "buscarNominaToolStripMenuItem";
            this.buscarNominaToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.buscarNominaToolStripMenuItem.Text = "Buscar Nomina";
            this.buscarNominaToolStripMenuItem.Click += new System.EventHandler(this.buscarNominaToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(693, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "ACEPTAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(223, 263);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "ACEPTAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(124, 429);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "IMSS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 432);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "ISR";
            // 
            // lbDeducciones
            // 
            this.lbDeducciones.FormattingEnabled = true;
            this.lbDeducciones.ItemHeight = 16;
            this.lbDeducciones.Location = new System.Drawing.Point(522, 326);
            this.lbDeducciones.Name = "lbDeducciones";
            this.lbDeducciones.Size = new System.Drawing.Size(165, 84);
            this.lbDeducciones.TabIndex = 16;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(693, 326);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "DESHACER";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(182, 453);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = "%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(78, 453);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 17);
            this.label20.TabIndex = 34;
            this.label20.Text = "%";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "DESHACER";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(670, 439);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 45);
            this.button7.TabIndex = 18;
            this.button7.Text = "Guardar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(817, 439);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 45);
            this.button8.TabIndex = 19;
            this.button8.Text = "Cancelar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(177, 46);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "ACEPTAR";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 199);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(219, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Aplicar a todos los empleados";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // mtbISR
            // 
            this.mtbISR.Location = new System.Drawing.Point(22, 450);
            this.mtbISR.Mask = "00";
            this.mtbISR.Name = "mtbISR";
            this.mtbISR.Size = new System.Drawing.Size(50, 22);
            this.mtbISR.TabIndex = 12;
            // 
            // mtbIMSS
            // 
            this.mtbIMSS.Location = new System.Drawing.Point(120, 448);
            this.mtbIMSS.Mask = "00";
            this.mtbIMSS.Name = "mtbIMSS";
            this.mtbIMSS.Size = new System.Drawing.Size(56, 22);
            this.mtbIMSS.TabIndex = 13;
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Items.AddRange(new object[] {
            "Supervisor",
            "Calidad",
            "Pasante"});
            this.cbPuesto.Location = new System.Drawing.Point(634, 153);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(195, 24);
            this.cbPuesto.TabIndex = 36;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Items.AddRange(new object[] {
            "Sistemas",
            "Administracion",
            "Servicio a Clientes"});
            this.cbDepartamento.Location = new System.Drawing.Point(181, 155);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(195, 24);
            this.cbDepartamento.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Puesto";
            // 
            // cbDias
            // 
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDias.Location = new System.Drawing.Point(634, 45);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(195, 24);
            this.cbDias.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Dias trabajados";
            // 
            // formNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 494);
            this.Controls.Add(this.cbDias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbIMSS);
            this.Controls.Add(this.mtbISR);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lbDeducciones);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cbDeducciones);
            this.Controls.Add(this.lbPercepciones);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAnio);
            this.Controls.Add(this.cbPercepciones);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formNomina";
            this.Text = "Calculo de Nomina";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbPercepciones;
        private System.Windows.Forms.ComboBox cbAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbPercepciones;
        private System.Windows.Forms.ComboBox cbDeducciones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lbDeducciones;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ToolStripMenuItem nuevoPuestoToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem buscarNominaToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox mtbISR;
        private System.Windows.Forms.MaskedTextBox mtbIMSS;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.Label label5;
    }
}