using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace Control
{
	public class Utilities
	{
		//BBDD CONECTION
		db_devloEntities db = new db_devloEntities();


		//CHECK LOGIN
		public string pa_login(string user, string password)
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_CHECK_LOGIN(
				user,
				password,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}

		//NEW CONTACT
		public string pa_addContact(string name, string surnames, string phone, string email, string address, string role)
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_ADD_CONTACT(
				name,
				surnames,
				phone,
				email,
				address,
				role,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}
	}
} 

