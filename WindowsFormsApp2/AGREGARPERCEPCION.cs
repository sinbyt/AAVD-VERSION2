using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.FUNCIONES;
using static Lists;
namespace WindowsFormsApp2
{
    public partial class AGREGARPERCEPCION : Form
    {
        public AGREGARPERCEPCION()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarPercepcion_Click(object sender, EventArgs e)
        {
            var conex = new WindowsFormsApplication2.EnlaceCassandra();
            var error = false;

            PERDEC PERCEPCIONDEDUCCION = new PERDEC();

            PERCEPCIONDEDUCCION.tipoDato = cbPerDec.Text;
            PERCEPCIONDEDUCCION.conceptoPD = tbConcepto.Text;
            PERCEPCIONDEDUCCION.porcentPD = cbPorcenMonto.Text;
            PERCEPCIONDEDUCCION.monto = tbValor.Text;

            
           if (cbPerDec.Text != "" && tbConcepto.Text != "" && tbValor.Text != "")
           {
                    error = conex.Insertperdec(PERCEPCIONDEDUCCION);

                    
                if (error)
                {
                    MessageBox.Show("No se pudo agregar al alumno");
                }
                else
                {

                    MessageBox.Show("Ahora puede usar este concepto", "MUCHAS GRACIAS!!!", MessageBoxButtons.OK);
                    cbPerDec.Text = "";
                    tbConcepto.Text = "";
                    tbValor.Text = "";
                }
           }
                //MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "NUEVO DEPARTAMENTO!!!", MessageBoxButtons.OK);

            
            

         
          

        }

        private void AGREGARPERCEPCION_Load(object sender, EventArgs e)
        {

        }

        private void cbPorcenMonto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbConcepto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPerDec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
