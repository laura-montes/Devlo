
namespace Proyecto_DAM.Forms.Sales
{
    partial class FrmAddSale
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSale));
			this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.PanelData = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.LstViewProducts = new System.Windows.Forms.ListView();
			this.ClmnHdrName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ClmnHdrCuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LblEuros = new System.Windows.Forms.Label();
			this.LblTotal = new System.Windows.Forms.Label();
			this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
			this.DataGridViewProducts = new Guna.UI2.WinForms.Guna2DataGridView();
			this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.CmbBxContact = new Guna.UI2.WinForms.Guna2ComboBox();
			this.LblSupplier = new System.Windows.Forms.Label();
			this.LblCategory = new System.Windows.Forms.Label();
			this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
			this.PctBxBack = new Guna.UI2.WinForms.Guna2PictureBox();
			this.LblAddProduct = new System.Windows.Forms.Label();
			this.db_devloDataSetProducts = new Proyecto_DAM.db_devloDataSetProducts();
			this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pRODUCTSTableAdapter = new Proyecto_DAM.db_devloDataSetProductsTableAdapters.PRODUCTSTableAdapter();
			this.db_devloDataSet = new Proyecto_DAM.db_devloDataSet();
			this.cONTACTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cONTACTSTableAdapter = new Proyecto_DAM.db_devloDataSetTableAdapters.CONTACTSTableAdapter();
			this.IDPRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SELL_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDCATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDSUPPLIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUPPLIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PanelContainer.SuspendLayout();
			this.PanelData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PctBxBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.db_devloDataSetProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.db_devloDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cONTACTSBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// PanelContainer
			// 
			this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			this.PanelContainer.Controls.Add(this.guna2DateTimePicker1);
			this.PanelContainer.Controls.Add(this.PanelData);
			this.PanelContainer.Controls.Add(this.CmbBxContact);
			this.PanelContainer.Controls.Add(this.LblSupplier);
			this.PanelContainer.Controls.Add(this.LblCategory);
			this.PanelContainer.Controls.Add(this.BtnSave);
			this.PanelContainer.Controls.Add(this.PctBxBack);
			this.PanelContainer.Controls.Add(this.LblAddProduct);
			this.PanelContainer.Location = new System.Drawing.Point(34, 0);
			this.PanelContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PanelContainer.Name = "PanelContainer";
			this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
			this.PanelContainer.Size = new System.Drawing.Size(814, 540);
			this.PanelContainer.TabIndex = 7;
			// 
			// guna2DateTimePicker1
			// 
			this.guna2DateTimePicker1.Animated = true;
			this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
			this.guna2DateTimePicker1.BorderRadius = 8;
			this.guna2DateTimePicker1.BorderThickness = 2;
			this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
			this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			this.guna2DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
			this.guna2DateTimePicker1.Location = new System.Drawing.Point(498, 75);
			this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
			this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
			this.guna2DateTimePicker1.Size = new System.Drawing.Size(271, 29);
			this.guna2DateTimePicker1.TabIndex = 30;
			this.guna2DateTimePicker1.Value = new System.DateTime(2021, 11, 13, 17, 57, 40, 820);
			// 
			// PanelData
			// 
			this.PanelData.BackColor = System.Drawing.Color.Transparent;
			this.PanelData.Controls.Add(this.LstViewProducts);
			this.PanelData.Controls.Add(this.LblEuros);
			this.PanelData.Controls.Add(this.LblTotal);
			this.PanelData.Controls.Add(this.guna2VSeparator1);
			this.PanelData.Controls.Add(this.DataGridViewProducts);
			this.PanelData.Controls.Add(this.TxtSearch);
			this.PanelData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			this.PanelData.Location = new System.Drawing.Point(63, 116);
			this.PanelData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PanelData.Name = "PanelData";
			this.PanelData.ShadowColor = System.Drawing.Color.Black;
			this.PanelData.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.PanelData.Size = new System.Drawing.Size(722, 358);
			this.PanelData.TabIndex = 29;
			// 
			// LstViewProducts
			// 
			this.LstViewProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			this.LstViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LstViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmnHdrName,
            this.ClmnHdrCuantity});
			this.LstViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LstViewProducts.FullRowSelect = true;
			this.LstViewProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.LstViewProducts.HideSelection = false;
			this.LstViewProducts.Location = new System.Drawing.Point(385, 13);
			this.LstViewProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.LstViewProducts.Name = "LstViewProducts";
			this.LstViewProducts.Size = new System.Drawing.Size(321, 282);
			this.LstViewProducts.TabIndex = 9;
			this.LstViewProducts.UseCompatibleStateImageBehavior = false;
			this.LstViewProducts.View = System.Windows.Forms.View.Details;
			// 
			// ClmnHdrName
			// 
			this.ClmnHdrName.Text = "Name";
			this.ClmnHdrName.Width = 140;
			// 
			// ClmnHdrCuantity
			// 
			this.ClmnHdrCuantity.Text = "Cuantity";
			this.ClmnHdrCuantity.Width = 140;
			// 
			// LblEuros
			// 
			this.LblEuros.AutoSize = true;
			this.LblEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblEuros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
			this.LblEuros.Location = new System.Drawing.Point(609, 312);
			this.LblEuros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblEuros.Name = "LblEuros";
			this.LblEuros.Size = new System.Drawing.Size(90, 26);
			this.LblEuros.TabIndex = 8;
			this.LblEuros.Text = "000,00€";
			// 
			// LblTotal
			// 
			this.LblTotal.AutoSize = true;
			this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTotal.Location = new System.Drawing.Point(514, 318);
			this.LblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblTotal.Name = "LblTotal";
			this.LblTotal.Size = new System.Drawing.Size(48, 20);
			this.LblTotal.TabIndex = 7;
			this.LblTotal.Text = "Total:";
			// 
			// guna2VSeparator1
			// 
			this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
			this.guna2VSeparator1.Location = new System.Drawing.Point(363, 13);
			this.guna2VSeparator1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.guna2VSeparator1.Name = "guna2VSeparator1";
			this.guna2VSeparator1.Size = new System.Drawing.Size(14, 335);
			this.guna2VSeparator1.TabIndex = 5;
			// 
			// DataGridViewProducts
			// 
			this.DataGridViewProducts.AllowUserToAddRows = false;
			this.DataGridViewProducts.AllowUserToDeleteRows = false;
			this.DataGridViewProducts.AllowUserToOrderColumns = true;
			this.DataGridViewProducts.AllowUserToResizeColumns = false;
			this.DataGridViewProducts.AllowUserToResizeRows = false;
			dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			this.DataGridViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
			this.DataGridViewProducts.AutoGenerateColumns = false;
			this.DataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			this.DataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.DataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
			dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
			this.DataGridViewProducts.ColumnHeadersHeight = 50;
			this.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DataGridViewProducts.ColumnHeadersVisible = false;
			this.DataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCT,
            this.CODE,
            this.NAME,
            this.STOCK,
            this.SELL_PRICE,
            this.CATEGORY,
            this.IDCATEGORY,
            this.IDSUPPLIER,
            this.SUPPLIER});
			this.DataGridViewProducts.DataSource = this.pRODUCTSBindingSource;
			dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle27.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
			dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle27;
			this.DataGridViewProducts.EnableHeadersVisualStyles = false;
			this.DataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
			this.DataGridViewProducts.Location = new System.Drawing.Point(11, 62);
			this.DataGridViewProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.DataGridViewProducts.MultiSelect = false;
			this.DataGridViewProducts.Name = "DataGridViewProducts";
			this.DataGridViewProducts.ReadOnly = true;
			this.DataGridViewProducts.RowHeadersVisible = false;
			this.DataGridViewProducts.RowHeadersWidth = 51;
			this.DataGridViewProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
			this.DataGridViewProducts.RowsDefaultCellStyle = dataGridViewCellStyle28;
			this.DataGridViewProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridViewProducts.RowTemplate.Height = 34;
			this.DataGridViewProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.DataGridViewProducts.Size = new System.Drawing.Size(335, 286);
			this.DataGridViewProducts.TabIndex = 4;
			this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.DataGridViewProducts.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			this.DataGridViewProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
			this.DataGridViewProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DataGridViewProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DataGridViewProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridViewProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.DataGridViewProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DataGridViewProducts.ThemeStyle.HeaderStyle.Height = 50;
			this.DataGridViewProducts.ThemeStyle.ReadOnly = true;
			this.DataGridViewProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			this.DataGridViewProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.DataGridViewProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridViewProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.DataGridViewProducts.ThemeStyle.RowsStyle.Height = 34;
			this.DataGridViewProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
			this.DataGridViewProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.DataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProducts_CellClick);
			// 
			// TxtSearch
			// 
			this.TxtSearch.BorderColor = System.Drawing.Color.White;
			this.TxtSearch.BorderRadius = 8;
			this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TxtSearch.DefaultText = "";
			this.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.TxtSearch.DisabledState.Parent = this.TxtSearch;
			this.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.TxtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
			this.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.Transparent;
			this.TxtSearch.FocusedState.Parent = this.TxtSearch;
			this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtSearch.ForeColor = System.Drawing.Color.Empty;
			this.TxtSearch.HoverState.BorderColor = System.Drawing.Color.Transparent;
			this.TxtSearch.HoverState.Parent = this.TxtSearch;
			this.TxtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtSearch.IconLeft")));
			this.TxtSearch.Location = new System.Drawing.Point(11, 13);
			this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TxtSearch.Name = "TxtSearch";
			this.TxtSearch.PasswordChar = '\0';
			this.TxtSearch.PlaceholderForeColor = System.Drawing.Color.White;
			this.TxtSearch.PlaceholderText = "Buscar producto...";
			this.TxtSearch.SelectedText = "";
			this.TxtSearch.ShadowDecoration.Parent = this.TxtSearch;
			this.TxtSearch.Size = new System.Drawing.Size(335, 32);
			this.TxtSearch.TabIndex = 3;
			this.TxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
			// 
			// CmbBxContact
			// 
			this.CmbBxContact.BackColor = System.Drawing.Color.Transparent;
			this.CmbBxContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
			this.CmbBxContact.BorderRadius = 8;
			this.CmbBxContact.BorderThickness = 2;
			this.CmbBxContact.DataSource = this.cONTACTSBindingSource;
			this.CmbBxContact.DisplayMember = "NAME";
			this.CmbBxContact.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.CmbBxContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbBxContact.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			this.CmbBxContact.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.CmbBxContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.CmbBxContact.FocusedState.Parent = this.CmbBxContact;
			this.CmbBxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.CmbBxContact.ForeColor = System.Drawing.Color.Black;
			this.CmbBxContact.HoverState.Parent = this.CmbBxContact;
			this.CmbBxContact.ItemHeight = 30;
			this.CmbBxContact.ItemsAppearance.Parent = this.CmbBxContact;
			this.CmbBxContact.Location = new System.Drawing.Point(187, 72);
			this.CmbBxContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CmbBxContact.Name = "CmbBxContact";
			this.CmbBxContact.ShadowDecoration.Parent = this.CmbBxContact;
			this.CmbBxContact.Size = new System.Drawing.Size(222, 36);
			this.CmbBxContact.TabIndex = 28;
			this.CmbBxContact.ValueMember = "IDCONTACT";
			// 
			// LblSupplier
			// 
			this.LblSupplier.AutoSize = true;
			this.LblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblSupplier.Location = new System.Drawing.Point(444, 78);
			this.LblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblSupplier.Name = "LblSupplier";
			this.LblSupplier.Size = new System.Drawing.Size(58, 20);
			this.LblSupplier.TabIndex = 13;
			this.LblSupplier.Text = "Fecha:";
			// 
			// LblCategory
			// 
			this.LblCategory.AutoSize = true;
			this.LblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblCategory.Location = new System.Drawing.Point(62, 75);
			this.LblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblCategory.Name = "LblCategory";
			this.LblCategory.Size = new System.Drawing.Size(130, 20);
			this.LblCategory.TabIndex = 12;
			this.LblCategory.Text = "Cliente/Empresa:";
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
			this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSave.ForeColor = System.Drawing.Color.White;
			this.BtnSave.HoverState.Parent = this.BtnSave;
			this.BtnSave.Location = new System.Drawing.Point(650, 486);
			this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.ShadowDecoration.Parent = this.BtnSave;
			this.BtnSave.Size = new System.Drawing.Size(135, 37);
			this.BtnSave.TabIndex = 2;
			this.BtnSave.Text = "Guardar";
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// PctBxBack
			// 
			this.PctBxBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBxBack.Image")));
			this.PctBxBack.ImageRotate = 0F;
			this.PctBxBack.Location = new System.Drawing.Point(26, 10);
			this.PctBxBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PctBxBack.Name = "PctBxBack";
			this.PctBxBack.ShadowDecoration.Parent = this.PctBxBack;
			this.PctBxBack.Size = new System.Drawing.Size(57, 49);
			this.PctBxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PctBxBack.TabIndex = 1;
			this.PctBxBack.TabStop = false;
			this.PctBxBack.Click += new System.EventHandler(this.PctBxBack_Click);
			// 
			// LblAddProduct
			// 
			this.LblAddProduct.AutoSize = true;
			this.LblAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
			this.LblAddProduct.Location = new System.Drawing.Point(104, 15);
			this.LblAddProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblAddProduct.Name = "LblAddProduct";
			this.LblAddProduct.Size = new System.Drawing.Size(166, 31);
			this.LblAddProduct.TabIndex = 0;
			this.LblAddProduct.Text = "Añadir venta";
			// 
			// db_devloDataSetProducts
			// 
			this.db_devloDataSetProducts.DataSetName = "db_devloDataSetProducts";
			this.db_devloDataSetProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pRODUCTSBindingSource
			// 
			this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
			this.pRODUCTSBindingSource.DataSource = this.db_devloDataSetProducts;
			// 
			// pRODUCTSTableAdapter
			// 
			this.pRODUCTSTableAdapter.ClearBeforeFill = true;
			// 
			// db_devloDataSet
			// 
			this.db_devloDataSet.DataSetName = "db_devloDataSet";
			this.db_devloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cONTACTSBindingSource
			// 
			this.cONTACTSBindingSource.DataMember = "CONTACTS";
			this.cONTACTSBindingSource.DataSource = this.db_devloDataSet;
			// 
			// cONTACTSTableAdapter
			// 
			this.cONTACTSTableAdapter.ClearBeforeFill = true;
			// 
			// IDPRODUCT
			// 
			this.IDPRODUCT.DataPropertyName = "IDPRODUCT";
			this.IDPRODUCT.HeaderText = "IDPRODUCT";
			this.IDPRODUCT.MinimumWidth = 6;
			this.IDPRODUCT.Name = "IDPRODUCT";
			this.IDPRODUCT.ReadOnly = true;
			this.IDPRODUCT.Visible = false;
			// 
			// CODE
			// 
			this.CODE.DataPropertyName = "CODE";
			this.CODE.HeaderText = "CODE";
			this.CODE.Name = "CODE";
			this.CODE.ReadOnly = true;
			// 
			// NAME
			// 
			this.NAME.DataPropertyName = "NAME";
			this.NAME.HeaderText = "NAME";
			this.NAME.MinimumWidth = 6;
			this.NAME.Name = "NAME";
			this.NAME.ReadOnly = true;
			// 
			// STOCK
			// 
			this.STOCK.DataPropertyName = "STOCK";
			this.STOCK.HeaderText = "STOCK";
			this.STOCK.Name = "STOCK";
			this.STOCK.ReadOnly = true;
			this.STOCK.Visible = false;
			// 
			// SELL_PRICE
			// 
			this.SELL_PRICE.DataPropertyName = "SELL_PRICE";
			this.SELL_PRICE.HeaderText = "SELL_PRICE";
			this.SELL_PRICE.Name = "SELL_PRICE";
			this.SELL_PRICE.ReadOnly = true;
			this.SELL_PRICE.Visible = false;
			// 
			// CATEGORY
			// 
			this.CATEGORY.DataPropertyName = "CATEGORY";
			this.CATEGORY.HeaderText = "CATEGORY";
			this.CATEGORY.Name = "CATEGORY";
			this.CATEGORY.ReadOnly = true;
			this.CATEGORY.Visible = false;
			// 
			// IDCATEGORY
			// 
			this.IDCATEGORY.DataPropertyName = "IDCATEGORY";
			this.IDCATEGORY.HeaderText = "IDCATEGORY";
			this.IDCATEGORY.Name = "IDCATEGORY";
			this.IDCATEGORY.ReadOnly = true;
			this.IDCATEGORY.Visible = false;
			// 
			// IDSUPPLIER
			// 
			this.IDSUPPLIER.DataPropertyName = "IDSUPPLIER";
			this.IDSUPPLIER.HeaderText = "IDSUPPLIER";
			this.IDSUPPLIER.Name = "IDSUPPLIER";
			this.IDSUPPLIER.ReadOnly = true;
			this.IDSUPPLIER.Visible = false;
			// 
			// SUPPLIER
			// 
			this.SUPPLIER.DataPropertyName = "SUPPLIER";
			this.SUPPLIER.HeaderText = "SUPPLIER";
			this.SUPPLIER.Name = "SUPPLIER";
			this.SUPPLIER.ReadOnly = true;
			this.SUPPLIER.Visible = false;
			// 
			// FrmAddSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(879, 551);
			this.Controls.Add(this.PanelContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmAddSale";
			this.Text = "FrmAddSales";
			this.Load += new System.EventHandler(this.FrmAddSales_Load);
			this.PanelContainer.ResumeLayout(false);
			this.PanelContainer.PerformLayout();
			this.PanelData.ResumeLayout(false);
			this.PanelData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PctBxBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.db_devloDataSetProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.db_devloDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cONTACTSBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelContainer;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2ShadowPanel PanelData;
        private System.Windows.Forms.ListView LstViewProducts;
        private System.Windows.Forms.ColumnHeader ClmnHdrName;
        private System.Windows.Forms.ColumnHeader ClmnHdrCuantity;
        private System.Windows.Forms.Label LblEuros;
        private System.Windows.Forms.Label LblTotal;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewProducts;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox CmbBxContact;
        private System.Windows.Forms.Label LblSupplier;
        private System.Windows.Forms.Label LblCategory;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2PictureBox PctBxBack;
        private System.Windows.Forms.Label LblAddProduct;
        private db_devloDataSetProducts db_devloDataSetProducts;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private db_devloDataSetProductsTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private db_devloDataSet db_devloDataSet;
        private System.Windows.Forms.BindingSource cONTACTSBindingSource;
        private db_devloDataSetTableAdapters.CONTACTSTableAdapter cONTACTSTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCT;
		private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
		private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn STOCK;
		private System.Windows.Forms.DataGridViewTextBoxColumn SELL_PRICE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDCATEGORY;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDSUPPLIER;
		private System.Windows.Forms.DataGridViewTextBoxColumn SUPPLIER;
	}
}