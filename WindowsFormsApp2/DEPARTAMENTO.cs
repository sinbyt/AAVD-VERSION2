﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static List;


namespace WindowsFormsApp2
{
    public partial class DEPARTAMENTO : Form
    {
        public DEPARTAMENTO()
        {
            InitializeComponent();
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
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento();
            departamento.nomDepa = depaText.Text;
            departamento.sueldoBase = sueldotext.Text;

        }
    }
}
