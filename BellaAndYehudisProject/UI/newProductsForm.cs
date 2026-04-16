using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class NEWProductsForm : BaseForm
    {
        private ProductBL productbl;
        public NEWProductsForm()
        {
            InitializeComponent();
            productbl = new ProductBL(new DAL.ProductDAL());
            ConfigureForm();
        }
        protected override void ConfigureForm()
        {
            lblField1.Text = "Product Number";
            lblField2.Text = "Product Name";
            lblField3.Text = "Cost Per Unit";
            lblField4.Text = "Amount in Stock";
            lblField5.Visible = false;
            lblField6.Visible = false;
            txtField5.Visible = false;
            txtField6.Visible = false;
            ShowOnelbl.Text = "Product Number:";
        }

        private void newProductsForm_Load(object sender, EventArgs e) { }  //CREATED ACCIDENTLY

        #region Enter Create and update button
        protected override void EnterCreatebtnMethod()
        {

            try
            {
                if (currentMode == FormMode.Create)  //create
                {

                    productbl.CreateProduct(new Entities.Product(int.Parse(txtField1.Text), txtField2.Text, double.Parse(txtField3.Text), int.Parse(txtField4.Text)));
                    MessageBox.Show("Product Created");

                }
                if (currentMode == FormMode.Update) ///update
                {
                    productbl.UpdateProduct(new Entities.Product(int.Parse(txtField1.Text), txtField2.Text, double.Parse(txtField3.Text), int.Parse(txtField4.Text)));
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

            ReadAlltxt.AppendText(Text = "Product Number, Product Name, Cost Per Unit, Amount In Stock" + "\r\n"); //adding column headers
            foreach (Entities.Product product in productbl.Read())
            {
                ReadAlltxt.AppendText($"{product.ToString()}" + "\r\n"); //adding each product to the text box
            }
        }


        #endregion

        #region Enter read one button and delete

        protected override void EnterReadOnebtnMethod()
        {


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

        private void ReadOneNumtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductNumtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadAlltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtField1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtField1.Text, out int id))
                return;

            foreach (Entities.Product product in productbl.Read())
            {
                if (id == product.ProductNumber)
                {
                    txtField2.Text = product.ProductName;
                    txtField3.Text = $"{product.CostPerUnit}";
                    txtField4.Text = $"{product.AmountInStock}";
                }
            }
        }

    }
}


