using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static WindowsFormsApp2.FUNCIONES;




namespace WindowsFormsApp2
{
   
    public partial class formInicio : Form
    {
        formAgregar NuevaPercepcion;
        formNomina NuevaNomina;
        Datos_de_la_empresa NuevoDatos;
        Recibo NuevoRecibo;
        //LOGIN NuevoLogin;
        //formEmpleados NuevoEmpleado;
        public formInicio()
        {

            InitializeComponent();
            NuevaPercepcion = new formAgregar();
            NuevaNomina = new formNomina();
            NuevoDatos = new Datos_de_la_empresa();
            NuevoRecibo = new Recibo();
            //NuevoLogin = new LOGIN();
            //NuevoEmpleado = new formEmpleados();
        }

        private void percepcionesYDeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDeducciones_Click(object sender, EventArgs e)
        {
            //NuevaDeduccion.ShowDialog();
        }

        private void btnPercepciones_Click_1(object sender, EventArgs e)
        {
            NuevaPercepcion.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //NuevoEmpleado.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //NuevoEmpleado.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //NuevoBorrado.ShowDialog();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {

        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            NuevaNomina.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoDatos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //RECIBO ESTA JSJSJA
        {
            NuevoRecibo.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var dialog = new DialogResult();

            dialog = MessageBox.Show("Seguro que quiere cerrar la aplicacion?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dialog == DialogResult.No)
            {
                this.Close();
            }
            if (dialog == DialogResult.Yes)
            {

                Application.Exit();
            }
        }
        //CON ESTO SE IMPRIME UN PDF PARA EL RICHTEXTBOX RTB
        
        

        private void btnLetra_Click(object sender, EventArgs e)
        {
            //NumeroALetras(tbLETRAS)
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // NuevoLogin.Show();
            
        }

        private void formInicio_Load(object sender, EventArgs e)
        {

        }
    }
       
}
