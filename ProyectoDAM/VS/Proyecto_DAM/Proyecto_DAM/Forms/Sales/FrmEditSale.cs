using Control;
using Proyecto_DAM.Forms.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms.Sales
{
    public partial class FrmEditSale : Form
    {
        int idSale;
        Utilities utilities = new Utilities();
        db_devloEntities db = new db_devloEntities();
        IEnumerable<V_SALESEDIT> sale;
        public FrmEditSale(int idSale)
        {
            InitializeComponent();
            this.idSale = idSale;
            sale = db.V_SALESEDIT.Where(x => x.IDCAB == idSale);

            TxtCliente.Text = sale.ElementAt(0).CONTACTO;
            guna2DateTimePicker1.Text = sale.ElementAt(0).FECHA_PEDIDO.ToString();
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

		private void FrmEditSale_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'db_devloDataSetProducts.PRODUCTS' Puede moverla o quitarla según sea necesario.
			this.pRODUCTSTableAdapter.FillBy(this.db_devloDataSetProducts.PRODUCTS);

		}
	}
}
