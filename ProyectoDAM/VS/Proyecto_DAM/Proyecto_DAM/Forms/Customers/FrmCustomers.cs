using Control;
using Proyecto_DAM.Forms.Customers;
using System;
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
			// CARGA DE CONTACTOS
			this.cONTACTSTableAdapter.Fill(this.db_devloDataSet.CONTACTS);
		}

		private void BtnFilter_Click(object sender, EventArgs e)
		{
            // SORT ASC
            this.cONTACTSTableAdapter.SortGridViewByName(db_devloDataSet.CONTACTS);
        }

        private void BtnAddCustomers_Click(object sender, EventArgs e)
        {
            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            FrmAddContact frmAddContact = new FrmAddContact();
            frmAddContact.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmAddContact);
            frmAddContact.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmAddContact.Dock = DockStyle.Fill;
            this.Close();
            frmAddContact.Show(); 
        }

		private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
		{
            // BUSQUEDA DE CONTACTO TECLA POR TECLA
            this.cONTACTSTableAdapter.DynamicSearch(db_devloDataSet.CONTACTS, "%" + TxtSearch.Text.Trim()+ "%");

        }

        private void DataGridViewCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DataGridViewCustomers.Rows[e.RowIndex].Cells["NameColumn"].Selected || DataGridViewCustomers.Rows[e.RowIndex].Cells["SurnamesColumn"].Selected)
            {
                // CAMBIAR
                int idContact = int.Parse(DataGridViewCustomers.Rows[e.RowIndex].Cells["IdContact"].Value.ToString());
                detailContact(idContact);
            }

            
        }
        private void DataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DEPENDIENDO DE LA COLUMNA EN LA QUE ESTÉ EN LA CELDA HAREMOS UNA ACCION U OTRA
            if (DataGridViewCustomers.Rows[e.RowIndex].Cells["EditColumn"].Selected)
            {
                int idContact = int.Parse(DataGridViewCustomers.Rows[e.RowIndex].Cells["IdContact"].Value.ToString());
                editContact(idContact);
            }
            else if (DataGridViewCustomers.Rows[e.RowIndex].Cells["DeleteColumn"].Selected)
            {
                if (MessageBox.Show("¿Desea eliminar el contacto?\nEsta opción no se podrá deshacer.", "Devlo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // BORRAR
                    int idContact = int.Parse(DataGridViewCustomers.Rows[e.RowIndex].Cells["IdContact"].Value.ToString());
                    utilities.pa_deleteContact(idContact);
                    this.cONTACTSTableAdapter.Fill(this.db_devloDataSet.CONTACTS);
                }
            }
        }

        private void editContact(int id)
        {
            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            FrmEditContact frmEditContact = new FrmEditContact(id);
            frmEditContact.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmEditContact);
            frmEditContact.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmEditContact.Dock = DockStyle.Fill;
            this.Close();
            frmEditContact.Show();
        }

        private void detailContact(int id)
        {
            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            FrmDetailContact frmDetailContact = new FrmDetailContact(id);
            frmDetailContact.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmDetailContact);
            frmDetailContact.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmDetailContact.Dock = DockStyle.Fill;
            this.Close();
            frmDetailContact.Show();
        }
    }
}
