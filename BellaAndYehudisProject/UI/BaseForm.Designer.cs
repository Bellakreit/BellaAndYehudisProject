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
            this.CreatePanel.Controls.Add(this.EnterCreatebtn);
            this.CreatePanel.Controls.Add(this.Stocktxt);
            this.CreatePanel.Controls.Add(this.StockLabel);
            this.CreatePanel.Controls.Add(this.Costtxt);
            this.CreatePanel.Controls.Add(this.CostLabel);
            this.CreatePanel.Controls.Add(this.ProductNametxt);
            this.CreatePanel.Controls.Add(this.ProductNamelabel);
            this.CreatePanel.Controls.Add(this.ProductNumlabel);
            this.CreatePanel.Controls.Add(this.ProductNumtxt);
            this.CreatePanel.Location = new System.Drawing.Point(-20, 26);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(490, 448);
            this.CreatePanel.TabIndex = 11;
            this.CreatePanel.Visible = false;
            // 
            // EnterCreatebtn
            // 
            this.EnterCreatebtn.Location = new System.Drawing.Point(128, 258);
            this.EnterCreatebtn.Name = "EnterCreatebtn";
            this.EnterCreatebtn.Size = new System.Drawing.Size(171, 53);
            this.EnterCreatebtn.TabIndex = 8;
            this.EnterCreatebtn.Text = "Enter";
            this.EnterCreatebtn.UseVisualStyleBackColor = true;
            this.EnterCreatebtn.Click += new System.EventHandler(this.EnterCreatebtn_Click);
            // 
            // Stocktxt
            // 
            this.Stocktxt.Location = new System.Drawing.Point(198, 183);
            this.Stocktxt.Name = "Stocktxt";
            this.Stocktxt.Size = new System.Drawing.Size(244, 31);
            this.Stocktxt.TabIndex = 7;
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Location = new System.Drawing.Point(14, 183);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(182, 25);
            this.StockLabel.TabIndex = 6;
            this.StockLabel.Text = "Number in Stock: ";
            // 
            // Costtxt
            // 
            this.Costtxt.Location = new System.Drawing.Point(198, 134);
            this.Costtxt.Name = "Costtxt";
            this.Costtxt.Size = new System.Drawing.Size(244, 31);
            this.Costtxt.TabIndex = 5;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(14, 134);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(146, 25);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost per unit: ";
            // 
            // ProductNametxt
            // 
            this.ProductNametxt.Location = new System.Drawing.Point(198, 83);
            this.ProductNametxt.Name = "ProductNametxt";
            this.ProductNametxt.Size = new System.Drawing.Size(244, 31);
            this.ProductNametxt.TabIndex = 3;
            // 
            // ProductNamelabel
            // 
            this.ProductNamelabel.AutoSize = true;
            this.ProductNamelabel.Location = new System.Drawing.Point(14, 86);
            this.ProductNamelabel.Name = "ProductNamelabel";
            this.ProductNamelabel.Size = new System.Drawing.Size(160, 25);
            this.ProductNamelabel.TabIndex = 2;
            this.ProductNamelabel.Text = "Product Name: ";
            // 
            // ProductNumlabel
            // 
            this.ProductNumlabel.AutoSize = true;
            this.ProductNumlabel.Location = new System.Drawing.Point(14, 38);
            this.ProductNumlabel.Name = "ProductNumlabel";
            this.ProductNumlabel.Size = new System.Drawing.Size(179, 25);
            this.ProductNumlabel.TabIndex = 1;
            this.ProductNumlabel.Text = "Product Number: ";
            this.ProductNumlabel.Click += new System.EventHandler(this.ProductNumlabel_Click);
            // 
            // ProductNumtxt
            // 
            this.ProductNumtxt.Location = new System.Drawing.Point(198, 34);
            this.ProductNumtxt.Name = "ProductNumtxt";
            this.ProductNumtxt.Size = new System.Drawing.Size(244, 31);
            this.ProductNumtxt.TabIndex = 0;
            // 
            // ReadAllpanel
            // 
            this.ReadAllpanel.Controls.Add(this.ReadOnePanel);
            this.ReadAllpanel.Controls.Add(this.ExitReadAllbtn);
            this.ReadAllpanel.Controls.Add(this.ReadAlltxt);
            this.ReadAllpanel.Location = new System.Drawing.Point(-4, 11);
            this.ReadAllpanel.Name = "ReadAllpanel";
            this.ReadAllpanel.Size = new System.Drawing.Size(994, 545);
            this.ReadAllpanel.TabIndex = 12;
            this.ReadAllpanel.Visible = false;
            // 
            // ReadOnePanel
            // 
            this.ReadOnePanel.Controls.Add(this.EnterReadOnebtn);
            this.ReadOnePanel.Controls.Add(this.ReadOneNumtxt);
            this.ReadOnePanel.Controls.Add(this.ProdNumlabel);
            this.ReadOnePanel.Location = new System.Drawing.Point(22, 12);
            this.ReadOnePanel.Name = "ReadOnePanel";
            this.ReadOnePanel.Size = new System.Drawing.Size(816, 56);
            this.ReadOnePanel.TabIndex = 4;
            this.ReadOnePanel.Visible = false;
            // 
            // EnterReadOnebtn
            // 
            this.EnterReadOnebtn.Location = new System.Drawing.Point(522, 5);
            this.EnterReadOnebtn.Name = "EnterReadOnebtn";
            this.EnterReadOnebtn.Size = new System.Drawing.Size(176, 42);
            this.EnterReadOnebtn.TabIndex = 4;
            this.EnterReadOnebtn.Text = "Enter";
            this.EnterReadOnebtn.UseVisualStyleBackColor = true;
            this.EnterReadOnebtn.Click += new System.EventHandler(this.EnterReadOnebtn_Click);
            // 
            // ReadOneNumtxt
            // 
            this.ReadOneNumtxt.Location = new System.Drawing.Point(195, 11);
            this.ReadOneNumtxt.Name = "ReadOneNumtxt";
            this.ReadOneNumtxt.Size = new System.Drawing.Size(300, 31);
            this.ReadOneNumtxt.TabIndex = 3;
            // 
            // ProdNumlabel
            // 
            this.ProdNumlabel.AutoSize = true;
            this.ProdNumlabel.Location = new System.Drawing.Point(10, 14);
            this.ProdNumlabel.Name = "ProdNumlabel";
            this.ProdNumlabel.Size = new System.Drawing.Size(179, 25);
            this.ProdNumlabel.TabIndex = 2;
            this.ProdNumlabel.Text = "Product Number: ";
            // 
            // ExitReadAllbtn
            // 
            this.ExitReadAllbtn.Location = new System.Drawing.Point(354, 394);
            this.ExitReadAllbtn.Name = "ExitReadAllbtn";
            this.ExitReadAllbtn.Size = new System.Drawing.Size(180, 41);
            this.ExitReadAllbtn.TabIndex = 1;
            this.ExitReadAllbtn.Text = "Exit";
            this.ExitReadAllbtn.UseVisualStyleBackColor = true;
            this.ExitReadAllbtn.Click += new System.EventHandler(this.ExitReadAllbtn_Click);
            // 
            // ReadAlltxt
            // 
            this.ReadAlltxt.Location = new System.Drawing.Point(22, 73);
            this.ReadAlltxt.Multiline = true;
            this.ReadAlltxt.Name = "ReadAlltxt";
            this.ReadAlltxt.Size = new System.Drawing.Size(954, 285);
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
            this.MainPanel.Location = new System.Drawing.Point(979, 20);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(260, 512);
            this.MainPanel.TabIndex = 10;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(32, 338);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(182, 55);
            this.Deletebtn.TabIndex = 4;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(32, 262);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(183, 55);
            this.Updatebtn.TabIndex = 3;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // ReadOnebtn
            // 
            this.ReadOnebtn.Location = new System.Drawing.Point(32, 188);
            this.ReadOnebtn.Name = "ReadOnebtn";
            this.ReadOnebtn.Size = new System.Drawing.Size(182, 58);
            this.ReadOnebtn.TabIndex = 2;
            this.ReadOnebtn.Text = "Show One";
            this.ReadOnebtn.UseVisualStyleBackColor = true;
            this.ReadOnebtn.Click += new System.EventHandler(this.ReadOnebtn_Click);
            // 
            // ReadAllbtn
            // 
            this.ReadAllbtn.Location = new System.Drawing.Point(32, 106);
            this.ReadAllbtn.Name = "ReadAllbtn";
            this.ReadAllbtn.Size = new System.Drawing.Size(182, 56);
            this.ReadAllbtn.TabIndex = 1;
            this.ReadAllbtn.Text = "Show All";
            this.ReadAllbtn.UseVisualStyleBackColor = true;
            this.ReadAllbtn.Click += new System.EventHandler(this.ReadAllbtn_Click);
            // 
            // Createbtn
            // 
            this.Createbtn.Location = new System.Drawing.Point(32, 31);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(182, 53);
            this.Createbtn.TabIndex = 0;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 566);
            this.Controls.Add(this.CreatePanel);
            this.Controls.Add(this.ReadAllpanel);
            this.Controls.Add(this.MainPanel);
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
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label ProductNamelabel;
        private System.Windows.Forms.Label ProductNumlabel;
        private System.Windows.Forms.Panel ReadAllpanel;
        private System.Windows.Forms.Panel ReadOnePanel;
        private System.Windows.Forms.Button EnterReadOnebtn;
        private System.Windows.Forms.Label ProdNumlabel;
        private System.Windows.Forms.Button ExitReadAllbtn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button ReadOnebtn;
        private System.Windows.Forms.Button ReadAllbtn;
        private System.Windows.Forms.Button Createbtn;
        protected System.Windows.Forms.TextBox Stocktxt;
        protected System.Windows.Forms.TextBox Costtxt;
        protected System.Windows.Forms.TextBox ProductNametxt;
        protected System.Windows.Forms.TextBox ProductNumtxt;
        protected System.Windows.Forms.TextBox ReadOneNumtxt;
        protected System.Windows.Forms.TextBox ReadAlltxt;
    }
}