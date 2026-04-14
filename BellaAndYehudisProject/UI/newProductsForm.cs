using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class newProductsForm : BaseForm
    {
        public newProductsForm()
        {
            InitializeComponent();
        }

        private void newProductsForm_Load(object sender, EventArgs e) { }  //CREATED ACCIDENTLY

        #region Enter Create and update button
        protected override void EnterCreatebtnMethod()
        {
            ProductBL productbl = new ProductBL(new DAL.ProductDAL());
            try
            {
                if (currentMode == FormMode.Create)  //create
                {

                    productbl.CreateProduct(new Entities.Product(int.Parse(ProductNumtxt.Text), ProductNametxt.Text, double.Parse(Costtxt.Text), int.Parse(Stocktxt.Text)));
                    MessageBox.Show("Product Created");

                }
                if (currentMode == FormMode.Update) ///update
                {
                    productbl.UpdateProduct(new Entities.Product(int.Parse(ProductNumtxt.Text), ProductNametxt.Text, double.Parse(Costtxt.Text), int.Parse(Stocktxt.Text)));
                    MessageBox.Show("Product Updated");

                }
            }
            catch (Exception ex) ///catch any exceptions that may occur during the create or update process and display an error message to the user.
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Read All Button 

        protected override void ReadAllMethod()
        {
            ProductBL productbl = new ProductBL(new DAL.ProductDAL());
            ReadAlltxt.AppendText(Text = "Product Number, Product Name, Cost Per Unit, Amount In Stock" + "\r\n"); //adding column headers
            foreach (Entities.Product product in productbl.Read())
            {
                ReadAlltxt.AppendText($"{product.ToString()}" + "\r\n"); //adding each product to the text box
            }
        }


        #endregion

        #region Enter read one button

        protected override void EnterReadOnebtnMethod()
        {
            ProductBL productbl = new ProductBL(new DAL.ProductDAL());

            try
            {
                if (currentMode == FormMode.ReadOne)
                {

                    //productbl.Read(int.Parse(ReadOneNumtxt.Text));
                    ReadAlltxt.AppendText(Text = $"{productbl.Read(int.Parse(ReadOneNumtxt.Text))}");
                }
                if (currentMode == FormMode.Delete)
                {

                    productbl.DeleteProduct(new Entities.Product(int.Parse(ReadOneNumtxt.Text), "", 0, 0));
                    MessageBox.Show("Product Deleted");

                }
            }
            catch (ExceptionProductNotExist ex) /// exception handeling
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


    }
}
