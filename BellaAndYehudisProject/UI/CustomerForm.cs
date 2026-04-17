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
            customerbl = new CustomerBL(new DAL.CustomerDAL());
            ConfigureForm();
        }
        protected override void ConfigureForm()
        {
            lblField1.Text = "Customer Name";
            lblField2.Text = "Customer ID";
            lblField3.Text = "Cardholder Name";
            lblField4.Text = "Credit Card Number";
            lblField5.Text = "Exp Date:";
            lblField6.Text = "CVC:";
            ShowOnelbl.Text = "Customer ID";
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
    }
}

