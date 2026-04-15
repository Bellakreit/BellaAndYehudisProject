namespace UI
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreatePanel = new System.Windows.Forms.Panel();
            this.txtField6 = new System.Windows.Forms.TextBox();
            this.txtField5 = new System.Windows.Forms.TextBox();
            this.lblField6 = new System.Windows.Forms.Label();
            this.lblField5 = new System.Windows.Forms.Label();
            this.EnterCreatebtn = new System.Windows.Forms.Button();
            this.txtField4 = new System.Windows.Forms.TextBox();
            this.lblField4 = new System.Windows.Forms.Label();
            this.txtField3 = new System.Windows.Forms.TextBox();
            this.lblField3 = new System.Windows.Forms.Label();
            this.txtField2 = new System.Windows.Forms.TextBox();
            this.lblField2 = new System.Windows.Forms.Label();
            this.lblField1 = new System.Windows.Forms.Label();
            this.txtField1 = new System.Windows.Forms.TextBox();
            this.ReadAllpanel = new System.Windows.Forms.Panel();
            this.ReadOnePanel = new System.Windows.Forms.Panel();
            this.EnterReadOnebtn = new System.Windows.Forms.Button();
            this.ReadOneNumtxt = new System.Windows.Forms.TextBox();
            this.ShowOnelbl = new System.Windows.Forms.Label();
            this.ExitReadAllbtn = new System.Windows.Forms.Button();
            this.ReadAlltxt = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.ReadOnebtn = new System.Windows.Forms.Button();
            this.ReadAllbtn = new System.Windows.Forms.Button();
            this.Createbtn = new System.Windows.Forms.Button();
            this.CreatePanel.SuspendLayout();
            this.ReadAllpanel.SuspendLayout();
            this.ReadOnePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatePanel
            // 
            this.CreatePanel.Controls.Add(this.txtField6);
            this.CreatePanel.Controls.Add(this.txtField5);
            this.CreatePanel.Controls.Add(this.lblField6);
            this.CreatePanel.Controls.Add(this.lblField5);
            this.CreatePanel.Controls.Add(this.EnterCreatebtn);
            this.CreatePanel.Controls.Add(this.txtField4);
            this.CreatePanel.Controls.Add(this.lblField4);
            this.CreatePanel.Controls.Add(this.txtField3);
            this.CreatePanel.Controls.Add(this.lblField3);
            this.CreatePanel.Controls.Add(this.txtField2);
            this.CreatePanel.Controls.Add(this.lblField2);
            this.CreatePanel.Controls.Add(this.lblField1);
            this.CreatePanel.Controls.Add(this.txtField1);
            this.CreatePanel.Location = new System.Drawing.Point(0, 0);
            this.CreatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(725, 416);
            this.CreatePanel.TabIndex = 11;
            this.CreatePanel.Visible = false;
            this.CreatePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CreatePanel_Paint);
            // 
            // txtField6
            // 
            this.txtField6.Location = new System.Drawing.Point(336, 159);
            this.txtField6.Margin = new System.Windows.Forms.Padding(2);
            this.txtField6.Name = "txtField6";
            this.txtField6.Size = new System.Drawing.Size(90, 22);
            this.txtField6.TabIndex = 12;
            this.txtField6.TextChanged += new System.EventHandler(this.txtField6_TextChanged);
            // 
            // txtField5
            // 
            this.txtField5.Location = new System.Drawing.Point(161, 159);
            this.txtField5.Margin = new System.Windows.Forms.Padding(2);
            this.txtField5.Name = "txtField5";
            this.txtField5.Size = new System.Drawing.Size(96, 22);
            this.txtField5.TabIndex = 11;
            this.txtField5.TextChanged += new System.EventHandler(this.txtField5_TextChanged);
            // 
            // lblField6
            // 
            this.lblField6.AutoSize = true;
            this.lblField6.Location = new System.Drawing.Point(295, 165);
            this.lblField6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField6.Name = "lblField6";
            this.lblField6.Size = new System.Drawing.Size(37, 16);
            this.lblField6.TabIndex = 10;
            this.lblField6.Text = "CVC:";
            this.lblField6.Click += new System.EventHandler(this.lblField6_Click);
            // 
            // lblField5
            // 
            this.lblField5.AutoSize = true;
            this.lblField5.Location = new System.Drawing.Point(92, 162);
            this.lblField5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField5.Name = "lblField5";
            this.lblField5.Size = new System.Drawing.Size(65, 16);
            this.lblField5.TabIndex = 9;
            this.lblField5.Text = "Exp Date:";
            this.lblField5.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnterCreatebtn
            // 
            this.EnterCreatebtn.Location = new System.Drawing.Point(189, 234);
            this.EnterCreatebtn.Margin = new System.Windows.Forms.Padding(2);
            this.EnterCreatebtn.Name = "EnterCreatebtn";
            this.EnterCreatebtn.Size = new System.Drawing.Size(114, 34);
            this.EnterCreatebtn.TabIndex = 8;
            this.EnterCreatebtn.Text = "Enter";
            this.EnterCreatebtn.UseVisualStyleBackColor = true;
            this.EnterCreatebtn.Click += new System.EventHandler(this.EnterCreatebtn_Click);
            // 
            // txtField4
            // 
            this.txtField4.Location = new System.Drawing.Point(189, 119);
            this.txtField4.Margin = new System.Windows.Forms.Padding(2);
            this.txtField4.Name = "txtField4";
            this.txtField4.Size = new System.Drawing.Size(280, 22);
            this.txtField4.TabIndex = 7;
            this.txtField4.TextChanged += new System.EventHandler(this.txtField4_TextChanged);
            // 
            // lblField4
            // 
            this.lblField4.AutoSize = true;
            this.lblField4.Location = new System.Drawing.Point(22, 123);
            this.lblField4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField4.Name = "lblField4";
            this.lblField4.Size = new System.Drawing.Size(111, 16);
            this.lblField4.TabIndex = 6;
            this.lblField4.Text = "Number in Stock: ";
            this.lblField4.Click += new System.EventHandler(this.lblField4_Click);
            // 
            // txtField3
            // 
            this.txtField3.Location = new System.Drawing.Point(189, 88);
            this.txtField3.Margin = new System.Windows.Forms.Padding(2);
            this.txtField3.Name = "txtField3";
            this.txtField3.Size = new System.Drawing.Size(280, 22);
            this.txtField3.TabIndex = 5;
            this.txtField3.TextChanged += new System.EventHandler(this.txtField3_TextChanged);
            // 
            // lblField3
            // 
            this.lblField3.AutoSize = true;
            this.lblField3.Location = new System.Drawing.Point(22, 92);
            this.lblField3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField3.Name = "lblField3";
            this.lblField3.Size = new System.Drawing.Size(86, 16);
            this.lblField3.TabIndex = 4;
            this.lblField3.Text = "Cost per unit: ";
            // 
            // txtField2
            // 
            this.txtField2.Location = new System.Drawing.Point(189, 55);
            this.txtField2.Margin = new System.Windows.Forms.Padding(2);
            this.txtField2.Name = "txtField2";
            this.txtField2.Size = new System.Drawing.Size(280, 22);
            this.txtField2.TabIndex = 3;
            this.txtField2.TextChanged += new System.EventHandler(this.txtField2_TextChanged);
            // 
            // lblField2
            // 
            this.lblField2.AutoSize = true;
            this.lblField2.Location = new System.Drawing.Point(22, 61);
            this.lblField2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(99, 16);
            this.lblField2.TabIndex = 2;
            this.lblField2.Text = "Product Name: ";
            // 
            // lblField1
            // 
            this.lblField1.AutoSize = true;
            this.lblField1.Location = new System.Drawing.Point(22, 30);
            this.lblField1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(110, 16);
            this.lblField1.TabIndex = 1;
            this.lblField1.Text = "Product Number: ";
            this.lblField1.Click += new System.EventHandler(this.ProductNumlabel_Click);
            // 
            // txtField1
            // 
            this.txtField1.Location = new System.Drawing.Point(189, 24);
            this.txtField1.Margin = new System.Windows.Forms.Padding(2);
            this.txtField1.Name = "txtField1";
            this.txtField1.Size = new System.Drawing.Size(280, 22);
            this.txtField1.TabIndex = 0;
            this.txtField1.TextChanged += new System.EventHandler(this.txtField1_TextChanged);
            // 
            // ReadAllpanel
            // 
            this.ReadAllpanel.Controls.Add(this.ReadOnePanel);
            this.ReadAllpanel.Controls.Add(this.ExitReadAllbtn);
            this.ReadAllpanel.Controls.Add(this.ReadAlltxt);
            this.ReadAllpanel.Location = new System.Drawing.Point(-3, 7);
            this.ReadAllpanel.Margin = new System.Windows.Forms.Padding(2);
            this.ReadAllpanel.Name = "ReadAllpanel";
            this.ReadAllpanel.Size = new System.Drawing.Size(990, 524);
            this.ReadAllpanel.TabIndex = 12;
            this.ReadAllpanel.Visible = false;
            this.ReadAllpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ReadAllpanel_Paint);
            // 
            // ReadOnePanel
            // 
            this.ReadOnePanel.Controls.Add(this.EnterReadOnebtn);
            this.ReadOnePanel.Controls.Add(this.ReadOneNumtxt);
            this.ReadOnePanel.Controls.Add(this.ShowOnelbl);
            this.ReadOnePanel.Location = new System.Drawing.Point(15, 8);
            this.ReadOnePanel.Margin = new System.Windows.Forms.Padding(2);
            this.ReadOnePanel.Name = "ReadOnePanel";
            this.ReadOnePanel.Size = new System.Drawing.Size(544, 36);
            this.ReadOnePanel.TabIndex = 4;
            this.ReadOnePanel.Visible = false;
            // 
            // EnterReadOnebtn
            // 
            this.EnterReadOnebtn.Location = new System.Drawing.Point(348, 3);
            this.EnterReadOnebtn.Margin = new System.Windows.Forms.Padding(2);
            this.EnterReadOnebtn.Name = "EnterReadOnebtn";
            this.EnterReadOnebtn.Size = new System.Drawing.Size(117, 27);
            this.EnterReadOnebtn.TabIndex = 4;
            this.EnterReadOnebtn.Text = "Enter";
            this.EnterReadOnebtn.UseVisualStyleBackColor = true;
            this.EnterReadOnebtn.Click += new System.EventHandler(this.EnterReadOnebtn_Click);
            // 
            // ReadOneNumtxt
            // 
            this.ReadOneNumtxt.Location = new System.Drawing.Point(130, 7);
            this.ReadOneNumtxt.Margin = new System.Windows.Forms.Padding(2);
            this.ReadOneNumtxt.Name = "ReadOneNumtxt";
            this.ReadOneNumtxt.Size = new System.Drawing.Size(201, 22);
            this.ReadOneNumtxt.TabIndex = 3;
            // 
            // ShowOnelbl
            // 
            this.ShowOnelbl.AutoSize = true;
            this.ShowOnelbl.Location = new System.Drawing.Point(7, 9);
            this.ShowOnelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowOnelbl.Name = "ShowOnelbl";
            this.ShowOnelbl.Size = new System.Drawing.Size(110, 16);
            this.ShowOnelbl.TabIndex = 2;
            this.ShowOnelbl.Text = "Product Number: ";
            // 
            // ExitReadAllbtn
            // 
            this.ExitReadAllbtn.Location = new System.Drawing.Point(736, 293);
            this.ExitReadAllbtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitReadAllbtn.Name = "ExitReadAllbtn";
            this.ExitReadAllbtn.Size = new System.Drawing.Size(120, 26);
            this.ExitReadAllbtn.TabIndex = 1;
            this.ExitReadAllbtn.Text = "Exit";
            this.ExitReadAllbtn.UseVisualStyleBackColor = true;
            this.ExitReadAllbtn.Click += new System.EventHandler(this.ExitReadAllbtn_Click);
            // 
            // ReadAlltxt
            // 
            this.ReadAlltxt.Location = new System.Drawing.Point(15, 47);
            this.ReadAlltxt.Margin = new System.Windows.Forms.Padding(2);
            this.ReadAlltxt.Multiline = true;
            this.ReadAlltxt.Name = "ReadAlltxt";
            this.ReadAlltxt.Size = new System.Drawing.Size(895, 302);
            this.ReadAlltxt.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MainPanel.Controls.Add(this.Deletebtn);
            this.MainPanel.Controls.Add(this.Updatebtn);
            this.MainPanel.Controls.Add(this.ReadOnebtn);
            this.MainPanel.Controls.Add(this.ReadAllbtn);
            this.MainPanel.Controls.Add(this.Createbtn);
            this.MainPanel.Location = new System.Drawing.Point(1011, 84);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(173, 328);
            this.MainPanel.TabIndex = 10;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(21, 216);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(121, 35);
            this.Deletebtn.TabIndex = 4;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(21, 168);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(122, 35);
            this.Updatebtn.TabIndex = 3;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // ReadOnebtn
            // 
            this.ReadOnebtn.Location = new System.Drawing.Point(21, 120);
            this.ReadOnebtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadOnebtn.Name = "ReadOnebtn";
            this.ReadOnebtn.Size = new System.Drawing.Size(121, 37);
            this.ReadOnebtn.TabIndex = 2;
            this.ReadOnebtn.Text = "Show One";
            this.ReadOnebtn.UseVisualStyleBackColor = true;
            this.ReadOnebtn.Click += new System.EventHandler(this.ReadOnebtn_Click);
            // 
            // ReadAllbtn
            // 
            this.ReadAllbtn.Location = new System.Drawing.Point(21, 68);
            this.ReadAllbtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadAllbtn.Name = "ReadAllbtn";
            this.ReadAllbtn.Size = new System.Drawing.Size(121, 36);
            this.ReadAllbtn.TabIndex = 1;
            this.ReadAllbtn.Text = "Show All";
            this.ReadAllbtn.UseVisualStyleBackColor = true;
            this.ReadAllbtn.Click += new System.EventHandler(this.ReadAllbtn_Click);
            // 
            // Createbtn
            // 
            this.Createbtn.Location = new System.Drawing.Point(21, 20);
            this.Createbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(121, 34);
            this.Createbtn.TabIndex = 0;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 577);
            this.Controls.Add(this.CreatePanel);
            this.Controls.Add(this.ReadAllpanel);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.CreatePanel.ResumeLayout(false);
            this.CreatePanel.PerformLayout();
            this.ReadAllpanel.ResumeLayout(false);
            this.ReadAllpanel.PerformLayout();
            this.ReadOnePanel.ResumeLayout(false);
            this.ReadOnePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CreatePanel;
        private System.Windows.Forms.Button EnterCreatebtn;
        private System.Windows.Forms.Panel ReadAllpanel;
        private System.Windows.Forms.Panel ReadOnePanel;
        private System.Windows.Forms.Button EnterReadOnebtn;
        private System.Windows.Forms.Button ExitReadAllbtn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button ReadOnebtn;
        private System.Windows.Forms.Button ReadAllbtn;
        private System.Windows.Forms.Button Createbtn;
        protected System.Windows.Forms.TextBox txtField4;
        protected System.Windows.Forms.TextBox txtField3;
        protected System.Windows.Forms.TextBox txtField2;
        protected System.Windows.Forms.TextBox txtField1;
        protected System.Windows.Forms.TextBox ReadOneNumtxt;
        protected System.Windows.Forms.TextBox ReadAlltxt;
        protected System.Windows.Forms.Label lblField1;
        protected System.Windows.Forms.Label lblField4;
        protected System.Windows.Forms.Label lblField3;
        protected System.Windows.Forms.Label lblField2;
        protected System.Windows.Forms.Label lblField6;
        protected System.Windows.Forms.Label lblField5;
        protected System.Windows.Forms.TextBox txtField6;
        protected System.Windows.Forms.TextBox txtField5;
        protected System.Windows.Forms.Label ShowOnelbl;
    }
}