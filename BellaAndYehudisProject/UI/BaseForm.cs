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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            
        }
        protected virtual void ConfigureForm()
        {
            lblField1.Text = "Field 1";
            lblField2.Text = "Field 2";
            lblField3.Text = "Field 3";
            lblField4.Text = "Field 4";
            lblField5.Text = "Field 5";
            lblField6.Text = "Field 6";
            ShowOnelbl.Text = "Show One";
        }
        private void CloseAllPanels()
        {
            CreatePanel.Visible = false;
            ReadAllpanel.Visible = false;
            ReadOnePanel.Visible = false;
        }
        protected enum FormMode
        {
            None,
            Create,
            Update,
            Delete,
            ReadOne
        }
        protected FormMode currentMode = FormMode.None;

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
            //Create_Method();

        }

        //method to take care of adding new customer/product
        //protected virtual void Create_Method() { }
        

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
            ReadAllMethod();
        }
        protected virtual void ReadAllMethod() { }

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
            //ReadOneMethod();
        }
        //protected virtual void ReadOneMethod() { }

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
            UpdateMethod();
        }
        protected virtual void UpdateMethod() { }

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
            DeleteMethod();
        }
        protected virtual void DeleteMethod() { }

        private void EnterCreatebtn_Click(object sender, EventArgs e)
        {
            EnterCreatebtnMethod();
            CreatePanel.Visible = false;
            txtField1.Clear();
            txtField2.Clear();
            txtField3.Clear();
            txtField4.Clear();
            txtField5.Clear();
            txtField6.Clear();
        }
        protected virtual void EnterCreatebtnMethod() { }

        private void ExitReadAllbtn_Click(object sender, EventArgs e)
        {
            ReadAlltxt.Clear();
            ReadAllpanel.Visible = false;
            ReadOnePanel.Visible = false;
            ExitReadAllbtnMethod();
        }
        protected virtual void ExitReadAllbtnMethod() { }

        private void EnterReadOnebtn_Click(object sender, EventArgs e)
        {
            EnterReadOnebtnMethod();
            ReadOnePanel.Visible = false;
            ReadOneNumtxt.Clear();
        }
        protected virtual void EnterReadOnebtnMethod() { }

        private void ProductNumlabel_Click(object sender, EventArgs e) { }

        private void CreatePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReadAllpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtField1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblField4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtField2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtField3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtField4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtField5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblField6_Click(object sender, EventArgs e)
        {

        }

        private void txtField6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitToMainMenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
