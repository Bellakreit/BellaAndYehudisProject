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
            lblField1.Text = "Customer Name";
            lblField2.Text = "Customer ID";
            lblField3.Text = "Cardholder Name";
            lblField4.Text = "Credit Card Number";
            lblField5.Visible = false;
            lblField6.Visible = false;
            ShowOnelbl.Text = "Order ID";
        }
        private void newProductsForm_Load(object sender, EventArgs e) { }  //CREATED ACCIDENTLY
        #region Enter Create and update button
        protected override void EnterCreatebtnMethod()
        {

            try
            {
                if (currentMode == FormMode.Create)  //create
                {

                    customerbl.CreateCustomer(new Entities.Customer(txtField1.Text, txtField2.Text, (new Entities.CreditCard(txtField3.Text, txtField4.Text, txtField5.Text, txtField6.Text))));
                    MessageBox.Show("Customer Created");

                }
                if (currentMode == FormMode.Update) ///update
                {
                    customerbl.UpdateCustomer(new Entities.Customer(txtField1.Text, txtField2.Text, new Entities.CreditCard(txtField3.Text, txtField4.Text, txtField5.Text, txtField6.Text)));
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
                    ReadAlltxt.AppendText(Text = $"{customerbl.Read(ReadOneNumtxt.Text)}");
                }

                if (currentMode == FormMode.Delete)
                {

                    customerbl.DeleteCustomer(new Entities.Customer("", ReadOneNumtxt.Text, new Entities.CreditCard("", "", "", "")));
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
            if (txtField2.Text == "")  //if tehre is nothing in first text box then clear the rest
            {
                txtField1.Clear();
                txtField3.Clear();
                txtField4.Clear();
                txtField5.Clear();
                txtField6.Clear();
            }
            else
            {

                foreach (Entities.Customer customer in customerbl.Read())  //go through the products and find the one that matches id
                {
                    if (txtField2.Text == customer.ID)  //if they match change the rest of text boxes with the corresponding details
                    {
                        txtField1.Text = customer.Name;
                        txtField3.Text = customer.creditCard.CCOwner;
                        txtField4.Text = customer.creditCard.CreditCardNumber;
                        txtField5.Text = customer.creditCard.ExpDate;
                        txtField6.Text = customer.creditCard.SecurityCode;
                        break;  //break because you found it
                    }
                    else
                    {
                        txtField1.Clear();
                        txtField3.Clear();
                        txtField4.Clear();
                        txtField5.Clear();
                        txtField6.Clear();
                    }
                }
            }
        }
    }
}

