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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //on click of products btn to show products form
        {
            CustomerForm cf = new CustomerForm();
            this.Hide();
            cf.ShowDialog();
            this.Show();
        }

        private void Productsbtn_Click(object sender, EventArgs e)   //on click for products btn to show products form
        {
            NEWProductsForm pf = new NEWProductsForm();
            this.Hide();
            pf.ShowDialog();
            this.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)  //order btn to show order form
        {
            OrderForm of = new OrderForm();
            this.Hide();
            of.ShowDialog();
            this.Show();
        }
    }
}
