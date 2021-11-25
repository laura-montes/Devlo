
namespace Proyecto_DAM.Forms
{
    partial class FrmDeleteMessage
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
            this.BtnYes = new Guna.UI2.WinForms.Guna2Button();
            this.BtnNo = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblInformation
            // 
            this.LblInformation.AutoSize = true;
            this.LblInformation.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformation.Location = new System.Drawing.Point(38, 24);
            this.LblInformation.Name = "LblInformation";
            this.LblInformation.Size = new System.Drawing.Size(244, 24);
            this.LblInformation.TabIndex = 1;
            this.LblInformation.Text = "¿Está seguro de que desea";
            // 
            // BtnYes
            // 
            this.BtnYes.BorderColor = System.Drawing.Color.White;
            this.BtnYes.BorderRadius = 8;
            this.BtnYes.BorderThickness = 2;
            this.BtnYes.CheckedState.Parent = this.BtnYes;
            this.BtnYes.CustomImages.Parent = this.BtnYes;
            this.BtnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnYes.DisabledState.Parent = this.BtnYes;
            this.BtnYes.FillColor = System.Drawing.Color.Empty;
            this.BtnYes.Font = new System.Drawing.Font("Louis George Café", 9F);
            this.BtnYes.ForeColor = System.Drawing.Color.White;
            this.BtnYes.HoverState.Parent = this.BtnYes;
            this.BtnYes.Location = new System.Drawing.Point(35, 112);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.ShadowDecoration.Parent = this.BtnYes;
            this.BtnYes.Size = new System.Drawing.Size(88, 45);
            this.BtnYes.TabIndex = 2;
            this.BtnYes.Text = "Sí";
            // 
            // BtnNo
            // 
            this.BtnNo.BorderColor = System.Drawing.Color.White;
            this.BtnNo.BorderRadius = 8;
            this.BtnNo.BorderThickness = 2;
            this.BtnNo.CheckedState.Parent = this.BtnNo;
            this.BtnNo.CustomImages.Parent = this.BtnNo;
            this.BtnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNo.DisabledState.Parent = this.BtnNo;
            this.BtnNo.FillColor = System.Drawing.Color.Empty;
            this.BtnNo.Font = new System.Drawing.Font("Louis George Café", 9F);
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.HoverState.Parent = this.BtnNo;
            this.BtnNo.Location = new System.Drawing.Point(194, 112);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.ShadowDecoration.Parent = this.BtnNo;
            this.BtnNo.Size = new System.Drawing.Size(88, 45);
            this.BtnNo.TabIndex = 3;
            this.BtnNo.Text = "No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "eliminar este registro?";
            // 
            // FrmDeleteMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(333, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.LblInformation);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDeleteMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonalMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInformation;
        internal Guna.UI2.WinForms.Guna2Button BtnYes;
        internal Guna.UI2.WinForms.Guna2Button BtnNo;
        private System.Windows.Forms.Label label1;
    }
}