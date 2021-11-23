using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

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

		private void loginCheck()
        {
			try
			{
				if (utilidades.pa_login(TxtUser.Text.ToUpper(), TxtPassword.Text.ToUpper()).Equals("0"))
				{
					MessageBox.Show("CREDENCIALES CORRECTAS");

					FrmGeneral frmGeneral = new FrmGeneral();
					this.Hide();
					frmGeneral.Show();
				}
				else
				{
					TxtUser.Text = "";
					TxtPassword.Text = "";
					MessageBox.Show("CREDENCIALES INCORRECTAS");

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
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
	}
}