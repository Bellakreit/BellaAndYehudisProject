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
        public ProductsForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (CreatePanel.Visible == true)
            {
                CreatePanel.Visible = false;
            }
            else
                CreatePanel.Visible = true;
        }

        private void EnterCreatebtn_Click(object sender, EventArgs e)
        {
            ProductBL productbl = new ProductBL(new DAL.ProductDAL());
            try
            {
                productbl.CreateProduct(new Entities.Product(int.Parse(ProductNumtxt.Text), ProductNametxt.Text, double.Parse(Costtxt.Text), int.Parse(Stocktxt.Text)));
                MessageBox.Show("Product Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CreatePanel.Visible = false;
            ProductNumtxt.Clear();
            ProductNametxt.Clear();
            Costtxt.Clear();
            Stocktxt.Clear();
        }

        private void ReadAllbtn_Click(object sender, EventArgs e)
        {   
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

        private void ExitReadAllbtn_Click(object sender, EventArgs e)
        {
            ReadAlltxt.Clear();
            ReadAllpanel.Visible = false;
            ReadOnePanel.Visible = false;
        }

        private void ReadOnebtn_Click(object sender, EventArgs e)
        {
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

        private void EnterReadOnebtn_Click(object sender, EventArgs e)
        {
            ProductBL productbl = new ProductBL(new DAL.ProductDAL());
            try
            {
                //productbl.Read(int.Parse(ReadOneNumtxt.Text));
                ReadAlltxt.AppendText(Text = $"{productbl.Read(int.Parse(ReadOneNumtxt.Text))}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ReadOnePanel.Visible = false;
            ReadOneNumtxt.Clear();

        }
    }
}
