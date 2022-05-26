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
    public partial class VENTANA1_EMPLEADO : Form
    {
        formCambiar CambiarEmp;
        Recibo NuevoRecibo;
        public VENTANA1_EMPLEADO()
        {
            InitializeComponent();
            CambiarEmp = new formCambiar();
            NuevoRecibo = new Recibo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarEmp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevoRecibo.ShowDialog();
        }
    }
}
