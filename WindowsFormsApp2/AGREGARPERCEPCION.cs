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

            PER_DEC PERCEPCIONDEDUCCION = new PER_DEC();

            PERCEPCIONDEDUCCION.tipoDato = cbPerDec.Text;
            PERCEPCIONDEDUCCION.conceptopPD = tbConcepto.Text;
            PERCEPCIONDEDUCCION.clavePD = tbClave.Text;
            PERCEPCIONDEDUCCION.porcentPD = tbValor.Text;
            PERCEPCIONDEDUCCION.monto = tbValor.Text;

            if (cbPerDec.Text != "" && tbConcepto.Text != "" && tbClave.Text != "" && tbValor.Text != "")
            {
                MessageBox.Show("Ahora puede usar este concepto", "MUCHAS GRACIAS!!!", MessageBoxButtons.OK);

            }
            cbPerDec.Text = "";
            tbConcepto.Text = "";
            tbClave.Text = "";
            tbValor.Text = "";
                error = conex.Insertperdec(PERCEPCIONDEDUCCION);

        }
    }
}
