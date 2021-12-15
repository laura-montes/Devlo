using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Proyecto_DAM.Forms.Messages;

namespace Proyecto_DAM.Forms.Customers
{
    public partial class FrmDetailContact : Form
    {
        private FormCollection formsList;
        int idContact = 0;
        db_devloEntities db = new db_devloEntities();
        IEnumerable<CONTACT> contact;

        public FrmDetailContact(int idContact)
        {
            InitializeComponent();
            this.idContact = idContact;
            contact = db.CONTACTS.Where(x => x.IDCONTACT == idContact).ToList();



            TxtName.Text = contact.ElementAt(0).NAME;
            TxtSurname.Text = contact.ElementAt(0).SURNAMES;
            TxtAddress.Text = contact.ElementAt(0).ADDRESS;
            TxtEmail.Text = contact.ElementAt(0).EMAIL;
            TxtPhone.Text = contact.ElementAt(0).PHONE;
            TxtObservations.Text = contact.ElementAt(0).OBSERVATIONS;

            if(contact.ElementAt(0).ROLE.ToUpper().Equals("COMPANY")){
                ChckCustomer.Checked = false;
                ChckCompany.Checked = true;
            }
            else if(contact.ElementAt(0).ROLE.ToUpper().Equals("CUSTOMER"))
            {
                ChckCompany.Checked = false;
                ChckCustomer.Checked = true;
            } 
        }

        private void PctBxBack_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmCustomer);
            frmCustomer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmCustomer.Dock = DockStyle.Fill;
            
            frmCustomer.Show();
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //BOTON DE GENERAR EL REPORTE
            FrmReport frmReport = new FrmReport(idContact);
            frmReport.Show();
        }

		private void ChckCustomer_CheckedChanged(object sender, EventArgs e)
		{
            if (contact.ElementAt(0).ROLE.ToUpper().Equals("COMPANY"))
            {
                ChckCustomer.Checked = false;
                ChckCompany.Checked = true;
            }
            else if (contact.ElementAt(0).ROLE.ToUpper().Equals("CUSTOMER"))
            {
                ChckCompany.Checked = false;
                ChckCustomer.Checked = true;
            }
        }

		private void ChckCompany_CheckedChanged(object sender, EventArgs e)
		{
            if (contact.ElementAt(0).ROLE.ToUpper().Equals("COMPANY"))
            {
                ChckCustomer.Checked = false;
                ChckCompany.Checked = true;
            }
            else if (contact.ElementAt(0).ROLE.ToUpper().Equals("CUSTOMER"))
            {
                ChckCompany.Checked = false;
                ChckCustomer.Checked = true;
            }
        }
	}
}
