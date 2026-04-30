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
    public partial class OrderForm : BaseForm
    {
        OrderBL orderbl;
        public OrderForm()
        {
            InitializeComponent();
            orderbl = new OrderBL(OrderDAL.Instance);
            ConfigureForm();
        }
        protected override void ConfigureForm()
        {
            lblField1.Text = "Order Number";
            lblField2.Text = "Customer ID";
            lblField3.Text = "Product Number";
            lblField4.Text = "Order Quantity";
            lblField5.Visible = false;
            txtField5.Visible = false;
            txtField6.Visible = false;
            lblField6.Visible = false;
            ShowOnelbl1.Text = "Order Number";
            ShowOnelbl2.Text = "Product Number";
            ShowOnelbl3.Text = "Customer ID";


        }
        #region Enter Create and update button
        protected override void Create_Method()
        {
            lblField1.Visible = false; 
            txtField1.Visible = false;
        }
        protected override void EnterCreatebtnMethod()
        {
            try
            {
                if (currentMode == FormMode.Create)  //create
                {


                    orderbl.CreateOrder(new Entities.Order(int.Parse(txtField3.Text), txtField2.Text, int.Parse(txtField4.Text)));
                    MessageBox.Show("Order Created");

                }
                if (currentMode == FormMode.Update) ///update
                {

                    orderbl.Update(new Entities.Order(int.Parse(txtField3.Text), txtField2.Text, int.Parse(txtField4.Text), int.Parse(txtField1.Text)));
                    MessageBox.Show("Order Updated");
                }
            }
            catch (Exception ex) ///catch any exceptions that may occur during the create or update process and display an error message to the user.
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Read All Button 

        protected override void ReadAllMethod()
        {

            ReadAlltxt.AppendText(Text = "Order Number, Product Number, Customer ID, Order Quantity\r\n "); //adding column headers
            foreach (Entities.Order order in orderbl.Read())
            {
                ReadAlltxt.AppendText($"{order.ToString()}" + "\r\n"); //adding each order to the text box
            }
        }

        #endregion

        #region Enter read one button
        protected override void ReadOneMethod() { SearchBox.Visible = true; }
        protected override void DeleteMethod() { SearchBox.Visible = false;  ShowOnelbl3.Text = "Order Quantity:"; }
        protected override void EnterReadOnebtnMethod()
        {

            try
            {
                if (currentMode == FormMode.ReadOne)
                {
                    lblField1.Visible = true;
                    lblField1.Text = "Order Number";
                    ReadAlltxt.AppendText(Text = $"{orderbl.ReadbyCustomer(ShowOnetxt1.Text)}");
                }

                if (currentMode == FormMode.Delete)
                {
                    //get new panel to come up
                    orderbl.Delete(new Entities.Order(int.Parse(ShowOnetxt2.Text), "", int.Parse(ShowOnetxt3.Text), int.Parse(ShowOnetxt1.Text)));    
                    MessageBox.Show("Order Deleted");

                }
            }
            catch (ExceptionCustomerNotExist ex) /// exception handeling
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion



        private void txtField2_TextChanged_1(object sender, EventArgs e)  //autofill 
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

                foreach (Entities.Order order in orderbl.Read())  //go through the and find the one that matches id
                {
                    if (int.Parse(txtField1.Text) == order.OrderNumber)  //if they match change the rest of text boxes with the corresponding details
                    {
                        txtField2.Text = order.CustomerID;
                        txtField3.Text = $"{order.ProductNumber}";
                        txtField4.Text = $"{order.OrderNumber}";
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

        private void searchByOrderNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}