﻿
namespace WindowsFormsApp2
{
    partial class AGREGARPERCEPCION
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.tbConcepto = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btnGuardarPercepcion = new System.Windows.Forms.Button();
            this.cbPerDec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPorcenMonto = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Concepto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Porcentaje O Monto";
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(59, 154);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(118, 22);
            this.tbClave.TabIndex = 3;
            // 
            // tbConcepto
            // 
            this.tbConcepto.Location = new System.Drawing.Point(59, 103);
            this.tbConcepto.Name = "tbConcepto";
            this.tbConcepto.Size = new System.Drawing.Size(118, 22);
            this.tbConcepto.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(211, 307);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "Cancelar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnGuardarPercepcion
            // 
            this.btnGuardarPercepcion.Location = new System.Drawing.Point(64, 307);
            this.btnGuardarPercepcion.Name = "btnGuardarPercepcion";
            this.btnGuardarPercepcion.Size = new System.Drawing.Size(113, 45);
            this.btnGuardarPercepcion.TabIndex = 6;
            this.btnGuardarPercepcion.Text = "Guardar";
            this.btnGuardarPercepcion.UseVisualStyleBackColor = true;
            this.btnGuardarPercepcion.Click += new System.EventHandler(this.btnGuardarPercepcion_Click);
            // 
            // cbPerDec
            // 
            this.cbPerDec.FormattingEnabled = true;
            this.cbPerDec.Items.AddRange(new object[] {
            "Percepcion",
            "Deduccion"});
            this.cbPerDec.Location = new System.Drawing.Point(57, 33);
            this.cbPerDec.Name = "cbPerDec";
            this.cbPerDec.Size = new System.Drawing.Size(121, 24);
            this.cbPerDec.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Percepcion o deduccion";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(60, 266);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(118, 22);
            this.tbValor.TabIndex = 5;
            this.tbValor.TextChanged += new System.EventHandler(this.tbValor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Valor de Porcentaje o Monto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbPorcenMonto
            // 
            this.cbPorcenMonto.FormattingEnabled = true;
            this.cbPorcenMonto.Items.AddRange(new object[] {
            "Porcentaje",
            "Monto"});
            this.cbPorcenMonto.Location = new System.Drawing.Point(59, 211);
            this.cbPorcenMonto.Name = "cbPorcenMonto";
            this.cbPorcenMonto.Size = new System.Drawing.Size(121, 24);
            this.cbPorcenMonto.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Concepto,
            this.Clave,
            this.Valor});
            this.dataGridView1.Location = new System.Drawing.Point(275, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 202);
            this.dataGridView1.TabIndex = 51;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.MinimumWidth = 6;
            this.Concepto.Name = "Concepto";
            this.Concepto.Width = 125;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.Width = 125;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.Width = 125;
            // 
            // AGREGARPERCEPCION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 364);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbPorcenMonto);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPerDec);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnGuardarPercepcion);
            this.Controls.Add(this.tbConcepto);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "AGREGARPERCEPCION";
            this.Text = "Agregar Percepcion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.TextBox tbConcepto;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnGuardarPercepcion;
        private System.Windows.Forms.ComboBox cbPerDec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPorcenMonto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}