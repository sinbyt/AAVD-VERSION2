﻿using System;
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
        private int n = 0;
        //formBorrar NuevoBorrado;
        //formCambiar NuevoCambiado;
        REPORTEGENERALDENOMINA NuevoReporteN;
        //Lista_de_Empleados NuevaListaEmp;
        HeadCounter NuevoHeadcounter;
        //private BUSSINESLOGICLAYER _BussinesLogicLayer;
        public formAgregar()
        {
            InitializeComponent();
            //_BussinesLogicLayer = new BUSSINESLOGICLAYER();
            //NuevoBorrado = new formBorrar();
            //NuevoCambiado = new formCambiar();
            //NuevoReporteN = new REPORTEGENERALDENOMINA();
            //NuevaListaEmp = new Lista_de_Empleados();
            //NuevoHeadcounter = new HeadCounter();
            var conex = new WindowsFormsApplication2.EnlaceCassandra();
            

            var dptoSource = conex.GetDepa();
            var pstSource = conex.GetPuesto();
          //  var perSource = conex.Get_All_per();
            //var dedSource = conex.Get_All_deduc();


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
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            var conex = new WindowsFormsApplication2.EnlaceCassandra();
            var error = false;
            
            Lists.Empleado empleado = new Lists.Empleado();
            //Guid num_empleado = Guid.NewGuid();

            //empleado.ID_Empleado = num_empleado;
            /*
            empleado.nombre = "hola";
            empleado.apellidos = "mi";
            empleado.fechaAlta = "nombre";

            empleado.depa = "es";
            empleado.puesto = "fray";
            empleado.fechaNacimiento = "ernesto";

            
            empleado.edad = 17;

            empleado.CURP = "perez";
            empleado.NSS = "y";
            empleado.RFC = "vengo";
            empleado.domicilio = "a";
            empleado.banco = "celebrar";
            empleado.numCuenta = "la";
            empleado.telefono ="lala";
            empleado.email = "lalaa";
            empleado.contra = "larala";
            */

            
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
                        empleado.domicilio = tbCalle.Text + ", " + mtbNum.Text+", "+tbColonia.Text + ", " +mtbCP.Text + ", " +tbMunicipio.Text + ", " +cbEstado.Text ;
                        empleado.banco = cbBanco.Text;
                        empleado.numCuenta = tbCuenta.Text;
                        empleado.telefono = mtbTelefono.Text;
                        empleado.email = tbEmail.Text;
                        empleado.contra = tbcontra.Text;
                        
            // if (tbNombre.Text != "" && tbApellidos.Text != "" && cbDepartamento.Text != "" && cbPuesto.Text != "" && mtbCURP.Text != "" && mtbNSS.Text != "" && DTPNacimiento.Text != "" && tbRFC.Text != "" && tbCalle.Text != "" && cbBanco.Text != "" && tbCuenta.Text != "" && mtbTelefono.Text != "")
            //{
            // public Guid id_emp;


            // if (EsValidoRFC(empleado.RFC) == false)
            // {
            //   MessageBox.Show("Porfavor ponga un RFC valido", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
            /*
            else if (EsValidoCURP(empleado.CURP) == false)
            {
                MessageBox.Show("Porfavor ponga un CURP valido", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            //else  {
            error = conex.InsertEmpleado(empleado);

                   if (error)
                    {
                        MessageBox.Show("No se pudo agregar al alumno");
                    }
                    else{


                        MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "NUEVO DEPARTAMENTO!!!", MessageBoxButtons.OK);

                        // MessageBox.Show("el alumno se agregó con éxito.");
                        MessageBox.Show("Bienvenido al equipo!", "FELICIDADES!!!", MessageBoxButtons.OK);
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

                    }
                //}
           // }

           
          /*
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
            */
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
            //NuevoBorrado.ShowDialog();
        }

        private void editarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NuevoCambiado.ShowDialog();
        }

        private void headCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoHeadcounter.ShowDialog();

        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  NuevaListaEmp.ShowDialog();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoReporteN.ShowDialog();
        }

        private void borrarEmpleadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           // NuevoBorrado.ShowDialog();
        }

        private void editarEmpleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //NuevoCambiado.ShowDialog();
        }

        private void listaDeEmpleadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //NuevaListaEmp.ShowDialog();

        }
        //EDITARRRRRRRRR
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow nuevorenglon = dgvEmpleado.Rows[n];
            nuevorenglon.Cells[0].Value = tbNombre.Text;
            //nuevorenglon.Cells[1].Value = tbPorcentaje.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //ELIMINARRRRRRRRRRRRRRRRRRRRRRRRRR
        private void button3_Click(object sender, EventArgs e)
        {
            if (n >= 0)
            {
                dgvEmpleado.Rows.RemoveAt(n);
            }
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            DataGridViewRow renglon = dgvEmpleado.Rows[n];


            tbID.Text = renglon.Cells[0].Value.ToString();
            tbApellidos.Text = renglon.Cells[1].Value.ToString();
            tbNombre.Text = renglon.Cells[2].Value.ToString();
            tbNombre.Text = renglon.Cells[3].Value.ToString();
            tbNombre.Text = renglon.Cells[4].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbNombre.Text = renglon.Cells[0].Value.ToString();
        }
    }
}
