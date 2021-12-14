namespace Proyecto_DAM.Forms.Products
{
    partial class FrmProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.DataGridViewProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_devloDataSetProducts = new Proyecto_DAM.db_devloDataSetProducts();
            this.PanelAddOptions = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.BtnAddSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddCategory = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pRODUCTSTableAdapter = new Proyecto_DAM.db_devloDataSetProductsTableAdapters.PRODUCTSTableAdapter();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_devloDataSetProducts)).BeginInit();
            this.PanelAddOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.AutoScroll = true;
            this.PanelContainer.BackColor = System.Drawing.Color.White;
            this.PanelContainer.Controls.Add(this.BtnRefresh);
            this.PanelContainer.Controls.Add(this.guna2VScrollBar1);
            this.PanelContainer.Controls.Add(this.PanelAddOptions);
            this.PanelContainer.Controls.Add(this.BtnFilter);
            this.PanelContainer.Controls.Add(this.BtnAdd);
            this.PanelContainer.Controls.Add(this.TxtSearch);
            this.PanelContainer.Controls.Add(this.DataGridViewProducts);
            this.PanelContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelContainer.Location = new System.Drawing.Point(25, 0);
            this.PanelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
            this.PanelContainer.Size = new System.Drawing.Size(1120, 639);
            this.PanelContainer.TabIndex = 3;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BindingContainer = this.DataGridViewProducts;
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.guna2VScrollBar1.HoverState.Parent = null;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1076, 85);
            this.guna2VScrollBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2VScrollBar1.Minimum = 1;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.PressedState.Parent = this.guna2VScrollBar1;
            this.guna2VScrollBar1.ScrollbarSize = 21;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(21, 524);
            this.guna2VScrollBar1.TabIndex = 6;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.guna2VScrollBar1.Value = 1;
            // 
            // DataGridViewProducts
            // 
            this.DataGridViewProducts.AllowUserToAddRows = false;
            this.DataGridViewProducts.AllowUserToDeleteRows = false;
            this.DataGridViewProducts.AllowUserToOrderColumns = true;
            this.DataGridViewProducts.AllowUserToResizeColumns = false;
            this.DataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewProducts.AutoGenerateColumns = false;
            this.DataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewProducts.ColumnHeadersHeight = 30;
            this.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRE,
            this.IDPRODUCT,
            this.CATEGORIA,
            this.PROVEDOR,
            this.STOCK,
            this.Detail,
            this.Edit,
            this.Delete});
            this.DataGridViewProducts.DataSource = this.pRODUCTSBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewProducts.EnableHeadersVisualStyles = false;
            this.DataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DataGridViewProducts.Location = new System.Drawing.Point(20, 85);
            this.DataGridViewProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewProducts.MultiSelect = false;
            this.DataGridViewProducts.Name = "DataGridViewProducts";
            this.DataGridViewProducts.ReadOnly = true;
            this.DataGridViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewProducts.RowHeadersVisible = false;
            this.DataGridViewProducts.RowHeadersWidth = 51;
            this.DataGridViewProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProducts.RowTemplate.Height = 34;
            this.DataGridViewProducts.RowTemplate.ReadOnly = true;
            this.DataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewProducts.Size = new System.Drawing.Size(1077, 524);
            this.DataGridViewProducts.TabIndex = 1;
            this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProducts.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridViewProducts.ThemeStyle.ReadOnly = true;
            this.DataGridViewProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Louis George Café", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewProducts.ThemeStyle.RowsStyle.Height = 34;
            this.DataGridViewProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DataGridViewProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProducts_CellClick);
            // 
            // CODIGO
            // 
            this.CODIGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CODIGO.DataPropertyName = "CODE";
            this.CODIGO.FillWeight = 54.21403F;
            this.CODIGO.Frozen = true;
            this.CODIGO.HeaderText = "";
            this.CODIGO.MinimumWidth = 6;
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CODIGO.Width = 55;
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NOMBRE.DataPropertyName = "NAME";
            this.NOMBRE.FillWeight = 54.21403F;
            this.NOMBRE.Frozen = true;
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NOMBRE.Width = 250;
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
            // CATEGORIA
            // 
            this.CATEGORIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CATEGORIA.DataPropertyName = "CATEGORY";
            this.CATEGORIA.FillWeight = 54.21403F;
            this.CATEGORIA.Frozen = true;
            this.CATEGORIA.HeaderText = "Categoría";
            this.CATEGORIA.MinimumWidth = 6;
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            this.CATEGORIA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CATEGORIA.Width = 135;
            // 
            // PROVEDOR
            // 
            this.PROVEDOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PROVEDOR.DataPropertyName = "SUPPLIER";
            this.PROVEDOR.FillWeight = 54.21403F;
            this.PROVEDOR.Frozen = true;
            this.PROVEDOR.HeaderText = "Proveedor";
            this.PROVEDOR.MinimumWidth = 6;
            this.PROVEDOR.Name = "PROVEDOR";
            this.PROVEDOR.ReadOnly = true;
            this.PROVEDOR.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PROVEDOR.Width = 138;
            // 
            // STOCK
            // 
            this.STOCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.STOCK.DataPropertyName = "STOCK";
            this.STOCK.FillWeight = 54.21403F;
            this.STOCK.Frozen = true;
            this.STOCK.HeaderText = "Stock";
            this.STOCK.MinimumWidth = 6;
            this.STOCK.Name = "STOCK";
            this.STOCK.ReadOnly = true;
            this.STOCK.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.STOCK.Width = 95;
            // 
            // Detail
            // 
            this.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Detail.Frozen = true;
            this.Detail.HeaderText = "";
            this.Detail.Image = ((System.Drawing.Image)(resources.GetObject("Detail.Image")));
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detail.Width = 65;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.FillWeight = 185.6143F;
            this.Edit.Frozen = true;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.FillWeight = 243.3155F;
            this.Delete.Frozen = true;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 65;
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.db_devloDataSetProducts;
            // 
            // db_devloDataSetProducts
            // 
            this.db_devloDataSetProducts.DataSetName = "db_devloDataSetProducts";
            this.db_devloDataSetProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelAddOptions
            // 
            this.PanelAddOptions.BackColor = System.Drawing.Color.Transparent;
            this.PanelAddOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.PanelAddOptions.BorderRadius = 8;
            this.PanelAddOptions.BorderThickness = 2;
            this.PanelAddOptions.Controls.Add(this.guna2Separator2);
            this.PanelAddOptions.Controls.Add(this.guna2Separator1);
            this.PanelAddOptions.Controls.Add(this.BtnAddSupplier);
            this.PanelAddOptions.Controls.Add(this.BtnAddCategory);
            this.PanelAddOptions.Controls.Add(this.BtnAddProduct);
            this.PanelAddOptions.Location = new System.Drawing.Point(730, 62);
            this.PanelAddOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelAddOptions.Name = "PanelAddOptions";
            this.PanelAddOptions.ShadowDecoration.Parent = this.PanelAddOptions;
            this.PanelAddOptions.Size = new System.Drawing.Size(180, 130);
            this.PanelAddOptions.TabIndex = 5;
            this.PanelAddOptions.Visible = false;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.guna2Separator2.Location = new System.Drawing.Point(5, 80);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(169, 10);
            this.guna2Separator2.TabIndex = 9;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.guna2Separator1.Location = new System.Drawing.Point(5, 37);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(169, 10);
            this.guna2Separator1.TabIndex = 6;
            // 
            // BtnAddSupplier
            // 
            this.BtnAddSupplier.BorderRadius = 8;
            this.BtnAddSupplier.CheckedState.Parent = this.BtnAddSupplier;
            this.BtnAddSupplier.CustomImages.Parent = this.BtnAddSupplier;
            this.BtnAddSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddSupplier.DisabledState.Parent = this.BtnAddSupplier;
            this.BtnAddSupplier.FillColor = System.Drawing.Color.White;
            this.BtnAddSupplier.Font = new System.Drawing.Font("Louis George Café", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddSupplier.ForeColor = System.Drawing.Color.Black;
            this.BtnAddSupplier.HoverState.Parent = this.BtnAddSupplier;
            this.BtnAddSupplier.Location = new System.Drawing.Point(3, 90);
            this.BtnAddSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddSupplier.Name = "BtnAddSupplier";
            this.BtnAddSupplier.ShadowDecoration.Parent = this.BtnAddSupplier;
            this.BtnAddSupplier.Size = new System.Drawing.Size(173, 31);
            this.BtnAddSupplier.TabIndex = 8;
            this.BtnAddSupplier.Text = "Proveedor";
            this.BtnAddSupplier.Click += new System.EventHandler(this.BtnAddSupplier_Click);
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.BorderRadius = 8;
            this.BtnAddCategory.CheckedState.Parent = this.BtnAddCategory;
            this.BtnAddCategory.CustomImages.Parent = this.BtnAddCategory;
            this.BtnAddCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddCategory.DisabledState.Parent = this.BtnAddCategory;
            this.BtnAddCategory.FillColor = System.Drawing.Color.White;
            this.BtnAddCategory.Font = new System.Drawing.Font("Louis George Café", 9F);
            this.BtnAddCategory.ForeColor = System.Drawing.Color.Black;
            this.BtnAddCategory.HoverState.Parent = this.BtnAddCategory;
            this.BtnAddCategory.Location = new System.Drawing.Point(5, 48);
            this.BtnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.ShadowDecoration.Parent = this.BtnAddCategory;
            this.BtnAddCategory.Size = new System.Drawing.Size(171, 36);
            this.BtnAddCategory.TabIndex = 7;
            this.BtnAddCategory.Text = "Categoría";
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.BorderRadius = 8;
            this.BtnAddProduct.CheckedState.Parent = this.BtnAddProduct;
            this.BtnAddProduct.CustomImages.Parent = this.BtnAddProduct;
            this.BtnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddProduct.DisabledState.Parent = this.BtnAddProduct;
            this.BtnAddProduct.FillColor = System.Drawing.Color.White;
            this.BtnAddProduct.Font = new System.Drawing.Font("Louis George Café", 9F);
            this.BtnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnAddProduct.HoverState.Parent = this.BtnAddProduct;
            this.BtnAddProduct.Location = new System.Drawing.Point(4, 7);
            this.BtnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.ShadowDecoration.Parent = this.BtnAddProduct;
            this.BtnAddProduct.Size = new System.Drawing.Size(173, 31);
            this.BtnAddProduct.TabIndex = 6;
            this.BtnAddProduct.Text = "Producto";
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnFilter
            // 
            this.BtnFilter.BorderRadius = 8;
            this.BtnFilter.CheckedState.Parent = this.BtnFilter;
            this.BtnFilter.CustomImages.Parent = this.BtnFilter;
            this.BtnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFilter.DisabledState.Parent = this.BtnFilter;
            this.BtnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BtnFilter.ForeColor = System.Drawing.Color.White;
            this.BtnFilter.HoverState.Parent = this.BtnFilter;
            this.BtnFilter.Image = ((System.Drawing.Image)(resources.GetObject("BtnFilter.Image")));
            this.BtnFilter.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnFilter.Location = new System.Drawing.Point(1024, 14);
            this.BtnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.ShadowDecoration.Parent = this.BtnFilter;
            this.BtnFilter.Size = new System.Drawing.Size(73, 44);
            this.BtnFilter.TabIndex = 4;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BorderRadius = 8;
            this.BtnAdd.CheckedState.Parent = this.BtnAdd;
            this.BtnAdd.CustomImages.Parent = this.BtnAdd;
            this.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdd.DisabledState.Parent = this.BtnAdd;
            this.BtnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnAdd.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.HoverState.Parent = this.BtnAdd;
            this.BtnAdd.Location = new System.Drawing.Point(730, 16);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.ShadowDecoration.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(180, 46);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Añadir";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.TxtSearch.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.White;
            this.TxtSearch.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtSearch.HoverState.Parent = this.TxtSearch;
            this.TxtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtSearch.IconLeft")));
            this.TxtSearch.Location = new System.Drawing.Point(18, 12);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtSearch.PlaceholderText = "Buscar producto...";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.ShadowDecoration.Parent = this.TxtSearch;
            this.TxtSearch.Size = new System.Drawing.Size(472, 41);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BorderRadius = 8;
            this.BtnRefresh.CheckedState.Parent = this.BtnRefresh;
            this.BtnRefresh.CustomImages.Parent = this.BtnRefresh;
            this.BtnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRefresh.DisabledState.Parent = this.BtnRefresh;
            this.BtnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.HoverState.Parent = this.BtnRefresh;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnRefresh.Location = new System.Drawing.Point(945, 16);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.ShadowDecoration.Parent = this.BtnRefresh;
            this.BtnRefresh.Size = new System.Drawing.Size(73, 44);
            this.BtnRefresh.TabIndex = 7;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 640);
            this.Controls.Add(this.PanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_devloDataSetProducts)).EndInit();
            this.PanelAddOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelContainer;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewProducts;
        private Guna.UI2.WinForms.Guna2Button BtnFilter;
        private Guna.UI2.WinForms.Guna2Button BtnAdd;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2Panel PanelAddOptions;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button BtnAddSupplier;
        private Guna.UI2.WinForms.Guna2Button BtnAddCategory;
        private Guna.UI2.WinForms.Guna2Button BtnAddProduct;
		private db_devloDataSetProducts db_devloDataSetProducts;
		private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
		private db_devloDataSetProductsTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK;
        private System.Windows.Forms.DataGridViewImageColumn Detail;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
    }
}