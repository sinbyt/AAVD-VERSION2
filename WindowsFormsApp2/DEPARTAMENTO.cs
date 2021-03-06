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
using static WindowsFormsApp2.FUNCIONES;


namespace WindowsFormsApp2
{
    public partial class DEPARTAMENTO : Form
    {
        private int n= 0;
        

        public DEPARTAMENTO()
        {
            
           // List<Departamento> lst = new List<Departamento>();
            InitializeComponent();
            var conex = new WindowsFormsApplication2.EnlaceCassandra();


            var dptoSource = conex.GetDepa();

            foreach (Departamento nuevodepa in dptoSource)
            {
                int cuenta = dgvDepartamento.Rows.Add();
                dgvDepartamento.Rows[cuenta].Cells[0].Value = nuevodepa.nomDepa;
                dgvDepartamento.Rows[cuenta].Cells[1].Value = nuevodepa.sueldoBase;


            }
        }
        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            var conex = new WindowsFormsApplication2.EnlaceCassandra();
            var error = false;

            Departamento NuevoDepa = new Departamento();
            NuevoDepa.nomDepa = tbdepa.Text;
            NuevoDepa.sueldoBase = mtbSueldo.Text;
            if (tbdepa.Text != "" && mtbSueldo.Text != "")
            {
                error = conex.InsertDepa(NuevoDepa);


                if (error)
                {
                    MessageBox.Show("No se pudo agregar el departamento");
                }
                else
                {
                    MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "NUEVO DEPARTAMENTO!!!", MessageBoxButtons.OK);

                    // MessageBox.Show("el alumno se agregó con éxito.");
                    tbdepa.Text = "";
                    mtbSueldo.Text = "";

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DEPARTAMENTOS_Load(object sender, EventArgs e)
        {
            //foreach (Departamento d in lst)
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAgregar(object sender, EventArgs e)
        {
            var conex = new WindowsFormsApplication2.EnlaceCassandra();
            var error = false;

            Departamento NuevoDepa = new Departamento();
            NuevoDepa.nomDepa = tbdepa.Text;
            NuevoDepa.sueldoBase = mtbSueldo.Text;
            if (tbdepa.Text != "" && mtbSueldo.Text != "")
            {
                error = conex.InsertDepa(NuevoDepa);


                if (error)
                {
                    MessageBox.Show("No se pudo agregar al alumno");
                }
                else
                {
                    MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "NUEVO DEPARTAMENTO!!!", MessageBoxButtons.OK);

                   // MessageBox.Show("el alumno se agregó con éxito.");
                    tbdepa.Text = "";
                    mtbSueldo.Text = "";
                    
                }
            }
            //if (mtbRazon.Text != "" && mtbNombreEmp.Text != "" && mtbDomicilio.Text != "" && mtbINICIO.Text != "" && mtbRFC.Text != "")
            //{
            //    MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "MUCHAS GRACIAS!!!", MessageBoxButtons.OK);

            //}
            //mtbRazon.Text = "";
            //mtbNombreEmp.Text = "";
            //mtbDomicilio.Text = "";
            //mtbINICIO.Text = "";
            //mtbRFC.Text = "";

        }
        //EDITAR
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow nuevorenglon = dgvDepartamento.Rows[n];
            nuevorenglon.Cells[0].Value = tbdepa.Text;
            nuevorenglon.Cells[1].Value = mtbSueldo.Text;
            MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "Muchas gracias!!!", MessageBoxButtons.OK);

        }
        //ELIMINAR
        private void button3_Click(object sender, EventArgs e)
        {
            if (n >= 0)
            {
                dgvDepartamento.Rows.RemoveAt(n);
                MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "Se han eliminado los datos!!!", MessageBoxButtons.OK);

            }
        }
        //LLENAR TB CON RENGLON ACTUAL
        private void dgvDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            DataGridViewRow renglon = dgvDepartamento.Rows[n];

            tbdepa.Text = renglon.Cells[0].Value.ToString();
           mtbSueldo.Text = renglon.Cells[1].Value.ToString();

        }
    }
}
