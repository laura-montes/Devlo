
namespace Proyecto_DAM.Forms.Customers
{
    partial class FrmEditContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditContact));
            this.LblAddContact = new System.Windows.Forms.Label();
            this.PctBxBack = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ShadowpanelContainer = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ChckCompany = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ChckCustomer = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TxtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblAdress = new System.Windows.Forms.Label();
            this.TxtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblMandatory = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.CmbBxRelations = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblRelation = new System.Windows.Forms.Label();
            this.LblObservations = new System.Windows.Forms.Label();
            this.TxtObservations = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxBack)).BeginInit();
            this.ShadowpanelContainer.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAddContact
            // 
            this.LblAddContact.AutoSize = true;
            this.LblAddContact.Font = new System.Drawing.Font("Louis George Café", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.LblAddContact.Location = new System.Drawing.Point(138, 19);
            this.LblAddContact.Name = "LblAddContact";
            this.LblAddContact.Size = new System.Drawing.Size(0, 40);
            this.LblAddContact.TabIndex = 0;
            // 
            // PctBxBack
            // 
            this.PctBxBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBxBack.Image")));
            this.PctBxBack.ImageRotate = 0F;
            this.PctBxBack.Location = new System.Drawing.Point(34, 12);
            this.PctBxBack.Name = "PctBxBack";
            this.PctBxBack.ShadowDecoration.Parent = this.PctBxBack;
            this.PctBxBack.Size = new System.Drawing.Size(76, 60);
            this.PctBxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBxBack.TabIndex = 1;
            this.PctBxBack.TabStop = false;
            this.PctBxBack.Click += new System.EventHandler(this.PctBxBack_Click);
            // 
            // ShadowpanelContainer
            // 
            this.ShadowpanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ShadowpanelContainer.Controls.Add(this.ChckCompany);
            this.ShadowpanelContainer.Controls.Add(this.ChckCustomer);
            this.ShadowpanelContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ShadowpanelContainer.Location = new System.Drawing.Point(53, 91);
            this.ShadowpanelContainer.Name = "ShadowpanelContainer";
            this.ShadowpanelContainer.ShadowColor = System.Drawing.Color.DarkGray;
            this.ShadowpanelContainer.ShadowDepth = 50;
            this.ShadowpanelContainer.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.ShadowpanelContainer.Size = new System.Drawing.Size(1002, 90);
            this.ShadowpanelContainer.TabIndex = 5;
            // 
            // ChckCompany
            // 
            this.ChckCompany.AutoSize = true;
            this.ChckCompany.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ChckCompany.CheckedState.BorderRadius = 0;
            this.ChckCompany.CheckedState.BorderThickness = 0;
            this.ChckCompany.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ChckCompany.Font = new System.Drawing.Font("Louis George Café", 12F);
            this.ChckCompany.Location = new System.Drawing.Point(70, 29);
            this.ChckCompany.Name = "ChckCompany";
            this.ChckCompany.Size = new System.Drawing.Size(110, 28);
            this.ChckCompany.TabIndex = 3;
            this.ChckCompany.Text = "Empresa";
            this.ChckCompany.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ChckCompany.UncheckedState.BorderRadius = 0;
            this.ChckCompany.UncheckedState.BorderThickness = 0;
            this.ChckCompany.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            // 
            // ChckCustomer
            // 
            this.ChckCustomer.AutoSize = true;
            this.ChckCustomer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ChckCustomer.CheckedState.BorderRadius = 0;
            this.ChckCustomer.CheckedState.BorderThickness = 0;
            this.ChckCustomer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ChckCustomer.Font = new System.Drawing.Font("Louis George Café", 12F);
            this.ChckCustomer.Location = new System.Drawing.Point(388, 29);
            this.ChckCustomer.Name = "ChckCustomer";
            this.ChckCustomer.Size = new System.Drawing.Size(93, 28);
            this.ChckCustomer.TabIndex = 4;
            this.ChckCustomer.Text = "Cliente";
            this.ChckCustomer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ChckCustomer.UncheckedState.BorderRadius = 0;
            this.ChckCustomer.UncheckedState.BorderThickness = 0;
            this.ChckCustomer.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            // 
            // TxtName
            // 
            this.TxtName.Animated = true;
            this.TxtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtName.BorderRadius = 8;
            this.TxtName.BorderThickness = 2;
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.DefaultText = "";
            this.TxtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.DisabledState.Parent = this.TxtName;
            this.TxtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtName.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtName.FocusedState.Parent = this.TxtName;
            this.TxtName.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.Black;
            this.TxtName.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtName.HoverState.Parent = this.TxtName;
            this.TxtName.Location = new System.Drawing.Point(195, 247);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PlaceholderText = "";
            this.TxtName.SelectedText = "";
            this.TxtName.ShadowDecoration.Parent = this.TxtName;
            this.TxtName.Size = new System.Drawing.Size(339, 36);
            this.TxtName.TabIndex = 6;
            // 
            // TxtSurname
            // 
            this.TxtSurname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtSurname.BorderRadius = 8;
            this.TxtSurname.BorderThickness = 2;
            this.TxtSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSurname.DefaultText = "";
            this.TxtSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSurname.DisabledState.Parent = this.TxtSurname;
            this.TxtSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSurname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtSurname.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtSurname.FocusedState.Parent = this.TxtSurname;
            this.TxtSurname.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurname.ForeColor = System.Drawing.Color.Black;
            this.TxtSurname.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtSurname.HoverState.Parent = this.TxtSurname;
            this.TxtSurname.Location = new System.Drawing.Point(195, 312);
            this.TxtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.PasswordChar = '\0';
            this.TxtSurname.PlaceholderText = "";
            this.TxtSurname.SelectedText = "";
            this.TxtSurname.ShadowDecoration.Parent = this.TxtSurname;
            this.TxtSurname.Size = new System.Drawing.Size(339, 36);
            this.TxtSurname.TabIndex = 7;
            // 
            // TxtPhone
            // 
            this.TxtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtPhone.BorderRadius = 8;
            this.TxtPhone.BorderThickness = 2;
            this.TxtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPhone.DefaultText = "";
            this.TxtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPhone.DisabledState.Parent = this.TxtPhone;
            this.TxtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtPhone.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtPhone.FocusedState.Parent = this.TxtPhone;
            this.TxtPhone.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.ForeColor = System.Drawing.Color.Black;
            this.TxtPhone.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtPhone.HoverState.Parent = this.TxtPhone;
            this.TxtPhone.Location = new System.Drawing.Point(195, 374);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.PasswordChar = '\0';
            this.TxtPhone.PlaceholderText = "";
            this.TxtPhone.SelectedText = "";
            this.TxtPhone.ShadowDecoration.Parent = this.TxtPhone;
            this.TxtPhone.Size = new System.Drawing.Size(339, 36);
            this.TxtPhone.TabIndex = 8;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtEmail.BorderRadius = 8;
            this.TxtEmail.BorderThickness = 2;
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmail.DefaultText = "";
            this.TxtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.DisabledState.Parent = this.TxtEmail;
            this.TxtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtEmail.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtEmail.FocusedState.Parent = this.TxtEmail;
            this.TxtEmail.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.Black;
            this.TxtEmail.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtEmail.HoverState.Parent = this.TxtEmail;
            this.TxtEmail.Location = new System.Drawing.Point(195, 433);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PlaceholderText = "";
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.ShadowDecoration.Parent = this.TxtEmail;
            this.TxtEmail.Size = new System.Drawing.Size(339, 36);
            this.TxtEmail.TabIndex = 9;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(86, 249);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(88, 24);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Nombre:";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSurname.Location = new System.Drawing.Point(86, 314);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(95, 24);
            this.LblSurname.TabIndex = 11;
            this.LblSurname.Text = "Apellidos:";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone.Location = new System.Drawing.Point(86, 376);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(87, 24);
            this.LblPhone.TabIndex = 12;
            this.LblPhone.Text = "Teléfono:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(86, 436);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(63, 24);
            this.LblEmail.TabIndex = 13;
            this.LblEmail.Text = "Email:";
            // 
            // LblAdress
            // 
            this.LblAdress.AutoSize = true;
            this.LblAdress.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdress.Location = new System.Drawing.Point(86, 496);
            this.LblAdress.Name = "LblAdress";
            this.LblAdress.Size = new System.Drawing.Size(98, 24);
            this.LblAdress.TabIndex = 14;
            this.LblAdress.Text = "Dirección:";
            // 
            // TxtAddress
            // 
            this.TxtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtAddress.BorderRadius = 8;
            this.TxtAddress.BorderThickness = 2;
            this.TxtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAddress.DefaultText = "";
            this.TxtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAddress.DisabledState.Parent = this.TxtAddress;
            this.TxtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtAddress.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtAddress.FocusedState.Parent = this.TxtAddress;
            this.TxtAddress.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.ForeColor = System.Drawing.Color.Black;
            this.TxtAddress.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtAddress.HoverState.Parent = this.TxtAddress;
            this.TxtAddress.Location = new System.Drawing.Point(195, 494);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.PasswordChar = '\0';
            this.TxtAddress.PlaceholderText = "";
            this.TxtAddress.SelectedText = "";
            this.TxtAddress.ShadowDecoration.Parent = this.TxtAddress;
            this.TxtAddress.Size = new System.Drawing.Size(339, 36);
            this.TxtAddress.TabIndex = 15;
            // 
            // LblMandatory
            // 
            this.LblMandatory.AutoSize = true;
            this.LblMandatory.ForeColor = System.Drawing.Color.Red;
            this.LblMandatory.Location = new System.Drawing.Point(168, 247);
            this.LblMandatory.Name = "LblMandatory";
            this.LblMandatory.Size = new System.Drawing.Size(13, 17);
            this.LblMandatory.TabIndex = 16;
            this.LblMandatory.Text = "*";
            this.LblMandatory.Visible = false;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Louis George Café", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.LblInfo.Location = new System.Drawing.Point(138, 19);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(236, 40);
            this.LblInfo.TabIndex = 18;
            this.LblInfo.Text = "EditarContacto";
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.PanelContainer.Controls.Add(this.CmbBxRelations);
            this.PanelContainer.Controls.Add(this.LblRelation);
            this.PanelContainer.Controls.Add(this.LblObservations);
            this.PanelContainer.Controls.Add(this.TxtObservations);
            this.PanelContainer.Controls.Add(this.BtnSave);
            this.PanelContainer.Controls.Add(this.LblInfo);
            this.PanelContainer.Controls.Add(this.LblMandatory);
            this.PanelContainer.Controls.Add(this.TxtAddress);
            this.PanelContainer.Controls.Add(this.LblAdress);
            this.PanelContainer.Controls.Add(this.LblEmail);
            this.PanelContainer.Controls.Add(this.LblPhone);
            this.PanelContainer.Controls.Add(this.LblSurname);
            this.PanelContainer.Controls.Add(this.LblName);
            this.PanelContainer.Controls.Add(this.TxtEmail);
            this.PanelContainer.Controls.Add(this.TxtPhone);
            this.PanelContainer.Controls.Add(this.TxtSurname);
            this.PanelContainer.Controls.Add(this.TxtName);
            this.PanelContainer.Controls.Add(this.ShadowpanelContainer);
            this.PanelContainer.Controls.Add(this.PctBxBack);
            this.PanelContainer.Controls.Add(this.LblAddContact);
            this.PanelContainer.Location = new System.Drawing.Point(48, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
            this.PanelContainer.Size = new System.Drawing.Size(1085, 646);
            this.PanelContainer.TabIndex = 3;
            // 
            // CmbBxRelations
            // 
            this.CmbBxRelations.BackColor = System.Drawing.Color.Transparent;
            this.CmbBxRelations.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.CmbBxRelations.BorderRadius = 8;
            this.CmbBxRelations.BorderThickness = 2;
            this.CmbBxRelations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbBxRelations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxRelations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.CmbBxRelations.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBxRelations.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBxRelations.FocusedState.Parent = this.CmbBxRelations;
            this.CmbBxRelations.Font = new System.Drawing.Font("Louis George Café", 12F);
            this.CmbBxRelations.ForeColor = System.Drawing.Color.Black;
            this.CmbBxRelations.HoverState.Parent = this.CmbBxRelations;
            this.CmbBxRelations.ItemHeight = 30;
            this.CmbBxRelations.ItemsAppearance.Parent = this.CmbBxRelations;
            this.CmbBxRelations.Location = new System.Drawing.Point(568, 413);
            this.CmbBxRelations.Name = "CmbBxRelations";
            this.CmbBxRelations.ShadowDecoration.Parent = this.CmbBxRelations;
            this.CmbBxRelations.Size = new System.Drawing.Size(455, 36);
            this.CmbBxRelations.TabIndex = 27;
            // 
            // LblRelation
            // 
            this.LblRelation.AutoSize = true;
            this.LblRelation.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRelation.Location = new System.Drawing.Point(564, 386);
            this.LblRelation.Name = "LblRelation";
            this.LblRelation.Size = new System.Drawing.Size(102, 24);
            this.LblRelation.TabIndex = 26;
            this.LblRelation.Text = "Relaciones";
            // 
            // LblObservations
            // 
            this.LblObservations.AutoSize = true;
            this.LblObservations.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservations.Location = new System.Drawing.Point(564, 252);
            this.LblObservations.Name = "LblObservations";
            this.LblObservations.Size = new System.Drawing.Size(146, 24);
            this.LblObservations.TabIndex = 21;
            this.LblObservations.Text = "Observaciones:";
            // 
            // TxtObservations
            // 
            this.TxtObservations.Animated = true;
            this.TxtObservations.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtObservations.BorderRadius = 8;
            this.TxtObservations.BorderThickness = 2;
            this.TxtObservations.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtObservations.DefaultText = "";
            this.TxtObservations.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtObservations.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtObservations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtObservations.DisabledState.Parent = this.TxtObservations;
            this.TxtObservations.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtObservations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtObservations.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtObservations.FocusedState.Parent = this.TxtObservations;
            this.TxtObservations.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservations.ForeColor = System.Drawing.Color.Black;
            this.TxtObservations.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtObservations.HoverState.Parent = this.TxtObservations;
            this.TxtObservations.Location = new System.Drawing.Point(568, 280);
            this.TxtObservations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtObservations.Name = "TxtObservations";
            this.TxtObservations.PasswordChar = '\0';
            this.TxtObservations.PlaceholderText = "";
            this.TxtObservations.SelectedText = "";
            this.TxtObservations.ShadowDecoration.Parent = this.TxtObservations;
            this.TxtObservations.Size = new System.Drawing.Size(455, 88);
            this.TxtObservations.TabIndex = 20;
            // 
            // BtnSave
            // 
            this.BtnSave.BorderRadius = 8;
            this.BtnSave.CheckedState.Parent = this.BtnSave;
            this.BtnSave.CustomImages.Parent = this.BtnSave;
            this.BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSave.DisabledState.Parent = this.BtnSave;
            this.BtnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnSave.Font = new System.Drawing.Font("Louis George Café", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.HoverState.Parent = this.BtnSave;
            this.BtnSave.Location = new System.Drawing.Point(843, 569);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.ShadowDecoration.Parent = this.BtnSave;
            this.BtnSave.Size = new System.Drawing.Size(180, 45);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 678);
            this.Controls.Add(this.PanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditContact";
            this.Text = "FrmEditContact";
            ((System.ComponentModel.ISupportInitialize)(this.PctBxBack)).EndInit();
            this.ShadowpanelContainer.ResumeLayout(false);
            this.ShadowpanelContainer.PerformLayout();
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblAddContact;
        private Guna.UI2.WinForms.Guna2PictureBox PctBxBack;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowpanelContainer;
        private Guna.UI2.WinForms.Guna2CheckBox ChckCompany;
        private Guna.UI2.WinForms.Guna2CheckBox ChckCustomer;
        private Guna.UI2.WinForms.Guna2TextBox TxtName;
        private Guna.UI2.WinForms.Guna2TextBox TxtSurname;
        private Guna.UI2.WinForms.Guna2TextBox TxtPhone;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmail;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblAdress;
        private Guna.UI2.WinForms.Guna2TextBox TxtAddress;
        private System.Windows.Forms.Label LblMandatory;
        private Guna.UI2.WinForms.Guna2Panel PanelContainer;
        private System.Windows.Forms.Label LblObservations;
        private Guna.UI2.WinForms.Guna2TextBox TxtObservations;
        private Guna.UI2.WinForms.Guna2ComboBox CmbBxRelations;
        private System.Windows.Forms.Label LblRelation;
        internal System.Windows.Forms.Label LblInfo;
        internal Guna.UI2.WinForms.Guna2Button BtnSave;
    }
}