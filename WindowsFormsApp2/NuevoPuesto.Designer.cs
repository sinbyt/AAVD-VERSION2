
namespace WindowsFormsApp2
{
    partial class NuevoPuesto
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
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.tbSueldo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPorcentaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "ACEPTAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 57;
            this.label14.Text = "Departamento";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(46, 138);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(121, 24);
            this.cbDepartamento.TabIndex = 1;
            // 
            // cbDias
            // 
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Location = new System.Drawing.Point(46, 352);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(121, 24);
            this.cbDias.TabIndex = 5;
            // 
            // tbSueldo
            // 
            this.tbSueldo.Enabled = false;
            this.tbSueldo.Location = new System.Drawing.Point(46, 209);
            this.tbSueldo.Name = "tbSueldo";
            this.tbSueldo.Size = new System.Drawing.Size(121, 22);
            this.tbSueldo.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 322);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 17);
            this.label18.TabIndex = 60;
            this.label18.Text = "Dias trabajados";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 59;
            this.label12.Text = "Sueldo Diario";
            // 
            // tbPorcentaje
            // 
            this.tbPorcentaje.Location = new System.Drawing.Point(46, 277);
            this.tbPorcentaje.Name = "tbPorcentaje";
            this.tbPorcentaje.Size = new System.Drawing.Size(121, 22);
            this.tbPorcentaje.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "%";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(46, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 33);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(220, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 33);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(46, 84);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 22);
            this.tbNombre.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nombre";
            // 
            // NuevoPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbPorcentaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDias);
            this.Controls.Add(this.tbSueldo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbDepartamento);
            this.Name = "NuevoPuesto";
            this.Text = "NuevoPuesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.TextBox tbSueldo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPorcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
    }
}