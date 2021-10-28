using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Models
{
	public class Customers
	{
        public int IDCONTACT { get; set; }
        public string NAME { get; set; }
        public string SURNAMES { get; set; }

        public string FULL_NAME { get { return NAME + " " + SURNAMES; } }

        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string ADDRESS { get; set; }
        public string ROLE { get; set; }

    }
}
