using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp2
{
    public partial class Lista_de_Empleados : Form
    {
        public Lista_de_Empleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF FILE|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        //GRIDEMPLEADOS ES COMO SE LLAMA LA TABLA 
                        doc.Add(new iTextSharp.text.Paragraph(gridEmpleados.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
    }
}
