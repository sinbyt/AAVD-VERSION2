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

namespace WindowsFormsApp2
{
    public partial class PUESTO : Form
    {
        private int n = 0;

        public PUESTO()
        {
            InitializeComponent();
            var conex = new WindowsFormsApplication2.EnlaceCassandra();


            var pstSource = conex.GetPuesto();

            foreach (Puesto puesto in pstSource)
            {

                int cuenta = dgvPuesto.Rows.Add();
                dgvPuesto.Rows[cuenta].Cells[0].Value = puesto.nomPuesto;
                dgvPuesto.Rows[cuenta].Cells[1].Value = puesto.proporSal;

                //(puesto.nomPuesto);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            var conex = new WindowsFormsApplication2.EnlaceCassandra();
            var error = false;

            Lists.Puesto NuevoPuesto = new Lists.Puesto();
            NuevoPuesto.nomPuesto = tbNombre.Text;
            NuevoPuesto.proporSal = tbPorcentaje.Text;
            if (tbNombre.Text != "" && tbPorcentaje.Text != "")
            {
                error = conex.InsertPuesto(NuevoPuesto);


                if (error)
                {
                    MessageBox.Show("No se pudo agregar el puesto");
                }
                else
                {
                    MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "NUEVO PUESTO!!!", MessageBoxButtons.OK);

                    // MessageBox.Show("el alumno se agregó con éxito.");
                    tbNombre.Text = "";
                    tbPorcentaje.Text = "";

                }
                
            }
            
            //DataGridViewRow fila = new DataGridViewRow();
           // fila.CreateCells(dgvPuesto);
            
        }

        private void NuevoPuesto_Load(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
        //LLENAR TB CON RENGLON ACTUAL
        private void dgvPuesto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            DataGridViewRow renglon = dgvPuesto.Rows[n];

            tbNombre.Text = renglon.Cells[0].Value.ToString();
            tbPorcentaje.Text = renglon.Cells[1].Value.ToString();

            if (n >= 0)
            {
                
            }
        }
        //ELIMINAR
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (n>= 0)
            {
                dgvPuesto.Rows.RemoveAt(n);
            }
        }
        //EDITAAAAAAAAAAAAAAAAAAAAAAAAAR
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow nuevorenglon = dgvPuesto.Rows[n];
            nuevorenglon.Cells[0].Value = tbNombre.Text;
            nuevorenglon.Cells[1].Value = tbPorcentaje.Text;

        }
    }
}
