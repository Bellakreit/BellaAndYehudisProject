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
            lblField5.Text = "Exp Date:";
            lblField6.Text = "CVC:";
            ShowOnelbl.Text = "Customer ID";
        }
        #region Enter Create and update button
        protected override void EnterCreatebtnMethod()
        {
            try
            {
                if (currentMode == FormMode.Create)  //create
                {
                    lblField1.Visible = false;
                    orderbl.CreateOrder(new Entities.Order(int.Parse(txtField3.Text), txtField2.Text, int.Parse(txtField4.Text)));
                    MessageBox.Show("Order Created");

                }
                if (currentMode == FormMode.Update) ///update
                {
                    orderbl.CreateOrder(new Entities.Order(int.Parse(txtField3.Text), txtField2.Text, int.Parse(txtField4.Text), int.Parse(txtField1.Text)));
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

            ReadAlltxt.AppendText(Text = "Product Number, Customer ID, Order Quantity, Order Number"); //adding column headers
            foreach (Entities.Order order in orderbl.Read())
            {
                ReadAlltxt.AppendText($"{order.ToString()}" + "\r\n"); //adding each order to the text box
            }
        }

        #endregion

        #region Enter read one button
        #endregion


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
    }
}