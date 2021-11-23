using Control;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Proyecto_DAM.Forms.Sales;
using SpreadsheetLight;
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

namespace Proyecto_DAM.Forms.Ventas
{
    public partial class FrmSales : Form
    {

        Control.Utilities utilities = new Control.Utilities();

        public FrmSales()
        {
            InitializeComponent();
            this.v_SALESTableAdapter.Fill(this.db_devloDataSetSales.V_SALES);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            FrmAddSale frmAddSale = new FrmAddSale();
            frmAddSale.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmAddSale);
            frmAddSale.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmAddSale.Dock = DockStyle.Fill;
            this.Close();
            frmAddSale.Show();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {

        }

        private void FrmSales_Load(object sender, EventArgs e)
        {

        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            this.v_SALESTableAdapter.DynamicSearch(db_devloDataSetSales.V_SALES, "%" + TxtSearch.Text.Trim() + "%");
        }

        private void DataGridViewSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DEPENDIENDO DE LA COLUMNA EN LA QUE ESTÉ EN LA CELDA HAREMOS UNA ACCION U OTRA
            if (DataGridViewSales.Rows[e.RowIndex].Cells["Edit"].Selected)
            {
                int idSale = int.Parse(DataGridViewSales.Rows[e.RowIndex].Cells["IDCAB"].Value.ToString());
                editSale(idSale);
            }
            else if (DataGridViewSales.Rows[e.RowIndex].Cells["Delete"].Selected)
            {
                if (MessageBox.Show("¿Desea eliminar el contacto?\nEsta opción no se podrá deshacer.", "Devlo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // BORRAR
                    int idSale = int.Parse(DataGridViewSales.Rows[e.RowIndex].Cells["IDCAB"].Value.ToString());
                    utilities.pa_deleteSale(idSale);
                    this.v_SALESTableAdapter.Fill(this.db_devloDataSetSales.V_SALES);
                }
            }
        }

        private void editSale(int id)
        {
            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            FrmEditSale frmEditSale = new FrmEditSale(id);
            frmEditSale.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmEditSale);
            frmEditSale.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmEditSale.Dock = DockStyle.Fill;
            this.Close();
            frmEditSale.Show();
        }

        private void DataGridViewSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DataGridViewSales.Rows[e.RowIndex].Cells["IDCAB"].Selected || DataGridViewSales.Rows[e.RowIndex].Cells["NAME"].Selected ||
                DataGridViewSales.Rows[e.RowIndex].Cells["DESCRIPTION"].Selected || DataGridViewSales.Rows[e.RowIndex].Cells["FECHA_PEDIDO"].Selected)
            {
                int idSale = int.Parse(DataGridViewSales.Rows[e.RowIndex].Cells["IDCAB"].Value.ToString());
                detalSale(idSale);
            }

            /*SaveFileDialog save = new SaveFileDialog();
            //save.fileName
            string html = "<table><tr><td>PRUEBA DE PDF</td></tr></table>";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdf, stream);

                    pdf.Open();

                    pdf.Add(new Phrase("Prueba"));

                    pdf.Close();
                    stream.Close();
                }
            }*/
        }

        public void detalSale(int id){

            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            FrmDetailSale frmDetailSale = new FrmDetailSale(id);
            frmDetailSale.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmDetailSale);
            frmDetailSale.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmDetailSale.Dock = DockStyle.Fill;
            this.Close();
            frmDetailSale.Show();
        }
    }
}
