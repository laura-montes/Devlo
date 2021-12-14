
namespace Proyecto_DAM.Forms
{
    partial class FrmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePassword));
            this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.PctBxSeeNewPassword = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PctBxSeeActualPassword = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.TxtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtActualPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblActualPassword = new System.Windows.Forms.Label();
            this.LblNewPassword = new System.Windows.Forms.Label();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.PctBxBack = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LblAddContact = new System.Windows.Forms.Label();
            this.PanelContainer.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxSeeNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxSeeActualPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.White;
            this.PanelContainer.Controls.Add(this.guna2ShadowPanel1);
            this.PanelContainer.Controls.Add(this.BtnSave);
            this.PanelContainer.Controls.Add(this.PctBxBack);
            this.PanelContainer.Controls.Add(this.LblAddContact);
            this.PanelContainer.Location = new System.Drawing.Point(46, 0);
            this.PanelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
            this.PanelContainer.Size = new System.Drawing.Size(1085, 646);
            this.PanelContainer.TabIndex = 4;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.PctBxSeeNewPassword);
            this.guna2ShadowPanel1.Controls.Add(this.PctBxSeeActualPassword);
            this.guna2ShadowPanel1.Controls.Add(this.TxtNewPassword);
            this.guna2ShadowPanel1.Controls.Add(this.TxtActualPassword);
            this.guna2ShadowPanel1.Controls.Add(this.LblActualPassword);
            this.guna2ShadowPanel1.Controls.Add(this.LblNewPassword);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(33, 102);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1021, 423);
            this.guna2ShadowPanel1.TabIndex = 26;
            // 
            // PctBxSeeNewPassword
            // 
            this.PctBxSeeNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("PctBxSeeNewPassword.Image")));
            this.PctBxSeeNewPassword.ImageRotate = 0F;
            this.PctBxSeeNewPassword.Location = new System.Drawing.Point(737, 220);
            this.PctBxSeeNewPassword.Name = "PctBxSeeNewPassword";
            this.PctBxSeeNewPassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PctBxSeeNewPassword.ShadowDecoration.Parent = this.PctBxSeeNewPassword;
            this.PctBxSeeNewPassword.Size = new System.Drawing.Size(26, 26);
            this.PctBxSeeNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBxSeeNewPassword.TabIndex = 13;
            this.PctBxSeeNewPassword.TabStop = false;
            this.PctBxSeeNewPassword.Click += new System.EventHandler(this.PctBxSeeNewPassword_Click);
            // 
            // PctBxSeeActualPassword
            // 
            this.PctBxSeeActualPassword.Image = ((System.Drawing.Image)(resources.GetObject("PctBxSeeActualPassword.Image")));
            this.PctBxSeeActualPassword.ImageRotate = 0F;
            this.PctBxSeeActualPassword.Location = new System.Drawing.Point(737, 152);
            this.PctBxSeeActualPassword.Name = "PctBxSeeActualPassword";
            this.PctBxSeeActualPassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PctBxSeeActualPassword.ShadowDecoration.Parent = this.PctBxSeeActualPassword;
            this.PctBxSeeActualPassword.Size = new System.Drawing.Size(26, 26);
            this.PctBxSeeActualPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBxSeeActualPassword.TabIndex = 12;
            this.PctBxSeeActualPassword.TabStop = false;
            this.PctBxSeeActualPassword.Click += new System.EventHandler(this.PctBxSeeActualPassword_Click);
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtNewPassword.BorderRadius = 8;
            this.TxtNewPassword.BorderThickness = 2;
            this.TxtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNewPassword.DefaultText = "";
            this.TxtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNewPassword.DisabledState.Parent = this.TxtNewPassword;
            this.TxtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtNewPassword.FocusedState.Parent = this.TxtNewPassword;
            this.TxtNewPassword.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtNewPassword.HoverState.Parent = this.TxtNewPassword;
            this.TxtNewPassword.Location = new System.Drawing.Point(390, 214);
            this.TxtNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.PasswordChar = '\0';
            this.TxtNewPassword.PlaceholderText = "";
            this.TxtNewPassword.SelectedText = "";
            this.TxtNewPassword.ShadowDecoration.Parent = this.TxtNewPassword;
            this.TxtNewPassword.Size = new System.Drawing.Size(339, 36);
            this.TxtNewPassword.TabIndex = 7;
            this.TxtNewPassword.UseSystemPasswordChar = true;
            // 
            // TxtActualPassword
            // 
            this.TxtActualPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtActualPassword.BorderRadius = 8;
            this.TxtActualPassword.BorderThickness = 2;
            this.TxtActualPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtActualPassword.DefaultText = "";
            this.TxtActualPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtActualPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtActualPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtActualPassword.DisabledState.Parent = this.TxtActualPassword;
            this.TxtActualPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtActualPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtActualPassword.FocusedState.Parent = this.TxtActualPassword;
            this.TxtActualPassword.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtActualPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtActualPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TxtActualPassword.HoverState.Parent = this.TxtActualPassword;
            this.TxtActualPassword.Location = new System.Drawing.Point(390, 148);
            this.TxtActualPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxtActualPassword.Name = "TxtActualPassword";
            this.TxtActualPassword.PasswordChar = '\0';
            this.TxtActualPassword.PlaceholderText = "";
            this.TxtActualPassword.SelectedText = "";
            this.TxtActualPassword.ShadowDecoration.Parent = this.TxtActualPassword;
            this.TxtActualPassword.Size = new System.Drawing.Size(339, 36);
            this.TxtActualPassword.TabIndex = 6;
            this.TxtActualPassword.UseSystemPasswordChar = true;
            // 
            // LblActualPassword
            // 
            this.LblActualPassword.AutoSize = true;
            this.LblActualPassword.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActualPassword.Location = new System.Drawing.Point(195, 150);
            this.LblActualPassword.Name = "LblActualPassword";
            this.LblActualPassword.Size = new System.Drawing.Size(177, 24);
            this.LblActualPassword.TabIndex = 10;
            this.LblActualPassword.Text = "Contraseña actual:";
            // 
            // LblNewPassword
            // 
            this.LblNewPassword.AutoSize = true;
            this.LblNewPassword.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewPassword.Location = new System.Drawing.Point(195, 214);
            this.LblNewPassword.Name = "LblNewPassword";
            this.LblNewPassword.Size = new System.Drawing.Size(176, 24);
            this.LblNewPassword.TabIndex = 11;
            this.LblNewPassword.Text = "Contraseña nueva:";
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
            this.BtnSave.Font = new System.Drawing.Font("Louis George Café", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.HoverState.Parent = this.BtnSave;
            this.BtnSave.Location = new System.Drawing.Point(875, 572);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.ShadowDecoration.Parent = this.BtnSave;
            this.BtnSave.Size = new System.Drawing.Size(180, 46);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            // LblAddContact
            // 
            this.LblAddContact.AutoSize = true;
            this.LblAddContact.Font = new System.Drawing.Font("Louis George Café", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.LblAddContact.Location = new System.Drawing.Point(139, 18);
            this.LblAddContact.Name = "LblAddContact";
            this.LblAddContact.Size = new System.Drawing.Size(329, 40);
            this.LblAddContact.TabIndex = 0;
            this.LblAddContact.Text = "Cambiar contrraseña";
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 678);
            this.Controls.Add(this.PanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChangePassword";
            this.Text = "FrmEditProfile";
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxSeeNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxSeeActualPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelContainer;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PctBxSeeNewPassword;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PctBxSeeActualPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtActualPassword;
        private System.Windows.Forms.Label LblActualPassword;
        private System.Windows.Forms.Label LblNewPassword;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2PictureBox PctBxBack;
        private System.Windows.Forms.Label LblAddContact;
    }
}