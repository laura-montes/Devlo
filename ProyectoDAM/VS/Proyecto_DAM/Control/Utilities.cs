using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace Control
{
	public class Utilities
	{
		//BBDD CONECTION
				db_devloEntities db = new db_devloEntities();

		//UPDATE PASSWORD
		public string pa_update_password(string user, string password, string newPass, int invoker)
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_UPDATE_PASSWORD(
				user,
				password,
				newPass,
				invoker,
				"",
				"",
				retcode,
				message
				);

			return message.Value.ToString();
		}

		//NEW USERS
		public string pa_addUser(string name, string surnames, string email, string password, int role)
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_ADD_USER(
				name,
				surnames,
				email,
				password,
				role,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}

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

		public string pa_recover_password(string email)
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
			ObjectParameter password = new ObjectParameter("PASSWORD", typeof(string));

			db.PA_RECOVER_PASSWORD(
				email,
				0,
				"",
				"",
				retcode,
				message,
				password
				);

			return password.Value.ToString();
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


		//SALES
		public string pa_add_sale(int? idcontact, decimal? totalPrice, string coments, DateTime fecha, List<SALES_LIN> lineas)
		{
			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
			ObjectParameter idCab = new ObjectParameter("IDCAB", typeof(int));

			db.PA_ADD_SALE_CAB(
				idcontact,
				totalPrice,
				coments,
				fecha,
				0,
				"",
				"",
				message,
				retcode,
				idCab
				);

				int contador = 1;
				foreach(SALES_LIN linea in lineas){

					db.PA_ADD_SALE_LIN(
					contador,
					linea.IDPRODUCT,
					linea.UNITS,
					int.Parse(idCab.Value.ToString()),
					0,
					"",
					"",
					message,
					retcode
					);

					contador++;
				}

			return retcode.Value.ToString();
		}
		public string pa_update_sale(int? idcab, int? n_lin, int? idproduct, int? units, int? idlin, decimal? totalprice, int state){

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_UPDATE_SALE(
				idcab,
				n_lin,
				idproduct,
				units,
				idlin,
				totalprice,
				state,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}
		public string pa_deleteSale(int? idSale)
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));

			db.PA_DELETE_SALE(
				idSale,
				0,
				"",
				"",
				message,
				retcode
				);

			return retcode.Value.ToString();
		}


		//FUNCTIONS
		public string count_users(DateTime fecha){

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
			ObjectParameter cantidad = new ObjectParameter("CANTIDAD", typeof(int));

			db.PA_COUNT_USERS(
				fecha,
				0,
				"",
				"",
				message,
				retcode,
				cantidad
				);

			return cantidad.Value.ToString();
		}

		public string count_users()
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
			ObjectParameter cantidad = new ObjectParameter("CANTIDAD", typeof(int));

			db.PA_COUNT_USERS(
				null,
				1,
				"",
				"",
				message,
				retcode,
				cantidad
				);

			return cantidad.Value.ToString();
		}

		public string count_products()
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
			ObjectParameter cantidad = new ObjectParameter("CANTIDAD", typeof(int));

			db.PA_COUNT_PRODUCTS(
				0,
				"",
				"",
				message,
				retcode,
				cantidad
				);

			return cantidad.Value.ToString();
		}
		public string count_dailyEarns()
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
			ObjectParameter cantidad = new ObjectParameter("CANTIDAD", typeof(int));

			db.PA_COUNT_DAILYEARNS(
				0,
				"",
				"",
				message,
				retcode,
				cantidad
				);

			return cantidad.Value.ToString();
		}
		public string count_monthlyEarns()
		{

			ObjectParameter message = new ObjectParameter("MENSAJE", typeof(string));
			ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
			ObjectParameter cantidad = new ObjectParameter("CANTIDAD", typeof(int));

			db.PA_COUNT_MONTHLYEARNS(
				0,
				"",
				"",
				message,
				retcode,
				cantidad
				);

			return cantidad.Value.ToString();
		}
	}
} 

