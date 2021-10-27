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
            DataGridViewCustomers.DataSource = utilities.view_contacts();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            
        }
        //FILTER
        private void BtnFilter_Click(object sender, EventArgs e)
		{
            DataGridViewCustomers.DataSource = utilities.order_view_contacts();
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

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // QUE BUSQUE LOS CONTACTOS CON LA PALABRA TECLEADA O QUE BUSQUE LOS CONTACTOS MEDIANTE EL TECLEO (MAS COMPLICADO PERO MEJOR)
        }

        
    }
}
