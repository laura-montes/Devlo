
namespace Proyecto_DAM.Forms.Sales
{
    partial class FrmDetailSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetailSale));
            this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnExcel = new Guna.UI2.WinForms.Guna2Button();
            this.TxtCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.DatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.PanelData = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TxtState = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.DataGridViewProductsInSale = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSALESEDITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_devloDataSetDetailSale = new Proyecto_DAM.db_devloDataSetDetailSale();
            this.LblEuros = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblSupplier = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.BtnPDF = new Guna.UI2.WinForms.Guna2Button();
            this.PctBxBack = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LblAddProduct = new System.Windows.Forms.Label();
            this.v_SALESEDITTableAdapter = new Proyecto_DAM.db_devloDataSetDetailSaleTableAdapters.V_SALESEDITTableAdapter();
            this.PanelContainer.SuspendLayout();
            this.PanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductsInSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSALESEDITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_devloDataSetDetailSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.White;
            this.PanelContainer.Controls.Add(this.BtnExcel);
            this.PanelContainer.Controls.Add(this.TxtCliente);
            this.PanelContainer.Controls.Add(this.DatePicker);
            this.PanelContainer.Controls.Add(this.PanelData);
            this.PanelContainer.Controls.Add(this.LblSupplier);
            this.PanelContainer.Controls.Add(this.LblCategory);
            this.PanelContainer.Controls.Add(this.BtnPDF);
            this.PanelContainer.Controls.Add(this.PctBxBack);
            this.PanelContainer.Controls.Add(this.LblAddProduct);
            this.PanelContainer.Location = new System.Drawing.Point(45, 0);
            this.PanelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
            this.PanelContainer.Size = new System.Drawing.Size(1085, 646);
            this.PanelContainer.TabIndex = 6;
            // 
            // BtnExcel
            // 
            this.BtnExcel.BorderRadius = 8;
            this.BtnExcel.CheckedState.Parent = this.BtnExcel;
            this.BtnExcel.CustomImages.Parent = this.BtnExcel;
            this.BtnExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExcel.DisabledState.Parent = this.BtnExcel;
            this.BtnExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnExcel.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.ForeColor = System.Drawing.Color.White;
            this.BtnExcel.HoverState.Parent = this.BtnExcel;
            this.BtnExcel.Location = new System.Drawing.Point(651, 598);
            this.BtnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.ShadowDecoration.Parent = this.BtnExcel;
            this.BtnExcel.Size = new System.Drawing.Size(180, 46);
            this.BtnExcel.TabIndex = 32;
            this.BtnExcel.Text = "Generar Excel";
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtCliente.BorderRadius = 8;
            this.TxtCliente.BorderThickness = 2;
            this.TxtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCliente.DefaultText = "";
            this.TxtCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCliente.DisabledState.Parent = this.TxtCliente;
            this.TxtCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCliente.FocusedState.Parent = this.TxtCliente;
            this.TxtCliente.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.ForeColor = System.Drawing.Color.Black;
            this.TxtCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtCliente.HoverState.Parent = this.TxtCliente;
            this.TxtCliente.Location = new System.Drawing.Point(285, 84);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(5);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.PasswordChar = '\0';
            this.TxtCliente.PlaceholderText = "";
            this.TxtCliente.ReadOnly = true;
            this.TxtCliente.SelectedText = "";
            this.TxtCliente.ShadowDecoration.Parent = this.TxtCliente;
            this.TxtCliente.Size = new System.Drawing.Size(296, 32);
            this.TxtCliente.TabIndex = 31;
            // 
            // DatePicker
            // 
            this.DatePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DatePicker.BorderRadius = 8;
            this.DatePicker.BorderThickness = 2;
            this.DatePicker.CheckedState.Parent = this.DatePicker;
            this.DatePicker.Enabled = false;
            this.DatePicker.FillColor = System.Drawing.Color.White;
            this.DatePicker.Font = new System.Drawing.Font("Louis George Café", 10.2F);
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePicker.HoverState.Parent = this.DatePicker;
            this.DatePicker.Location = new System.Drawing.Point(692, 84);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.ShadowDecoration.Parent = this.DatePicker;
            this.DatePicker.Size = new System.Drawing.Size(355, 36);
            this.DatePicker.TabIndex = 30;
            this.DatePicker.Value = new System.DateTime(2021, 11, 22, 0, 0, 0, 0);
            // 
            // PanelData
            // 
            this.PanelData.BackColor = System.Drawing.Color.Transparent;
            this.PanelData.Controls.Add(this.TxtState);
            this.PanelData.Controls.Add(this.LblStatus);
            this.PanelData.Controls.Add(this.DataGridViewProductsInSale);
            this.PanelData.Controls.Add(this.LblEuros);
            this.PanelData.Controls.Add(this.LblTotal);
            this.PanelData.FillColor = System.Drawing.Color.White;
            this.PanelData.Location = new System.Drawing.Point(84, 143);
            this.PanelData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelData.Name = "PanelData";
            this.PanelData.ShadowColor = System.Drawing.Color.Black;
            this.PanelData.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.PanelData.Size = new System.Drawing.Size(963, 441);
            this.PanelData.TabIndex = 29;
            // 
            // TxtState
            // 
            this.TxtState.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtState.BorderRadius = 8;
            this.TxtState.BorderThickness = 2;
            this.TxtState.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtState.DefaultText = "";
            this.TxtState.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtState.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtState.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtState.DisabledState.Parent = this.TxtState;
            this.TxtState.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtState.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtState.FocusedState.Parent = this.TxtState;
            this.TxtState.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtState.ForeColor = System.Drawing.Color.Black;
            this.TxtState.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtState.HoverState.Parent = this.TxtState;
            this.TxtState.Location = new System.Drawing.Point(128, 384);
            this.TxtState.Margin = new System.Windows.Forms.Padding(5);
            this.TxtState.Name = "TxtState";
            this.TxtState.PasswordChar = '\0';
            this.TxtState.PlaceholderText = "";
            this.TxtState.ReadOnly = true;
            this.TxtState.SelectedText = "";
            this.TxtState.ShadowDecoration.Parent = this.TxtState;
            this.TxtState.Size = new System.Drawing.Size(241, 44);
            this.TxtState.TabIndex = 33;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(35, 394);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(75, 24);
            this.LblStatus.TabIndex = 34;
            this.LblStatus.Text = "Estado:";
            // 
            // DataGridViewProductsInSale
            // 
            this.DataGridViewProductsInSale.AllowUserToAddRows = false;
            this.DataGridViewProductsInSale.AllowUserToDeleteRows = false;
            this.DataGridViewProductsInSale.AllowUserToOrderColumns = true;
            this.DataGridViewProductsInSale.AllowUserToResizeColumns = false;
            this.DataGridViewProductsInSale.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewProductsInSale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewProductsInSale.AutoGenerateColumns = false;
            this.DataGridViewProductsInSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewProductsInSale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewProductsInSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewProductsInSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewProductsInSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProductsInSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewProductsInSale.ColumnHeadersHeight = 30;
            this.DataGridViewProductsInSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewProductsInSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Cantidad,
            this.P_Unitario,
            this.Importe});
            this.DataGridViewProductsInSale.DataSource = this.vSALESEDITBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProductsInSale.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewProductsInSale.EnableHeadersVisualStyles = false;
            this.DataGridViewProductsInSale.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DataGridViewProductsInSale.Location = new System.Drawing.Point(36, 27);
            this.DataGridViewProductsInSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewProductsInSale.MultiSelect = false;
            this.DataGridViewProductsInSale.Name = "DataGridViewProductsInSale";
            this.DataGridViewProductsInSale.ReadOnly = true;
            this.DataGridViewProductsInSale.RowHeadersVisible = false;
            this.DataGridViewProductsInSale.RowHeadersWidth = 51;
            this.DataGridViewProductsInSale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewProductsInSale.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewProductsInSale.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProductsInSale.RowTemplate.Height = 34;
            this.DataGridViewProductsInSale.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewProductsInSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewProductsInSale.Size = new System.Drawing.Size(896, 342);
            this.DataGridViewProductsInSale.TabIndex = 9;
            this.DataGridViewProductsInSale.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewProductsInSale.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewProductsInSale.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProductsInSale.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewProductsInSale.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProductsInSale.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewProductsInSale.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DataGridViewProductsInSale.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DataGridViewProductsInSale.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewProductsInSale.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProductsInSale.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewProductsInSale.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewProductsInSale.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridViewProductsInSale.ThemeStyle.ReadOnly = true;
            this.DataGridViewProductsInSale.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewProductsInSale.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewProductsInSale.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProductsInSale.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewProductsInSale.ThemeStyle.RowsStyle.Height = 34;
            this.DataGridViewProductsInSale.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DataGridViewProductsInSale.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "PRODUCTO";
            this.Descripcion.FillWeight = 123.5772F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "UNITS";
            this.Cantidad.FillWeight = 123.5772F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // P_Unitario
            // 
            this.P_Unitario.DataPropertyName = "SELL_PRICE";
            this.P_Unitario.HeaderText = "Precio unitario";
            this.P_Unitario.MinimumWidth = 6;
            this.P_Unitario.Name = "P_Unitario";
            this.P_Unitario.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "IMPORTE";
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // vSALESEDITBindingSource
            // 
            this.vSALESEDITBindingSource.DataMember = "V_SALESEDIT";
            this.vSALESEDITBindingSource.DataSource = this.db_devloDataSetDetailSale;
            // 
            // db_devloDataSetDetailSale
            // 
            this.db_devloDataSetDetailSale.DataSetName = "db_devloDataSetDetailSale";
            this.db_devloDataSetDetailSale.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblEuros
            // 
            this.LblEuros.AutoSize = true;
            this.LblEuros.Font = new System.Drawing.Font("Louis George Café", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEuros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.LblEuros.Location = new System.Drawing.Point(777, 384);
            this.LblEuros.Name = "LblEuros";
            this.LblEuros.Size = new System.Drawing.Size(130, 34);
            this.LblEuros.TabIndex = 8;
            this.LblEuros.Text = "000,00€";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(685, 391);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(57, 24);
            this.LblTotal.TabIndex = 7;
            this.LblTotal.Text = "Total:";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSupplier.Location = new System.Drawing.Point(607, 89);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(66, 24);
            this.LblSupplier.TabIndex = 13;
            this.LblSupplier.Text = "Fecha:";
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.Location = new System.Drawing.Point(116, 87);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(161, 24);
            this.LblCategory.TabIndex = 12;
            this.LblCategory.Text = "Cliente/Empresa:";
            // 
            // BtnPDF
            // 
            this.BtnPDF.BorderRadius = 8;
            this.BtnPDF.CheckedState.Parent = this.BtnPDF;
            this.BtnPDF.CustomImages.Parent = this.BtnPDF;
            this.BtnPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPDF.DisabledState.Parent = this.BtnPDF;
            this.BtnPDF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnPDF.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPDF.ForeColor = System.Drawing.Color.White;
            this.BtnPDF.HoverState.Parent = this.BtnPDF;
            this.BtnPDF.Location = new System.Drawing.Point(867, 598);
            this.BtnPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPDF.Name = "BtnPDF";
            this.BtnPDF.ShadowDecoration.Parent = this.BtnPDF;
            this.BtnPDF.Size = new System.Drawing.Size(180, 46);
            this.BtnPDF.TabIndex = 2;
            this.BtnPDF.Text = "Generar PDF";
            this.BtnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
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
            // LblAddProduct
            // 
            this.LblAddProduct.AutoSize = true;
            this.LblAddProduct.Font = new System.Drawing.Font("Louis George Café", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.LblAddProduct.Location = new System.Drawing.Point(139, 18);
            this.LblAddProduct.Name = "LblAddProduct";
            this.LblAddProduct.Size = new System.Drawing.Size(324, 40);
            this.LblAddProduct.TabIndex = 0;
            this.LblAddProduct.Text = "Información de venta";
            // 
            // v_SALESEDITTableAdapter
            // 
            this.v_SALESEDITTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDetailSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 678);
            this.Controls.Add(this.PanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDetailSale";
            this.Text = "FrmDetailSale";
            this.Load += new System.EventHandler(this.FrmDetailSale_Load);
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            this.PanelData.ResumeLayout(false);
            this.PanelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductsInSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSALESEDITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_devloDataSetDetailSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelContainer;
        private Guna.UI2.WinForms.Guna2TextBox TxtCliente;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePicker;
        private Guna.UI2.WinForms.Guna2ShadowPanel PanelData;
        private System.Windows.Forms.Label LblEuros;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblSupplier;
        private System.Windows.Forms.Label LblCategory;
        private Guna.UI2.WinForms.Guna2Button BtnPDF;
        private Guna.UI2.WinForms.Guna2PictureBox PctBxBack;
        private System.Windows.Forms.Label LblAddProduct;
        private Guna.UI2.WinForms.Guna2Button BtnExcel;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewProductsInSale;
		private db_devloDataSetDetailSale db_devloDataSetDetailSale;
		private System.Windows.Forms.BindingSource vSALESEDITBindingSource;
		private db_devloDataSetDetailSaleTableAdapters.V_SALESEDITTableAdapter v_SALESEDITTableAdapter;
        private System.Windows.Forms.Label LblStatus;
		private Guna.UI2.WinForms.Guna2TextBox TxtState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}