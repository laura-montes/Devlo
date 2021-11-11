using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms.Products
{
    public partial class FrmEditProduct : Form
    {
        int idProduct = 0;
        Utilities utilities = new Utilities();
        db_devloEntities db = new db_devloEntities();
        IEnumerable<PRODUCT> product;

        public FrmEditProduct(int idProduct)
        {
            InitializeComponent();
            this.idProduct = idProduct;
            product = db.PRODUCTS.Where(x => x.IDPRODUCT == idProduct).ToList();

            TxtCode.Text = product.ElementAt(0).CODE.ToString();
            TxtName.Text = product.ElementAt(0).NAME;
            TxtCost_Price.Text = product.ElementAt(0).SUPPLIER_PRICE.ToString();
            TxtDescription.Text = product.ElementAt(0).DESCRIPTION;
            TxtSell_Price.Text = product.ElementAt(0).SELL_PRICE.ToString();
            TxtStock.Text = product.ElementAt(0).STOCK.ToString();

            CmbBxCategory.Text = product.ElementAt(0).CATEGORY1.ToString();
            CmbBxSupplier.Text = product.ElementAt(0).SUPPLIER1.ToString();

        }

        private void PctBxBack_Click(object sender, EventArgs e)
        {
            FrmProducts frmProducts = new FrmProducts();
            frmProducts.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmProducts);
            frmProducts.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmProducts.Dock = DockStyle.Fill;
            this.Close();
            frmProducts.Show();
        }

		private void BtnSave_Click(object sender, EventArgs e)
		{
            utilities.pa_update_product(
                int.Parse(TxtCode.Text),
                TxtName.Text,
                TxtDescription.Text,
                int.Parse(CmbBxCategory.SelectedValue.ToString()),
                int.Parse(CmbBxSupplier.SelectedValue.ToString()),
                int.Parse(TxtStock.Text),
                decimal.Parse(TxtSell_Price.Text),
                decimal.Parse(TxtCost_Price.Text)
            );

            TxtCode.Text = "";
            TxtName.Text = "";
            TxtCost_Price.Text = "";
            TxtDescription.Text = "";
            TxtSell_Price.Text = "";
            TxtStock.Text = "";

            CmbBxCategory.Text = null;
            CmbBxSupplier.Text = null;
        }
	}
}
