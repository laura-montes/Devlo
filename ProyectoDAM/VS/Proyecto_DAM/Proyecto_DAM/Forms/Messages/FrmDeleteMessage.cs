using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms
{
    public partial class FrmDeleteMessage : Form
    {
        int id;
        string formName;
        Utilities utilities = new Utilities();
        public FrmDeleteMessage(int id, string formName)
        {
            InitializeComponent();
            this.id = id;
            this.formName = formName;
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            switch (formName)
            {
                case "customers":
                    utilities.pa_deleteContact(id);
                    this.Close(); 
                    break;
                case "products": 
                    utilities.pa_deleteProduct(id);
                    this.Close();
                    break;
                case "sales":
                    utilities.pa_deleteSale(id);
                    this.Close();
                    break;
            }
               
                
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void FrmDeleteMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
