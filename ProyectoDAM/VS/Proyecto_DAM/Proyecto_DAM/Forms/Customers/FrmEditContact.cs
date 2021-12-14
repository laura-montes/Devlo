using Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms.Customers
{
	public partial class FrmEditContact : Form
	{

		int idContact = 0;
		Utilities utilities = new Utilities();
		db_devloEntities db = new db_devloEntities();
		IEnumerable<CONTACT> contact;

		public FrmEditContact(int idContact)
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

			if (contact.ElementAt(0).ROLE.ToUpper().Equals("COMPANY"))
			{
				ChckCustomer.Checked = false;
				ChckCustomer.Enabled = false;

				ChckCompany.Checked = true;
			}
			else if (contact.ElementAt(0).ROLE.ToUpper().Equals("CUSTOMER"))
			{
				ChckCompany.Checked = false;
				ChckCompany.Enabled = false;

				ChckCustomer.Checked = true;
			}

		}
		private void PctBxBack_Click(object sender, EventArgs e)
		{
			returnHome();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
            try
            {
				if (ChckCustomer.Checked)
				{
					utilities.pa_updateContact(idContact,
					TxtName.Text,
					TxtSurname.Text,
					TxtPhone.Text,
					TxtEmail.Text,
					TxtAddress.Text,
					"Company",
					TxtObservations.Text
					);
				}
				else if (ChckCompany.Checked)
				{
					utilities.pa_updateContact(idContact,
					TxtName.Text,
					TxtSurname.Text,
					TxtPhone.Text,
					TxtEmail.Text,
					TxtAddress.Text,
					"Customer",
					TxtObservations.Text
					);
				}
			}
            catch (Exception ex)
            {
				MessageBox.Show("Error");
            }
			

			returnHome();
			clear();
		}


		private void returnHome()
		{
			FrmCustomer frmCustomer = new FrmCustomer();
			frmCustomer.TopLevel = false;
			FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
			Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
			panelLoad.Controls.Add(frmCustomer);
			frmCustomer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			frmCustomer.Dock = DockStyle.Fill;
			this.Close();
			frmCustomer.Show();
		}

		private void clear()
		{
			TxtEmail.Clear();
			TxtAddress.Clear();
			TxtName.Clear();
			TxtObservations.Clear();
			TxtPhone.Clear();
		}

		private void ChckCompany_CheckedChanged(object sender, EventArgs e)
		{
			if (ChckCompany.Checked)
			{
				ChckCompany.Checked = true;
			}
			else
			{
				ChckCompany.Checked = true;
			}
		}

		private void ChckCustomer_CheckedChanged(object sender, EventArgs e)
		{
			if (ChckCustomer.Checked)
			{
				ChckCustomer.Checked = true;
			}
			else
			{
				ChckCustomer.Checked = true;
			}
		}
	}
}
