
namespace Proyecto_DAM
{
    partial class FrmDashBoard
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
			this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
			this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.SuspendLayout();
			// 
			// guna2CircleProgressBar1
			// 
			this.guna2CircleProgressBar1.Animated = true;
			this.guna2CircleProgressBar1.AnimationSpeed = 0.1F;
			this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.Black;
			this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
			this.guna2CircleProgressBar1.InnerColor = System.Drawing.Color.White;
			this.guna2CircleProgressBar1.Location = new System.Drawing.Point(632, 81);
			this.guna2CircleProgressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.guna2CircleProgressBar1.Minimum = 0;
			this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
			this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
			this.guna2CircleProgressBar1.Size = new System.Drawing.Size(120, 120);
			this.guna2CircleProgressBar1.TabIndex = 0;
			this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
			this.guna2CircleProgressBar1.Value = 80;
			// 
			// guna2DateTimePicker1
			// 
			this.guna2DateTimePicker1.BorderRadius = 8;
			this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
			this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
			this.guna2DateTimePicker1.Location = new System.Drawing.Point(335, 81);
			this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
			this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
			this.guna2DateTimePicker1.Size = new System.Drawing.Size(196, 20);
			this.guna2DateTimePicker1.TabIndex = 1;
			this.guna2DateTimePicker1.Value = new System.DateTime(2021, 10, 28, 0, 24, 16, 508);
			// 
			// FrmDashBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(866, 543);
			this.Controls.Add(this.guna2DateTimePicker1);
			this.Controls.Add(this.guna2CircleProgressBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmDashBoard";
			this.Text = "FrmDashBoard";
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}