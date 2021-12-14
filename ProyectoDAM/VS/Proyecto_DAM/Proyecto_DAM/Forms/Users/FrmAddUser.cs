using Control;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms.Users
{
	public partial class FrmAddUser : Form
	{
		string password;

		public static Regex _regex = new Regex(
			@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
			RegexOptions.CultureInvariant | RegexOptions.Singleline);


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
			Utilities utilities = new Utilities();
			if (!String.IsNullOrEmpty(TxtEmail.Text) && IsValidEmailFormat(TxtEmail.Text))
			{
				// GUARDAR
				password = randomPassword();

				utilities.pa_addUser(TxtName.Text,
					TxtSurname.Text,
					TxtEmail.Text,
					password,
					int.Parse(CmbBxRole.SelectedValue.ToString())
					);

				sendMessage();
				// comprobar de que el nuevo usuario no esté ya registrado
			}
			else
			{
				// NO GUARDAR
				MessageBox.Show("Formato invalido");
				TxtEmail.Text = "";
			}
		}

		// NO TERMINADO
		private void sendMessage()
		{
			MailMessage mail = new MailMessage();
			// SALIDA
			mail.From = new MailAddress("devlo@devlo.org", "Devlo", System.Text.Encoding.UTF8);
			// DESTINO
			mail.To.Add(TxtEmail.Text.Trim());
			// ASUNTO
			mail.Subject = "Alta de usuario Devlo CRM"; 

			// REEMPLAZAMOS CAMPOS EN EL HTML
			mail.IsBodyHtml = true;
			string html= Properties.Resources.email_generator.ToString();
			html = html.Replace("@USER",TxtEmail.Text);
			html = html.Replace("@PASSWORD", randomPassword());

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

		private void FrmAddUser_Load(object sender, EventArgs e)
		{
			// Revisar de que el usuario no esté registrado
			this.rOL_USERSTableAdapter.Fill(this.db_devloDataSetRol_Users.ROL_USERS);
		}

		public static bool IsValidEmailFormat(string emailInput)
		{
			return _regex.IsMatch(emailInput);
		}

    }
}
