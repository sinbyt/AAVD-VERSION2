﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra;
using static WindowsFormsApp2.FUNCIONES;
using static WindowsFormsApp2.LOGIN;
using static WindowsFormsApp2.EliminarP;
using static WindowsFormsApp2.formAgregar;

namespace WindowsFormsApp2
{
    public partial class LOGIN : Form
    {
        formInicio NuevoInicio;
        VENTANA1_EMPLEADO NuevaVentanaEmp;
        public LOGIN()
        {
            InitializeComponent();
            NuevoInicio = new formInicio();
            NuevaVentanaEmp = new VENTANA1_EMPLEADO();
        }
        //SE QUEDA COMO NULO A LA VERGA NO SE PORQUE A LA VERGA ME CAGA A LA VERGA AAAAAAAAAAAAAAAA
        //string usuario = tbUsuario;
        
        public void btnLogin_Click(object sender, EventArgs e)
        {
            string CB1 = cbTUsuario.Text;
            string T1 = tbUsuario.Text;
            string T2 = tbContra.Text;
            string COMBO = cbTUsuario.Text;
            if (CB1 == "")
            {
                MessageBox.Show("Porfavor seleccione su puesto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
                
            }
            else if (CB1 == "Empleado" && T1 == "DIEGO" && T2 == "22")
            {
                MessageBox.Show("USTED INICIO SESION", "Buenas noticias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NuevaVentanaEmp.ShowDialog();
            }
            else if (CB1 == "Gerente")
            {
                if (T1 == "DIEGO" && T2 == "22")
                {
                    MessageBox.Show("USTED INICIO SESION", "Buenas noticias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    NuevoInicio.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ha habido un error, intente otra vez", "Malas noticias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
