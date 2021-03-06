
namespace Proyecto_DAM.Forms.Products
{
    partial class FrmEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditProduct));
            this.LblEditContact = new System.Windows.Forms.Label();
            this.PctBxBack = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TxtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblCode = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.LblSupplier = new System.Windows.Forms.Label();
            this.LblMandatory = new System.Windows.Forms.Label();
            this.TxtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblObservations = new System.Windows.Forms.Label();
            this.CmbBxSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.sUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_devloDataSetSuppliers = new Proyecto_DAM.db_devloDataSetSuppliers();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbBxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_devloDataSetCategory = new Proyecto_DAM.db_devloDataSetCategory();
            this.PanelData = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TxtCost_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblSell_Price = new System.Windows.Forms.Label();
            this.LblCost_Price = new System.Windows.Forms.Label();
            this.TxtSell_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.cATEGORYTableAdapter = new Proyecto_DAM.db_devloDataSetCategoryTableAdapters.CATEGORYTableAdapter();
            this.sUPPLIERSTableAdapter = new Proyecto_DAM.db_devloDataSetSuppliersTableAdapters.SUPPLIERSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_devloDataSetSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_devloDataSetCategory)).BeginInit();
            this.PanelData.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblEditContact
            // 
            this.LblEditContact.AutoSize = true;
            this.LblEditContact.Font = new System.Drawing.Font("Louis George Café", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.LblEditContact.Location = new System.Drawing.Point(139, 18);
            this.LblEditContact.Name = "LblEditContact";
            this.LblEditContact.Size = new System.Drawing.Size(241, 40);
            this.LblEditContact.TabIndex = 0;
            this.LblEditContact.Text = "Editar producto";
            // 
            // PctBxBack
            // 
            this.PctBxBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBxBack.Image")));
            this.PctBxBack.ImageRotate = 0F;
            this.PctBxBack.Location = new System.Drawing.Point(35, 12);
            this.PctBxBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PctBxBack.Name = "PctBxBack";
            this.PctBxBack.ShadowDecoration.Parent = this.PctBxBack;
            this.PctBxBack.Size = new System.Drawing.Size(76, 60);
            this.PctBxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBxBack.TabIndex = 1;
            this.PctBxBack.TabStop = false;
            this.PctBxBack.Click += new System.EventHandler(this.PctBxBack_Click);
            // 
            // TxtName
            // 
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
            this.TxtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtName.FocusedState.Parent = this.TxtName;
            this.TxtName.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.Black;
            this.TxtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtName.HoverState.Parent = this.TxtName;
            this.TxtName.Location = new System.Drawing.Point(219, 199);
            this.TxtName.Margin = new System.Windows.Forms.Padding(5);
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PlaceholderText = "";
            this.TxtName.SelectedText = "";
            this.TxtName.ShadowDecoration.Parent = this.TxtName;
            this.TxtName.Size = new System.Drawing.Size(356, 36);
            this.TxtName.TabIndex = 6;
            // 
            // TxtCode
            // 
            this.TxtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtCode.BorderRadius = 8;
            this.TxtCode.BorderThickness = 2;
            this.TxtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCode.DefaultText = "";
            this.TxtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCode.DisabledState.Parent = this.TxtCode;
            this.TxtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCode.Enabled = false;
            this.TxtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtCode.FocusedState.Parent = this.TxtCode;
            this.TxtCode.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCode.ForeColor = System.Drawing.Color.Black;
            this.TxtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtCode.HoverState.Parent = this.TxtCode;
            this.TxtCode.Location = new System.Drawing.Point(219, 129);
            this.TxtCode.Margin = new System.Windows.Forms.Padding(5);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.PasswordChar = '\0';
            this.TxtCode.PlaceholderText = "";
            this.TxtCode.SelectedText = "";
            this.TxtCode.ShadowDecoration.Parent = this.TxtCode;
            this.TxtCode.Size = new System.Drawing.Size(145, 36);
            this.TxtCode.TabIndex = 7;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(117, 199);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(88, 24);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Nombre:";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCode.Location = new System.Drawing.Point(117, 135);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(79, 24);
            this.LblCode.TabIndex = 11;
            this.LblCode.Text = "Código:";
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.Location = new System.Drawing.Point(117, 274);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(103, 24);
            this.LblCategory.TabIndex = 12;
            this.LblCategory.Text = "Categoría:";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSupplier.Location = new System.Drawing.Point(117, 338);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(106, 24);
            this.LblSupplier.TabIndex = 13;
            this.LblSupplier.Text = "Proveedor:";
            // 
            // LblMandatory
            // 
            this.LblMandatory.AutoSize = true;
            this.LblMandatory.ForeColor = System.Drawing.Color.Red;
            this.LblMandatory.Location = new System.Drawing.Point(197, 194);
            this.LblMandatory.Name = "LblMandatory";
            this.LblMandatory.Size = new System.Drawing.Size(13, 17);
            this.LblMandatory.TabIndex = 16;
            this.LblMandatory.Text = "*";
            // 
            // TxtDescription
            // 
            this.TxtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtDescription.BorderRadius = 8;
            this.TxtDescription.BorderThickness = 2;
            this.TxtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescription.DefaultText = "";
            this.TxtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDescription.DisabledState.Parent = this.TxtDescription;
            this.TxtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtDescription.FocusedState.Parent = this.TxtDescription;
            this.TxtDescription.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.ForeColor = System.Drawing.Color.Black;
            this.TxtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtDescription.HoverState.Parent = this.TxtDescription;
            this.TxtDescription.Location = new System.Drawing.Point(121, 447);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.PasswordChar = '\0';
            this.TxtDescription.PlaceholderText = "";
            this.TxtDescription.SelectedText = "";
            this.TxtDescription.ShadowDecoration.Parent = this.TxtDescription;
            this.TxtDescription.Size = new System.Drawing.Size(455, 89);
            this.TxtDescription.TabIndex = 22;
            // 
            // LblObservations
            // 
            this.LblObservations.AutoSize = true;
            this.LblObservations.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservations.Location = new System.Drawing.Point(117, 409);
            this.LblObservations.Name = "LblObservations";
            this.LblObservations.Size = new System.Drawing.Size(119, 24);
            this.LblObservations.TabIndex = 23;
            this.LblObservations.Text = "Descripción:";
            // 
            // CmbBxSupplier
            // 
            this.CmbBxSupplier.BackColor = System.Drawing.Color.Transparent;
            this.CmbBxSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.CmbBxSupplier.BorderRadius = 8;
            this.CmbBxSupplier.BorderThickness = 2;
            this.CmbBxSupplier.DataSource = this.sUPPLIERSBindingSource;
            this.CmbBxSupplier.DisplayMember = "NAME";
            this.CmbBxSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbBxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxSupplier.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.CmbBxSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.CmbBxSupplier.FocusedState.Parent = this.CmbBxSupplier;
            this.CmbBxSupplier.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxSupplier.ForeColor = System.Drawing.Color.Black;
            this.CmbBxSupplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.CmbBxSupplier.HoverState.Parent = this.CmbBxSupplier;
            this.CmbBxSupplier.ItemHeight = 30;
            this.CmbBxSupplier.ItemsAppearance.Parent = this.CmbBxSupplier;
            this.CmbBxSupplier.Location = new System.Drawing.Point(227, 335);
            this.CmbBxSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbBxSupplier.Name = "CmbBxSupplier";
            this.CmbBxSupplier.ShadowDecoration.Parent = this.CmbBxSupplier;
            this.CmbBxSupplier.Size = new System.Drawing.Size(348, 36);
            this.CmbBxSupplier.TabIndex = 25;
            this.CmbBxSupplier.ValueMember = "ID";
            // 
            // sUPPLIERSBindingSource
            // 
            this.sUPPLIERSBindingSource.DataMember = "SUPPLIERS";
            this.sUPPLIERSBindingSource.DataSource = this.db_devloDataSetSuppliers;
            // 
            // db_devloDataSetSuppliers
            // 
            this.db_devloDataSetSuppliers.DataSetName = "db_devloDataSetSuppliers";
            this.db_devloDataSetSuppliers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(189, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 27;
            // 
            // CmbBxCategory
            // 
            this.CmbBxCategory.BackColor = System.Drawing.Color.Transparent;
            this.CmbBxCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.CmbBxCategory.BorderRadius = 8;
            this.CmbBxCategory.BorderThickness = 2;
            this.CmbBxCategory.DataSource = this.cATEGORYBindingSource;
            this.CmbBxCategory.DisplayMember = "NAME";
            this.CmbBxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbBxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.CmbBxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.CmbBxCategory.FocusedState.Parent = this.CmbBxCategory;
            this.CmbBxCategory.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxCategory.ForeColor = System.Drawing.Color.Black;
            this.CmbBxCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.CmbBxCategory.HoverState.Parent = this.CmbBxCategory;
            this.CmbBxCategory.ItemHeight = 30;
            this.CmbBxCategory.ItemsAppearance.Parent = this.CmbBxCategory;
            this.CmbBxCategory.Location = new System.Drawing.Point(227, 270);
            this.CmbBxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbBxCategory.Name = "CmbBxCategory";
            this.CmbBxCategory.ShadowDecoration.Parent = this.CmbBxCategory;
            this.CmbBxCategory.Size = new System.Drawing.Size(348, 36);
            this.CmbBxCategory.TabIndex = 28;
            this.CmbBxCategory.ValueMember = "ID";
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.db_devloDataSetCategory;
            // 
            // db_devloDataSetCategory
            // 
            this.db_devloDataSetCategory.DataSetName = "db_devloDataSetCategory";
            this.db_devloDataSetCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelData
            // 
            this.PanelData.BackColor = System.Drawing.Color.Transparent;
            this.PanelData.Controls.Add(this.TxtCost_Price);
            this.PanelData.Controls.Add(this.LblStock);
            this.PanelData.Controls.Add(this.LblSell_Price);
            this.PanelData.Controls.Add(this.LblCost_Price);
            this.PanelData.Controls.Add(this.TxtSell_Price);
            this.PanelData.Controls.Add(this.TxtStock);
            this.PanelData.FillColor = System.Drawing.Color.White;
            this.PanelData.Location = new System.Drawing.Point(645, 129);
            this.PanelData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelData.Name = "PanelData";
            this.PanelData.ShadowColor = System.Drawing.Color.Black;
            this.PanelData.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.PanelData.Size = new System.Drawing.Size(388, 229);
            this.PanelData.TabIndex = 29;
            // 
            // TxtCost_Price
            // 
            this.TxtCost_Price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtCost_Price.BorderRadius = 8;
            this.TxtCost_Price.BorderThickness = 2;
            this.TxtCost_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCost_Price.DefaultText = "";
            this.TxtCost_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCost_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCost_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCost_Price.DisabledState.Parent = this.TxtCost_Price;
            this.TxtCost_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCost_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtCost_Price.FocusedState.Parent = this.TxtCost_Price;
            this.TxtCost_Price.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCost_Price.ForeColor = System.Drawing.Color.Black;
            this.TxtCost_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtCost_Price.HoverState.Parent = this.TxtCost_Price;
            this.TxtCost_Price.Location = new System.Drawing.Point(175, 148);
            this.TxtCost_Price.Margin = new System.Windows.Forms.Padding(5);
            this.TxtCost_Price.Name = "TxtCost_Price";
            this.TxtCost_Price.PasswordChar = '\0';
            this.TxtCost_Price.PlaceholderText = "";
            this.TxtCost_Price.SelectedText = "";
            this.TxtCost_Price.ShadowDecoration.Parent = this.TxtCost_Price;
            this.TxtCost_Price.Size = new System.Drawing.Size(145, 36);
            this.TxtCost_Price.TabIndex = 27;
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.Location = new System.Drawing.Point(13, 34);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(63, 24);
            this.LblStock.TabIndex = 14;
            this.LblStock.Text = "Stock:";
            // 
            // LblSell_Price
            // 
            this.LblSell_Price.AutoSize = true;
            this.LblSell_Price.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSell_Price.Location = new System.Drawing.Point(13, 92);
            this.LblSell_Price.Name = "LblSell_Price";
            this.LblSell_Price.Size = new System.Drawing.Size(151, 24);
            this.LblSell_Price.TabIndex = 24;
            this.LblSell_Price.Text = "Precio de venta:";
            // 
            // LblCost_Price
            // 
            this.LblCost_Price.AutoSize = true;
            this.LblCost_Price.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCost_Price.Location = new System.Drawing.Point(16, 156);
            this.LblCost_Price.Name = "LblCost_Price";
            this.LblCost_Price.Size = new System.Drawing.Size(149, 24);
            this.LblCost_Price.TabIndex = 26;
            this.LblCost_Price.Text = "Precio de coste:";
            // 
            // TxtSell_Price
            // 
            this.TxtSell_Price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtSell_Price.BorderRadius = 8;
            this.TxtSell_Price.BorderThickness = 2;
            this.TxtSell_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSell_Price.DefaultText = "";
            this.TxtSell_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSell_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSell_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSell_Price.DisabledState.Parent = this.TxtSell_Price;
            this.TxtSell_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSell_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtSell_Price.FocusedState.Parent = this.TxtSell_Price;
            this.TxtSell_Price.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSell_Price.ForeColor = System.Drawing.Color.Black;
            this.TxtSell_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtSell_Price.HoverState.Parent = this.TxtSell_Price;
            this.TxtSell_Price.Location = new System.Drawing.Point(175, 89);
            this.TxtSell_Price.Margin = new System.Windows.Forms.Padding(5);
            this.TxtSell_Price.Name = "TxtSell_Price";
            this.TxtSell_Price.PasswordChar = '\0';
            this.TxtSell_Price.PlaceholderText = "";
            this.TxtSell_Price.SelectedText = "";
            this.TxtSell_Price.ShadowDecoration.Parent = this.TxtSell_Price;
            this.TxtSell_Price.Size = new System.Drawing.Size(145, 36);
            this.TxtSell_Price.TabIndex = 9;
            // 
            // TxtStock
            // 
            this.TxtStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtStock.BorderRadius = 8;
            this.TxtStock.BorderThickness = 2;
            this.TxtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtStock.DefaultText = "";
            this.TxtStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtStock.DisabledState.Parent = this.TxtStock;
            this.TxtStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtStock.FocusedState.Parent = this.TxtStock;
            this.TxtStock.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStock.ForeColor = System.Drawing.Color.Black;
            this.TxtStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtStock.HoverState.Parent = this.TxtStock;
            this.TxtStock.Location = new System.Drawing.Point(175, 30);
            this.TxtStock.Margin = new System.Windows.Forms.Padding(5);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.PasswordChar = '\0';
            this.TxtStock.PlaceholderText = "";
            this.TxtStock.SelectedText = "";
            this.TxtStock.ShadowDecoration.Parent = this.TxtStock;
            this.TxtStock.Size = new System.Drawing.Size(145, 36);
            this.TxtStock.TabIndex = 15;
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
            this.BtnSave.Location = new System.Drawing.Point(875, 572);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.ShadowDecoration.Parent = this.BtnSave;
            this.BtnSave.Size = new System.Drawing.Size(180, 46);
            this.BtnSave.TabIndex = 30;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.White;
            this.PanelContainer.Controls.Add(this.BtnSave);
            this.PanelContainer.Controls.Add(this.PanelData);
            this.PanelContainer.Controls.Add(this.CmbBxCategory);
            this.PanelContainer.Controls.Add(this.label2);
            this.PanelContainer.Controls.Add(this.CmbBxSupplier);
            this.PanelContainer.Controls.Add(this.LblObservations);
            this.PanelContainer.Controls.Add(this.TxtDescription);
            this.PanelContainer.Controls.Add(this.LblMandatory);
            this.PanelContainer.Controls.Add(this.LblSupplier);
            this.PanelContainer.Controls.Add(this.LblCategory);
            this.PanelContainer.Controls.Add(this.LblCode);
            this.PanelContainer.Controls.Add(this.LblName);
            this.PanelContainer.Controls.Add(this.TxtCode);
            this.PanelContainer.Controls.Add(this.TxtName);
            this.PanelContainer.Controls.Add(this.PctBxBack);
            this.PanelContainer.Controls.Add(this.LblEditContact);
            this.PanelContainer.FillColor = System.Drawing.Color.White;
            this.PanelContainer.Location = new System.Drawing.Point(48, 0);
            this.PanelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
            this.PanelContainer.Size = new System.Drawing.Size(1085, 646);
            this.PanelContainer.TabIndex = 5;
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // sUPPLIERSTableAdapter
            // 
            this.sUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 678);
            this.Controls.Add(this.PanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEditProduct";
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.FrmEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_devloDataSetSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_devloDataSetCategory)).EndInit();
            this.PanelData.ResumeLayout(false);
            this.PanelData.PerformLayout();
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Label LblEditContact;
		private Guna.UI2.WinForms.Guna2PictureBox PctBxBack;
		private Guna.UI2.WinForms.Guna2TextBox TxtName;
		private Guna.UI2.WinForms.Guna2TextBox TxtCode;
		private System.Windows.Forms.Label LblName;
		private System.Windows.Forms.Label LblCode;
		private System.Windows.Forms.Label LblCategory;
		private System.Windows.Forms.Label LblSupplier;
		private System.Windows.Forms.Label LblMandatory;
		private Guna.UI2.WinForms.Guna2TextBox TxtDescription;
		private System.Windows.Forms.Label LblObservations;
		private Guna.UI2.WinForms.Guna2ComboBox CmbBxSupplier;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2ComboBox CmbBxCategory;
		private Guna.UI2.WinForms.Guna2ShadowPanel PanelData;
		private Guna.UI2.WinForms.Guna2TextBox TxtCost_Price;
		private System.Windows.Forms.Label LblStock;
		private System.Windows.Forms.Label LblSell_Price;
		private System.Windows.Forms.Label LblCost_Price;
		private Guna.UI2.WinForms.Guna2TextBox TxtSell_Price;
		private Guna.UI2.WinForms.Guna2TextBox TxtStock;
		private Guna.UI2.WinForms.Guna2Button BtnSave;
		private Guna.UI2.WinForms.Guna2Panel PanelContainer;
		private db_devloDataSetCategory db_devloDataSetCategory;
		private System.Windows.Forms.BindingSource cATEGORYBindingSource;
		private db_devloDataSetCategoryTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
		private db_devloDataSetSuppliers db_devloDataSetSuppliers;
		private System.Windows.Forms.BindingSource sUPPLIERSBindingSource;
		private db_devloDataSetSuppliersTableAdapters.SUPPLIERSTableAdapter sUPPLIERSTableAdapter;
	}
}