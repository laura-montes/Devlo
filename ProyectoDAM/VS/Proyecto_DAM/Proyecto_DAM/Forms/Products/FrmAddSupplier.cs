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
    public partial class FrmAddSupplier : Form
    {

        Utilities utilities = new Utilities();

        public FrmAddSupplier()
        {
            InitializeComponent();
        }

        private void PctBxBack_Click(object sender, EventArgs e)
        {
            goBack();

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
            
            frmProducts.Show();
            this.Close();
        }

		private void BtnSave_Click(object sender, EventArgs e)
		{
            try
            {
                if (String.IsNullOrEmpty(TxtName.Text))
                {
                    FrmAddMessage frm = new FrmAddMessage();
                    frm.Show();
                }
                else
                {
                    utilities.pa_add_supplier(TxtName.Text, TxtDescription.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

            TxtName.Text = "";
            TxtDescription.Text = "";
            goBack();

        }
	}
}
