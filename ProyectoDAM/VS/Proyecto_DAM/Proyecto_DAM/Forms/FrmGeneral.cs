using Proyecto_DAM.Forms;
using Proyecto_DAM.Forms.Products;
using Proyecto_DAM.Forms.Users;
using Proyecto_DAM.Forms.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAM
{
    public partial class FrmGeneral : Form
    {
        private FormCollection formsList;
        private int counter = 0;
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

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            switch (counter)
            {
                case 0:
                    if (LblRole.Text.Equals("admin"))
                    {
                        PanelUser.Visible = true;
                        PanelUser2.Visible = true;
                        counter = 1;
                    }
                    else if (LblRole.Text.Equals("ventas"))
                    {
                        PanelUser2.Visible = true;
                        counter = 1;
                    }
                    break;
                case 1:
                    PanelUser.Visible = false;
                    PanelUser2.Visible = false;
                    counter = 0;
                    break;
            }

           

        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

            FrmAddUser frmAddUser = new FrmAddUser();
            frmAddUser.TopLevel = false;
            PanelLoad.Controls.Add(frmAddUser);
            frmAddUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmAddUser.Dock = DockStyle.Fill;
            frmAddUser.Show();

            PanelUser.Visible = false;
            PanelUser2.Visible = false;
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
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

            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.TopLevel = false;
            PanelLoad.Controls.Add(frmChangePassword);
            frmChangePassword.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmChangePassword.Dock = DockStyle.Fill;
            frmChangePassword.Show();

            PanelUser.Visible = false;
            PanelUser2.Visible = false;
        }
    }    
}
