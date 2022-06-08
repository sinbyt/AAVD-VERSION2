using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.LOGIN;
using static WindowsFormsApp2.FUNCIONES;
using static Lists;
using System.IO;
namespace WindowsFormsApp2
{
    public partial class formNomina : Form
    {
        AGREGARPERCEPCION NuevaNomina;
        EliminarP NuevaEliminada;
        EDITAR_NOMINA NuevaNominaEditada;
        Puesto PuestoNuevo;
        BUSCARNOMINA BuscarNomina;
        public formNomina()
        {
            InitializeComponent();
            NuevaNomina = new AGREGARPERCEPCION();
            NuevaEliminada = new EliminarP();
            NuevaNominaEditada = new EDITAR_NOMINA();
            PuestoNuevo = new Puesto();
            BuscarNomina = new BUSCARNOMINA();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaEliminada.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaNomina.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaNominaEditada.ShowDialog();
        }

        private void nuevoPuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuestoNuevo.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarNomina.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*
            var conex = new WindowsFormsApplication2.EnlaceCassandra();
            var error = false;
            NOMINA NuevaNom = new NOMINA();

            NuevaNom.FechaNom = cbMes.Text + cbAnio.Text;
            NuevaNom.percept = cbPercepciones.Text;
            NuevaNom.deducc = cbDeducciones.Text;
            NuevaNom.jornada = cbDias.Text;
            NuevaNom.depa = cbDepartamento.Text;
            NuevaNom.puesto = cbPuesto.Text;

            error = conex.InsertNomina(NuevaNom);
            */

            TextWriter text1 = new StreamWriter(@"C:\Users\E\source\repos\WindowsFormsApp2\CSV");
            text1.Write(cbMes.Text + "," + cbPercepciones.Text + "," + cbDeducciones.Text + "," + cbDias.Text + "," + cbDepartamento.Text + "," + cbPuesto.Text);
            text1.Close();
            //text1.Write(NuevaNom.FechaNom + "," + NuevaNom.percept + "," + NuevaNom.deducc + "," + NuevaNom.jornada + "," + NuevaNom.depa + "," + NuevaNom.puesto);
            //            text1.Close();

        }
    }
}
