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
        FrmCustomer frmCustomer;
        FrmProducts frmProducts;
        FrmSales frmSales;

        public FrmGeneral()
        {
            InitializeComponent();
        }

        private void FrmGeneral_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);

            //Hour
            LblClock.Text = DateTime.Now.ToString("HH:mm:ss");

            frmCustomer = new FrmCustomer();
            frmProducts = new FrmProducts();
            frmSales = new FrmSales();
            
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("hh:mm:ss");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                frmProducts.Close();
                frmSales.Close();
            }
            catch (Exception)
            {

                
            }

            frmCustomer = new FrmCustomer();
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
                frmCustomer.Close();
                frmSales.Close();
            }
            catch (Exception)
            {


            }

            frmProducts = new FrmProducts();
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
                frmCustomer.Close();
                frmProducts.Close();
            }
            catch (Exception)
            {


            }

            frmSales = new FrmSales();
            frmSales.TopLevel = false;
            PanelLoad.Controls.Add(frmSales);
            frmSales.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmSales.Dock = DockStyle.Fill;
            frmSales.Show();
        }
    }
}
