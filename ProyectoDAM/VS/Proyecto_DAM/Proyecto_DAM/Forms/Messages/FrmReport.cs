using Control;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms.Messages
{
    public partial class FrmReport : Form
    {
        string name, surnames;
        int idContact, idSale;
        double subtotal=0;
        public FrmReport(int idContact)
        {
            InitializeComponent();
            this.idContact = idContact;
        }

        private void DatePickerInit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            DatePickerFinal.Value = DateTime.Now;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            // OBTENER TODOS LOS DATOS COMO EN LA FACTURA GUARDADOS EN LA BBDD
            iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 10f, 10f, 0f);
            //Llamas el metodo GenerarDocumentos
            GeneratePDF(pdfDoc);

            this.Close();

            //EXPLICACION PARA SACAR LOS DATOS
            //---------------------------------
            //TENEMOS UNA LISTA --> sales
            //LOS OBJETOS DE ESA LISTA SON DEL TIPO --> V_SALES_BETWEEN_DATES
            //AL SER UNA LISTA ENUMERABLE LOS DATOS LOS SACAMOS DE ESTA MANERA
            //LO RECORREMOS CON UN FOREACH Y DENTRO DE EL COGEMOS LOS ATRIBUTOS QUE QUERAMOS


        }

        private void GeneratePDF(iTextSharp.text.Document document)
        {
            db_devloEntities db = new db_devloEntities();

            IEnumerable<V_SALES_BETWEEN_DATES> sales = db.V_SALES_BETWEEN_DATES.ToList().Where(x => x.FECHA_PEDIDO >= DatePickerInit.Value.Date
                                                                                                && x.FECHA_PEDIDO <= DatePickerFinal.Value.Date
                                                                                                && x.IDCONTACT == idContact);


            foreach (V_SALES_BETWEEN_DATES registro in sales)
            {

                //LOS ATRIBUTOS LOS PILLAMOS DE ESTA MANERA 
                //Y YA PUES LOS ALMACENAS EN DONDE TU QUIERAS O LOS UTILIZAR PARA EL HTML, COMO VEAS
                name = registro.NAME;
                surnames = registro.SURNAMES;
                idSale = registro.IDCAB;
                
            }

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = name + "_" + surnames + "_ReporteHasta_" + DatePickerFinal.Value.ToString().Substring(0, 10).Replace('/', '_');
            save.Filter = "PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            save.FilterIndex = 1;
            string html = Properties.Resources.report_generator.ToString();
            // REEMPLAZAMOS POR LOS DATOS
            html = html.Replace("@Customer", name+" "+surnames);
            html = html.Replace("@Number", idSale.ToString());
            


            string rows = string.Empty;

            foreach (V_SALES_BETWEEN_DATES registro in sales)
            {
                rows += "<tr>";
                rows += "<td style=\"text-align:center\">" + registro.FECHA_PEDIDO.ToString().Substring(0,10) + "</td>";
                rows += "<td style=\"text-align:right\">" + registro.UNITS + "</td>";
                rows += "<td style=\"text-align:center\">" + registro.PRODUCTO + "</td>";
                rows += "<td style=\"text-align:right\">" + registro.SELL_PRICE + "</td>";
                rows += "<td style=\"text-align:right\">" + registro.IMPORTE + "€</td>";
                rows += "</tr>";
                subtotal += Convert.ToDouble(registro.TOTAL_PRICE);
            }

            // REEMPLAZAMOS POR EL CODIGO CON LA INFORMACION
            html = html.Replace("@Filas", rows);
            html = html.Replace("@Subtotal", subtotal.ToString() + "€");

            double iva = Math.Round(Convert.ToDouble(subtotal * 0.21),2);
            html = html.Replace("@IVA", iva.ToString() + "€");

            double total = Math.Round(Convert.ToDouble(subtotal + iva),2);
            html = html.Replace("@Total", "  " + total.ToString() + "€");


            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    Document pdf = new Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
                    iTextSharp.text.pdf.PdfWriter writer = PdfWriter.GetInstance(pdf, stream);

                    pdf.Open();

                    StringReader sr = new StringReader(html);

                    pdf.Add(new Paragraph());

                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, sr);


                    pdf.Close();
                    stream.Close();
                }
            }
        }
    }
}
