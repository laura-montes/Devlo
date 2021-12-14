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
    public partial class FrmAddMessage : Form
    {
        public FrmAddMessage()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
