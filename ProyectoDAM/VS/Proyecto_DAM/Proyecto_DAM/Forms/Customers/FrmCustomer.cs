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

namespace Proyecto_DAM
{
    public partial class FrmCustomer : Form
    {
        Utilities utilities = new Utilities();

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
			// TODO: esta línea de código carga datos en la tabla 'db_devloDataSet.CONTACTS' Puede moverla o quitarla según sea necesario.
			this.cONTACTSTableAdapter.Fill(this.db_devloDataSet.CONTACTS);
			

		}
		//FILTER
		private void BtnFilter_Click(object sender, EventArgs e)
		{
            //DES SORT
            this.cONTACTSTableAdapter.SortGridView(db_devloDataSet.CONTACTS);
        }

        private void BtnAddCustomers_Click(object sender, EventArgs e)
        {
            FrmAddContact frmAddContact = new FrmAddContact();
            frmAddContact.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmAddContact);
            frmAddContact.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmAddContact.Dock = DockStyle.Fill;
            this.Hide();
            frmAddContact.Show(); 
        }

		private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
		{
            //ESTO ES EL LLENADO DINAMICO
            //Dynamic search from txtSearch
            this.cONTACTSTableAdapter.DynamicSearch(db_devloDataSet.CONTACTS, "%" + TxtSearch.Text.Trim()+ "%");

        }
	}
}
