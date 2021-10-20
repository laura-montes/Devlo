
namespace Proyecto_DAM.Controls
{
    partial class TextBox_User
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
            this.CustomTxtUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomTxtUser
            // 
            this.CustomTxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.CustomTxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomTxtUser.ForeColor = System.Drawing.Color.White;
            this.CustomTxtUser.Location = new System.Drawing.Point(12, 4);
            this.CustomTxtUser.Name = "CustomTxtUser";
            this.CustomTxtUser.Size = new System.Drawing.Size(303, 28);
            this.CustomTxtUser.TabIndex = 0;
            // 
            // TextBox_User
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(123)))));
            this.Controls.Add(this.CustomTxtUser);
            this.Font = new System.Drawing.Font("Louis George Café", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TextBox_User";
            this.Size = new System.Drawing.Size(332, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomTxtUser;
    }
}
