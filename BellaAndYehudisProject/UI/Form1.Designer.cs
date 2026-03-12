namespace UI
{
    partial class ProductsForm1
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.ReadOnebtn = new System.Windows.Forms.Button();
            this.ReadAllbtn = new System.Windows.Forms.Button();
            this.Createbtn = new System.Windows.Forms.Button();
            this.CreatePanel = new System.Windows.Forms.Panel();
            this.EnterCreatebtn = new System.Windows.Forms.Button();
            this.Stocktxt = new System.Windows.Forms.TextBox();
            this.StockLabel = new System.Windows.Forms.Label();
            this.Costtxt = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ProductNametxt = new System.Windows.Forms.TextBox();
            this.ProductNamelabel = new System.Windows.Forms.Label();
            this.ProductNumlabel = new System.Windows.Forms.Label();
            this.ProductNumtxt = new System.Windows.Forms.TextBox();
            this.ReadAllpanel = new System.Windows.Forms.Panel();
            this.ReadOnePanel = new System.Windows.Forms.Panel();
            this.EnterReadOnebtn = new System.Windows.Forms.Button();
            this.ReadOneNumtxt = new System.Windows.Forms.TextBox();
            this.ProdNumlabel = new System.Windows.Forms.Label();
            this.ExitReadAllbtn = new System.Windows.Forms.Button();
            this.ReadAlltxt = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.CreatePanel.SuspendLayout();
            this.ReadAllpanel.SuspendLayout();
            this.ReadOnePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MainPanel.Controls.Add(this.Deletebtn);
            this.MainPanel.Controls.Add(this.Updatebtn);
            this.MainPanel.Controls.Add(this.ReadOnebtn);
            this.MainPanel.Controls.Add(this.ReadAllbtn);
            this.MainPanel.Controls.Add(this.Createbtn);
            this.MainPanel.Location = new System.Drawing.Point(674, 25);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(173, 328);
            this.MainPanel.TabIndex = 0;
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
            this.CreatePanel.Controls.Add(this.EnterCreatebtn);
            this.CreatePanel.Controls.Add(this.Stocktxt);
            this.CreatePanel.Controls.Add(this.StockLabel);
            this.CreatePanel.Controls.Add(this.Costtxt);
            this.CreatePanel.Controls.Add(this.CostLabel);
            this.CreatePanel.Controls.Add(this.ProductNametxt);
            this.CreatePanel.Controls.Add(this.ProductNamelabel);
            this.CreatePanel.Controls.Add(this.ProductNumlabel);
            this.CreatePanel.Controls.Add(this.ProductNumtxt);
            this.CreatePanel.Location = new System.Drawing.Point(8, 29);
            this.CreatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(327, 287);
            this.CreatePanel.TabIndex = 1;
            this.CreatePanel.Visible = false;
            // 
            // EnterCreatebtn
            // 
            this.EnterCreatebtn.Location = new System.Drawing.Point(85, 165);
            this.EnterCreatebtn.Margin = new System.Windows.Forms.Padding(2);
            this.EnterCreatebtn.Name = "EnterCreatebtn";
            this.EnterCreatebtn.Size = new System.Drawing.Size(114, 34);
            this.EnterCreatebtn.TabIndex = 8;
            this.EnterCreatebtn.Text = "Enter";
            this.EnterCreatebtn.UseVisualStyleBackColor = true;
            this.EnterCreatebtn.Click += new System.EventHandler(this.EnterCreatebtn_Click);
            // 
            // Stocktxt
            // 
            this.Stocktxt.Location = new System.Drawing.Point(132, 117);
            this.Stocktxt.Margin = new System.Windows.Forms.Padding(2);
            this.Stocktxt.Name = "Stocktxt";
            this.Stocktxt.Size = new System.Drawing.Size(164, 22);
            this.Stocktxt.TabIndex = 7;
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Location = new System.Drawing.Point(9, 117);
            this.StockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(111, 16);
            this.StockLabel.TabIndex = 6;
            this.StockLabel.Text = "Number in Stock: ";
            // 
            // Costtxt
            // 
            this.Costtxt.Location = new System.Drawing.Point(132, 86);
            this.Costtxt.Margin = new System.Windows.Forms.Padding(2);
            this.Costtxt.Name = "Costtxt";
            this.Costtxt.Size = new System.Drawing.Size(164, 22);
            this.Costtxt.TabIndex = 5;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(9, 86);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(86, 16);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost per unit: ";
            this.CostLabel.Click += new System.EventHandler(this.CostLabel_Click);
            // 
            // ProductNametxt
            // 
            this.ProductNametxt.Location = new System.Drawing.Point(132, 53);
            this.ProductNametxt.Margin = new System.Windows.Forms.Padding(2);
            this.ProductNametxt.Name = "ProductNametxt";
            this.ProductNametxt.Size = new System.Drawing.Size(164, 22);
            this.ProductNametxt.TabIndex = 3;
            // 
            // ProductNamelabel
            // 
            this.ProductNamelabel.AutoSize = true;
            this.ProductNamelabel.Location = new System.Drawing.Point(9, 55);
            this.ProductNamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductNamelabel.Name = "ProductNamelabel";
            this.ProductNamelabel.Size = new System.Drawing.Size(99, 16);
            this.ProductNamelabel.TabIndex = 2;
            this.ProductNamelabel.Text = "Product Name: ";
            // 
            // ProductNumlabel
            // 
            this.ProductNumlabel.AutoSize = true;
            this.ProductNumlabel.Location = new System.Drawing.Point(9, 24);
            this.ProductNumlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductNumlabel.Name = "ProductNumlabel";
            this.ProductNumlabel.Size = new System.Drawing.Size(110, 16);
            this.ProductNumlabel.TabIndex = 1;
            this.ProductNumlabel.Text = "Product Number: ";
            this.ProductNumlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductNumtxt
            // 
            this.ProductNumtxt.Location = new System.Drawing.Point(132, 22);
            this.ProductNumtxt.Margin = new System.Windows.Forms.Padding(2);
            this.ProductNumtxt.Name = "ProductNumtxt";
            this.ProductNumtxt.Size = new System.Drawing.Size(164, 22);
            this.ProductNumtxt.TabIndex = 0;
            // 
            // ReadAllpanel
            // 
            this.ReadAllpanel.Controls.Add(this.ReadOnePanel);
            this.ReadAllpanel.Controls.Add(this.ExitReadAllbtn);
            this.ReadAllpanel.Controls.Add(this.ReadAlltxt);
            this.ReadAllpanel.Location = new System.Drawing.Point(19, 19);
            this.ReadAllpanel.Margin = new System.Windows.Forms.Padding(2);
            this.ReadAllpanel.Name = "ReadAllpanel";
            this.ReadAllpanel.Size = new System.Drawing.Size(663, 349);
            this.ReadAllpanel.TabIndex = 9;
            this.ReadAllpanel.Visible = false;
            // 
            // ReadOnePanel
            // 
            this.ReadOnePanel.Controls.Add(this.EnterReadOnebtn);
            this.ReadOnePanel.Controls.Add(this.ReadOneNumtxt);
            this.ReadOnePanel.Controls.Add(this.ProdNumlabel);
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
            // ProdNumlabel
            // 
            this.ProdNumlabel.AutoSize = true;
            this.ProdNumlabel.Location = new System.Drawing.Point(7, 9);
            this.ProdNumlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProdNumlabel.Name = "ProdNumlabel";
            this.ProdNumlabel.Size = new System.Drawing.Size(110, 16);
            this.ProdNumlabel.TabIndex = 2;
            this.ProdNumlabel.Text = "Product Number: ";
            // 
            // ExitReadAllbtn
            // 
            this.ExitReadAllbtn.Location = new System.Drawing.Point(236, 252);
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
            this.ReadAlltxt.Size = new System.Drawing.Size(637, 184);
            this.ReadAlltxt.TabIndex = 0;
            // 
            // ProductsForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 417);
            this.Controls.Add(this.CreatePanel);
            this.Controls.Add(this.ReadAllpanel);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductsForm1";
            this.Text = "Products Form";
            this.MainPanel.ResumeLayout(false);
            this.CreatePanel.ResumeLayout(false);
            this.CreatePanel.PerformLayout();
            this.ReadAllpanel.ResumeLayout(false);
            this.ReadAllpanel.PerformLayout();
            this.ReadOnePanel.ResumeLayout(false);
            this.ReadOnePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ReadAllbtn;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button ReadOnebtn;
        private System.Windows.Forms.Panel CreatePanel;
        private System.Windows.Forms.Label ProductNumlabel;
        private System.Windows.Forms.TextBox ProductNumtxt;
        private System.Windows.Forms.TextBox ProductNametxt;
        private System.Windows.Forms.Label ProductNamelabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.TextBox Costtxt;
        private System.Windows.Forms.Button EnterCreatebtn;
        private System.Windows.Forms.TextBox Stocktxt;
        private System.Windows.Forms.Panel ReadAllpanel;
        private System.Windows.Forms.Button ExitReadAllbtn;
        private System.Windows.Forms.TextBox ReadAlltxt;
        private System.Windows.Forms.Label ProdNumlabel;
        private System.Windows.Forms.Panel ReadOnePanel;
        private System.Windows.Forms.Button EnterReadOnebtn;
        private System.Windows.Forms.TextBox ReadOneNumtxt;
    }
}

