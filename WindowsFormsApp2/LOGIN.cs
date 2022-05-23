using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.FUNCIONES;
using static WindowsFormsApp2.LOGIN;
namespace WindowsFormsApp2
{
    public partial class LOGIN : Form
    {
        
        public LOGIN()
        {
            InitializeComponent();
            
            
        }
        //SE QUEDA COMO NULO A LA VERGA NO SE PORQUE A LA VERGA ME CAGA A LA VERGA AAAAAAAAAAAAAAAA
        //string usuario = tbUsuario;
        string USUARIO;
        string CONTRA;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbUsuario.Text = USUARIO;
            tbContra.Text = CONTRA;
            if(USUARIO == "Diego" && CONTRA == "GUAPOTE")
            {
                MessageBox.Show("USTED INICIO SESION", "Buenas noticias",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("USTED la cago", "Buenas noticias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
