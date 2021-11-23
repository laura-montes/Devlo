using Control;
using Proyecto_DAM.Forms.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAM.Forms.Sales
{
    public partial class FrmAddSale : Form
    {

        List<Classes.Product> products;
        Classes.Product product;
        double price = 0;

        Utilities utilities = new Utilities();
        List<SALES_LIN> lineas;
        SALES_LIN linea;
        DateTime thisDay = DateTime.Today;

        public FrmAddSale()
        {
            InitializeComponent();
        }

        private void FrmAddSales_Load(object sender, EventArgs e)
        {
            this.cONTACTSTableAdapter.FillCmboxSales(this.db_devloDataSet.CONTACTS);

            this.pRODUCTSTableAdapter.FillBy(this.db_devloDataSetProducts.PRODUCTS);
            CmbBxContact.DisplayMember = "FULLNAME";
            CmbBxContact.ValueMember = "IDCONTACT";


            guna2DateTimePicker1.MinDate = thisDay;

            products = new List<Classes.Product>();
        }

        private void PctBxBack_Click(object sender, EventArgs e)
        {
            volver();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //COMENTADO PORQUE TIENES QUE CAMBIAR EL LISTBOX YA QUE LOS DATOS SE COGEN DE MANERA DISTINTA

            lineas = new List<SALES_LIN>();

            foreach (Classes.Product product in products)
            {

                linea = new SALES_LIN();

                linea.IDPRODUCT = product.Id;
                linea.UNITS = product.Units;

                lineas.Add(linea);

            }

            utilities.pa_add_sale(int.Parse(CmbBxContact.SelectedValue.ToString()), decimal.Parse(price.ToString("0.00")),null, guna2DateTimePicker1.Value, lineas);

            //BORRAMOS LOS ELEMENTOS DE LA LISTA AL GUARDAR
            products.Clear();
            MessageBox.Show("Pedido realizado con exito");
            LstViewProducts.Items.Clear();
            volver();
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.pRODUCTSTableAdapter.DynamicSearch(db_devloDataSetProducts.PRODUCTS, "%" + TxtSearch.Text.Trim() + "%");
        }

        private void DataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            product = new Classes.Product();

            if (DataGridViewProducts.Rows[e.RowIndex].Cells["CODE"].Selected || DataGridViewProducts.Rows[e.RowIndex].Cells["NAME"].Selected)
            {

                //LstBxSelectedProducts.DataSource = null;

                product.Id = int.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["IDPRODUCT"].Value.ToString());
                product.Name = DataGridViewProducts.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
                product.Code = int.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["CODE"].Value.ToString());
                product.Sell_price = double.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["SELL_PRICE"].Value.ToString());

                

                product.Supplier = int.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["SUPPLIER"].Value.ToString());
                product.Category = int.Parse(DataGridViewProducts.Rows[e.RowIndex].Cells["SUPPLIER"].Value.ToString());


                FrmSelectCuantity frmSelectCuantity = new FrmSelectCuantity();

                if (frmSelectCuantity.ShowDialog() == DialogResult.OK)
                {
                    int cuantity = frmSelectCuantity.Cuantity; //lee la propiedad
                    //MessageBox.Show(cuantity.ToString());
                    product.Units = cuantity;


                    //LBL PRECIO
                    price = price + product.Sell_price * product.Units;
                    LblEuros.Text = price.ToString() + ",00€";


                    ListViewItem producto = new ListViewItem(product.Name);
                    producto.SubItems.Add(product.Units.ToString());
                    LstViewProducts.Items.Add(producto);

                }

                products.Add(product);
            } 
        }
        public void volver()
        {
            FrmSales frmSales = new FrmSales();
            frmSales.TopLevel = false;
            FrmGeneral frmGeneral = (FrmGeneral)Application.OpenForms["FrmGeneral"];
            Panel panelLoad = (Panel)frmGeneral.Controls["Panelload"];
            panelLoad.Controls.Add(frmSales);
            frmSales.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmSales.Dock = DockStyle.Fill;
            this.Close();
            frmSales.Show();
        }
    }
}
