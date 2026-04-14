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
            ProductNumtxt.Clear();
            ProductNametxt.Clear();
            Costtxt.Clear();
            Stocktxt.Clear();
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
    }
}
