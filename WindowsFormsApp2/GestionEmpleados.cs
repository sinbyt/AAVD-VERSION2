using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class formInicioGT : Form
    {
        formAgregar NuevoEmpleado;
        formBorrar NuevoBorrado;
        formCambiar NuevoCambiado;
        //HEADCOUNTER nHeadCounter;
        Lista_de_Empleados nListaEMP;
        REPORTEGENERALDENOMINA nReporte;
        public formInicioGT()
        {
            InitializeComponent();
            NuevoEmpleado = new formAgregar();
            NuevoBorrado = new formBorrar();
            NuevoCambiado = new formCambiar();
            //nHeadCounter = new HEADCOUNTER();
            nListaEMP = new Lista_de_Empleados();
            nReporte = new REPORTEGENERALDENOMINA();
        }



        private void agregarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoEmpleado.ShowDialog();
        }

        private void borrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoBorrado.ShowDialog();
        }

        private void editarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoCambiado.ShowDialog();
        }

        private void headcounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nHeadCounter.ShowDialog();
        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nListaEMP.ShowDialog();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nReporte.ShowDialog();
        }
    }
}
