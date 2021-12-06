using Control;
using Proyecto_DAM.Forms;
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
            loadContacts();
		}

        // CARGA DE CONTACTOS
        internal void loadContacts()
        {
            this.cONTACTSTableAdapter.Fill(this.db_devloDataSet.CONTACTS);
        }

        // FILTRADO
		private void BtnFilter_Click(object sender, EventArgs e)
		{
            this.cONTACTSTableAdapter.SortGridViewBySurnames(db_devloDataSet.CONTACTS);
        }

        // AÑADIR USUARIOS
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

        // BUSQUEDA DE CONTACTO TECLA POR TECLA
        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
		{         
            this.cONTACTSTableAdapter.DynamicSearch(db_devloDataSet.CONTACTS, "%" + TxtSearch.Text.Trim()+ "%");

        }

        // AL PULSAR CELDA EN DATAGRIDVIEW
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
                FrmDeleteMessage frm = new FrmDeleteMessage(int.Parse(DataGridViewCustomers.Rows[e.RowIndex].Cells["IdContact"].Value.ToString()),"customers");
                frm.Show();
                
            } else if (DataGridViewCustomers.Rows[e.RowIndex].Cells["DetailColumn"].Selected){
                // DETALLE
                int idContact = int.Parse(DataGridViewCustomers.Rows[e.RowIndex].Cells["IdContact"].Value.ToString());
                detailContact(idContact);
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
            frmEditContact.Show();
            this.Close();
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
            frmDetailContact.Show();
            this.Close();
        }
    }
}
