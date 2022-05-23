﻿using System;
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
    public partial class formInicioGT : Form
    {
        //formAgregar NuevoEmpleado;
        formBorrar NuevoBorrado;
        formCambiar NuevoCambiado;

        REPORTEGENERALDENOMINA NuevoReporteN;
        Lista_de_Empleados NuevaListaEmp;
        HeadCounter NuevoHeadcounter;

        public formInicioGT()
        {
            InitializeComponent();
           // NuevoEmpleado = new formAgregar();
            NuevoBorrado = new formBorrar();
            NuevoCambiado = new formCambiar();

            NuevoReporteN = new REPORTEGENERALDENOMINA();
            NuevaListaEmp = new Lista_de_Empleados();
            NuevoHeadcounter = new HeadCounter();

        }



        private void agregarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // NuevoEmpleado.ShowDialog();
        }


        private void headcounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nHeadCounter.ShowDialog();
        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nListaEMP.ShowDialog();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nReporte.ShowDialog();
        }

    }
}
