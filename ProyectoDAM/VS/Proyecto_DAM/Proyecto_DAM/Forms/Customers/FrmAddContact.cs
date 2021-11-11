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
    public partial class FrmAddContact : Form
    {
        Utilities utilities = new Utilities();
        public FrmAddContact()
        {
            InitializeComponent();
        }

        // NO MULTIPLE CHECK
        private void ChckCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckCompany.Checked)
            {
                TxtSurname.Enabled = false;
                TxtAddress.Enabled = true;
                if (ChckCustomer.Checked)
                {
                    ChckCustomer.Checked = false;
                }
            }else{
                TxtSurname.Enabled = true;
            }
        }

        // NO MULTIPLE CHECK
        private void ChckCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckCustomer.Checked)
            {
                TxtSurname.Enabled = true;
                TxtAddress.Enabled = false;

                if (ChckCompany.Checked)
                {
                    ChckCompany.Checked = false;
                }
            }else {
                TxtAddress.Enabled = true;
            }
        }

        private void PctBxBack_Click(object sender, EventArgs e)
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("El nombre no puede estar vacio");
            } else {
                if (ChckCompany.Checked)
                {
                    Company company = new Company(TxtName.Text, TxtPhone.Text, TxtEmail.Text, TxtAddress.Text);
                    utilities.pa_addContact(company.Name, null, company.Phone, company.Email, company.Address, company.Role, null);
                    clean();
                }
                else if (ChckCustomer.Checked)
                {
                    Customer customer = new Customer(TxtName.Text, TxtSurname.Text, TxtPhone.Text, TxtEmail.Text);
                    utilities.pa_addContact(customer.Name, customer.Surnames, customer.Phone, customer.Email, null, customer.Role, null);
                    clean();
                }
            }
        }

        private void clean()
        {
            TxtName.Clear();
            TxtSurname.Clear();
            TxtPhone.Clear();
            TxtEmail.Clear();
            TxtAddress.Clear();
        }
    }
}
