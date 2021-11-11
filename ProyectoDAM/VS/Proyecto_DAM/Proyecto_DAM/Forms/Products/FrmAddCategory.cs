﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Proyecto_DAM.Forms.Products
{
    public partial class FrmAddCategory : Form
    {

        Utilities utilities = new Utilities();
        public FrmAddCategory()
        {
            InitializeComponent();
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
            utilities.pa_add_category(TxtName.Text, TxtDescription.Text);
            TxtName.Text = "";
            TxtDescription.Text = "";
		}
	}
}
