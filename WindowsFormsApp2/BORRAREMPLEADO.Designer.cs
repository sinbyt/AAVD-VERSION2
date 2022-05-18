
namespace WindowsFormsApp2
{
    partial class formBorrar
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmpleadoID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listEmpleado = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(364, 345);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuerde que una vez eliminado no se puede recuperar la informacion del empleado";
            // 
            // tbEmpleadoID
            // 
            this.tbEmpleadoID.Location = new System.Drawing.Point(338, 127);
            this.tbEmpleadoID.Name = "tbEmpleadoID";
            this.tbEmpleadoID.Size = new System.Drawing.Size(205, 22);
            this.tbEmpleadoID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID EMPLEADO";
            // 
            // listEmpleado
            // 
            this.listEmpleado.FormattingEnabled = true;
            this.listEmpleado.ItemHeight = 16;
            this.listEmpleado.Location = new System.Drawing.Point(338, 163);
            this.listEmpleado.Name = "listEmpleado";
            this.listEmpleado.Size = new System.Drawing.Size(205, 148);
            this.listEmpleado.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(659, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "REGRESAR";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(558, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // formBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmpleadoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Name = "formBorrar";
            this.Text = "Borrar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmpleadoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listEmpleado;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBuscar;
    }
}