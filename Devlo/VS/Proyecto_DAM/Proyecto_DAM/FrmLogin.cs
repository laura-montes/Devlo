using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Proyecto_DAM
{
	public partial class FrmLogin : Form
	{

		public FrmLogin()
		{
			InitializeComponent();

            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

		// COMPROBACION USUARIO
		public bool checkLogin()
		{

			string email, password;
			email = TxtUser.Text;
			password = TxtPassword.Text;

			bool found = false;

			using (db_devloEntities db = new db_devloEntities())
			{
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));
				db.PA_CHECK_LOGIN(email, password, 0, "devlo_admin", "", retcode, mensaje);

				if ((int)retcode.Value == 0)
				{
					found = true;
				}
				else
				{
					found = false;
				}
			}

			return found;
		}

		private void PctBxClose_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

        private void BtnLogin_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Hola");
			if (checkLogin() == true)
			{
				MessageBox.Show("Bien");
			}
			else
			{
				MessageBox.Show("mal");
			}
		}
    }
}