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
        private FormCollection formsList;
        Control.Utilities utilities = new Control.Utilities();
        int counter = 0;
        public FrmSales()
        {
            InitializeComponent();
            
        }

        private void loadSales()
        {
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
            
            frmAddSale.Show();
            this.Close();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            switch (counter)
            {
                case 0:
                    this.v_SALESTableAdapter.SortGridByName(this.db_devloDataSetSales.V_SALES); //NOMBRE
                    counter++;
                                                                                                
                    break;
                case 1:
                    this.v_SALESTableAdapter.SortGridByDateDESC(this.db_devloDataSetSales.V_SALES); //FECHA DESCENDENTE EJ: 30/12 - 29/12 - ....
                    counter++;
                    break;
                case 2:
                    this.v_SALESTableAdapter.SortGridByState(this.db_devloDataSetSales.V_SALES); //ESTADO
                    counter=0;
                    break;
                //case 3: counter = 0;break;
            }
            
            
           
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
           

            loadSales();
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
                FrmDeleteMessage frm = new FrmDeleteMessage(int.Parse(DataGridViewSales.Rows[e.RowIndex].Cells["IDCAB"].Value.ToString()), "sales");
                frm.Show();
            } else if (DataGridViewSales.Rows[e.RowIndex].Cells["Detail"].Selected)
            {
                int idSale = int.Parse(DataGridViewSales.Rows[e.RowIndex].Cells["IDCAB"].Value.ToString());
                detalSale(idSale);
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
            
            frmEditSale.Show();
            this.Close();
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
            
            frmDetailSale.Show();
            this.Close();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            loadSales();
        }
    }
}
