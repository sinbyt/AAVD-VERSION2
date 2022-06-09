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
    public partial class FORMNOMINA : Form
    {
        AGREGARPERCEPCION NuevaNomina;
        EDITAR_NOMINA NuevaNominaEditada;
        PUESTO PuestoNuevo;
        DEPARTAMENTO NuevoDepartamento;
        PUESTO NuevoPuesto;

        public FORMNOMINA()
        {
            InitializeComponent();
            NuevaNomina = new AGREGARPERCEPCION();
            NuevaNominaEditada = new EDITAR_NOMINA();
            PuestoNuevo = new PUESTO();
            NuevoDepartamento = new DEPARTAMENTO();
            NuevoPuesto = new PUESTO();

            var conex = new WindowsFormsApplication2.EnlaceCassandra();
           // var error = false;

            var dptoSource = conex.GetDepa();
            var pstSource = conex.GetPuesto();
            var perSource = conex.Get_All_per();
            var dedSource = conex.Get_All_deduc();


            //carga depas
            foreach (Departamento nuevodepa in dptoSource)
            {
                cbDepartamento.Items.Add(nuevodepa.nomDepa);
                
            }
            //carga puesto
            foreach (Puesto puesto in pstSource)
            {
                cbPuesto.Items.Add(puesto.nomPuesto);

            }
            //carga percepciones
            
            foreach (PERDEC perdec in perSource)
            {
                cbPercepciones.Items.Add(perdec.conceptoPD);

            }
            
            //carga deducciones

            foreach (PERDEC perdec in dedSource)
            {
                cbDeducciones.Items.Add(perdec.conceptoPD);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  NuevaEliminada.ShowDialog();
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
            var conex = new WindowsFormsApplication2.EnlaceCassandra();
            var error = false;
           
            lbPercepciones.Items.Add(cbPercepciones.Text);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  BuscarNomina.ShowDialog();
        }
        //GENERA NOMINA
        private void button7_Click(object sender, EventArgs e)
        {
            
            var conex = new WindowsFormsApplication2.EnlaceCassandra();
            var error = false;
            NOMINA NuevaNom = new NOMINA();
            Empleado NuevoEmp = new Empleado();
            string sueldoBase="";
            string nivelSalarial="";
            //EnlaceCassandra enlace = new EnlaceCassandra();
            var dptoSource = conex.GetDepa();
            var pstoSource = conex.GetPuesto();
            var dedSource = conex.Get_All_deduc();
            var perSource = conex.Get_All_per();

            var empsource = conex.Get_All_Empleado();

            NuevaNom.FechaNom = cbAnio.Text +"/" + cbMes.Text + "/" + "01" ;

            cbDepartamento.Items.Add(dptoSource);
            cbPuesto.Items.Add(pstoSource);

            cbPuesto.Items.Add(pstoSource);


           

            /*
            var ID_Empleado = new Guid();
            ID_Empleado = Guid.NewGuid();

            var fechaAlta = DateTime.Now.ToString("yyyy'-'MM'-'dd");
            */
         


           // NuevaNom.percep = cbPercepciones.Text;

            //NuevaNom.deducc = cbDeducciones.Text;
            float.Parse(NuevaNom.sueldoB);
            // NuevaNom.deducc =
            //NuevaNom.jornada = cbDias.Text;
            // NuevaNom.depa = cbDepartamento.Text;
            // NuevaNom.puesto = cbPuesto.Text;

            // CALCULO SUELDO BRUTO
            //  double sueldob = float.Parse(nivelSalarial) * double.Parse(sueldoBase) * dias;
            // NuevaNom.sueldoB = string.Format("{0:c}", sueldob);

            //CALCULO SUELDO  NETO
            //   double sueldon = sueldob + double.Parse(NuevaNom.percep) - double.Parse(NuevaNom.deducc);

            //generar todos los empleados
            foreach (Empleado nuevoem in empsource) {


                List<string> listaPercepciones = new List<string>();
                List<string> listaDeducciones = new List<string>();

                int dias = GetLastDayOfMonth(NuevaNom.FechaNom);
                NuevaNom.jornada = dias;
                //Se obtiene el sueldo base

                foreach (Departamento departamento in dptoSource)
                {
                    if (departamento.nomDepa == NuevoEmp.depa)
                    {
                        sueldoBase = departamento.sueldoBase;
                        break;
                    }
                }

                //Por cada deduccion que le pertenezca al empleado en cuestion, se calcula, abona y docuemtna
                //lbPercepciones=

                foreach (PERDEC per in perSource)
                {
                    if (per.conceptoPD == lbPercepciones.Text)
                    {
                        if (per.tipoDato == "Porcentaje")
                        {
                            double cantidad= getPorcentaje(double.Parse(NuevaNom.sueldoB), double.Parse(per.monto));

                            //new listadeduc= listadeduc new ();
                            
                            //  listaPer.Add(per.conceptoPD, StringFormat({0:c}, cantidad));

                           

                        }
                        else {
                       //     listaPer.Add(per.conceptoPD, per.monto);

                        }

                        break;
                    }
                }
                foreach (Departamento departamento in dptoSource)
                {
                    if (departamento.nomDepa == NuevoEmp.depa)
                    {
                        sueldoBase = departamento.sueldoBase;
                        break;
                    }
                }
                NuevaNom.nomEmple = nuevoem.nombre;
                NuevaNom.numEmp = nuevoem.ID_Empleado;
                NuevaNom.depa = nuevoem.depa;
                NuevaNom.puesto = nuevoem.puesto;
                


            }

            error = conex.InsertNomina(NuevaNom);


            //text1.Write(NuevaNom.FechaNom + "," + NuevaNom.percept + "," + NuevaNom.deducc + "," + NuevaNom.jornada + "," + NuevaNom.depa + "," + NuevaNom.puesto);
            //            text1.Close();

        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoDepartamento.ShowDialog();
        }

        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPuesto.ShowDialog();
        }
        //GENERA CSV
        private void btnCSV_Click(object sender, EventArgs e)
        {
            TextWriter text1 = new StreamWriter(@"C:\Users\E\source\repos\WindowsFormsApp2\CSV");
            text1.Write(cbMes.Text + "," + cbAnio.Text + "," + cbPercepciones.Text + "," + cbDeducciones.Text + "," + cbDepartamento.Text + "," + cbPuesto.Text);
            text1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //agregar deducciones al list box
            lbDeducciones.Items.Add(cbDeducciones.Text);

        }

        private void lbPercepciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                cbDepartamento.Enabled = false;
                cbPuesto.Enabled = false;
                    }
            else
            {
                cbDepartamento.Enabled = true;
                cbPuesto.Enabled = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        /*  private void checkBox1_CheckedChanged(object sender, EventArgs e)
          {
              if (checkBox1.Checked)
              {
                  cbDepartamento.Enabled = false;
                  cbPuesto.Enabled = false;
              }
              else
              {
                  cbDepartamento.Enabled = true;
                  cbPuesto.Enabled = true;
              }
          }*/
    }
}
