
namespace WindowsFormsApp2
{
    partial class HeadCounter
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
            this.gridEmpleados = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_en_puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_en_depa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reporteNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGeneralNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headcounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Num_en_puesto,
            this.Num_en_depa});
            this.gridEmpleados.Location = new System.Drawing.Point(76, 154);
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.RowHeadersWidth = 51;
            this.gridEmpleados.RowTemplate.Height = 24;
            this.gridEmpleados.Size = new System.Drawing.Size(934, 384);
            this.gridEmpleados.TabIndex = 4;
            this.gridEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmpleados_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Departamento";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Puesto";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Num_en_puesto
            // 
            this.Num_en_puesto.HeaderText = "Num_en_puesto";
            this.Num_en_puesto.MinimumWidth = 6;
            this.Num_en_puesto.Name = "Num_en_puesto";
            this.Num_en_puesto.Width = 125;
            // 
            // Num_en_depa
            // 
            this.Num_en_depa.HeaderText = "Num_en_depa";
            this.Num_en_depa.MinimumWidth = 6;
            this.Num_en_depa.Name = "Num_en_depa";
            this.Num_en_depa.Width = 125;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(481, 93);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(101, 38);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteNominaToolStripMenuItem,
            this.reporteGeneralNominaToolStripMenuItem,
            this.headcounterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reporteNominaToolStripMenuItem
            // 
            this.reporteNominaToolStripMenuItem.Name = "reporteNominaToolStripMenuItem";
            this.reporteNominaToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.reporteNominaToolStripMenuItem.Text = "Reporte Nomina";
            this.reporteNominaToolStripMenuItem.Click += new System.EventHandler(this.reporteNominaToolStripMenuItem_Click);
            // 
            // reporteGeneralNominaToolStripMenuItem
            // 
            this.reporteGeneralNominaToolStripMenuItem.Name = "reporteGeneralNominaToolStripMenuItem";
            this.reporteGeneralNominaToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.reporteGeneralNominaToolStripMenuItem.Text = "Reporte General Nomina";
            this.reporteGeneralNominaToolStripMenuItem.Click += new System.EventHandler(this.reporteGeneralNominaToolStripMenuItem_Click);
            // 
            // headcounterToolStripMenuItem
            // 
            this.headcounterToolStripMenuItem.Name = "headcounterToolStripMenuItem";
            this.headcounterToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.headcounterToolStripMenuItem.Text = "Headcounter";
            // 
            // HeadCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 550);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.gridEmpleados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HeadCounter";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmpleados;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_en_puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_en_depa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reporteNominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGeneralNominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headcounterToolStripMenuItem;
    }
}