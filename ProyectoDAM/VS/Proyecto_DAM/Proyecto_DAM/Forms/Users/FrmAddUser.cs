using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms.Users
{
    public partial class FrmAddUser : Form
    {
        string password;
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void PctBxBack_Click(object sender, EventArgs e)
        {
            goBack();
        }
        
        private void goBack()
        {
            FrmDashBoard frmDashBoard = new FrmDashBoard();
            frmDashBoard.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmDashBoard);
            frmDashBoard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmDashBoard.Dock = DockStyle.Fill;
            this.Close();
            frmDashBoard.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtEmail.Text))
            {
                // GUARDAR
                password = randomPassword();
                sendMessage();
                // comprobar de que el nuevo usuario no esté ya registrado
            }
            else
            {
                // NO GUARDAR
            }
        }

        // NO TERMINADO
        private void sendMessage()
        {
            string miau = "Bienvenido a Devlo." + Environment.NewLine + Environment.NewLine + "Usted a sido registrado por su administrador en Devlo CRM, le proporcionamos su" +
                "usuario y contraseña.";
            //MessageBox.Show(miau);
            MailMessage mail = new MailMessage();
            // SALIDA
            mail.From = new MailAddress("devlo@devlo.org", "Devlo", System.Text.Encoding.UTF8);
            // DESTINO
            mail.To.Add(TxtEmail.Text.Trim());
            // ASUNTO
            mail.Subject = "Alta de usuario Devlo CRM"; //Asunto
            // CUERPO
            mail.IsBodyHtml = true;
            string html = "<p>Bienvenido a Devlo</p><p>Usted a sido registrado por su administrador en Devlo CRM, le proporcionamos su</p>";
            /* mail.Body = "Bienvenido a Devlo."+Environment.NewLine+Environment.NewLine+"Usted a sido registrado por su administrador en Devlo CRM, le proporcionamos su" +
                 "usuario y contraseña."+Environment.NewLine+ "Usuario: "+TxtEmail.Text.Trim()+Environment.NewLine+"\tContraseña: "+password+
                 Environment.NewLine+"Esperemos que tenga una buena experiencia con nosotros." +
                 "Recuerde contactar con su administrador ante cualquier problema."+Environment.NewLine+"Atentamente,"+Environment.NewLine+"Devlo";*/
            mail.Body = html;
            mail.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            // HOST SERVIDOR
            smtp.Host = "smtp.gmail.com";
            // PUERTO DE SALIDA
            smtp.Port = 25; //Puerto de salida
            // CUENTA DE CORREO
            smtp.Credentials = new System.Net.NetworkCredential("devlo@devlo.org", "ADMIN_devlo");
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        private string randomPassword()
        {
            Random random = new Random();
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int length = characters.Length;
            char character;
            string randomPassword = string.Empty;
            // 10 ES LA LONGITUD DE LA CONTRASEÑA QUE DESEAMOS
            for (int i = 0; i < 10; i++) 
            {
                character = characters[random.Next(length)];
                randomPassword += character.ToString();
            }

            return randomPassword;
        }
    }
}
