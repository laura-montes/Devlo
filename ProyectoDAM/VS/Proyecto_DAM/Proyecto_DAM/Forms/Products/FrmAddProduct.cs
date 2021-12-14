using Control;
using System;
using System.Windows.Forms;

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

			CmbBxSupplier.SelectedIndex = -1;
			CmbBxCategory.SelectedIndex = -1;
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			try
			{
                if (String.IsNullOrEmpty(TxtCode.Text) || String.IsNullOrEmpty(TxtCode.Text))
                {
					FrmAddMessage frm = new FrmAddMessage();
					frm.Show();
                }
                else
                {
					utilities.pa_add_product(
					int.Parse(TxtCode.Text),
					TxtName.Text,
					TxtDescription.Text,
					int.Parse(CmbBxCategory.SelectedValue.ToString()),
					int.Parse(CmbBxSupplier.SelectedValue.ToString()),
					int.Parse(TxtStock.Text),
					decimal.Parse(TxtSell_Price.Text),
					decimal.Parse(TxtCost_Price.Text));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error");
			}

			clear();
			goBack();

		}

		private void PctBxBack_Click(object sender, EventArgs e)
		{goBack();
			 }

		private void goBack()
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
