
namespace WindowsFormsApp2
{
    partial class formInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbtitulo = new System.Windows.Forms.Label();
            this.btnPercepciones = new System.Windows.Forms.Button();
            this.btnNomina = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRecibos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Response = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.RTB = new System.Windows.Forms.RichTextBox();
            this.CSVTEXT = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Location = new System.Drawing.Point(290, 63);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(203, 17);
            this.lbtitulo.TabIndex = 1;
            this.lbtitulo.Text = "Bienvenido! Que desea hacer?";
            // 
            // btnPercepciones
            // 
            this.btnPercepciones.Location = new System.Drawing.Point(313, 93);
            this.btnPercepciones.Name = "btnPercepciones";
            this.btnPercepciones.Size = new System.Drawing.Size(180, 23);
            this.btnPercepciones.TabIndex = 1;
            this.btnPercepciones.Text = "Gestion Empleados";
            this.btnPercepciones.UseVisualStyleBackColor = true;
            this.btnPercepciones.Click += new System.EventHandler(this.btnPercepciones_Click_1);
            // 
            // btnNomina
            // 
            this.btnNomina.Location = new System.Drawing.Point(313, 164);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(180, 23);
            this.btnNomina.TabIndex = 2;
            this.btnNomina.Text = "Gestion Nomina";
            this.btnNomina.UseVisualStyleBackColor = true;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Datos de la empresa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRecibos
            // 
            this.btnRecibos.Location = new System.Drawing.Point(313, 294);
            this.btnRecibos.Name = "btnRecibos";
            this.btnRecibos.Size = new System.Drawing.Size(180, 23);
            this.btnRecibos.TabIndex = 4;
            this.btnRecibos.Text = "Gestion de recibos";
            this.btnRecibos.UseVisualStyleBackColor = true;
            this.btnRecibos.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir y Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Response
            // 
            this.Response.Location = new System.Drawing.Point(669, 63);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(114, 23);
            this.Response.TabIndex = 6;
            this.Response.Text = "IMPRIME PDF";
            this.Response.UseVisualStyleBackColor = true;
            this.Response.Click += new System.EventHandler(this.BTNPDF_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(428, 376);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCSV.TabIndex = 8;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // RTB
            // 
            this.RTB.Location = new System.Drawing.Point(546, 109);
            this.RTB.Name = "RTB";
            this.RTB.Size = new System.Drawing.Size(193, 208);
            this.RTB.TabIndex = 7;
            this.RTB.Text = "";
            // 
            // CSVTEXT
            // 
            this.CSVTEXT.Location = new System.Drawing.Point(120, 151);
            this.CSVTEXT.Name = "CSVTEXT";
            this.CSVTEXT.Size = new System.Drawing.Size(100, 96);
            this.CSVTEXT.TabIndex = 9;
            this.CSVTEXT.Text = "";
            // 
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.CSVTEXT);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.RTB);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRecibos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNomina);
            this.Controls.Add(this.btnPercepciones);
            this.Controls.Add(this.lbtitulo);
            this.Name = "formInicio";
            this.Text = "INICIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Button btnPercepciones;
        private System.Windows.Forms.Button btnNomina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRecibos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Response;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.RichTextBox RTB;
        private System.Windows.Forms.RichTextBox CSVTEXT;
    }
}

