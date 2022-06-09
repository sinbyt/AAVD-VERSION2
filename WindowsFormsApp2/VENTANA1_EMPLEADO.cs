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
    public partial class INICIO : Form
    {
        //formCambiar CambiarEmp;
        Recibo_EMP NuevoRecibo;
        EditarPropio NuevoPropio;
        public INICIO()
        {
            InitializeComponent();
            //CambiarEmp = new formCambiar();
            NuevoRecibo = new Recibo_EMP();
            NuevoPropio = new EditarPropio();

            //NuevoActualizar = new Empleado.SelfEditarEmpleado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoPropio.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevoRecibo.ShowDialog();
        }
    }
}
