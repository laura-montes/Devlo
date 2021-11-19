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

		//CONTACT
		public string pa_addContact(string name, string surnames, string phone, string email, string address, string role, string observations)
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
				observations,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}

		public string pa_updateContact(int idContact, string name, string surnames, string phone, string email, string address, string role, string observations)
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_UPDATE_CONTACT(
				idContact,
				name,
				surnames,
				phone,
				email,
				address,
				role,
				observations,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}
		public string pa_deleteContact(int idContact)
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_DELETE_CONTACT(
				idContact,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}

		//NEW CATEGORY
		public string pa_add_category(string name, string description){

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_ADD_CATEGORY(
				name,
				description,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}
		//NEW SUPPLIER
		public string pa_add_supplier(string name, string description)
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_ADD_SUPPLIER(
				name,
				description,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}


		//PRODCUTS
		public string pa_add_product(int? code, string name, string description, int? category, int? supplier, int? stock, decimal? sell_price, decimal? supplier_price)
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_ADD_PRODUCT(
				code,
				name,
				description,
				category,
				supplier,
				stock,
				sell_price,
				supplier_price,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}
		public string pa_update_product(int? code, string name, string description, int? category, int? supplier, int? stock, decimal? sell_price, decimal? supplier_price)
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_UPDATE_PRODUCT(
				code,
				name,
				description,
				category,
				supplier,
				stock,
				sell_price,
				supplier_price,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}
		public string pa_deleteProduct(int? idProduct){

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_DELETE_PRODUCT(
				idProduct,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}


		public string pa_add_sale(int? idcontact, decimal? totalPrice, string coments, List<SALES_LIN> lineas)
		{
			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
			ObjectParameter idCab = new ObjectParameter("IDCAB", typeof(int));

			db.PA_ADD_SALE_CAB(
				idcontact,
				totalPrice,
				coments,
				0,
				"",
				"",
				message,
				retcode,
				idCab
				);



			return retcode.Value.ToString();
		}
	}
} 

