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
namespace WindowsFormsApp2
{
    public partial class LOGIN : Form
    {
        formInicio NuevoInicio;
        public LOGIN()
        {
            InitializeComponent();
            NuevoInicio = new formInicio();
            
        }
        //SE QUEDA COMO NULO A LA VERGA NO SE PORQUE A LA VERGA ME CAGA A LA VERGA AAAAAAAAAAAAAAAA
        //string usuario = tbUsuario;
        
        public void btnLogin_Click(object sender, EventArgs e)
        {
            string T1 = tbUsuario.Text;
            string T2 = tbContra.Text;
           
            if(T1 == "DIEGO" && T2 == "22")
            {
                MessageBox.Show("USTED INICIO SESION", "Buenas noticias",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NuevoInicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ha habido un error, intente otra vez", "Malas noticias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
