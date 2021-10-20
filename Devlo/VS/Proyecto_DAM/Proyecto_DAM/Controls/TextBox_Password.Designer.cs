
namespace Proyecto_DAM.Controls
{
    partial class TextBox_Password
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomTxtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomTxtPassword
            // 
            this.CustomTxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.CustomTxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomTxtPassword.ForeColor = System.Drawing.Color.White;
            this.CustomTxtPassword.Location = new System.Drawing.Point(12, 4);
            this.CustomTxtPassword.Name = "CustomTxtPassword";
            this.CustomTxtPassword.Size = new System.Drawing.Size(303, 28);
            this.CustomTxtPassword.TabIndex = 0;
            this.CustomTxtPassword.UseSystemPasswordChar = true;
            // 
            // TextBox_Password
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.Controls.Add(this.CustomTxtPassword);
            this.Font = new System.Drawing.Font("Louis George Café", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TextBox_Password";
            this.Size = new System.Drawing.Size(332, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomTxtPassword;
    }
}
