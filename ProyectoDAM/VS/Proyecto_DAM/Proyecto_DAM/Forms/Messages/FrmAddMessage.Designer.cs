
namespace Proyecto_DAM.Forms
{
    partial class FrmAddMessage
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddMessage));
            this.LblInformation = new System.Windows.Forms.Label();
            this.BtnOk = new Guna.UI2.WinForms.Guna2Button();
            this.Transition = new Guna.UI2.WinForms.Guna2Transition();
            this.SuspendLayout();
            // 
            // LblInformation
            // 
            this.LblInformation.AutoSize = true;
            this.Transition.SetDecoration(this.LblInformation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LblInformation.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformation.Location = new System.Drawing.Point(26, 29);
            this.LblInformation.Name = "LblInformation";
            this.LblInformation.Size = new System.Drawing.Size(285, 24);
            this.LblInformation.TabIndex = 5;
            this.LblInformation.Text = "Rellene los campos obligatorios";
            // 
            // BtnOk
            // 
            this.BtnOk.BorderColor = System.Drawing.Color.White;
            this.BtnOk.BorderRadius = 8;
            this.BtnOk.BorderThickness = 2;
            this.BtnOk.CheckedState.Parent = this.BtnOk;
            this.BtnOk.CustomImages.Parent = this.BtnOk;
            this.Transition.SetDecoration(this.BtnOk, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.BtnOk.Location = new System.Drawing.Point(91, 67);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.ShadowDecoration.Parent = this.BtnOk;
            this.BtnOk.Size = new System.Drawing.Size(145, 45);
            this.BtnOk.TabIndex = 7;
            this.BtnOk.Text = "Aceptar";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // Transition
            // 
            this.Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition.DefaultAnimation = animation1;
            this.Transition.TimeStep = 1F;
            // 
            // FrmAddMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(333, 124);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LblInformation);
            this.Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddMessage";
            this.Load += new System.EventHandler(this.FrmAddMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblInformation;
        internal Guna.UI2.WinForms.Guna2Button BtnOk;
        private Guna.UI2.WinForms.Guna2Transition Transition;
    }
}