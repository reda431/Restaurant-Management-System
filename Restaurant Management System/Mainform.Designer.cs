namespace Restaurant_Management_System
{
    partial class Mainform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Customers_btn = new System.Windows.Forms.Button();
            this.Categories_btn = new System.Windows.Forms.Button();
            this.Inventory_btn = new System.Windows.Forms.Button();
            this.Shop_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashusers11 = new Restaurant_Management_System.dashusers1();
            this.customerForm1 = new Restaurant_Management_System.CustomerForm();
            this.categoriesForm1 = new Restaurant_Management_System.CategoriesForm();
            this.inventoryForm1 = new Restaurant_Management_System.InventoryForm();
            this.shopform1 = new Restaurant_Management_System.Shopform();
            this.dashboard1 = new Restaurant_Management_System.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 53);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurant";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Firebrick;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1176, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(57, 28);
            this.close.TabIndex = 0;
            this.close.Text = "x";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Logout_btn);
            this.panel2.Controls.Add(this.Customers_btn);
            this.panel2.Controls.Add(this.Categories_btn);
            this.panel2.Controls.Add(this.Inventory_btn);
            this.panel2.Controls.Add(this.Shop_btn);
            this.panel2.Controls.Add(this.Dashboard_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 687);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Management_System.Properties.Resources.images__1_;
            this.pictureBox1.Location = new System.Drawing.Point(75, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.Green;
            this.Logout_btn.Location = new System.Drawing.Point(12, 637);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(241, 38);
            this.Logout_btn.TabIndex = 5;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // Customers_btn
            // 
            this.Customers_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.Customers_btn.Location = new System.Drawing.Point(12, 364);
            this.Customers_btn.Name = "Customers_btn";
            this.Customers_btn.Size = new System.Drawing.Size(241, 38);
            this.Customers_btn.TabIndex = 4;
            this.Customers_btn.Text = "Customers";
            this.Customers_btn.UseVisualStyleBackColor = false;
            this.Customers_btn.Click += new System.EventHandler(this.Customers_btn_Click);
            // 
            // Categories_btn
            // 
            this.Categories_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.Categories_btn.Location = new System.Drawing.Point(12, 320);
            this.Categories_btn.Name = "Categories_btn";
            this.Categories_btn.Size = new System.Drawing.Size(241, 38);
            this.Categories_btn.TabIndex = 3;
            this.Categories_btn.Text = "Categories";
            this.Categories_btn.UseVisualStyleBackColor = false;
            this.Categories_btn.Click += new System.EventHandler(this.Categories_btn_Click);
            // 
            // Inventory_btn
            // 
            this.Inventory_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.Inventory_btn.Location = new System.Drawing.Point(12, 276);
            this.Inventory_btn.Name = "Inventory_btn";
            this.Inventory_btn.Size = new System.Drawing.Size(241, 38);
            this.Inventory_btn.TabIndex = 2;
            this.Inventory_btn.Text = "Inventory";
            this.Inventory_btn.UseVisualStyleBackColor = false;
            this.Inventory_btn.Click += new System.EventHandler(this.Inventory_btn_Click);
            // 
            // Shop_btn
            // 
            this.Shop_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.Shop_btn.Location = new System.Drawing.Point(12, 232);
            this.Shop_btn.Name = "Shop_btn";
            this.Shop_btn.Size = new System.Drawing.Size(241, 38);
            this.Shop_btn.TabIndex = 1;
            this.Shop_btn.Text = "Shop";
            this.Shop_btn.UseVisualStyleBackColor = false;
            this.Shop_btn.Click += new System.EventHandler(this.Shop_btn_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.Dashboard_btn.Location = new System.Drawing.Point(12, 188);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(241, 38);
            this.Dashboard_btn.TabIndex = 0;
            this.Dashboard_btn.Text = "Dashboard";
            this.Dashboard_btn.UseVisualStyleBackColor = false;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashusers11);
            this.panel3.Controls.Add(this.customerForm1);
            this.panel3.Controls.Add(this.categoriesForm1);
            this.panel3.Controls.Add(this.inventoryForm1);
            this.panel3.Controls.Add(this.shopform1);
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(269, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 687);
            this.panel3.TabIndex = 2;
            // 
            // dashusers11
            // 
            this.dashusers11.BackColor = System.Drawing.SystemColors.Control;
            this.dashusers11.Location = new System.Drawing.Point(0, 0);
            this.dashusers11.Name = "dashusers11";
            this.dashusers11.Size = new System.Drawing.Size(976, 687);
            this.dashusers11.TabIndex = 5;
            // 
            // customerForm1
            // 
            this.customerForm1.Location = new System.Drawing.Point(0, 0);
            this.customerForm1.Name = "customerForm1";
            this.customerForm1.Size = new System.Drawing.Size(976, 687);
            this.customerForm1.TabIndex = 4;
            // 
            // categoriesForm1
            // 
            this.categoriesForm1.Location = new System.Drawing.Point(0, 0);
            this.categoriesForm1.Name = "categoriesForm1";
            this.categoriesForm1.Size = new System.Drawing.Size(976, 687);
            this.categoriesForm1.TabIndex = 3;
            // 
            // inventoryForm1
            // 
            this.inventoryForm1.Location = new System.Drawing.Point(0, 0);
            this.inventoryForm1.Name = "inventoryForm1";
            this.inventoryForm1.Size = new System.Drawing.Size(976, 687);
            this.inventoryForm1.TabIndex = 2;
            // 
            // shopform1
            // 
            this.shopform1.Location = new System.Drawing.Point(0, 3);
            this.shopform1.Name = "shopform1";
            this.shopform1.Size = new System.Drawing.Size(976, 687);
            this.shopform1.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(976, 687);
            this.dashboard1.TabIndex = 0;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 740);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Customers_btn;
        private System.Windows.Forms.Button Categories_btn;
        private System.Windows.Forms.Button Inventory_btn;
        private System.Windows.Forms.Button Shop_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Dashboard dashboard1;
        private Shopform shopform1;
        private InventoryForm inventoryForm1;
        private CategoriesForm categoriesForm1;
        private CustomerForm customerForm1;
        private dashusers1 dashusers11;
    }
}