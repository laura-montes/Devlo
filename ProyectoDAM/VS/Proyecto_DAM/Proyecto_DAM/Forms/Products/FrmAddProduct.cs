using Proyecto_DAM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using System.Collections;

namespace Proyecto_DAM.Forms.Products
{
    public partial class FrmAddProduct : Form
    {
        Utilities utilities = new Utilities();
        public FrmAddProduct()
        {
            InitializeComponent();

            this.cATEGORYTableAdapter.Fill(this.db_devloDataSetCategory.CATEGORY);
            this.sUPPLIERSTableAdapter.Fill(this.db_devloDataSetSuppliers.SUPPLIERS);

            CmbBxSupplier.Text = null;
            CmbBxCategory.Text = null;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // AÑADIR
            Product product = new Product(int.Parse(TxtCode.Text),int.Parse(CmbBxCategory.SelectedValue.ToString()),int.Parse(CmbBxSupplier.SelectedValue.ToString()),
                int.Parse(TxtStock.Text),TxtName.Text,TxtDescription.Text,double.Parse(TxtSell_Price.Text), double.Parse(TxtCost_Price.Text));

           utilities.pa_add_product(
                product.Code,
                product.Name,
                product.Description,
                product.Category,
                product.Supplier,
                product.Stock,
                (decimal?)product.Sell_price,
                (decimal?)product.Supplier_price);

            MessageBox.Show("Producto añadido correctamente");

            clear();
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

		private void FrmAddProduct_Load(object sender, EventArgs e)
		{			
		}

        private void clear()
        {
            TxtCode.Clear();
            TxtCost_Price.Clear();
            TxtDescription.Clear();
            TxtName.Clear();
            TxtSell_Price.Clear();
            TxtStock.Clear();
            CmbBxCategory.SelectedIndex = -1;
            CmbBxSupplier.SelectedIndex = -1;
        }
	}
}
