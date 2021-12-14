
namespace Proyecto_DAM.Forms
{
    partial class FrmEditMessage
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
            this.BtnOk = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // LblInformation
            // 
            this.LblInformation.AutoSize = true;
            this.LblInformation.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformation.Location = new System.Drawing.Point(56, 29);
            this.LblInformation.Name = "LblInformation";
            this.LblInformation.Size = new System.Drawing.Size(214, 24);
            this.LblInformation.TabIndex = 5;
            this.LblInformation.Text = "Editado correctamente";
            // 
            // BtnOk
            // 
            this.BtnOk.BorderColor = System.Drawing.Color.White;
            this.BtnOk.BorderRadius = 8;
            this.BtnOk.BorderThickness = 2;
            this.BtnOk.CheckedState.Parent = this.BtnOk;
            this.BtnOk.CustomImages.Parent = this.BtnOk;
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnOk.DisabledState.Parent = this.BtnOk;
            this.BtnOk.FillColor = System.Drawing.Color.Empty;
            this.BtnOk.Font = new System.Drawing.Font("Louis George Café", 9F);
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.HoverState.Parent = this.BtnOk;
            this.BtnOk.Location = new System.Drawing.Point(82, 76);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.ShadowDecoration.Parent = this.BtnOk;
            this.BtnOk.Size = new System.Drawing.Size(145, 45);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "Aceptar";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FrmEditMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(333, 133);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LblInformation);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditMessage";
            this.Text = "FrmAddMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblInformation;
        internal Guna.UI2.WinForms.Guna2Button BtnOk;
    }
}