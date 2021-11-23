
namespace Proyecto_DAM
{
	partial class FrmLogin
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PctBxShape = new System.Windows.Forms.PictureBox();
            this.PctBxIcon = new System.Windows.Forms.PictureBox();
            this.PctBxClose = new System.Windows.Forms.PictureBox();
            this.LblForgottenPassword = new System.Windows.Forms.Label();
            this.TxtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Louis George Café", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 1;
            // 
            // PctBxShape
            // 
            this.PctBxShape.Image = ((System.Drawing.Image)(resources.GetObject("PctBxShape.Image")));
            this.PctBxShape.Location = new System.Drawing.Point(-30, 42);
            this.PctBxShape.Name = "PctBxShape";
            this.PctBxShape.Size = new System.Drawing.Size(508, 400);
            this.PctBxShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBxShape.TabIndex = 2;
            this.PctBxShape.TabStop = false;
            // 
            // PctBxIcon
            // 
            this.PctBxIcon.BackColor = System.Drawing.Color.White;
            this.PctBxIcon.Image = ((System.Drawing.Image)(resources.GetObject("PctBxIcon.Image")));
            this.PctBxIcon.InitialImage = null;
            this.PctBxIcon.Location = new System.Drawing.Point(100, 162);
            this.PctBxIcon.Name = "PctBxIcon";
            this.PctBxIcon.Size = new System.Drawing.Size(222, 206);
            this.PctBxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBxIcon.TabIndex = 3;
            this.PctBxIcon.TabStop = false;
            // 
            // PctBxClose
            // 
            this.PctBxClose.Image = ((System.Drawing.Image)(resources.GetObject("PctBxClose.Image")));
            this.PctBxClose.Location = new System.Drawing.Point(895, 1);
            this.PctBxClose.Name = "PctBxClose";
            this.PctBxClose.Size = new System.Drawing.Size(47, 46);
            this.PctBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBxClose.TabIndex = 9;
            this.PctBxClose.TabStop = false;
            this.PctBxClose.Click += new System.EventHandler(this.PctBxClose_Click);
            // 
            // LblForgottenPassword
            // 
            this.LblForgottenPassword.AutoSize = true;
            this.LblForgottenPassword.Font = new System.Drawing.Font("Louis George Café", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForgottenPassword.Location = new System.Drawing.Point(591, 383);
            this.LblForgottenPassword.Name = "LblForgottenPassword";
            this.LblForgottenPassword.Size = new System.Drawing.Size(225, 23);
            this.LblForgottenPassword.TabIndex = 5;
            this.LblForgottenPassword.Text = "¿Olvidaste la contraseña?";
            // 
            // TxtUser
            // 
            this.TxtUser.BorderColor = System.Drawing.Color.White;
            this.TxtUser.BorderRadius = 8;
            this.TxtUser.BorderThickness = 2;
            this.TxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUser.DefaultText = "";
            this.TxtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUser.DisabledState.Parent = this.TxtUser;
            this.TxtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtUser.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtUser.FocusedState.Parent = this.TxtUser;
            this.TxtUser.Font = new System.Drawing.Font("Louis George Café", 13.8F);
            this.TxtUser.ForeColor = System.Drawing.Color.White;
            this.TxtUser.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtUser.HoverState.Parent = this.TxtUser;
            this.TxtUser.Location = new System.Drawing.Point(501, 162);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.PasswordChar = '\0';
            this.TxtUser.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtUser.PlaceholderText = "Usuario";
            this.TxtUser.SelectedText = "";
            this.TxtUser.ShadowDecoration.Parent = this.TxtUser;
            this.TxtUser.Size = new System.Drawing.Size(355, 48);
            this.TxtUser.TabIndex = 13;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderColor = System.Drawing.Color.White;
            this.TxtPassword.BorderRadius = 8;
            this.TxtPassword.BorderThickness = 2;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.DefaultText = "";
            this.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.DisabledState.Parent = this.TxtPassword;
            this.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtPassword.FocusedState.Parent = this.TxtPassword;
            this.TxtPassword.Font = new System.Drawing.Font("Louis George Café", 13.8F);
            this.TxtPassword.ForeColor = System.Drawing.Color.White;
            this.TxtPassword.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtPassword.HoverState.Parent = this.TxtPassword;
            this.TxtPassword.Location = new System.Drawing.Point(501, 244);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '\0';
            this.TxtPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtPassword.PlaceholderText = "Contraseña";
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.ShadowDecoration.Parent = this.TxtPassword;
            this.TxtPassword.Size = new System.Drawing.Size(355, 48);
            this.TxtPassword.TabIndex = 14;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BorderRadius = 8;
            this.BtnLogin.CheckedState.Parent = this.BtnLogin;
            this.BtnLogin.CustomImages.Parent = this.BtnLogin;
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.DisabledState.Parent = this.BtnLogin;
            this.BtnLogin.FillColor = System.Drawing.Color.White;
            this.BtnLogin.Font = new System.Drawing.Font("Louis George Café", 13.8F);
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.BtnLogin.HoverState.Parent = this.BtnLogin;
            this.BtnLogin.Location = new System.Drawing.Point(501, 323);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.ShadowDecoration.Parent = this.BtnLogin;
            this.BtnLogin.Size = new System.Drawing.Size(355, 45);
            this.BtnLogin.TabIndex = 15;
            this.BtnLogin.Text = "Iniciar sesión";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(944, 506);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblForgottenPassword);
            this.Controls.Add(this.PctBxClose);
            this.Controls.Add(this.PctBxIcon);
            this.Controls.Add(this.PctBxShape);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Louis George Café", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PctBxShape;
        private System.Windows.Forms.PictureBox PctBxIcon;
        private System.Windows.Forms.PictureBox PctBxClose;
        private System.Windows.Forms.Label LblForgottenPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtUser;
        private Guna.UI2.WinForms.Guna2TextBox TxtPassword;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
    }
}

