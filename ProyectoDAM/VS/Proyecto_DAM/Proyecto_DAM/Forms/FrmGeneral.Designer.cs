
namespace Proyecto_DAM
{
    partial class FrmGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneral));
            this.PanelGeneral = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSales = new Guna.UI2.WinForms.Guna2Button();
            this.BtnProducts = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.LblClock = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.TimerClock = new System.Windows.Forms.Timer(this.components);
            this.PanelLoad = new System.Windows.Forms.Panel();
            this.PanelUser = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnAddUsers = new Guna.UI2.WinForms.Guna2Button();
            this.BtnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.PanelWindow = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelUser2 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelOption = new Guna.UI2.WinForms.Guna2Panel();
            this.PctBxMinimize = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PctBxExit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblRole = new System.Windows.Forms.Label();
            this.PanelGeneral.SuspendLayout();
            this.PanelUser.SuspendLayout();
            this.PanelWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.PanelUser2.SuspendLayout();
            this.PanelOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.PanelGeneral.Controls.Add(this.BtnDashboard);
            this.PanelGeneral.Controls.Add(this.BtnSales);
            this.PanelGeneral.Controls.Add(this.BtnProducts);
            this.PanelGeneral.Controls.Add(this.BtnCustomers);
            this.PanelGeneral.Controls.Add(this.LblClock);
            this.PanelGeneral.Controls.Add(this.guna2Separator1);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.ShadowDecoration.Parent = this.PanelGeneral;
            this.PanelGeneral.Size = new System.Drawing.Size(262, 802);
            this.PanelGeneral.TabIndex = 0;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BorderRadius = 8;
            this.BtnDashboard.CheckedState.Parent = this.BtnDashboard;
            this.BtnDashboard.CustomImages.Parent = this.BtnDashboard;
            this.BtnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDashboard.DisabledState.Parent = this.BtnDashboard;
            this.BtnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnDashboard.Font = new System.Drawing.Font("Louis George Café", 12F);
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.HoverState.Parent = this.BtnDashboard;
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnDashboard.Location = new System.Drawing.Point(27, 246);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.ShadowDecoration.BorderRadius = 1;
            this.BtnDashboard.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BtnDashboard.ShadowDecoration.Parent = this.BtnDashboard;
            this.BtnDashboard.Size = new System.Drawing.Size(180, 46);
            this.BtnDashboard.TabIndex = 13;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnSales
            // 
            this.BtnSales.BorderRadius = 8;
            this.BtnSales.CheckedState.Parent = this.BtnSales;
            this.BtnSales.CustomImages.Parent = this.BtnSales;
            this.BtnSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSales.DisabledState.Parent = this.BtnSales;
            this.BtnSales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnSales.Font = new System.Drawing.Font("Louis George Café", 12F);
            this.BtnSales.ForeColor = System.Drawing.Color.White;
            this.BtnSales.HoverState.Parent = this.BtnSales;
            this.BtnSales.Image = ((System.Drawing.Image)(resources.GetObject("BtnSales.Image")));
            this.BtnSales.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnSales.Location = new System.Drawing.Point(8, 455);
            this.BtnSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSales.Name = "BtnSales";
            this.BtnSales.ShadowDecoration.Parent = this.BtnSales;
            this.BtnSales.Size = new System.Drawing.Size(180, 46);
            this.BtnSales.TabIndex = 12;
            this.BtnSales.Text = "Ventas";
            this.BtnSales.Click += new System.EventHandler(this.BtnSales_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.BorderRadius = 8;
            this.BtnProducts.CheckedState.Parent = this.BtnProducts;
            this.BtnProducts.CustomImages.Parent = this.BtnProducts;
            this.BtnProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnProducts.DisabledState.Parent = this.BtnProducts;
            this.BtnProducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnProducts.Font = new System.Drawing.Font("Louis George Café", 12F);
            this.BtnProducts.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.HoverState.Parent = this.BtnProducts;
            this.BtnProducts.Image = ((System.Drawing.Image)(resources.GetObject("BtnProducts.Image")));
            this.BtnProducts.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnProducts.Location = new System.Drawing.Point(22, 385);
            this.BtnProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.ShadowDecoration.Parent = this.BtnProducts;
            this.BtnProducts.Size = new System.Drawing.Size(180, 46);
            this.BtnProducts.TabIndex = 11;
            this.BtnProducts.Text = "Productos";
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.BorderRadius = 8;
            this.BtnCustomers.CheckedState.Parent = this.BtnCustomers;
            this.BtnCustomers.CustomImages.Parent = this.BtnCustomers;
            this.BtnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCustomers.DisabledState.Parent = this.BtnCustomers;
            this.BtnCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnCustomers.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomers.ForeColor = System.Drawing.Color.White;
            this.BtnCustomers.HoverState.Parent = this.BtnCustomers;
            this.BtnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomers.Image")));
            this.BtnCustomers.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnCustomers.Location = new System.Drawing.Point(12, 312);
            this.BtnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.ShadowDecoration.Parent = this.BtnCustomers;
            this.BtnCustomers.Size = new System.Drawing.Size(180, 46);
            this.BtnCustomers.TabIndex = 10;
            this.BtnCustomers.Text = "Clientes";
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // LblClock
            // 
            this.LblClock.AutoSize = true;
            this.LblClock.Font = new System.Drawing.Font("Louis George Café", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClock.ForeColor = System.Drawing.Color.White;
            this.LblClock.Location = new System.Drawing.Point(51, 701);
            this.LblClock.Name = "LblClock";
            this.LblClock.Size = new System.Drawing.Size(190, 46);
            this.LblClock.TabIndex = 9;
            this.LblClock.Text = "00:00:00";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(33, 688);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 8;
            // 
            // TimerClock
            // 
            this.TimerClock.Enabled = true;
            this.TimerClock.Interval = 1000;
            this.TimerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
            // 
            // PanelLoad
            // 
            this.PanelLoad.BackColor = System.Drawing.Color.White;
            this.PanelLoad.Font = new System.Drawing.Font("Louis George Café", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLoad.Location = new System.Drawing.Point(262, 128);
            this.PanelLoad.Name = "PanelLoad";
            this.PanelLoad.Size = new System.Drawing.Size(1172, 674);
            this.PanelLoad.TabIndex = 2;
            // 
            // PanelUser
            // 
            this.PanelUser.BackColor = System.Drawing.Color.White;
            this.PanelUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.PanelUser.BorderRadius = 8;
            this.PanelUser.BorderThickness = 2;
            this.PanelUser.Controls.Add(this.BtnAddUsers);
            this.PanelUser.FillColor = System.Drawing.Color.White;
            this.PanelUser.Location = new System.Drawing.Point(218, 90);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.ShadowDecoration.Parent = this.PanelUser;
            this.PanelUser.Size = new System.Drawing.Size(191, 40);
            this.PanelUser.TabIndex = 14;
            this.PanelUser.Visible = false;
            // 
            // BtnAddUsers
            // 
            this.BtnAddUsers.BackColor = System.Drawing.Color.White;
            this.BtnAddUsers.BorderRadius = 8;
            this.BtnAddUsers.CheckedState.Parent = this.BtnAddUsers;
            this.BtnAddUsers.CustomImages.Parent = this.BtnAddUsers;
            this.BtnAddUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddUsers.DisabledState.Parent = this.BtnAddUsers;
            this.BtnAddUsers.FillColor = System.Drawing.Color.White;
            this.BtnAddUsers.Font = new System.Drawing.Font("Louis George Café", 9F);
            this.BtnAddUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnAddUsers.HoverState.Parent = this.BtnAddUsers;
            this.BtnAddUsers.Location = new System.Drawing.Point(3, 6);
            this.BtnAddUsers.Name = "BtnAddUsers";
            this.BtnAddUsers.ShadowDecoration.Parent = this.BtnAddUsers;
            this.BtnAddUsers.Size = new System.Drawing.Size(185, 26);
            this.BtnAddUsers.TabIndex = 0;
            this.BtnAddUsers.Text = "Añadir usuarios";
            this.BtnAddUsers.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.BorderRadius = 8;
            this.BtnChangePassword.CheckedState.Parent = this.BtnChangePassword;
            this.BtnChangePassword.CustomImages.Parent = this.BtnChangePassword;
            this.BtnChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnChangePassword.DisabledState.Parent = this.BtnChangePassword;
            this.BtnChangePassword.FillColor = System.Drawing.Color.White;
            this.BtnChangePassword.Font = new System.Drawing.Font("Louis George Café", 9F);
            this.BtnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnChangePassword.HoverState.Parent = this.BtnChangePassword;
            this.BtnChangePassword.Location = new System.Drawing.Point(3, 6);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.ShadowDecoration.Parent = this.BtnChangePassword;
            this.BtnChangePassword.Size = new System.Drawing.Size(185, 26);
            this.BtnChangePassword.TabIndex = 1;
            this.BtnChangePassword.Text = "Cambiar contraseña";
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // PanelWindow
            // 
            this.PanelWindow.BackColor = System.Drawing.Color.White;
            this.PanelWindow.Controls.Add(this.guna2PictureBox1);
            this.PanelWindow.Controls.Add(this.PanelUser2);
            this.PanelWindow.Controls.Add(this.PanelUser);
            this.PanelWindow.Controls.Add(this.PanelOption);
            this.PanelWindow.Controls.Add(this.guna2CirclePictureBox3);
            this.PanelWindow.Controls.Add(this.LblName);
            this.PanelWindow.Controls.Add(this.LblRole);
            this.PanelWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelWindow.Location = new System.Drawing.Point(262, 0);
            this.PanelWindow.Name = "PanelWindow";
            this.PanelWindow.ShadowDecoration.Parent = this.PanelWindow;
            this.PanelWindow.Size = new System.Drawing.Size(1172, 130);
            this.PanelWindow.TabIndex = 3;
            this.PanelWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGeneral_MouseDown);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(21, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(95, 66);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // PanelUser2
            // 
            this.PanelUser2.BackColor = System.Drawing.Color.White;
            this.PanelUser2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.PanelUser2.BorderRadius = 8;
            this.PanelUser2.BorderThickness = 2;
            this.PanelUser2.Controls.Add(this.BtnChangePassword);
            this.PanelUser2.FillColor = System.Drawing.Color.White;
            this.PanelUser2.Location = new System.Drawing.Point(218, 52);
            this.PanelUser2.Name = "PanelUser2";
            this.PanelUser2.ShadowDecoration.Parent = this.PanelUser2;
            this.PanelUser2.Size = new System.Drawing.Size(191, 38);
            this.PanelUser2.TabIndex = 15;
            this.PanelUser2.Visible = false;
            // 
            // PanelOption
            // 
            this.PanelOption.Controls.Add(this.PctBxMinimize);
            this.PanelOption.Controls.Add(this.PctBxExit);
            this.PanelOption.Location = new System.Drawing.Point(1085, 0);
            this.PanelOption.Name = "PanelOption";
            this.PanelOption.ShadowDecoration.Parent = this.PanelOption;
            this.PanelOption.Size = new System.Drawing.Size(87, 46);
            this.PanelOption.TabIndex = 0;
            // 
            // PctBxMinimize
            // 
            this.PctBxMinimize.FillColor = System.Drawing.Color.Transparent;
            this.PctBxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("PctBxMinimize.Image")));
            this.PctBxMinimize.ImageRotate = 0F;
            this.PctBxMinimize.Location = new System.Drawing.Point(3, 1);
            this.PctBxMinimize.Name = "PctBxMinimize";
            this.PctBxMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PctBxMinimize.ShadowDecoration.Parent = this.PctBxMinimize;
            this.PctBxMinimize.Size = new System.Drawing.Size(38, 42);
            this.PctBxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBxMinimize.TabIndex = 14;
            this.PctBxMinimize.TabStop = false;
            this.PctBxMinimize.Click += new System.EventHandler(this.PctBxMinimize_Click);
            // 
            // PctBxExit
            // 
            this.PctBxExit.FillColor = System.Drawing.Color.Transparent;
            this.PctBxExit.Image = ((System.Drawing.Image)(resources.GetObject("PctBxExit.Image")));
            this.PctBxExit.ImageRotate = 0F;
            this.PctBxExit.Location = new System.Drawing.Point(47, 1);
            this.PctBxExit.Name = "PctBxExit";
            this.PctBxExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PctBxExit.ShadowDecoration.Parent = this.PctBxExit;
            this.PctBxExit.Size = new System.Drawing.Size(38, 42);
            this.PctBxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBxExit.TabIndex = 12;
            this.PctBxExit.TabStop = false;
            this.PctBxExit.Click += new System.EventHandler(this.PctBxExit_Click);
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(218, 36);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.ShadowDecoration.Parent = this.guna2CirclePictureBox3;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(22, 12);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 13;
            this.guna2CirclePictureBox3.TabStop = false;
            this.guna2CirclePictureBox3.Click += new System.EventHandler(this.guna2CirclePictureBox3_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Louis George Café", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.LblName.Location = new System.Drawing.Point(133, 23);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(74, 29);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Laura";
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.BackColor = System.Drawing.Color.Transparent;
            this.LblRole.Font = new System.Drawing.Font("Louis George Café", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRole.ForeColor = System.Drawing.Color.Black;
            this.LblRole.Location = new System.Drawing.Point(139, 52);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(50, 18);
            this.LblRole.TabIndex = 11;
            this.LblRole.Text = "admin";
            // 
            // FrmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 802);
            this.Controls.Add(this.PanelWindow);
            this.Controls.Add(this.PanelGeneral);
            this.Controls.Add(this.PanelLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGeneral";
            this.Load += new System.EventHandler(this.FrmGeneral_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGeneral_MouseDown);
            this.PanelGeneral.ResumeLayout(false);
            this.PanelGeneral.PerformLayout();
            this.PanelUser.ResumeLayout(false);
            this.PanelWindow.ResumeLayout(false);
            this.PanelWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.PanelUser2.ResumeLayout(false);
            this.PanelOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelGeneral;
        private System.Windows.Forms.Label LblClock;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Timer TimerClock;
        public System.Windows.Forms.Panel PanelLoad;
        private Guna.UI2.WinForms.Guna2Button BtnDashboard;
        private Guna.UI2.WinForms.Guna2Button BtnSales;
        private Guna.UI2.WinForms.Guna2Button BtnProducts;
        private Guna.UI2.WinForms.Guna2Button BtnCustomers;
        private Guna.UI2.WinForms.Guna2Panel PanelWindow;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PctBxMinimize;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PctBxExit;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblRole;
        private Guna.UI2.WinForms.Guna2Panel PanelOption;
        private Guna.UI2.WinForms.Guna2Button BtnChangePassword;
        private Guna.UI2.WinForms.Guna2Panel PanelUser;
        private Guna.UI2.WinForms.Guna2Button BtnAddUsers;
        private Guna.UI2.WinForms.Guna2Panel PanelUser2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}