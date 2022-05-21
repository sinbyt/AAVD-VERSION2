using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class formAgregar : Form
    {
        //private BUSSINESLOGICLAYER _BussinesLogicLayer;
        public formAgregar()
        {
            InitializeComponent();
            //_BussinesLogicLayer = new BUSSINESLOGICLAYER();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            var conex = new WindowsFormsApplication2.EnlaceCassandra();

            var error = false;
            Empleado empleado = new Empleado();
            empleado.nombre = tbNombre.Text;
            empleado.apellidos = tbApellidos.Text;
            empleado.fechaAlta = DTPAlta.Text;
            empleado.depa = cbDepartamento.Text;
            empleado.puesto = cbPuesto.Text;
            empleado.fechaNacimiento = DTPNacimiento.Text;
            empleado.CURP = tbCURP.Text;
            empleado.NSS = tbNSS.Text;
            empleado.RFC = tbRFC.Text;
            empleado.domicilio = tbCalle.Text;
            empleado.banco = cbBanco.Text;
            empleado.numCuenta = tbCuenta.Text;
            empleado.telefono = tbEmail.Text;

            error = conex.InsertEmpleado(empleado);
            //ESTO ES PARA SACAR EL VALOR DE UN COMBO BOX 
            //MessageBox.Show(this.cbEstado.SelectedItem.ToString());
        }
    }
}
