using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lists;

namespace WindowsFormsApp2
{
    public partial class NuevoPuesto : Form
    {
        public NuevoPuesto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var conex = new WindowsFormsApplication2.EnlaceCassandra();
            var error = false;

            Puesto NuevoPuesto = new Puesto();
            NuevoPuesto.nomPuesto = tbNombre.Text;
            NuevoPuesto.proporSal = tbPorcentaje.Text;
            if (tbNombre.Text != "" && tbPorcentaje.Text != "")
            {
                error = conex.InsertPuesto(NuevoPuesto);


                if (error)
                {
                    MessageBox.Show("No se pudo agregar al alumno");
                }
                else
                {
                    MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "NUEVO DEPARTAMENTO!!!", MessageBoxButtons.OK);

                    // MessageBox.Show("el alumno se agregó con éxito.");
                    tbNombre.Text = "";
                    tbPorcentaje.Text = "";

                }
            }
        }

        private void NuevoPuesto_Load(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
