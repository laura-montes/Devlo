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
			//Ocultamos siempre la contraseña si no se ha activado el CheckBox
			TxtPassword.UseSystemPasswordChar = true;
		}

		//MOSTRAMOS LA CONTRASEÑA AL USUARIO
		private void CbShowPass_CheckedChanged(object sender, EventArgs e)
		{
			if (CbShowPass.Checked == false)
			{
				TxtPassword.UseSystemPasswordChar = true;
			}
			else
			{
				TxtPassword.UseSystemPasswordChar = false;
			}
		}

		//COMPROBAMOS QUE EXISTE EN LA BASE DE DATOS
		private void BtnLogin_Click(object sender, EventArgs e)
		{
			if (checkLogin()) {
				MessageBox.Show("Bien");
			} else {
				MessageBox.Show("mal");
			}
		}

		//	CIERRE DE APLICACION
		private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}



		//METODO PARA COMPROBAR LA CONTRASEÑA
		public bool checkLogin()
		{

			string email, password;
			email = TxtUser.Text;
			password = TxtPassword.Text;

			bool t = false;

			using (db_devloEntities db = new db_devloEntities())
			{
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));
				db.PA_COMPROBAR_LOGIN(email, password, 0, "admin_devlo", "", retcode, mensaje);

				if ((int)retcode.Value == 0)
				{
					t = true;
				}
				else
				{
					t = false;
				}
			}

			return t;
		}


		//BOTON PARA REGISTRARSE
		private void BtnRegister_Click(object sender, EventArgs e)
		{
			//CREACION DE UN NUEVO FORMULARIO PARA REGISTRO

		}

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
				if (checkLogin())
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
}
