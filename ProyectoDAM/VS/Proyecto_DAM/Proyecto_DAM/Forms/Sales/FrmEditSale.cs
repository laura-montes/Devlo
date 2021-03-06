using Control;
using Proyecto_DAM.Forms.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms.Sales
{
	public partial class FrmEditSale : Form
	{
		private FormCollection formsList;
		int idSale;
		Utilities utilities = new Utilities();
		db_devloEntities db = new db_devloEntities();
		IEnumerable<V_SALESEDIT> sale;

		Classes.Product product;


		//DINERO TOTAL COMPRA
		double price = 0;

		//PRECIO DEL OBJETO CLICKADO
		List<double> precio_unitario = new List<double>();

		//INDICE DEL ITEM LISTVIEW
		int index;

		DateTime thisDay = DateTime.Today;

		public FrmEditSale(int idSale)
		{
			InitializeComponent();
			this.idSale = idSale;
		}

		private void PctBxBack_Click(object sender, EventArgs e)
		{
			goBack();
		}
		private void goBack()
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

		private void FrmEditSale_Load(object sender, EventArgs e)
		{			
			this.pRODUCTSTableAdapter.FillBy(this.db_devloDataSetProducts.PRODUCTS);

			sale = db.V_SALESEDIT.Where(x => x.IDCAB == idSale);

			TxtCustomer.Text = sale.ElementAt(0).CONTACTO;
			DateTimePickerSaleDate.Value = DateTime.Parse(sale.ElementAt(0).FECHA_PEDIDO.ToString());

			//LOS PRODUCTOS QUE YA TENEMOS EN LA VENTA
			foreach (V_SALESEDIT linea in sale)
			{
				ListViewItem lvi = new ListViewItem(linea.PRODUCTO);
				lvi.SubItems.Add(linea.UNITS.ToString());
				lvi.SubItems.Add(linea.IDLIN.ToString());
				lvi.SubItems.Add(linea.IDCAB.ToString());
				lvi.SubItems.Add(linea.N_LIN.ToString());
				lvi.SubItems.Add(linea.IDPRODUCT.ToString());
				precio_unitario.Add(double.Parse(linea.SELL_PRICE.ToString()));

				LstViewProducts.Items.Add(lvi);



				//LBL PRECIO
				price = double.Parse(linea.TOTAL_PRICE.ToString());
				LblEuros.Text = price.ToString() + ",00€";


				//COMBOBOX
				IEnumerable<STATE> states = db.STATES.ToList();
				this.sTATESTableAdapter.Fill(this.db_devloDataSetSalesStates.STATES);
				int index = 0;
				foreach (STATE item in states)
				{
					if (item.IDSTATE == sale.ElementAt(0).STATE)
					{
						index = states.ToList().IndexOf(item);
					}
				}

				guna2ComboBox1.SelectedIndex = index;
			}

		}

		private void LstViewProducts_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (LstViewProducts.SelectedIndices.Count > 0)
			{
				index = int.Parse(LstViewProducts.SelectedIndices[0].ToString());
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem sale_lin in LstViewProducts.Items)
			{

				utilities.pa_update_sale(
					int.Parse(sale_lin.SubItems[3].Text),//NOMBRE
					int.Parse(sale_lin.SubItems[4].Text),//UNIDADES
					int.Parse(sale_lin.SubItems[5].Text),//ID_LIN
					int.Parse(sale_lin.SubItems[1].Text),//ID_CAB
					int.Parse(sale_lin.SubItems[2].Text),//N_LIN
					decimal.Parse(price.ToString("0.00")),//ID_PRODUCT
					int.Parse(guna2ComboBox1.SelectedValue.ToString())
				);
			}

			goBack();

			
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
					price = price + product.Sell_price * product.Units;
					LblEuros.Text = price.ToString() + ",00€";


					//PRODUCTOS QUE AÑADIMOS AL EDITAR LA VENTA
					ListViewItem producto = new ListViewItem(product.Name); //NOMBRE
					producto.SubItems.Add(product.Units.ToString()); //UNIDADES
					producto.SubItems.Add("1"); //IDLIN
					producto.SubItems.Add(idSale.ToString()); //IDCAB SALE
					producto.SubItems.Add((LstViewProducts.Items.Count + 1).ToString()); //N_LIN
					producto.SubItems.Add(product.Id.ToString()); //IDPRODUCT
					LstViewProducts.Items.Add(producto);
					precio_unitario.Add(product.Sell_price);

				}
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

                        try
                        {
							price = price - cantidad_anterior * precio_unitario[index];

							price = price + cuantity * precio_unitario[index];
						}
                        catch (Exception ex)
                        {

                        }
						

						LblEuros.Text = price.ToString() + ",00€";

					}
					break;

				/*case MouseButtons.Right:
					// Right click

					price = price - double.Parse(LstViewProducts.Items[index].SubItems[1].Text) * double.Parse(precio_unitario[index].ToString());



					LblEuros.Text = price.ToString() + ",00€";

					LstViewProducts.Items.RemoveAt(index);
					precio_unitario.RemoveAt(index);
					if(precio_unitario.Count == 0){
						LblEuros.Text = 0.ToString() + ",00€";
					}

					break;*/

			}
		}

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
			this.pRODUCTSTableAdapter.DynamicSearch(db_devloDataSetProducts.PRODUCTS, "%" + TxtSearch.Text.Trim() + "%");
		}
    }
}
