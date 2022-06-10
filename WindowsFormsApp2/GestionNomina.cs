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
        private int n = 0;
        AGREGARPERCEPCION NuevaNomina;
        //EliminarP NuevaEliminada;
        EDITAR_NOMINA NuevaNominaEditada;
        PUESTO PuestoNuevo;
        //  BUSCARNOMINA BuscarNomina;
        DEPARTAMENTO NuevoDepartamento;
        PUESTO NuevoPuesto;
        Nomina.Individual_Nomina NuevaNominaIndividual;

        public FORMNOMINA()
        {
            InitializeComponent();
            //CONEXION CON CASSANDRA

            var conex = new WindowsFormsApplication2.EnlaceCassandra();


            var nmnSource = conex.GetAllNomina();

            foreach (NOMINA nominita in nmnSource)
            {

                int cuenta = dgvNomina.Rows.Add();
                dgvNomina.Rows[cuenta].Cells[0].Value = nominita.numemp;
                dgvNomina.Rows[cuenta].Cells[1].Value = nominita.nomemple;
                dgvNomina.Rows[cuenta].Cells[2].Value = nominita.fechanom;
                dgvNomina.Rows[cuenta].Cells[3].Value = nominita.sueldoB;
                dgvNomina.Rows[cuenta].Cells[4].Value = nominita.depa;
                dgvNomina.Rows[cuenta].Cells[5].Value = nominita.puesto;
                dgvNomina.Rows[cuenta].Cells[6].Value = nominita.sueldoN;


                //(puesto.nomPuesto);

            }

            //CONEXION CON CASSANDRA
            NuevaNomina = new AGREGARPERCEPCION();
            //  NuevaEliminada = new EliminarP();
            NuevaNominaEditada = new EDITAR_NOMINA();
            PuestoNuevo = new PUESTO();
            // BuscarNomina = new BUSCARNOMINA();
            NuevoDepartamento = new DEPARTAMENTO();
            NuevoPuesto = new PUESTO();
            NuevaNominaIndividual = new Nomina.Individual_Nomina();
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
            var NuevoEmp = new Lists.Empleado();

            string sueldoBase = "";
            string nivelSalarial = "";
            double cantidad = 0.0;
            double cantidad2 = 0.0;


            //EnlaceCassandra enlace = new EnlaceCassandra();
            var dptoSource = conex.GetDepa();
            var pstoSource = conex.GetPuesto();
            var dedSource = conex.Get_All_deduc();
            var perSource = conex.Get_All_per();

            var empsource = conex.Get_All_Empleado();


            cbDepartamento.Items.Add(dptoSource);
            cbPuesto.Items.Add(pstoSource);

            cbPuesto.Items.Add(pstoSource);

            //Generar todos los empleados=====================================================================
         //   if (checkBox1.Checked == true)
           // {
                foreach (Lists.Empleado nuevoem in empsource)
                {


                    List<string> listaPercepciones = new List<string>();
                    List<string> listaDeducciones = new List<string>();

                    NuevaNom.fechanom = tbanio.Text + "/" + cbMes.Text + "/" + "01";
                    NuevaNom.numemp = nuevoem.ID_Empleado;
                    //NuevaNom.nomemple = nuevoem.nombre;


                    int dias = GetLastDayOfMonth(NuevaNom.fechanom);
                    NuevaNom.jornada = dias;
                    //Se obtiene el sueldo base

                    foreach (Departamento departamento in dptoSource)
                    {
                        if (departamento.nomDepa == nuevoem.depa)
                        {
                            NuevaNom.depa = nuevoem.depa;
                            sueldoBase = departamento.sueldoBase;
                            break;
                        }
                    }
                    //Se obtiene la base salarial

                    foreach (Puesto puesto in pstoSource)
                    {
                        if (puesto.nomPuesto == nuevoem.puesto)
                        {
                            NuevaNom.puesto = nuevoem.puesto;
                            nivelSalarial = puesto.proporSal;
                            break;
                        }
                    }
                    // CALCULO SUELDO BRUTO
                    double sueldob = float.Parse(nivelSalarial) * double.Parse(sueldoBase) * dias;
                    // NuevaNom.sueldoB = string.Format("{0:c}", sueldob);
                    NuevaNom.sueldoB = sueldob;

                    //SUMAR PERCEPCIONES
                    foreach (String str in lbPercepciones.Items)
                    {

                        foreach (PERDEC per in perSource)
                        {
                            if (per.conceptoPD == str)
                            {
                                if (per.tipoDato == "Porcentaje")
                                {
                                    cantidad += getPorcentaje(NuevaNom.sueldoB, double.Parse(per.monto));
                                //conex.insert_listadeduc(nuevoem.ID_Empleado,NuevaNom.fechanom,"Percecpcion",per.conceptoPD,String.Format(cant,{ 0:c} ));
                                }
                                else
                                {
                                    cantidad += double.Parse(per.monto);

                                }
                                listaPercepciones.Add(per.conceptoPD);
                               // NuevaNom.perpepT = NuevaNom.perpepT + cantidad;

                                break;
                            }
                        }
                    }


                    //SUMAR DEDUCCIONES
                    foreach (String str in lbDeducciones.Items)
                    {

                        foreach (PERDEC dec in dedSource)
                        {
                            if (dec.conceptoPD == str)
                            {
                                if (dec.porcentPD == "Porcentaje")
                                {
                                    cantidad2 += getPorcentaje(NuevaNom.sueldoB, double.Parse(dec.monto));

                                }
                                else
                                {
                                    cantidad2 += double.Parse(dec.monto);

                                }
                                listaDeducciones.Add(dec.conceptoPD);

                                //NuevaNom.deduccT = NuevaNom.deduccT + cantidad2;

                                break;
                            }
                        }
                    }
                if (listaDeducciones.Any()==false) {
                    listaDeducciones.Add( " ");

                }
          

                if (comboBox1.Text == "Porcentaje") {

                    cantidad2+=getPorcentaje(sueldob, double.Parse(mtbISR.Text));
                    listaDeducciones.Add("ISR");


                }
                else {
                    cantidad2+= double.Parse(mtbISR.Text);
                    listaDeducciones.Add("ISR");
                }

                if (comboBox2.Text == "Porcentaje")
                {
                    cantidad2 += getPorcentaje(sueldob, double.Parse(mtbIMSS.Text));
                    listaDeducciones.Add("IMSS");

                }
                else {

                    cantidad2+= double.Parse(mtbIMSS.Text);
                    listaDeducciones.Add("IMSS");

                }


                //CALCULO SUELDO  NETO
                double sueldon = sueldob +cantidad -cantidad2;

                    NuevaNom.numemp = nuevoem.ID_Empleado;
                    NuevaNom.nomemple = nuevoem.nombre + " " + nuevoem.apellidos;
                    //NuevaNom.fechanom = "2022/02/02";
                    NuevaNom.percep = listaPercepciones;
                    NuevaNom.perpepT = cantidad.ToString();
                    NuevaNom.deducc = listaDeducciones;
                     NuevaNom.deduccT = cantidad2.ToString();
                    NuevaNom.sueldoB = sueldob;
                    NuevaNom.sueldoN = sueldon;
                    // NuevaNom.jornada = 30;
                    // NuevaNom.depa = "?";
                    //NuevaNom.puesto = "?";



                    error = conex.InsertNomina(NuevaNom);
                    if (error)
                    {
                        MessageBox.Show("No se pudo agregar");
                    }
                    else
                    {


                        MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "NUEVO DEPARTAMENTO!!!", MessageBoxButtons.OK);
                    }
                }

          //  }

        }
        
    //text1.Write(NuevaNom.fechanom + "," + NuevaNom.percept + "," + NuevaNom.deducc + "," + NuevaNom.jornada + "," + NuevaNom.depa + "," + NuevaNom.puesto);
    //            text1.Close();


      


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
            text1.Write(cbMes.Text + "," + tbanio.Text + "," + cbPercepciones.Text + "," + cbDeducciones.Text + "," + cbDepartamento.Text + "," + cbPuesto.Text);
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

        private void editarIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaNominaIndividual.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //EDITAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAR
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow nuevorenglon = dgvNomina.Rows[n];
            nuevorenglon.Cells[0].Value = mtbISR.Text;
            nuevorenglon.Cells[1].Value = mtbIMSS.Text;

            MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "Se han hecho los cambios deseados!!!", MessageBoxButtons.OK);

        }
        //ELIMINAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAR
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (n >= 0)
            {
                dgvNomina.Rows.RemoveAt(n);
                MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "Se elimino la informacion correctamente!!!", MessageBoxButtons.OK);

            }
        }
        //IMPRIMIR A TEXT BOOOOOOOOOOOOOOOOOOOOOOOOOOOOX
        private void dgvNomina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            DataGridViewRow renglon = dgvNomina.Rows[n];

            mtbIMSS.Text = renglon.Cells[0].Value.ToString();
            mtbISR.Text = renglon.Cells[1].Value.ToString();
        }
    }


}
