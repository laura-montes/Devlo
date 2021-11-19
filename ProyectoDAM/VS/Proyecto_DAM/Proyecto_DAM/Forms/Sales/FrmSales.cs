using Control;
using Proyecto_DAM.Forms.Sales;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms.Ventas
{
    public partial class FrmSales : Form
    {

        Utilities utilities = new Utilities();

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
                    //utilities.pa_deleteContact(idSale);
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
            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            /*FrmDetailSale frmDetailSale = new FrmDetailSale();
            frmDetailSale.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmDetailSale);
            frmDetailSale.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmDetailSale.Dock = DockStyle.Fill;
            this.Close();
            frmDetailSale.Show();*/
            //ExportarDatos(DataGridViewSales);
        }

        private void ExportarDatos(DataGridView dalagrid)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in dalagrid.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in dalagrid.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in dalagrid.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                    }
                }
                excel.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Registros a Exportar.");
            }
        }
    }
}
