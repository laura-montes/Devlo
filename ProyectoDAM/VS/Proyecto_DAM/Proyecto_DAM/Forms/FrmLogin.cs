using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Proyecto_DAM.Forms;

namespace Proyecto_DAM
{
	public partial class FrmLogin : Form
	{

		Utilities utilidades = new Utilities();

		public static Regex _regex = new Regex(
			@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
			RegexOptions.CultureInvariant | RegexOptions.Singleline);
		public FrmLogin()
		{
			InitializeComponent();
			TxtPassword.Text = "admin";
			TxtUser.Text = "admin@devlo.org";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
		}

		private void PctBxClose_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

        private void BtnLogin_Click(object sender, EventArgs e)
        {
			if (IsValidEmailFormat(TxtUser.Text))
			{
				loginCheck();
			}
			else
			{
				MessageBox.Show("Formato invalido");
				TxtUser.Text = "";
				TxtPassword.Text = "";
			}
		}

		internal Boolean loginCheck()
        {
			try
			{
				if (utilidades.pa_login(TxtUser.Text.ToUpper(), TxtPassword.Text.ToUpper()).Equals("0"))
				{
					Program.SetMainForm(new FrmGeneral());
					Program.ShowMainForm();

					this.Close();
					return true;
				}
				else
				{
					TxtUser.Text = "";
					TxtPassword.Text = "";
					MessageBox.Show("Usuario y/o contraseña incorrectas.");
					return false;

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return true;
			}
		}
        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
			// AL PULSAR ENTER
			if (e.KeyCode == Keys.Enter){
				if(IsValidEmailFormat(TxtUser.Text))
				{
					loginCheck();
				}
				else{
					MessageBox.Show("Formato invalido");
				}
			}
		}

		public static bool IsValidEmailFormat(string emailInput)
		{
			return _regex.IsMatch(emailInput);
		}

        private void LblForgottenPassword_Click(object sender, EventArgs e)
        {
			sendEmail();	
		}

		private void sendEmail()
        {
			MailMessage mail = new MailMessage();
			// SALIDA
			mail.From = new MailAddress("devlo@devlo.org", "Devlo", System.Text.Encoding.UTF8);
			// DESTINO
			mail.To.Add(TxtUser.Text.Trim());
			// ASUNTO
			mail.Subject = "Recordatorio de contraseña Devlo CRM";

			// REEMPLAZAMOS CAMPOS EN EL HTML
			mail.IsBodyHtml = true;
			string html = Properties.Resources.password_generator.ToString();
			html = html.Replace("@USER", TxtUser.Text);
			html = html.Replace("@PASSWORD", utilidades.pa_recover_password(TxtUser.Text.Trim()));

			mail.Body = html;
			mail.Priority = MailPriority.Normal;
			SmtpClient smtp = new SmtpClient();
			smtp.UseDefaultCredentials = false;
			// HOST SERVIDOR
			smtp.Host = "smtp.gmail.com";
			// PUERTO DE SALIDA
			smtp.Port = 25;

			// CUENTA DE CORREO
			smtp.Credentials = new System.Net.NetworkCredential("devlo@devlo.org", "ADMIN_devlo");
			ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
			smtp.EnableSsl = true;
			smtp.Send(mail);
		}


		// Mover ventana
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
    }
}