namespace UI
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.Customerbtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Productsbtn = new System.Windows.Forms.Button();
            this.btnToOrder = new System.Windows.Forms.Label();
            this.Orderbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customerbtn
            // 
            this.Customerbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerbtn.Location = new System.Drawing.Point(276, 256);
            this.Customerbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Customerbtn.Name = "Customerbtn";
            this.Customerbtn.Size = new System.Drawing.Size(614, 164);
            this.Customerbtn.TabIndex = 0;
            this.Customerbtn.Text = "Click Here For Customers";
            this.Customerbtn.UseVisualStyleBackColor = true;
            this.Customerbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Productsbtn
            // 
            this.Productsbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productsbtn.Location = new System.Drawing.Point(276, 467);
            this.Productsbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Productsbtn.Name = "Productsbtn";
            this.Productsbtn.Size = new System.Drawing.Size(614, 164);
            this.Productsbtn.TabIndex = 3;
            this.Productsbtn.Text = "Click Here For Products";
            this.Productsbtn.UseVisualStyleBackColor = true;
            this.Productsbtn.Click += new System.EventHandler(this.Productsbtn_Click);
            // 
            // btnToOrder
            // 
            this.btnToOrder.AutoSize = true;
            this.btnToOrder.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToOrder.Location = new System.Drawing.Point(322, 36);
            this.btnToOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnToOrder.Name = "btnToOrder";
            this.btnToOrder.Size = new System.Drawing.Size(526, 113);
            this.btnToOrder.TabIndex = 4;
            this.btnToOrder.Text = "Welcome";
            // 
            // Orderbtn
            // 
            this.Orderbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderbtn.Location = new System.Drawing.Point(285, 682);
            this.Orderbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Orderbtn.Name = "Orderbtn";
            this.Orderbtn.Size = new System.Drawing.Size(614, 164);
            this.Orderbtn.TabIndex = 5;
            this.Orderbtn.Text = "Click Here For Orders";
            this.Orderbtn.UseVisualStyleBackColor = true;
            this.Orderbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 981);
            this.Controls.Add(this.Orderbtn);
            this.Controls.Add(this.btnToOrder);
            this.Controls.Add(this.Productsbtn);
            this.Controls.Add(this.Customerbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Customerbtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Productsbtn;
        private System.Windows.Forms.Label btnToOrder;
        private System.Windows.Forms.Button Orderbtn;
    }
}