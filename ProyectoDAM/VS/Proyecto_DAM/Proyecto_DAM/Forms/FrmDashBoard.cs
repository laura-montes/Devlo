using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_DAM
{
	public partial class FrmDashBoard : Form
	{

		db_devloEntities db = new db_devloEntities();
		List<V_CONTACTS_ADDED_DATE> contactos_fecha;
		List<V_SALES_ADDED_DATE> ventas_fecha;
		public FrmDashBoard()
		{
			InitializeComponent();
		}

		private void FrmDashBoard_Load(object sender, EventArgs e)
		{
			RadioBtnCustomers.Checked = true;
			RadioBtnSales.Checked = false;

			Utilities utilities = new Utilities();
			LblCustomerNumber.Text = utilities.count_users();
			LblProductsNumber.Text = utilities.count_products();
			LblEarnedTodayNumber.Text = utilities.count_dailyEarns().ToString() + ",00€";
			LblEarnedMonthNumber.Text = utilities.count_monthlyEarns().ToString() + ",00€";

			contactos_fecha = db.V_CONTACTS_ADDED_DATE.ToList();
			ventas_fecha = db.V_SALES_ADDED_DATE.ToList();

			addCustomerGraphicValues();
			addSalesGraphicValues();

		}

		private void changeChart(RadioButton radioButton)
		{
			switch (radioButton.Name)
			{
				case "RadioBtnCustomers":
					AreaDataSetCustomers.TargetChart = Chart;
					AreaDataSetSales.TargetChart = null;
					break;

				case "RadioBtnSales":
					AreaDataSetCustomers.TargetChart = null;
					AreaDataSetSales.TargetChart = Chart;
					break;

			}
		}

		private void addCustomerGraphicValues()
		{
			//QUITAMOS TODOS LOS PUNTOS GENERADOS POR DEFECTO
			AreaDataSetCustomers.DataPoints.Clear();
			foreach(V_CONTACTS_ADDED_DATE registro in contactos_fecha){
				//Add("Texto", posicion)
				AreaDataSetCustomers.DataPoints.Add(registro.ADDED_DATE.ToString().Substring(0,10), registro.CLIENTES);
			}
		}

		private void addSalesGraphicValues()
		{
			//QUITAMOS TODOS LOS PUNTOS GENERADOS POR DEFECTO
			AreaDataSetSales.DataPoints.Clear();
			foreach (V_SALES_ADDED_DATE registro in ventas_fecha)
			{
				//Add("Texto", posicion)
				AreaDataSetSales.DataPoints.Add(registro.FECHA_PEDIDO.ToString().Substring(0,10), double.Parse(registro.VENTAS.ToString()));
			}
		}

		private void RadioBtn_CheckedChanged(object sender, EventArgs e)
		{
			changeChart((RadioButton)sender);
		}
	}
}
