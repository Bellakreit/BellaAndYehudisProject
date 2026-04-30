using BL;
using DAL;
using Entities;
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
            productbl = new ProductBL(ProductDAL.Instance);
            ConfigureForm();
            //txtField1.TextChanged += txtField1_TextChanged;
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
            ShowOnelbl1.Text = "Product Number:";
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
            //this is used for read and delete

            try
            {
                if (currentMode == FormMode.ReadOne)
                {
                    
                    //productbl.Read(int.Parse(ReadOneNumtxt.Text));
                    ReadAlltxt.AppendText(Text = $"{productbl.Read(int.Parse(ShowOnetxt1.Text))}");
                }
                if (currentMode == FormMode.Delete)
                {
                   
                    productbl.DeleteProduct(new Entities.Product(int.Parse(ShowOnetxt1.Text), "", 0, 0));
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
        /// <summary>
        /// autofill the update / create boxes with the info you give it
        /// </summary>
        protected override void TextChangeMethod()
        {
            if (txtField1.Text == "")  //if tehre is nothing in first text box then clear the rest
            {
                txtField2.Clear();
                txtField3.Clear();
                txtField4.Clear();
            }
            else
            {
                if (!int.TryParse(txtField1.Text, out int id))  //make sure it is a number and make it an int
                    return;
                foreach (Entities.Product product in productbl.Read())  //go through the products and find the one that matches id
                {
                    if (id == product.ProductNumber)  //if they match change the rest of text boxes with the corresponding details
                    {
                        txtField2.Text = product.ProductName;
                        txtField3.Text = $"{product.CostPerUnit}";
                        txtField4.Text = $"{product.AmountInStock}";
                        break;  //break because you found it
                    }
                    else
                    {
                        txtField2.Clear();
                        txtField3.Clear();
                        txtField4.Clear();
                    }
                }

            }
        }

        protected override void DeleteMethod()  //when delete is clicked make the proper fields visible and named correctly
        {
            SearchBox.Visible = false;
            ShowOnelbl2.Visible = true;
            ShowOnelbl3.Visible = true;
            ShowOnetxt2.Visible = true;
            ShowOnetxt3.Visible = true;
            ShowOnelbl2.Text = "Product Name";
            ShowOnelbl3.Text = "Cost Per Unit";
        }
        protected override void ReadOneMethod()
        {
            SearchBox.Visible = false;
            ShowOnelbl2.Visible = false;
            ShowOnelbl3.Visible = false;
            ShowOnetxt2.Visible = false;
            ShowOnetxt3.Visible = false;

        }
        protected override void ShowOneTextMethod()   //autofill for the show one text boxes
        {
       
            if (currentMode == FormMode.Delete)   //autofill for read one is different then delete becuase it has different fields
            {
                if (ShowOnetxt1.Text == "")  //if tehre is nothing in first text box then clear the rest
                {
                    ShowOnetxt2.Clear();
                    ShowOnetxt3.Clear();
                }
                else
                {

                    foreach (Entities.Product p in productbl.Read())  //go through the and find the one that matches id
                    {
                        if (int.Parse(ShowOnetxt1.Text) == p.ProductNumber)  //if they match change the rest of text boxes with the corresponding details
                        {
                            ShowOnetxt2.Text = $"{p.ProductName}";
                            ShowOnetxt3.Text = $"{p.CostPerUnit}";
                            break;  //break because you found it
                        }
                        else
                        {
                            ShowOnetxt2.Clear();
                            ShowOnetxt3.Clear();

                        }
                    }
                }
            }
        }

        //private void txtField1_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtField1.Text == "")  //if tehre is nothing in first text box then clear the rest
        //    {
        //        txtField2.Clear();
        //        txtField3.Clear();
        //        txtField4.Clear();
        //    }
        //    else
        //    {
        //        if (!int.TryParse(txtField1.Text, out int id))  //make sure it is a number and make it an int
        //            return;
        //        foreach (Entities.Product product in productbl.Read())  //go through the products and find the one that matches id
        //        {
        //            if (id == product.ProductNumber)  //if they match change the rest of text boxes with the corresponding details
        //            {
        //                txtField2.Text = product.ProductName;
        //                txtField3.Text = $"{product.CostPerUnit}";
        //                txtField4.Text = $"{product.AmountInStock}";
        //                break;  //break because you found it
        //            }
        //            else
        //            {
        //                txtField2.Clear();
        //                txtField3.Clear();
        //                txtField4.Clear();
        //            }
        //        }

        //    }

        //}

        private void txtField1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}


