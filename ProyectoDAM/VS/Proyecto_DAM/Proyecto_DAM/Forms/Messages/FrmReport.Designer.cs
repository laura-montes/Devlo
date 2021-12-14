
namespace Proyecto_DAM.Forms.Messages
{
    partial class FrmReport
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
            this.LblInformation = new System.Windows.Forms.Label();
            this.DatePickerInit = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DatePickerFinal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReport = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // LblInformation
            // 
            this.LblInformation.AutoSize = true;
            this.LblInformation.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformation.Location = new System.Drawing.Point(56, 30);
            this.LblInformation.Name = "LblInformation";
            this.LblInformation.Size = new System.Drawing.Size(289, 24);
            this.LblInformation.TabIndex = 2;
            this.LblInformation.Text = "Seleccione entre qué dos fechas";
            // 
            // DatePickerInit
            // 
            this.DatePickerInit.BorderColor = System.Drawing.Color.White;
            this.DatePickerInit.BorderRadius = 8;
            this.DatePickerInit.BorderThickness = 2;
            this.DatePickerInit.CheckedState.Parent = this.DatePickerInit;
            this.DatePickerInit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DatePickerInit.Font = new System.Drawing.Font("Louis George Café", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerInit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerInit.HoverState.Parent = this.DatePickerInit;
            this.DatePickerInit.Location = new System.Drawing.Point(25, 101);
            this.DatePickerInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatePickerInit.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePickerInit.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePickerInit.Name = "DatePickerInit";
            this.DatePickerInit.ShadowDecoration.Parent = this.DatePickerInit;
            this.DatePickerInit.Size = new System.Drawing.Size(167, 34);
            this.DatePickerInit.TabIndex = 3;
            this.DatePickerInit.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DatePickerInit.ValueChanged += new System.EventHandler(this.DatePickerInit_ValueChanged);
            // 
            // DatePickerFinal
            // 
            this.DatePickerFinal.BorderColor = System.Drawing.Color.White;
            this.DatePickerFinal.BorderRadius = 8;
            this.DatePickerFinal.BorderThickness = 2;
            this.DatePickerFinal.CheckedState.Parent = this.DatePickerFinal;
            this.DatePickerFinal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.DatePickerFinal.Font = new System.Drawing.Font("Louis George Café", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerFinal.HoverState.Parent = this.DatePickerFinal;
            this.DatePickerFinal.Location = new System.Drawing.Point(220, 101);
            this.DatePickerFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatePickerFinal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePickerFinal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePickerFinal.Name = "DatePickerFinal";
            this.DatePickerFinal.ShadowDecoration.Parent = this.DatePickerFinal;
            this.DatePickerFinal.Size = new System.Drawing.Size(167, 34);
            this.DatePickerFinal.TabIndex = 4;
            this.DatePickerFinal.Value = new System.DateTime(2021, 12, 8, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "desea realizar el reporte";
            // 
            // BtnReport
            // 
            this.BtnReport.BorderColor = System.Drawing.Color.White;
            this.BtnReport.BorderRadius = 8;
            this.BtnReport.BorderThickness = 2;
            this.BtnReport.CheckedState.Parent = this.BtnReport;
            this.BtnReport.CustomImages.Parent = this.BtnReport;
            this.BtnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReport.DisabledState.Parent = this.BtnReport;
            this.BtnReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnReport.Font = new System.Drawing.Font("Louis George Café", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.HoverState.Parent = this.BtnReport;
            this.BtnReport.Location = new System.Drawing.Point(12, 154);
            this.BtnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.ShadowDecoration.Parent = this.BtnReport;
            this.BtnReport.Size = new System.Drawing.Size(387, 28);
            this.BtnReport.TabIndex = 6;
            this.BtnReport.Text = "Generar";
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(411, 194);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePickerFinal);
            this.Controls.Add(this.DatePickerInit);
            this.Controls.Add(this.LblInformation);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInformation;
        private System.Windows.Forms.Label label1;
        internal Guna.UI2.WinForms.Guna2DateTimePicker DatePickerInit;
        internal Guna.UI2.WinForms.Guna2DateTimePicker DatePickerFinal;
        private Guna.UI2.WinForms.Guna2Button BtnReport;
    }
}