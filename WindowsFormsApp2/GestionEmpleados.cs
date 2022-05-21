using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//PRUEBA AAAAA
namespace WindowsFormsApp2
{
    public partial class formInicioGT : Form
    {
        formAgregar NuevoEmpleado;
        formBorrar NuevoBorrado;
        formCambiar NuevoCambiado;
        public formInicioGT()
        {
            InitializeComponent();
            NuevoEmpleado = new formAgregar();
            NuevoBorrado = new formBorrar();
            NuevoCambiado = new formCambiar();

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

        private void headCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
