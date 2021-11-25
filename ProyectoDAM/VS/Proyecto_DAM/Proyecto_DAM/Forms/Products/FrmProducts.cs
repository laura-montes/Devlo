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

namespace Proyecto_DAM.Forms.Products
{
    public partial class FrmProducts : Form
    {
        // CONTADOR PARA VISUALIZAR O NO LAS OPCIONES DE AÑADIR
        int counter = 0;
        Utilities utilities = new Utilities();

        public FrmProducts()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (counter==0)
            {
                PanelAddOptions.Visible = true;
                counter++;
            } else if (counter==1)
            {
                PanelAddOptions.Visible = false;
                counter = 0;
            }
            
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            PanelAddOptions.Visible = false;
            counter = 0;

            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            FrmAddProduct frmAddProduct = new FrmAddProduct();
            frmAddProduct.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmAddProduct);
            frmAddProduct.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmAddProduct.Dock = DockStyle.Fill;
            this.Close();
            frmAddProduct.Show();
            
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            PanelAddOptions.Visible = false;
            counter = 0;

            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            FrmAddCategory frmAddCategory = new FrmAddCategory();
            frmAddCategory.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmAddCategory);
            frmAddCategory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmAddCategory.Dock = DockStyle.Fill;
            this.Close();
            frmAddCategory.Show();
            
        }

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            PanelAddOptions.Visible = false;
            counter = 0;

            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            FrmAddSupplier frmAddSupplier = new FrmAddSupplier();
            frmAddSupplier.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmAddSupplier);
            frmAddSupplier.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmAddSupplier.Dock = DockStyle.Fill;
            this.Close();
            frmAddSupplier.Show();
            
        }

        private void FrmProducts_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'db_devloDataSetProducts.PRODUCTS' Puede moverla o quitarla según sea necesario.
			this.pRODUCTSTableAdapter.FillGridView(this.db_devloDataSetProducts.PRODUCTS);

		}

		private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
		{
            // BUSQUEDA DE PRODUCTOS TECLA POR TECLA
            this.pRODUCTSTableAdapter.DynamicSearch(db_devloDataSetProducts.PRODUCTS, "%" + TxtSearch.Text.Trim() + "%");
        }

		private void DataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            // DEPENDIENDO DE LA COLUMNA EN LA QUE ESTÉ EN LA CELDA HAREMOS UNA ACCION U OTRA
            if (DataGridViewProducts.Rows[e.RowIndex].Cells["Edit"].Selected)
            {
                int idProduct = int.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["IdProduct"].Value.ToString());
                editProduct(idProduct);
            }
            else if (DataGridViewProducts.Rows[e.RowIndex].Cells["Delete"].Selected)
            {
                FrmDeleteMessage frmDeleteMessage = new FrmDeleteMessage();
                frmDeleteMessage.Show();

                if (frmDeleteMessage.BtnYes.DialogResult == DialogResult.Yes)
                {
                    // BORRAR
                    int idProduct = int.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["IdProduct"].Value.ToString());
                   utilities.pa_deleteProduct(idProduct);
                    this.pRODUCTSTableAdapter.FillBy(this.db_devloDataSetProducts.PRODUCTS);
                }
                else
                {
                    frmDeleteMessage.Close();
                }
            } else if (DataGridViewProducts.Rows[e.RowIndex].Cells["Detail"].Selected)
            {
                int idProduct = int.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["IDPRODUCT"].Value.ToString());
                detailProduct(idProduct);
            }
        }

        private void editProduct(int id)
        {
            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            FrmEditProduct frmEditProduct = new FrmEditProduct(id);
            frmEditProduct.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmEditProduct);
            frmEditProduct.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmEditProduct.Dock = DockStyle.Fill;
            this.Close();
            frmEditProduct.Show();
            
        }


        private void detailProduct(int id)
        {
            // APARICION DE FORMULARIO EN PANEL DEL FORMULARIO GENERAL
            FrmDetailProduct frmDetailProduct = new FrmDetailProduct(id);
            frmDetailProduct.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmDetailProduct);
            frmDetailProduct.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmDetailProduct.Dock = DockStyle.Fill;
            this.Close();
            frmDetailProduct.Show();
            
        }
	}
}
