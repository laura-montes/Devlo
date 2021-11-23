
namespace Proyecto_DAM.Forms.Sales
{
    partial class FrmSelectCuantity
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
            this.LblInfo = new System.Windows.Forms.Label();
            this.NumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.BtnAccept = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(42, 39);
            this.LblInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(402, 25);
            this.LblInfo.TabIndex = 0;
            this.LblInfo.Text = "Seleccione la cantidad deseada de producto.";
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.NumericUpDown.BorderColor = System.Drawing.Color.White;
            this.NumericUpDown.BorderRadius = 8;
            this.NumericUpDown.BorderThickness = 2;
            this.NumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericUpDown.DisabledState.Parent = this.NumericUpDown;
            this.NumericUpDown.FocusedState.Parent = this.NumericUpDown;
            this.NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NumericUpDown.ForeColor = System.Drawing.Color.Black;
            this.NumericUpDown.Location = new System.Drawing.Point(151, 86);
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.ShadowDecoration.Parent = this.NumericUpDown;
            this.NumericUpDown.Size = new System.Drawing.Size(157, 57);
            this.NumericUpDown.TabIndex = 1;
            this.NumericUpDown.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // BtnAccept
            // 
            this.BtnAccept.BorderColor = System.Drawing.Color.White;
            this.BtnAccept.BorderRadius = 8;
            this.BtnAccept.BorderThickness = 2;
            this.BtnAccept.CheckedState.Parent = this.BtnAccept;
            this.BtnAccept.CustomImages.Parent = this.BtnAccept;
            this.BtnAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAccept.DisabledState.Parent = this.BtnAccept;
            this.BtnAccept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccept.ForeColor = System.Drawing.Color.White;
            this.BtnAccept.HoverState.Parent = this.BtnAccept;
            this.BtnAccept.Location = new System.Drawing.Point(362, 137);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.ShadowDecoration.Parent = this.BtnAccept;
            this.BtnAccept.Size = new System.Drawing.Size(107, 44);
            this.BtnAccept.TabIndex = 2;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // FrmSelectCuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(481, 193);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.NumericUpDown);
            this.Controls.Add(this.LblInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmSelectCuantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelectCuantity";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInfo;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericUpDown;
        private Guna.UI2.WinForms.Guna2Button BtnAccept;
    }
}