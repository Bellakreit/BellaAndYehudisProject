using BL;
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
    public partial class ProductsForm1 : Form

    {
        /// <summary>
        /// method to close all panels, this is used to ensure that only one panel is visible at a time. When a user clicks on a button to perform an operation (create, read all, read one, update, delete), the corresponding panel is made visible while the other panels are hidden. This helps to keep the user interface clean and organized, and prevents confusion for the user.
        /// </summary>
        private void CloseAllPanels()
        {
            CreatePanel.Visible = false;
            ReadAllpanel.Visible = false;
            ReadOnePanel.Visible = false;
        }
        /// <summary>
        /// to toggle between the different modes of the form, I created an enum to keep track of the current mode. This way, I can use the same panels and buttons for multiple operations (create, update, delete, read one) without having to create separate panels and buttons for each operation. The enum allows me to easily switch between modes and perform the appropriate actions based on the current mode.
        /// </summary>
        private enum FormMode
        {
            None,
            Create,
            Update,
            Delete,
            ReadOne
        }
        private FormMode currentMode = FormMode.None;

        public ProductsForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// creates a new product when the create button is clicked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Createbtn_Click(object sender, EventArgs e)
        {
            currentMode = FormMode.Create;
            CloseAllPanels();

            if (CreatePanel.Visible == true)
            {
                CreatePanel.Visible = false;
            }
            else
                CreatePanel.Visible = true;
        }

        /// <summary>
        /// this button is used for both creating and updating a product. The current mode is determined by the value of the currentMode variable, which is set when the create or update button is clicked. If the current mode is create, a new product is created using the values entered in the text boxes. If the current mode is update, an existing product is updated with the new values entered in the text boxes. After the operation is performed, the text boxes are cleared and the create panel is hidden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterCreatebtn_Click(object sender, EventArgs e)
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
            CreatePanel.Visible = false;
            ProductNumtxt.Clear();
            ProductNametxt.Clear();
            Costtxt.Clear();
            Stocktxt.Clear();
        }

        /// <summary>
        /// this will read all products from the database and display them in a text box when the read all button is clicked. The method first clears the text box to ensure that only the most up-to-date information is displayed. Then, it checks if the read all panel is currently visible. If it is, the panel is hidden. If it is not, the panel is made visible. Finally, the method retrieves all products from the database using the ProductBL class and appends
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadAllbtn_Click(object sender, EventArgs e)
        {   
            CloseAllPanels();
            ReadAlltxt.Clear();
            if (ReadAllpanel.Visible == true) //making the panel visible
            {
                ReadAllpanel.Visible = false;
            }
            else
            {
                ReadAllpanel.Visible = true;
            }
            ProductBL productbl = new ProductBL(new DAL.ProductDAL());
            ReadAlltxt.AppendText(Text = "Product Number, Product Name, Cost Per Unit, Amount In Stock" + "\r\n"); //adding column headers
            foreach (Entities.Product product in productbl.Read())
            {
                ReadAlltxt.AppendText($"{product.ToString()}" + "\r\n"); //adding each product to the text box
            }
    
        }


        /// <summary>
        /// this will exit out of the read all panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitReadAllbtn_Click(object sender, EventArgs e)
        {
            ReadAlltxt.Clear();
            ReadAllpanel.Visible = false;
            ReadOnePanel.Visible = false;
        }

        /// <summary>
        /// this will read a single product 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadOnebtn_Click(object sender, EventArgs e)
        {
            ReadAlltxt.Clear();
            currentMode = FormMode.ReadOne;
            CloseAllPanels();
            if (ReadAllpanel.Visible == true) //making the panel visible
            {
                ReadAllpanel.Visible = false;
                ReadOnePanel.Visible = false;
            }
            else
            {
                ReadAllpanel.Visible = true;
                ReadOnePanel.Visible = true;
            }
            
            
        }

        /// <summary>
        /// this button is used for both reading a single product and deleting a product. The current mode is determined by the value of the currentMode variable, which is set when the read one or delete button is clicked. If the current mode is read one, a single product is retrieved from the database using the value entered in the text box and displayed in another text box. If the current mode is delete, an existing product is deleted from the database using the value entered in the text box. After the operation is performed, the text box is cleared and the read one panel is hidden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterReadOnebtn_Click(object sender, EventArgs e)
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
            catch (Exception ex) /// exception handeling
            {
                MessageBox.Show(ex.Message);
            }
            ReadOnePanel.Visible = false;
            ReadOneNumtxt.Clear();

        }

        private void CostLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this button updates an exsiscting product.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            currentMode = FormMode.Update;
            CloseAllPanels();
            if (CreatePanel.Visible == true)
            {
                CreatePanel.Visible = false;
            }
            else
                CreatePanel.Visible = true;
        }

        /// <summary>
        /// this button deletes an exsisting product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            ReadAlltxt.Clear();
            currentMode = FormMode.Delete;
            CloseAllPanels();
            if (ReadAllpanel.Visible == true) //making the panel visible
            {
                ReadAllpanel.Visible = false;
                ReadOnePanel.Visible = false;
            }
            else
            {
                ReadAllpanel.Visible = true;
                ReadOnePanel.Visible = true;
            }

        }
    }
}
