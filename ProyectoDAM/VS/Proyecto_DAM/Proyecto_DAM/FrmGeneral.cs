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
    public partial class FrmGeneral : Form
    {

        public FrmGeneral()
        {
            InitializeComponent();
        }

        private void FrmGeneral_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);

            //Hour
            var date = DateTime.Now.ToString("hh:mm:ss");
            LblClock.Text = date;

            
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("hh:mm:ss");
            LblClock.Text = time;
        }

        private void LblContacts_Click_1(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.TopLevel = false;
            PanelLoad.Controls.Add(frmCustomer);
            frmCustomer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmCustomer.Dock = DockStyle.Fill;
            frmCustomer.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*FrmDashBoard frmDashboard = new FrmDashBoard();
            frmDashboard.TopLevel = false;
            PanelLoad.Controls.Add(frmDashboard);
            frmDashboard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmDashboard.Dock = DockStyle.Fill;
            frmDashboard.Show();*/
        }
    }
}
