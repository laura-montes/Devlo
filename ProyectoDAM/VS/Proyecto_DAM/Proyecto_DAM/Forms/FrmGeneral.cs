using Proyecto_DAM.Forms.Products;
using Proyecto_DAM.Forms.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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


            FrmDashBoard frmDashboard = new FrmDashBoard();
            frmDashboard.TopLevel = false;
            PanelLoad.Controls.Add(frmDashboard);
            frmDashboard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmDashboard.Dock = DockStyle.Fill;
            frmDashboard.Show();


            
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            LblClock.Text = time;
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

            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.TopLevel = false;
            PanelLoad.Controls.Add(frmCustomer);
            frmCustomer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmCustomer.Dock = DockStyle.Fill;
            frmCustomer.Show();
            //normalColor();
            //this.BackColor = Color.FromArgb(217, 175, 123);


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

            FrmProducts frmProducts = new FrmProducts();
            frmProducts.TopLevel = false;
            PanelLoad.Controls.Add(frmProducts);
            frmProducts.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmProducts.Dock = DockStyle.Fill;
            frmProducts.Show();
            //normalColor();
            //this.BackColor = Color.FromArgb(217, 175, 123);


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

            FrmSales frmSales = new FrmSales();
            frmSales.TopLevel = false;
            PanelLoad.Controls.Add(frmSales);
            frmSales.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmSales.Dock = DockStyle.Fill;
            frmSales.Show();

            //normalColor();
            //this.BackColor = Color.FromArgb(217, 175, 123);


        }
        private void normalColor()
        {
            BtnCustomers.BackColor = Color.FromArgb(184,148,104);
            BtnProducts.BackColor = Color.FromArgb(184, 148, 104);
            BtnSales.BackColor = Color.FromArgb(184, 148, 104);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
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

            FrmDashBoard frmDashboard = new FrmDashBoard();
            frmDashboard.TopLevel = false;
            PanelLoad.Controls.Add(frmDashboard);
            frmDashboard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmDashboard.Dock = DockStyle.Fill;
            frmDashboard.Show();

            //normalColor();
            //this.BackColor = Color.FromArgb(217, 175, 123);

        }

        private void PctBxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        // Mover ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmGeneral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }

    
}
