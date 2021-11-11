
namespace Proyecto_DAM.Forms.Ventas
{
    partial class FrmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewSales = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.White;
            this.PanelContainer.Controls.Add(this.guna2VScrollBar1);
            this.PanelContainer.Controls.Add(this.BtnFilter);
            this.PanelContainer.Controls.Add(this.BtnAdd);
            this.PanelContainer.Controls.Add(this.TxtSearch);
            this.PanelContainer.Controls.Add(this.DataGridViewSales);
            this.PanelContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelContainer.Location = new System.Drawing.Point(26, 1);
            this.PanelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
            this.PanelContainer.Size = new System.Drawing.Size(1120, 639);
            this.PanelContainer.TabIndex = 4;
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
            this.BtnAdd.Location = new System.Drawing.Point(812, 14);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.ShadowDecoration.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(180, 46);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Añadir";
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
            this.TxtSearch.Font = new System.Drawing.Font("Louis George Café", 12F);
            this.TxtSearch.ForeColor = System.Drawing.Color.Empty;
            this.TxtSearch.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtSearch.HoverState.Parent = this.TxtSearch;
            this.TxtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtSearch.IconLeft")));
            this.TxtSearch.Location = new System.Drawing.Point(20, 12);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtSearch.PlaceholderText = "Buscar ventas...";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.ShadowDecoration.Parent = this.TxtSearch;
            this.TxtSearch.Size = new System.Drawing.Size(515, 43);
            this.TxtSearch.TabIndex = 2;
            // 
            // DataGridViewSales
            // 
            this.DataGridViewSales.AllowUserToAddRows = false;
            this.DataGridViewSales.AllowUserToDeleteRows = false;
            this.DataGridViewSales.AllowUserToOrderColumns = true;
            this.DataGridViewSales.AllowUserToResizeColumns = false;
            this.DataGridViewSales.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewSales.ColumnHeadersHeight = 50;
            this.DataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewSales.ColumnHeadersVisible = false;
            this.DataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSales.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewSales.EnableHeadersVisualStyles = false;
            this.DataGridViewSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DataGridViewSales.Location = new System.Drawing.Point(20, 85);
            this.DataGridViewSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewSales.MultiSelect = false;
            this.DataGridViewSales.Name = "DataGridViewSales";
            this.DataGridViewSales.ReadOnly = true;
            this.DataGridViewSales.RowHeadersVisible = false;
            this.DataGridViewSales.RowHeadersWidth = 51;
            this.DataGridViewSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewSales.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewSales.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewSales.RowTemplate.Height = 34;
            this.DataGridViewSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewSales.Size = new System.Drawing.Size(1077, 524);
            this.DataGridViewSales.TabIndex = 1;
            this.DataGridViewSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewSales.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewSales.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewSales.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DataGridViewSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewSales.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewSales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewSales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewSales.ThemeStyle.HeaderStyle.Height = 50;
            this.DataGridViewSales.ThemeStyle.ReadOnly = true;
            this.DataGridViewSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.DataGridViewSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewSales.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewSales.ThemeStyle.RowsStyle.Height = 34;
            this.DataGridViewSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DataGridViewSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BindingContainer = this.DataGridViewSales;
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
            this.guna2VScrollBar1.TabIndex = 5;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.guna2VScrollBar1.Value = 1;
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 640);
            this.Controls.Add(this.PanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSales";
            this.Text = "FrmSales";
            this.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelContainer;
        private Guna.UI2.WinForms.Guna2Button BtnFilter;
        private Guna.UI2.WinForms.Guna2Button BtnAdd;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewSales;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
    }
}