using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms
{
    public partial class FrmChangePassword : Form
    {
        int counterActual = 0;
        int counterNew = 0;
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void PctBxSeeActualPassword_Click(object sender, EventArgs e)
        {
            if (counterActual==0)
            {
                TxtActualPassword.UseSystemPasswordChar = false;
                counterActual++;
            }
            else
            {
                TxtActualPassword.UseSystemPasswordChar = true;
                counterActual = 0;
            }
            
        }

        private void PctBxSeeNewPassword_Click(object sender, EventArgs e)
        {
            if (counterNew == 0)
            {
                TxtNewPassword.UseSystemPasswordChar = false;
                counterNew++;
            }
            else
            {
                TxtNewPassword.UseSystemPasswordChar = true;
                counterNew = 0;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtActualPassword.Text.Equals(TxtNewPassword.Text))
            {
                // PA
            }
            else
            {
                // MENSAJE DE ERROR
            }
        }

        private void PctBxBack_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            FrmDashBoard frmDashBoard = new FrmDashBoard();
            frmDashBoard.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmDashBoard);
            frmDashBoard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmDashBoard.Dock = DockStyle.Fill;
            this.Close();
            frmDashBoard.Show();
        }
    }
}
