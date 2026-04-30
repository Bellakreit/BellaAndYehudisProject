using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CustomerForm : BaseForm
    {
        CustomerBL customerbl;
        public CustomerForm()
        {
            InitializeComponent();
            customerbl = new CustomerBL(CustomerDAL.Instance);
            ConfigureForm();
        }
        protected override void ConfigureForm()
        {
            lblField1.Text = "Customer ID";
            lblField2.Text = "Customer Name";
            lblField3.Text = "Cardholder Name";
            lblField4.Text = "Credit Card Number";
            lblField5.Text = "Exp date";
            lblField6.Text = "CVC";
            ShowOnelbl1.Text = "Customer ID";
        }
        private void newProductsForm_Load(object sender, EventArgs e) { }  //CREATED ACCIDENTLY
        #region Enter Create and update button
        protected override void EnterCreatebtnMethod()
        {

            try
            {
                if (currentMode == FormMode.Create)  //create
                {

                    customerbl.CreateCustomer(new Entities.Customer(txtField2.Text, txtField1.Text, (new Entities.CreditCard(txtField3.Text, txtField4.Text, txtField5.Text, txtField6.Text))));
                    MessageBox.Show("Customer Created");

                }
                if (currentMode == FormMode.Update) ///update
                {
                    customerbl.UpdateCustomer(new Entities.Customer(txtField2.Text, txtField1.Text, new Entities.CreditCard(txtField3.Text, txtField4.Text, txtField5.Text, txtField6.Text)));
                    MessageBox.Show("Customer Updated");

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

            ReadAlltxt.AppendText(Text = "Customer Name, Customer ID, Cardholder Name, Credit Card Number, Exp Date, CVV" + "\r\n"); //adding column headers
            foreach (Entities.Customer customer in customerbl.Read())
            {
                ReadAlltxt.AppendText($"{customer.ToString()}" + "\r\n"); //adding each customer to the text box
            }
        }


        #endregion

        #region Enter read one button

        protected override void EnterReadOnebtnMethod()
        {


            try
            {
                if (currentMode == FormMode.ReadOne)
                {

                    //productbl.Read(int.Parse(ReadOneNumtxt.Text));
                    ReadAlltxt.AppendText(Text = $"{customerbl.Read(ShowOnetxt1.Text)}");
                }

                if (currentMode == FormMode.Delete)
                {

                    customerbl.DeleteCustomer(new Entities.Customer("", ShowOnetxt1.Text, new Entities.CreditCard("", "", "", "")));
                    MessageBox.Show("Customer Deleted");

                }
            }
            catch (ExceptionCustomerNotExist ex) /// exception handeling
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void ReadOneNumtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadAlltxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtField2_TextChanged(object sender, EventArgs e)
        {
 

            
        }

        private void txtField2_TextChanged_1(object sender, EventArgs e)
        {

            
        }

        private void lblField1_Click(object sender, EventArgs e)
        {

        }

        private void txtField1_TextChanged(object sender, EventArgs e) //autofill
        {
            if (txtField1.Text == "")  //if tehre is nothing in first text box then clear the rest
            {
                txtField2.Clear();
                txtField3.Clear();
                txtField4.Clear();
                txtField5.Clear();
                txtField6.Clear();
            }
            else
            {

                foreach (Entities.Customer customer in customerbl.Read())  //go through the products and find the one that matches id
                {
                    if (txtField1.Text == customer.ID)  //if they match change the rest of text boxes with the corresponding details
                    {
                        txtField2.Text = customer.Name;
                        txtField3.Text = customer.creditCard.CCOwner;
                        txtField4.Text = customer.creditCard.CreditCardNumber;
                        txtField5.Text = customer.creditCard.ExpDate;
                        txtField6.Text = customer.creditCard.SecurityCode;
                        break;  //break because you found it
                    }
                    else
                    {
                        txtField2.Clear();
                        txtField3.Clear();
                        txtField4.Clear();
                        txtField5.Clear();
                        txtField6.Clear();
                    }
                }
            }
        }
        protected override void DeleteMethod()  //when delete is clicked make the proper fields visible and named correctly
        {
            SearchBox.Visible = false;
            ShowOnelbl2.Visible = true;
            ShowOnelbl3.Visible = false;
            ShowOnetxt2.Visible = true;
            ShowOnetxt3.Visible = false;
            ShowOnelbl2.Text = "Customer Name";
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
                    
                }
                else
                {

                    foreach (Entities.Customer c in customerbl.Read())  //go through the and find the one that matches id
                    {
                        if (ShowOnetxt1.Text == c.ID)  //if they match change the rest of text boxes with the corresponding details
                        {
                            ShowOnetxt2.Text = $"{c.Name}";
                            
                            break;  //break because you found it
                        }
                        else
                        {
                            ShowOnetxt2.Clear();
                            

                        }
                    }
                }
            }
        }
    }
    }


