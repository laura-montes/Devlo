using Proyecto_DAM.Forms;
using Proyecto_DAM.Forms.Customers;
using Proyecto_DAM.Forms.Products;
using Proyecto_DAM.Forms.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAM
{
	static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmGeneral());
		}
	}
}
