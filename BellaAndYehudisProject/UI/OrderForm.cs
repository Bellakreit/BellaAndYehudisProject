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
        /// <summary>
        /// create the order and the form
        /// </summary>
        public OrderForm()
        {
            InitializeComponent();
            orderbl = new OrderBL(OrderDAL.Instance);
            ConfigureForm();
        }
        /// <summary>
        /// overide the labels to say the correct things
        /// </summary>
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

        /// <summary>
        /// for create - we dont want the option to put in an order number
        /// </summary>
        protected override void Create_Method()  //when create is clicked make the proper fields visible and named correctly
        {
            lblField1.Visible = false;
            txtField1.Visible = false;
        }
        protected override void UpdateMethod()  //when update is clicked make the proper fields visible and named correctly
        {
            lblField1.Visible = true;
            txtField1.Visible = true;
        }
        protected override void EnterCreatebtnMethod()  //when the enter button for create or update is clicked
        {
            try
            {
                ///if the form is in create mode
                if (currentMode == FormMode.Create)  //create
                {
                    //create the order
                    //orderbl.CreateOrder(new Entities.Order(int.Parse(txtField3.Text), txtField2.Text, int.Parse(txtField4.Text)));
                    orderbl.CreateOrder(int.Parse(txtField3.Text), txtField2.Text, int.Parse(txtField4.Text));
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
                MessageBox.Show("CAUGHT: " + ex.GetType().Name + " | " + ex.Message);
            }
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Read All Button 

        protected override void ReadAllMethod()  //when read all is clicked
        {
            ///read all

            ReadAlltxt.AppendText(Text = " Order Number, Product Number, Customer ID, Order Quantity\r\n\n "); //adding column headers
            foreach (Entities.Order order in orderbl.Read())
            {
                ReadAlltxt.AppendText($"{order.ToString()}" + "\r\n"); //adding each order to the text box
            }
        }

        #endregion

        protected override void ReadOneMethod()  //when read one is clicked make the proper fields visible and named correctly
        {
            SearchBox.Visible = true;
            ShowOnelbl1.Visible = true;
            ShowOnetxt1.Visible = true;
            ShowOnelbl3.Text = "Customer ID";
        }
        protected override void DeleteMethod()  //when delete is clicked make the proper fields visible and named correctly
        {
            SearchBox.Visible = false;
            ShowOnelbl3.Text = "Order Quantity";
        }


        #region Enter read one button
        protected override void EnterReadOnebtnMethod()  //when the enter button for read one or delete is clicked
        {

            try
            {
                if (currentMode == FormMode.ReadOne)  // if read one was clicked 
                {
                    /// read one
                    ReadAlltxt.AppendText(Text = " Order Number, Product Number, Customer ID, Order Quantity\r\n\n "); //adding column headers
                    if (ShowOnetxt2.Text != "" && ShowOnetxt1.Text == "" && ShowOnetxt3.Text == "")  //if only the product is in
                    {
                        ReadAlltxt.AppendText(Text = $"{orderbl.ReadbyProduct(int.Parse(ShowOnetxt2.Text))}");  //use product read method
                    }
                    else if (ShowOnetxt3.Text != "" && ShowOnetxt1.Text == "" && ShowOnetxt2.Text == "")  //if only the customer is in
                    {
                        ReadAlltxt.AppendText(Text = $"{orderbl.ReadbyCustomer(ShowOnetxt3.Text)}");  //use customer read method
                    }
                    else  //if the order is filled in then call read by order number
                    {
                        ReadAlltxt.AppendText(Text = $"{orderbl.Read(int.Parse(ShowOnetxt1.Text))}");
                    }
                }

                if (currentMode == FormMode.Delete)  //if delete was clicked
                {
                    //calling the delete method with the user input
                    orderbl.Delete(new Entities.Order(int.Parse(ShowOnetxt2.Text), "", int.Parse(ShowOnetxt3.Text), int.Parse(ShowOnetxt1.Text)));
                    MessageBox.Show("Order Deleted");

                }
            }
            catch (ExceptionCustomerNotExist ex) /// exception handeling
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException ex)
            {
                ex = new FormatException("Please fill all fields with valid entries");
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion


        
        private void txtField2_TextChanged_1(object sender, EventArgs e)  //mistake autofill 
        {

        }
        

        private void searchByOrderNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #region autofill methods
        protected override void ShowOneTextMethod()   //autofill for the show one text boxes
        {
            if (currentMode == FormMode.ReadOne)   //autofill for read one is different then delete becuase it has different fields
            {
                if (ShowOnetxt1.Text == "")  //if tehre is nothing in first text box then clear the rest
                {
                    ShowOnetxt2.Clear();
                    ShowOnetxt3.Clear();
                }
                else
                {

                    foreach (Entities.Order order in orderbl.Read())  //go through the and find the one that matches id
                    {
                        if (int.Parse(ShowOnetxt1.Text) == order.OrderNumber)  //if they match change the rest of text boxes with the corresponding details
                        {
                            ShowOnetxt2.Text = $"{order.ProductNumber}";
                            ShowOnetxt3.Text = $"{order.CustomerID}";
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

            if (currentMode == FormMode.Delete)   //autofill for read one is different then delete becuase it has different fields
            {
                if (ShowOnetxt1.Text == "")  //if tehre is nothing in first text box then clear the rest
                {
                    ShowOnetxt2.Clear();
                    ShowOnetxt3.Clear();
                }
                else
                {

                    foreach (Entities.Order order in orderbl.Read())  //go through the and find the one that matches id
                    {
                        if (int.Parse(ShowOnetxt1.Text) == order.OrderNumber)  //if they match change the rest of text boxes with the corresponding details
                        {
                            ShowOnetxt2.Text = $"{order.ProductNumber}";
                            ShowOnetxt3.Text = $"{order.OrderQuantity}";
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

        private void txtField1_TextChanged(object sender, EventArgs e)   //autofill for the update text boxes
        {
            if (txtField1.Text == "")  //if tehre is nothing in first text box then clear the rest
            {
                txtField2.Clear();
                txtField3.Clear();
                txtField4.Clear();
            }
            else
            {

                foreach (Entities.Order order in orderbl.Read())  //go through the and find the one that matches id
                {
                    if (int.Parse(txtField1.Text) == order.OrderNumber)  //if they match change the rest of text boxes with the corresponding details
                    {
                        txtField2.Text = order.CustomerID;
                        txtField3.Text = $"{order.ProductNumber}";
                        txtField4.Text = $"{order.OrderQuantity}";
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

        #endregion
    }
}