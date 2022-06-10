using System;
using System.Collections;
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
using static WindowsFormsApp2.FUNCIONES;
using static Lists;
namespace WindowsFormsApp2
{
    public partial class Recibo_EMP : Form
    {
        public Recibo_EMP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPDF_Click(object sender, EventArgs e)
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
                        //DATOS DE FECHA
                        doc.Add(new iTextSharp.text.Phrase(cbFecha.Text + " "));
                        doc.Add(new iTextSharp.text.Phrase(listBox3.Text + " " + "/n"));

                        //DATOS DE LA EMPRESA
                        doc.Add(new iTextSharp.text.Phrase(tbRazon.Text + " "));
                        doc.Add(new iTextSharp.text.Phrase(tbDomicilio.Text + " "));
                        doc.Add(new iTextSharp.text.Phrase(tbRFCEMP.Text + " "));
                        doc.Add(new iTextSharp.text.Phrase(tbInicio.Text + " "+ "/n"));

                        //DATOS DE EMPLEADO
                        doc.Add(new iTextSharp.text.Phrase(tbEmpleado.Text + " "));
                        doc.Add(new iTextSharp.text.Phrase(tbNSS.Text + " "));
                        doc.Add(new iTextSharp.text.Phrase(tbCURP.Text + " "));
                        doc.Add(new iTextSharp.text.Phrase(tbRFC.Text + " "));
                        doc.Add(new iTextSharp.text.Phrase(tbID.Text + " " + "/n"));

                        //DATOS DE PUESTO
                        doc.Add(new iTextSharp.text.Phrase(tbPuesto.Text + " "));
                        doc.Add(new iTextSharp.text.Phrase(tbDepa.Text)); 
                        doc.Add(new iTextSharp.text.Phrase(tbDias.Text + " "));
                        doc.Add(new iTextSharp.text.Phrase(tbSalario.Text + " "));

                        //LISTAS DE PERCEPCIONES Y DEDUCCIONES

                        doc.Add(new iTextSharp.text.Paragraph(lbPer.Text + " "));
                        doc.Add(new iTextSharp.text.Paragraph(lbDec.Text + " "));
                        //doc.Add(new iTextSharp.text.Paragraph(RTB.Text));
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

        private void button1_Click(object sender, EventArgs e)
        {
            var conex = new WindowsFormsApplication2.EnlaceCassandra();

            var error = false;
            RECIBO recibo = new RECIBO();
            recibo.nomemple = tbEmpleado.Text;

            //recibo.

            /*
              AQUI ESTA EL CSV AAAAAAAAAAAAAAAAAAAAAAAA
            private async void btnCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TEXT Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                   // iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteAsync(NOMBRE DE TEXTBOX.Rtf);
                        }
                    }                                    
                    catch (Exception ex)
                    {
                        
                    }
                    finally
                    {
                        //doc.Close();
                    }
                }
            }
        }

             */
        }
    }
}
