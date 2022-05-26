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
    public partial class Datos_de_la_empresa : Form
    {
        public Datos_de_la_empresa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conex = new WindowsFormsApplication2.EnlaceCassandra();
            var error = false;
            Empresa INFOEMPRESA = new Empresa();

            INFOEMPRESA.razon_social = mtbRazon.Text;
            INFOEMPRESA.nombreEmp = mtbNombreEmp.Text;
            INFOEMPRESA.domicilioFis = mtbDomicilio.Text;
            INFOEMPRESA.inicioOp = mtbINICIO.Text;
            INFOEMPRESA.RFC_EMP = mtbRFC.Text;

            if (mtbRazon.Text != "" && mtbNombreEmp.Text != "" && mtbDomicilio.Text != "" && mtbINICIO.Text != "" && mtbRFC.Text != "")
            {
                MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "MUCHAS GRACIAS!!!", MessageBoxButtons.OK);

            }
            mtbRazon.Text = "";
            mtbNombreEmp.Text = "";
            mtbDomicilio.Text = "";
            mtbINICIO.Text = "";
            mtbRFC.Text = "";
            error = conex.InsertEmpresa(INFOEMPRESA);

        }
    }
}
