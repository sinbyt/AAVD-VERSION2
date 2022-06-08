using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cassandra;
using System.Windows.Forms;
using static WindowsFormsApp2.LOGIN;
using static WindowsFormsApp2.FUNCIONES;

using static Lists;


namespace WindowsFormsApp2
{

    public partial class formAgregar : Form
    {

        formBorrar NuevoBorrado;
        formCambiar NuevoCambiado;
        REPORTEGENERALDENOMINA NuevoReporteN;
        Lista_de_Empleados NuevaListaEmp;
        HeadCounter NuevoHeadcounter;
        //private BUSSINESLOGICLAYER _BussinesLogicLayer;
        public formAgregar()
        {
            InitializeComponent();
            //_BussinesLogicLayer = new BUSSINESLOGICLAYER();
            NuevoBorrado = new formBorrar();
            NuevoCambiado = new formCambiar();
            NuevoReporteN = new REPORTEGENERALDENOMINA();
            NuevaListaEmp = new Lista_de_Empleados();
            NuevoHeadcounter = new HeadCounter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //if()

            var conex = new WindowsFormsApplication2.EnlaceCassandra();

            var error = false;
            Empleado empleado = new Empleado();
            //empleado.ID_Empleado=

            empleado.nombre = tbNombre.Text;
            empleado.apellidos = tbApellidos.Text;
            empleado.fechaAlta = DTPAlta.Text;

            empleado.depa = cbDepartamento.Text;
            empleado.puesto = cbPuesto.Text;
            empleado.fechaNacimiento = DTPNacimiento.Text;

          //Calcular Edad
            DateTime today = DateTime.Today;
            DateTime bday = DateTime.Parse(empleado.fechaNacimiento);
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age))
                age--;
            empleado.edad = age;

            empleado.CURP = mtbCURP.Text;
            empleado.NSS = mtbNSS.Text;
            empleado.RFC = tbRFC.Text;
            empleado.domicilio = tbCalle.Text;
            empleado.banco = cbBanco.Text;
            empleado.numCuenta = tbCuenta.Text;
            //empleado.telefono = tbCuenta.Text;
            //empleado.email = tbCuenta.Text;
            empleado.contra = tbCuenta.Text;
        
            if (EsValidoRFC(empleado.RFC) ==false)
            {
                MessageBox.Show("Porfavor ponga un RFC valido", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (EsValidoCURP(empleado.CURP) == false)
            {
                MessageBox.Show("Porfavor ponga un CURP valido", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbNombre.Text != "" && tbApellidos.Text != "" && cbDepartamento.Text != "" && cbPuesto.Text != "" && mtbCURP.Text != "" && mtbNSS.Text != "" && DTPNacimiento.Text != "" && tbRFC.Text != "" && tbCalle.Text != "" && cbBanco.Text != "" && tbCuenta.Text != "" && mtbTelefono.Text != "")
            {
                MessageBox.Show("Bienvenido al equipo!", "FELICIDADES!!!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Porfavor agregue la informacion completa", "ERROR");
                  tbNombre.Text = "";
                tbApellidos.Text = "";
                cbDepartamento.Text = "";
                cbPuesto.Text = "";
                mtbCURP.Text = "";
                mtbNSS.Text = "";
                DTPNacimiento.Text = "";
                tbRFC.Text = "";
                tbCalle.Text = "";
                cbBanco.Text = "";
                tbCuenta.Text = "";
               
                tbColonia.Text= "";
                mtbNSS.Text = "";
                mtbNum.Text = "";
                tbID.Text = "";
                tbEmail.Text = "";
                tbMunicipio.Text = "";
                mtbCP.Text = "";

            }
            tbNombre.Text = "";
            tbApellidos.Text = "";
            cbDepartamento.Text = "";
            cbPuesto.Text = "";
            mtbCURP.Text = "";
            mtbNSS.Text = "";
            DTPNacimiento.Text = "";
            tbRFC.Text = "";
            tbCalle.Text = "";
            cbBanco.Text = "";
            tbCuenta.Text = "";
            mtbTelefono.Text = "";
            tbColonia.Text = "";
            mtbNSS.Text = "";
            mtbNum.Text = "";
            tbID.Text = "";
            tbEmail.Text = "";
            tbMunicipio.Text = "";
            mtbCP.Text = "";
            error = conex.InsertEmpleado(empleado);
            //ESTO ES PARA SACAR EL VALOR DE UN COMBO BOX 
            //MessageBox.Show(this.cbEstado.SelectedItem.ToString());


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
            NuevoHeadcounter.ShowDialog();

        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaListaEmp.ShowDialog();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoReporteN.ShowDialog();
        }

        private void borrarEmpleadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NuevoBorrado.ShowDialog();
        }

        private void editarEmpleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NuevoCambiado.ShowDialog();
        }

        private void listaDeEmpleadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NuevaListaEmp.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
