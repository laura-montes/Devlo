using Control;
using Proyecto_DAM.Forms.Ventas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms.Sales
{
	public partial class FrmAddSale : Form
	{
		private FormCollection formsList;
		List<Classes.Product> products;
		Classes.Product product;
		double price = 0;
		int index=0;
		//PRECIO DEL OBJETO CLICKADO
		List<double> precio_unitario = new List<double>();

		Utilities utilities = new Utilities();
		List<SALES_LIN> lineas;
		SALES_LIN linea;
		DateTime thisDay = DateTime.Today;


		public FrmAddSale()
		{
			InitializeComponent();
		}

		private void FrmAddSales_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'db_devloDataSetSalesStates.STATES' Puede moverla o quitarla según sea necesario.
			this.sTATESTableAdapter.Fill(this.db_devloDataSetSalesStates.STATES);
			this.cONTACTSTableAdapter.FillCmboxSales(this.db_devloDataSet.CONTACTS);

			this.pRODUCTSTableAdapter.FillBy(this.db_devloDataSetProducts.PRODUCTS);
			CmbBxContact.DisplayMember = "FULLNAME";
			CmbBxContact.ValueMember = "IDCONTACT";


			products = new List<Classes.Product>();
			DatePicker.Value = DateTime.Now;
		}

		private void PctBxBack_Click(object sender, EventArgs e)
		{
			goBack();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			lineas = new List<SALES_LIN>();

			foreach (Classes.Product product in products)
			{

				linea = new SALES_LIN();

				linea.IDPRODUCT = product.Id;
				linea.UNITS = product.Units;

				lineas.Add(linea);

			}

			decimal total = decimal.Parse(price.ToString("0.00"));

            try
            {
				utilities.pa_add_sale(int.Parse(CmbBxContact.SelectedValue.ToString()), total, null, DatePicker.Value.Date, lineas);
			}
            catch (Exception ex)
            {
				MessageBox.Show("Error");
            }
			
			
			products.Clear();
			LstViewProducts.Items.Clear();
			goBack();
		}

		private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.pRODUCTSTableAdapter.DynamicSearch(db_devloDataSetProducts.PRODUCTS, "%" + TxtSearch.Text.Trim() + "%");
		}

		private void DataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			product = new Classes.Product();

			if (DataGridViewProducts.Rows[e.RowIndex].Cells["CODE"].Selected || DataGridViewProducts.Rows[e.RowIndex].Cells["NAME"].Selected)
			{

				//LstBxSelectedProducts.DataSource = null;

				product.Id = int.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["IDPRODUCT"].Value.ToString());
				product.Name = DataGridViewProducts.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
				product.Code = int.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["CODE"].Value.ToString());
				product.Sell_price = double.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["SELL_PRICE"].Value.ToString());



				product.Supplier = int.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["SUPPLIER"].Value.ToString());
				product.Category = int.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["SUPPLIER"].Value.ToString());


				FrmSelectCuantity frmSelectCuantity = new FrmSelectCuantity(1);

				if (frmSelectCuantity.ShowDialog() == DialogResult.OK)
				{
					int cuantity = frmSelectCuantity.Cuantity; //lee la propiedad
															   //MessageBox.Show(cuantity.ToString());
					product.Units = cuantity;


					//LBL PRECIO
					price = price + (product.Sell_price * product.Units);
					LblEuros.Text = price.ToString() + ",00€";


					ListViewItem producto = new ListViewItem(product.Name);
					producto.SubItems.Add(product.Units.ToString());
					precio_unitario.Add(product.Sell_price);
					LstViewProducts.Items.Add(producto);

				}

				products.Add(product);
			}
		}
		public void goBack()
		{
			FrmSales frmSales = new FrmSales();
			frmSales.TopLevel = false;
			FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
			Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
			panelLoad.Controls.Add(frmSales);
			frmSales.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			frmSales.Dock = DockStyle.Fill;
			frmSales.Show();
			this.Close();

			try
			{
				formsList = Application.OpenForms;
				foreach (Form forms in Application.OpenForms)
				{
					if (forms.Name == "DateTimeDialog")
					{
						forms.Close();
					}
				}
			}
			catch (Exception ex)
			{

			}
		}

		private void LstViewProducts_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (LstViewProducts.SelectedIndices.Count > 0)
			{
				index = int.Parse(LstViewProducts.SelectedIndices[0].ToString());
			}
		}

		private void LstViewProducts_MouseClick(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{

				case MouseButtons.Left:
					// Left click

					FrmSelectCuantity frmSelectCuantity = new FrmSelectCuantity(int.Parse(LstViewProducts.Items[index].SubItems[1].Text));

					if (frmSelectCuantity.ShowDialog() == DialogResult.OK)
					{
						int cuantity = frmSelectCuantity.Cuantity; //lee la propiedad

						double cantidad_anterior = double.Parse(LstViewProducts.Items[index].SubItems[1].Text);
						//CAMBIO LA CANTIDAD DEL PRODUCTO 
						LstViewProducts.Items[index].SubItems[1].Text = cuantity.ToString();

						price = price - cantidad_anterior * precio_unitario[index];

						price = price + cuantity * precio_unitario[index];

						LblEuros.Text = price.ToString() + ",00€";

					}
					break;

				case MouseButtons.Right:
					// Right click


					price = price - double.Parse(LstViewProducts.Items[index].SubItems[1].Text) * double.Parse(precio_unitario[index].ToString());
					LblEuros.Text = price.ToString() + ",00€";

					LstViewProducts.Items.RemoveAt(index);
					precio_unitario.RemoveAt(index);
					if (precio_unitario.Count == 0)
					{
						LblEuros.Text = 0.ToString() + ",00€";
					}

					break;

			}
		}

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
