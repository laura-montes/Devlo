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
        public FrmSelectCuantity()
        {
            InitializeComponent();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

		private void NumericUpDown_ValueChanged(object sender, EventArgs e)
		{
            Cuantity = (int)NumericUpDown.Value;
        }
	}
}
