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
            this.ReadAllpanel = new System.Windows.Forms.Panel();
            this.ReadOnePanel = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ShowOnetxt3 = new System.Windows.Forms.TextBox();
            this.ShowOnelbl3 = new System.Windows.Forms.Label();
            this.ShowOnetxt2 = new System.Windows.Forms.TextBox();
            this.ShowOnelbl2 = new System.Windows.Forms.Label();
            this.ShowOnetxt1 = new System.Windows.Forms.TextBox();
            this.ShowOnelbl1 = new System.Windows.Forms.Label();
            this.EnterReadOnebtn = new System.Windows.Forms.Button();
            this.ExitReadAllbtn = new System.Windows.Forms.Button();
            this.ReadAlltxt = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ExitToMainMenubtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.ReadOnebtn = new System.Windows.Forms.Button();
            this.ReadAllbtn = new System.Windows.Forms.Button();
            this.Createbtn = new System.Windows.Forms.Button();
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
            this.ReadAllpanel.SuspendLayout();
            this.ReadOnePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.CreatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadAllpanel
            // 
            this.ReadAllpanel.AutoScroll = true;
            this.ReadAllpanel.Controls.Add(this.ReadOnePanel);
            this.ReadAllpanel.Controls.Add(this.ExitReadAllbtn);
            this.ReadAllpanel.Controls.Add(this.ReadAlltxt);
            this.ReadAllpanel.Font = new System.Drawing.Font("Candara Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadAllpanel.Location = new System.Drawing.Point(-3, 7);
            this.ReadAllpanel.Margin = new System.Windows.Forms.Padding(2);
            this.ReadAllpanel.Name = "ReadAllpanel";
            this.ReadAllpanel.Size = new System.Drawing.Size(1114, 601);
            this.ReadAllpanel.TabIndex = 12;
            this.ReadAllpanel.Visible = false;
            this.ReadAllpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ReadAllpanel_Paint);
            // 
            // ReadOnePanel
            // 
            this.ReadOnePanel.AutoScroll = true;
            this.ReadOnePanel.Controls.Add(this.SearchBox);
            this.ReadOnePanel.Controls.Add(this.ShowOnetxt3);
            this.ReadOnePanel.Controls.Add(this.ShowOnelbl3);
            this.ReadOnePanel.Controls.Add(this.ShowOnetxt2);
            this.ReadOnePanel.Controls.Add(this.ShowOnelbl2);
            this.ReadOnePanel.Controls.Add(this.ShowOnetxt1);
            this.ReadOnePanel.Controls.Add(this.ShowOnelbl1);
            this.ReadOnePanel.Controls.Add(this.EnterReadOnebtn);
            this.ReadOnePanel.Location = new System.Drawing.Point(43, 38);
            this.ReadOnePanel.Margin = new System.Windows.Forms.Padding(2);
            this.ReadOnePanel.Name = "ReadOnePanel";
            this.ReadOnePanel.Size = new System.Drawing.Size(929, 410);
            this.ReadOnePanel.TabIndex = 4;
            this.ReadOnePanel.Visible = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(196, 16);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(493, 40);
            this.SearchBox.TabIndex = 9;
            this.SearchBox.Text = "Choose a method to search by:";
            this.SearchBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ShowOnetxt3
            // 
            this.ShowOnetxt3.Location = new System.Drawing.Point(262, 207);
            this.ShowOnetxt3.Margin = new System.Windows.Forms.Padding(2);
            this.ShowOnetxt3.Name = "ShowOnetxt3";
            this.ShowOnetxt3.Size = new System.Drawing.Size(201, 40);
            this.ShowOnetxt3.TabIndex = 8;
            // 
            // ShowOnelbl3
            // 
            this.ShowOnelbl3.AutoSize = true;
            this.ShowOnelbl3.Location = new System.Drawing.Point(5, 201);
            this.ShowOnelbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowOnelbl3.Name = "ShowOnelbl3";
            this.ShowOnelbl3.Size = new System.Drawing.Size(223, 35);
            this.ShowOnelbl3.TabIndex = 7;
            this.ShowOnelbl3.Text = "Product Number: ";
            // 
            // ShowOnetxt2
            // 
            this.ShowOnetxt2.Location = new System.Drawing.Point(262, 152);
            this.ShowOnetxt2.Margin = new System.Windows.Forms.Padding(2);
            this.ShowOnetxt2.Name = "ShowOnetxt2";
            this.ShowOnetxt2.Size = new System.Drawing.Size(201, 40);
            this.ShowOnetxt2.TabIndex = 6;
            // 
            // ShowOnelbl2
            // 
            this.ShowOnelbl2.AutoSize = true;
            this.ShowOnelbl2.Location = new System.Drawing.Point(5, 152);
            this.ShowOnelbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowOnelbl2.Name = "ShowOnelbl2";
            this.ShowOnelbl2.Size = new System.Drawing.Size(223, 35);
            this.ShowOnelbl2.TabIndex = 5;
            this.ShowOnelbl2.Text = "Product Number: ";
            // 
            // ShowOnetxt1
            // 
            this.ShowOnetxt1.Location = new System.Drawing.Point(259, 91);
            this.ShowOnetxt1.Margin = new System.Windows.Forms.Padding(2);
            this.ShowOnetxt1.Name = "ShowOnetxt1";
            this.ShowOnetxt1.Size = new System.Drawing.Size(201, 40);
            this.ShowOnetxt1.TabIndex = 3;
            this.ShowOnetxt1.TextChanged += new System.EventHandler(this.ShowOnetxt1_TextChanged);
            // 
            // ShowOnelbl1
            // 
            this.ShowOnelbl1.AutoSize = true;
            this.ShowOnelbl1.Location = new System.Drawing.Point(2, 100);
            this.ShowOnelbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowOnelbl1.Name = "ShowOnelbl1";
            this.ShowOnelbl1.Size = new System.Drawing.Size(223, 35);
            this.ShowOnelbl1.TabIndex = 2;
            this.ShowOnelbl1.Text = "Product Number: ";
            // 
            // EnterReadOnebtn
            // 
            this.EnterReadOnebtn.Location = new System.Drawing.Point(153, 278);
            this.EnterReadOnebtn.Margin = new System.Windows.Forms.Padding(2);
            this.EnterReadOnebtn.Name = "EnterReadOnebtn";
            this.EnterReadOnebtn.Size = new System.Drawing.Size(117, 45);
            this.EnterReadOnebtn.TabIndex = 4;
            this.EnterReadOnebtn.Text = "Enter";
            this.EnterReadOnebtn.UseVisualStyleBackColor = true;
            this.EnterReadOnebtn.Click += new System.EventHandler(this.EnterReadOnebtn_Click);
            // 
            // ExitReadAllbtn
            // 
            this.ExitReadAllbtn.Location = new System.Drawing.Point(924, 518);
            this.ExitReadAllbtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitReadAllbtn.Name = "ExitReadAllbtn";
            this.ExitReadAllbtn.Size = new System.Drawing.Size(120, 41);
            this.ExitReadAllbtn.TabIndex = 1;
            this.ExitReadAllbtn.Text = "Clear";
            this.ExitReadAllbtn.UseVisualStyleBackColor = true;
            this.ExitReadAllbtn.Click += new System.EventHandler(this.ExitReadAllbtn_Click);
            // 
            // ReadAlltxt
            // 
            this.ReadAlltxt.BackColor = System.Drawing.SystemColors.Menu;
            this.ReadAlltxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReadAlltxt.Location = new System.Drawing.Point(2, 49);
            this.ReadAlltxt.Margin = new System.Windows.Forms.Padding(2);
            this.ReadAlltxt.Multiline = true;
            this.ReadAlltxt.Name = "ReadAlltxt";
            this.ReadAlltxt.Size = new System.Drawing.Size(895, 302);
            this.ReadAlltxt.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ExitToMainMenubtn);
            this.MainPanel.Controls.Add(this.Deletebtn);
            this.MainPanel.Controls.Add(this.Updatebtn);
            this.MainPanel.Controls.Add(this.ReadOnebtn);
            this.MainPanel.Controls.Add(this.ReadAllbtn);
            this.MainPanel.Controls.Add(this.Createbtn);
            this.MainPanel.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPanel.Location = new System.Drawing.Point(1188, 92);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(173, 366);
            this.MainPanel.TabIndex = 10;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // ExitToMainMenubtn
            // 
            this.ExitToMainMenubtn.Location = new System.Drawing.Point(27, 278);
            this.ExitToMainMenubtn.Name = "ExitToMainMenubtn";
            this.ExitToMainMenubtn.Size = new System.Drawing.Size(116, 59);
            this.ExitToMainMenubtn.TabIndex = 13;
            this.ExitToMainMenubtn.Text = "Back to Main Menu";
            this.ExitToMainMenubtn.UseVisualStyleBackColor = true;
            this.ExitToMainMenubtn.Click += new System.EventHandler(this.ExitToMainMenubtn_Click);
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
            // CreatePanel
            // 
            this.CreatePanel.AutoSize = true;
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
            this.CreatePanel.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePanel.Location = new System.Drawing.Point(0, 0);
            this.CreatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(909, 414);
            this.CreatePanel.TabIndex = 11;
            this.CreatePanel.Visible = false;
            this.CreatePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CreatePanel_Paint);
            // 
            // txtField6
            // 
            this.txtField6.Location = new System.Drawing.Point(344, 246);
            this.txtField6.Margin = new System.Windows.Forms.Padding(2);
            this.txtField6.Name = "txtField6";
            this.txtField6.Size = new System.Drawing.Size(90, 36);
            this.txtField6.TabIndex = 12;
            this.txtField6.TextChanged += new System.EventHandler(this.txtField6_TextChanged);
            // 
            // txtField5
            // 
            this.txtField5.Location = new System.Drawing.Point(169, 246);
            this.txtField5.Margin = new System.Windows.Forms.Padding(2);
            this.txtField5.Name = "txtField5";
            this.txtField5.Size = new System.Drawing.Size(96, 36);
            this.txtField5.TabIndex = 11;
            this.txtField5.TextChanged += new System.EventHandler(this.txtField5_TextChanged);
            // 
            // lblField6
            // 
            this.lblField6.AutoSize = true;
            this.lblField6.Location = new System.Drawing.Point(285, 254);
            this.lblField6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField6.Name = "lblField6";
            this.lblField6.Size = new System.Drawing.Size(56, 28);
            this.lblField6.TabIndex = 10;
            this.lblField6.Text = "CVC:";
            this.lblField6.Click += new System.EventHandler(this.lblField6_Click);
            // 
            // lblField5
            // 
            this.lblField5.AutoSize = true;
            this.lblField5.Location = new System.Drawing.Point(64, 249);
            this.lblField5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField5.Name = "lblField5";
            this.lblField5.Size = new System.Drawing.Size(105, 28);
            this.lblField5.TabIndex = 9;
            this.lblField5.Text = "Exp Date:";
            this.lblField5.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnterCreatebtn
            // 
            this.EnterCreatebtn.Location = new System.Drawing.Point(197, 321);
            this.EnterCreatebtn.Margin = new System.Windows.Forms.Padding(2);
            this.EnterCreatebtn.Name = "EnterCreatebtn";
            this.EnterCreatebtn.Size = new System.Drawing.Size(114, 46);
            this.EnterCreatebtn.TabIndex = 8;
            this.EnterCreatebtn.Text = "Enter";
            this.EnterCreatebtn.UseVisualStyleBackColor = true;
            this.EnterCreatebtn.Click += new System.EventHandler(this.EnterCreatebtn_Click);
            // 
            // txtField4
            // 
            this.txtField4.Location = new System.Drawing.Point(296, 194);
            this.txtField4.Margin = new System.Windows.Forms.Padding(2);
            this.txtField4.Name = "txtField4";
            this.txtField4.Size = new System.Drawing.Size(280, 36);
            this.txtField4.TabIndex = 7;
            this.txtField4.TextChanged += new System.EventHandler(this.txtField4_TextChanged);
            // 
            // lblField4
            // 
            this.lblField4.AutoSize = true;
            this.lblField4.Location = new System.Drawing.Point(11, 196);
            this.lblField4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField4.Name = "lblField4";
            this.lblField4.Size = new System.Drawing.Size(181, 28);
            this.lblField4.TabIndex = 6;
            this.lblField4.Text = "Number in Stock: ";
            this.lblField4.Click += new System.EventHandler(this.lblField4_Click);
            // 
            // txtField3
            // 
            this.txtField3.Location = new System.Drawing.Point(297, 151);
            this.txtField3.Margin = new System.Windows.Forms.Padding(2);
            this.txtField3.Name = "txtField3";
            this.txtField3.Size = new System.Drawing.Size(280, 36);
            this.txtField3.TabIndex = 5;
            this.txtField3.TextChanged += new System.EventHandler(this.txtField3_TextChanged);
            // 
            // lblField3
            // 
            this.lblField3.AutoSize = true;
            this.lblField3.Location = new System.Drawing.Point(11, 149);
            this.lblField3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField3.Name = "lblField3";
            this.lblField3.Size = new System.Drawing.Size(145, 28);
            this.lblField3.TabIndex = 4;
            this.lblField3.Text = "Cost per unit: ";
            // 
            // txtField2
            // 
            this.txtField2.Location = new System.Drawing.Point(297, 103);
            this.txtField2.Margin = new System.Windows.Forms.Padding(2);
            this.txtField2.Name = "txtField2";
            this.txtField2.Size = new System.Drawing.Size(280, 36);
            this.txtField2.TabIndex = 3;
            this.txtField2.TextChanged += new System.EventHandler(this.txtField2_TextChanged);
            // 
            // lblField2
            // 
            this.lblField2.AutoSize = true;
            this.lblField2.Location = new System.Drawing.Point(11, 103);
            this.lblField2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(162, 28);
            this.lblField2.TabIndex = 2;
            this.lblField2.Text = "Product Name: ";
            // 
            // lblField1
            // 
            this.lblField1.AutoSize = true;
            this.lblField1.Location = new System.Drawing.Point(10, 54);
            this.lblField1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(183, 28);
            this.lblField1.TabIndex = 1;
            this.lblField1.Text = "Product Number: ";
            this.lblField1.Click += new System.EventHandler(this.ProductNumlabel_Click);
            // 
            // txtField1
            // 
            this.txtField1.Location = new System.Drawing.Point(296, 54);
            this.txtField1.Margin = new System.Windows.Forms.Padding(2);
            this.txtField1.Name = "txtField1";
            this.txtField1.Size = new System.Drawing.Size(280, 36);
            this.txtField1.TabIndex = 0;
            this.txtField1.TextChanged += new System.EventHandler(this.txtField1_TextChanged);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1398, 739);
            this.Controls.Add(this.CreatePanel);
            this.Controls.Add(this.ReadAllpanel);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.ReadAllpanel.ResumeLayout(false);
            this.ReadAllpanel.PerformLayout();
            this.ReadOnePanel.ResumeLayout(false);
            this.ReadOnePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.CreatePanel.ResumeLayout(false);
            this.CreatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        protected System.Windows.Forms.TextBox ShowOnetxt1;
        protected System.Windows.Forms.TextBox ReadAlltxt;
        protected System.Windows.Forms.Label ShowOnelbl1;
        private System.Windows.Forms.Button ExitToMainMenubtn;
        private System.Windows.Forms.Panel CreatePanel;
        protected System.Windows.Forms.TextBox txtField6;
        protected System.Windows.Forms.TextBox txtField5;
        protected System.Windows.Forms.Label lblField6;
        protected System.Windows.Forms.Label lblField5;
        private System.Windows.Forms.Button EnterCreatebtn;
        protected System.Windows.Forms.TextBox txtField4;
        protected System.Windows.Forms.Label lblField4;
        protected System.Windows.Forms.TextBox txtField3;
        protected System.Windows.Forms.Label lblField3;
        protected System.Windows.Forms.TextBox txtField2;
        protected System.Windows.Forms.Label lblField2;
        protected System.Windows.Forms.Label lblField1;
        protected System.Windows.Forms.TextBox txtField1;
        protected System.Windows.Forms.TextBox ShowOnetxt3;
        protected System.Windows.Forms.Label ShowOnelbl3;
        protected System.Windows.Forms.TextBox ShowOnetxt2;
        protected System.Windows.Forms.Label ShowOnelbl2;
        public System.Windows.Forms.TextBox SearchBox;
    }
}