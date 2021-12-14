using Control;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Proyecto_DAM.Forms.Ventas;
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
using Document = iTextSharp.text.Document;
using Paragraph = iTextSharp.text.Paragraph;

namespace Proyecto_DAM.Forms.Sales
{
    public partial class FrmDetailSale : Form
    {
        int idSale;
        double price = 0;
        IEnumerable<V_SALESEDIT> vista ;
        db_devloEntities db = new db_devloEntities();

        public FrmDetailSale(int idSale)
        {
            InitializeComponent();
            this.idSale = idSale;
            vista = db.V_SALESEDIT.Where(x => x.IDCAB == idSale);
            TxtCliente.Text = vista.ElementAt(0).CONTACTO.ToString();
            TxtState.Text = vista.ElementAt(0).STATEDESCRIPTION.ToString();

            string date = vista.ElementAt(0).FECHA_PEDIDO.ToString().Substring(0, 10);
            DatePicker.Value = DateTime.Parse(date);

            price = double.Parse(vista.ElementAt(0).TOTAL_PRICE.ToString());
            LblEuros.Text = price.ToString() + ",00€";
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                int number1=0, number2=0;
                // LIBRERIA OFFICE
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                // AÑADIMOS HOJA EXCEL
                excel.Application.Workbooks.Add(true);

                int columnIndex = 0;

                excel.Cells[1, 1] = "Empresa: ";
                excel.Cells[1, 2] = TxtCliente.Text;
                excel.Cells[2, 1] = "Fecha: ";
                excel.Cells[2, 2] = DatePicker.Value.ToString().Substring(0,10);

                // LECTURA DE COLUMNAS
                foreach (DataGridViewColumn column in DataGridViewProductsInSale.Columns)
                {
                    columnIndex++;
                    excel.Cells[4, columnIndex] = column.Name.ToUpper();
                }

                int rowIndex = 3;
                int columnAux = 0;
                int rowAux = 4;
                // LECTURA DE FILAS
                foreach (DataGridViewRow fila in DataGridViewProductsInSale.Rows) 
                {
                    rowIndex++;
                    columnIndex = 0;
                    foreach (DataGridViewColumn column in DataGridViewProductsInSale.Columns)
                    {
                        columnIndex++;
                        excel.Cells[rowIndex + 1, columnIndex] = fila.Cells[column.Name].Value;

                        // ALMACENAMOS LA ULTIMA COLUMNA Y FILA CON REGISTROS PARA EL TOTAL
                        columnAux = columnIndex; 
                    }
                    rowAux = rowIndex;
                }
                // AÑADIMOS EL TOTAL
                excel.Cells[rowAux+3, columnAux] = "Subtotal: ";
                excel.Cells[rowAux + 3, columnAux+1] =LblEuros.Text;

                double iva = Math.Round(System.Convert.ToDouble(LblEuros.Text.Substring(0, LblEuros.Text.IndexOf('€'))) * 0.21, 2);
                excel.Cells[rowAux + 4, columnAux] = "IVA 21%: ";
                excel.Cells[rowAux + 4, columnAux+1] =iva.ToString() + "€";

                double total = Convert.ToDouble(LblEuros.Text.Substring(0, LblEuros.Text.IndexOf('€'))) + iva;
                excel.Cells[rowAux + 5, columnAux] = "Total: ";
                excel.Cells[rowAux + 5, columnAux+1] =total.ToString() + "€";

                // VISUALIZAMOS EXCEL
                excel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            if (DataGridViewProductsInSale.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para realizar un reporte");
            }
            else //Aqui pones todo lo de tu documento
            {
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 10f, 10f, 0f);
                //Llamas el metodo GenerarDocumentos
                GeneratePDF(pdfDoc);
            }
        }

        public void GeneratePDF(iTextSharp.text.Document document)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = TxtCliente.Text + "_" + DatePicker.Value.ToString().Substring(0,10).Replace('/', '_');
            save.Filter = "PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            save.FilterIndex = 1;

            string html =Properties.Resources.pdf_generator.ToString();
            // REEMPLAZAMOS POR LOS DATOS
            html = html.Replace("@Customer",TxtCliente.Text);
            html = html.Replace("@Date", DatePicker.Value.ToString().Substring(0,10));
            html = html.Replace("@Number", idSale.ToString());
            html = html.Replace("@Subtotal",LblEuros.Text);

            double iva = Convert.ToDouble(LblEuros.Text.Substring(0,LblEuros.Text.IndexOf('€'))) * 0.21;
            html = html.Replace("@IVA",iva.ToString()+"€");

            double total = Convert.ToDouble(LblEuros.Text.Substring(0, LblEuros.Text.IndexOf('€'))) + iva;
            html = html.Replace("@Total","  "+ total.ToString()+"€");


            string rows = string.Empty;

            // AGREGAMOS INFORMACION DEL GRID VIEW EN FORMA DE TABLA EN HTML
            foreach (DataGridViewRow row in DataGridViewProductsInSale.Rows)
            {
                rows += "<tr>";
                rows += "<td style=\"text-align:right\">" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                rows += "<td style=\"text-align:center\">" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                rows += "<td style=\"text-align:right\">" + row.Cells["P_Unitario"].Value.ToString() + "€</td>";
                rows += "<td style=\"text-align:right\">" + row.Cells["Importe"].Value.ToString() + "€</td>";
                rows += "</tr>";
            }

            // REEMPLAZAMOS POR EL CODIGO CON LA INFORMACION
            html = html.Replace("@FILAS", rows);


            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    Document pdf = new Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdf, stream);

                    pdf.Open();

                    StringReader sr = new StringReader(html);

                    pdf.Add(new Paragraph());

                    XMLWorkerHelper.GetInstance().ParseXHtml(writer,pdf,sr);


                    pdf.Close();
                    stream.Close();
                }
            }
        }

		private void FrmDetailSale_Load(object sender, EventArgs e)
		{
			this.v_SALESEDITTableAdapter.FillByIdCab(this.db_devloDataSetDetailSale.V_SALESEDIT, idSale);

           
        }

        private void PctBxBack_Click(object sender, EventArgs e)
        {
            FrmSales frmSales = new FrmSales();
            frmSales.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmSales);
            frmSales.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmSales.Dock = DockStyle.Fill;
            this.Close();
            frmSales.Show();
        }
    }
}
