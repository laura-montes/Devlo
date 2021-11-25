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
    public partial class FrmSelectCuantity : Form
    {
		public int Cuantity { get; set; }
		int cantidad;
		public FrmSelectCuantity(int cantidad)
		{
			InitializeComponent();
			this.cantidad = cantidad;
			NumericUpDown.Value = (decimal)cantidad;
		}

		private void BtnAccept_Click(object sender, EventArgs e)
		{
			if ((int)NumericUpDown.Value > 0)
			{
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Seleccione la cantidad de unidades que deseen");
				NumericUpDown.Value = (decimal)cantidad;
			}
		}

		private void NumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			Cuantity = (int)NumericUpDown.Value;
		}
	}
}
