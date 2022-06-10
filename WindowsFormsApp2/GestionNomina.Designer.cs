
namespace WindowsFormsApp2
{
    partial class FORMNOMINA
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
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lbDeducciones = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNomina = new System.Windows.Forms.DataGridView();
            this.numEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCSV = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbanio = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mtbISR = new System.Windows.Forms.MaskedTextBox();
            this.mtbIMSS = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMes.Location = new System.Drawing.Point(60, 38);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(66, 24);
            this.cbMes.TabIndex = 1;
            // 
            // cbPercepciones
            // 
            this.cbPercepciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPercepciones.FormattingEnabled = true;
            this.cbPercepciones.Location = new System.Drawing.Point(19, 60);
            this.cbPercepciones.Name = "cbPercepciones";
            this.cbPercepciones.Size = new System.Drawing.Size(178, 24);
            this.cbPercepciones.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de deducciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Deducciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "lista de percepciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Percepciones";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "año";
            // 
            // lbPercepciones
            // 
            this.lbPercepciones.FormattingEnabled = true;
            this.lbPercepciones.ItemHeight = 16;
            this.lbPercepciones.Location = new System.Drawing.Point(17, 125);
            this.lbPercepciones.Name = "lbPercepciones";
            this.lbPercepciones.Size = new System.Drawing.Size(180, 84);
            this.lbPercepciones.TabIndex = 10;
            this.lbPercepciones.SelectedIndexChanged += new System.EventHandler(this.lbPercepciones_SelectedIndexChanged);
            // 
            // cbDeducciones
            // 
            this.cbDeducciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeducciones.FormattingEnabled = true;
            this.cbDeducciones.Location = new System.Drawing.Point(339, 61);
            this.cbDeducciones.Name = "cbDeducciones";
            this.cbDeducciones.Size = new System.Drawing.Size(183, 24);
            this.cbDeducciones.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.puestoToolStripMenuItem,
            this.editarIndividualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1696, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.nuevoToolStripMenuItem.Text = "Nueva P/D";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // puestoToolStripMenuItem
            // 
            this.puestoToolStripMenuItem.Name = "puestoToolStripMenuItem";
            this.puestoToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.puestoToolStripMenuItem.Text = "Puesto";
            this.puestoToolStripMenuItem.Click += new System.EventHandler(this.puestoToolStripMenuItem_Click);
            // 
            // editarIndividualToolStripMenuItem
            // 
            this.editarIndividualToolStripMenuItem.Name = "editarIndividualToolStripMenuItem";
            this.editarIndividualToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.editarIndividualToolStripMenuItem.Text = "Editar Individual";
            this.editarIndividualToolStripMenuItem.Click += new System.EventHandler(this.editarIndividualToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(529, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "ACEPTAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(213, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "ACEPTAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbDeducciones
            // 
            this.lbDeducciones.FormattingEnabled = true;
            this.lbDeducciones.ItemHeight = 16;
            this.lbDeducciones.Location = new System.Drawing.Point(339, 126);
            this.lbDeducciones.Name = "lbDeducciones";
            this.lbDeducciones.Size = new System.Drawing.Size(183, 84);
            this.lbDeducciones.TabIndex = 16;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(529, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "DESHACER";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "DESHACER";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(212, 599);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 45);
            this.button7.TabIndex = 18;
            this.button7.Text = "Generar Nomina";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(351, 599);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 45);
            this.button8.TabIndex = 19;
            this.button8.Text = "Cancelar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(219, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Aplicar a todos los empleados";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbPuesto
            // 
            this.cbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Location = new System.Drawing.Point(164, 239);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(195, 24);
            this.cbPuesto.TabIndex = 36;
            this.cbPuesto.SelectedIndexChanged += new System.EventHandler(this.cbPuesto_SelectedIndexChanged);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(164, 196);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(195, 24);
            this.cbDepartamento.TabIndex = 37;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Puesto";
            // 
            // dgvNomina
            // 
            this.dgvNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numEmp,
            this.nomEmp,
            this.fecha,
            this.sueldoB,
            this.banco,
            this.numCuenta});
            this.dgvNomina.Location = new System.Drawing.Point(814, 47);
            this.dgvNomina.Name = "dgvNomina";
            this.dgvNomina.ReadOnly = true;
            this.dgvNomina.RowHeadersWidth = 51;
            this.dgvNomina.RowTemplate.Height = 24;
            this.dgvNomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNomina.Size = new System.Drawing.Size(804, 525);
            this.dgvNomina.TabIndex = 50;
            // 
            // numemp
            // 
            this.numemp.HeaderText = "Num. Empleado";
            this.numemp.MinimumWidth = 6;
            this.numemp.Name = "numemp";
            this.numemp.ReadOnly = true;
            this.numemp.Width = 125;
            // 
            // nomEmp
            // 
            this.nomEmp.HeaderText = "Nombre Empleado";
            this.nomEmp.MinimumWidth = 6;
            this.nomEmp.Name = "nomEmp";
            this.nomEmp.ReadOnly = true;
            this.nomEmp.Width = 125;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha ";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 125;
            // 
            // sueldoB
            // 
            this.sueldoB.HeaderText = "Sueldo Bruto";
            this.sueldoB.MinimumWidth = 6;
            this.sueldoB.Name = "sueldoB";
            this.sueldoB.ReadOnly = true;
            this.sueldoB.Width = 125;
            // 
            // banco
            // 
            this.banco.HeaderText = "Banco";
            this.banco.MinimumWidth = 6;
            this.banco.Name = "banco";
            this.banco.ReadOnly = true;
            this.banco.Width = 125;
            // 
            // numCuenta
            // 
            this.numCuenta.HeaderText = "Numero de cuenta";
            this.numCuenta.MinimumWidth = 6;
            this.numCuenta.Name = "numCuenta";
            this.numCuenta.ReadOnly = true;
            this.numCuenta.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 171);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione empleados a quienes se desea aplicar";
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(1228, 595);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(116, 49);
            this.btnCSV.TabIndex = 53;
            this.btnCSV.Text = "Generar CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbanio);
            this.groupBox3.Controls.Add(this.cbMes);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(13, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 82);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione fecha de nomina";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tbanio
            // 
            this.tbanio.Location = new System.Drawing.Point(177, 41);
            this.tbanio.Mask = "9999";
            this.tbanio.Name = "tbanio";
            this.tbanio.Size = new System.Drawing.Size(66, 22);
            this.tbanio.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.mtbISR);
            this.groupBox2.Controls.Add(this.mtbIMSS);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(433, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 171);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deducciones fijas";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Monto",
            "Porcentaje"});
            this.comboBox2.Location = new System.Drawing.Point(104, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 24);
            this.comboBox2.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Monto o Porcentaje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Monto o Porcentaje";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Monto",
            "Porcentaje"});
            this.comboBox1.Location = new System.Drawing.Point(104, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // mtbISR
            // 
            this.mtbISR.Location = new System.Drawing.Point(9, 38);
            this.mtbISR.Mask = "00000";
            this.mtbISR.Name = "mtbISR";
            this.mtbISR.Size = new System.Drawing.Size(61, 22);
            this.mtbISR.TabIndex = 12;
            // 
            // mtbIMSS
            // 
            this.mtbIMSS.Location = new System.Drawing.Point(9, 113);
            this.mtbIMSS.Mask = "00000";
            this.mtbIMSS.Name = "mtbIMSS";
            this.mtbIMSS.Size = new System.Drawing.Size(61, 22);
            this.mtbIMSS.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "ISR";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "IMSS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cbPercepciones);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lbPercepciones);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.cbDeducciones);
            this.groupBox4.Controls.Add(this.lbDeducciones);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(13, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(686, 230);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccione percepciones y deducciones que se aplicaran en la nomina";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // FORMNOMINA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 683);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.dgvNomina);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FORMNOMINA";
            this.Text = "Calculo de Nomina";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbPercepciones;
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
        private System.Windows.Forms.ListBox lbDeducciones;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn numEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestoToolStripMenuItem;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox mtbISR;
        private System.Windows.Forms.MaskedTextBox mtbIMSS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox tbanio;
        private System.Windows.Forms.ToolStripMenuItem editarIndividualToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
    }
}