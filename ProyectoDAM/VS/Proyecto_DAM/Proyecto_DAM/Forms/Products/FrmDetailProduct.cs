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
    public partial class FrmDetailProduct : Form
    {

        int idProduct = 0;
        db_devloEntities db = new db_devloEntities();
        IEnumerable<V_PRODUCTS> product;
        public FrmDetailProduct(int idProduct)
        {
            InitializeComponent();
            this.idProduct = idProduct;
            product = db.V_PRODUCTS.Where(x => x.IDPRODUCT == idProduct).ToList();


            TxtCode.Text = product.ElementAt(0).CODE.ToString();
            TxtName.Text = product.ElementAt(0).NAME.ToString();
            TxtDescription.Text = product.ElementAt(0).DESCRIPTION.ToString();
            TxtCost_Price.Text = product.ElementAt(0).SUPPLIER_PRICE.ToString();
            TxtSell_Price.Text = product.ElementAt(0).SELL_PRICE.ToString();
            TxtStock.Text = product.ElementAt(0).STOCK.ToString();

            txtCategory.Text = product.ElementAt(0).CATEGORY.ToString();
            txtSupplier.Text = product.ElementAt(0).SUPPLIER.ToString();

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

		private void FrmDetailProduct_Load(object sender, EventArgs e)
		{

		}
	}
}
