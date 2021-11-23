using Proyecto_DAM.Forms.Products;
using Proyecto_DAM.Forms.Ventas;
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
        private FormCollection formsList;

        public FrmGeneral()
        {
            InitializeComponent();
        }

        private void FrmGeneral_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);
            LblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            LblClock.Text = time;
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

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                formsList = Application.OpenForms;
                foreach (Form forms in formsList)
                {
                    if (forms.Name != "FrmGeneral")
                    {
                        forms.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //normalColor();
            //this.BackColor = Color.FromArgb(217, 175, 123);

            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.TopLevel = false;
            PanelLoad.Controls.Add(frmCustomer);
            frmCustomer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmCustomer.Dock = DockStyle.Fill;
            frmCustomer.Show();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {

            try
            {
                formsList = Application.OpenForms;
                foreach (Form forms in formsList)
                {
                    if (forms.Name != "FrmGeneral")
                    {
                        forms.Close();
                    }
                }
            }
            catch (Exception)
            {

            }

            //normalColor();
            //this.BackColor = Color.FromArgb(217, 175, 123);

            FrmProducts frmProducts = new FrmProducts();
            frmProducts.TopLevel = false;
            PanelLoad.Controls.Add(frmProducts);
            frmProducts.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmProducts.Dock = DockStyle.Fill;
            frmProducts.Show();
        }

        private void PctBxExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            try
            {
                formsList = Application.OpenForms;
                foreach (Form forms in formsList)
                {
                    if (forms.Name != "FrmGeneral")
                    {
                        forms.Close();
                    }
                }
            }
            catch (Exception)
            {

            }

            //normalColor();
            //this.BackColor = Color.FromArgb(217, 175, 123);

            FrmSales frmSales = new FrmSales();
            frmSales.TopLevel = false;
            PanelLoad.Controls.Add(frmSales);
            frmSales.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmSales.Dock = DockStyle.Fill;
            frmSales.Show();
        }
        private void normalColor()
        {
            BtnCustomers.BackColor = Color.FromArgb(184,148,104);
            BtnProducts.BackColor = Color.FromArgb(184, 148, 104);
            BtnSales.BackColor = Color.FromArgb(184, 148, 104);
        }
    }

    
}
