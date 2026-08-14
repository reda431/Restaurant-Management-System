namespace Restaurant_Management_System
{
    partial class InventoryForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inventory_importBTN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inventory_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inventory_status = new System.Windows.Forms.ComboBox();
            this.inventory_stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inventory_productName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inventory_category = new System.Windows.Forms.ComboBox();
            this.inventory_productID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inventory_addBTN = new System.Windows.Forms.Button();
            this.inventory_updateBTN = new System.Windows.Forms.Button();
            this.inventory_clearBTN = new System.Windows.Forms.Button();
            this.inventory_deleteBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(15, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 396);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.inventory_clearBTN);
            this.panel2.Controls.Add(this.inventory_deleteBTN);
            this.panel2.Controls.Add(this.inventory_updateBTN);
            this.panel2.Controls.Add(this.inventory_addBTN);
            this.panel2.Controls.Add(this.inventory_importBTN);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.inventory_price);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.inventory_status);
            this.panel2.Controls.Add(this.inventory_stock);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.inventory_productName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.inventory_category);
            this.panel2.Controls.Add(this.inventory_productID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 249);
            this.panel2.TabIndex = 1;
            // 
            // inventory_importBTN
            // 
            this.inventory_importBTN.BackColor = System.Drawing.Color.LimeGreen;
            this.inventory_importBTN.Location = new System.Drawing.Point(734, 172);
            this.inventory_importBTN.Name = "inventory_importBTN";
            this.inventory_importBTN.Size = new System.Drawing.Size(160, 43);
            this.inventory_importBTN.TabIndex = 13;
            this.inventory_importBTN.Text = "IMPORT";
            this.inventory_importBTN.UseVisualStyleBackColor = false;
            this.inventory_importBTN.Click += new System.EventHandler(this.inventory_importBTN_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(734, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 146);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Staus";
            // 
            // inventory_price
            // 
            this.inventory_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_price.Location = new System.Drawing.Point(421, 92);
            this.inventory_price.Name = "inventory_price";
            this.inventory_price.Size = new System.Drawing.Size(227, 28);
            this.inventory_price.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price";
            // 
            // inventory_status
            // 
            this.inventory_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_status.FormattingEnabled = true;
            this.inventory_status.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.inventory_status.Location = new System.Drawing.Point(421, 139);
            this.inventory_status.Name = "inventory_status";
            this.inventory_status.Size = new System.Drawing.Size(227, 30);
            this.inventory_status.TabIndex = 8;
            // 
            // inventory_stock
            // 
            this.inventory_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_stock.Location = new System.Drawing.Point(421, 52);
            this.inventory_stock.Name = "inventory_stock";
            this.inventory_stock.Size = new System.Drawing.Size(227, 28);
            this.inventory_stock.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "category";
            // 
            // inventory_productName
            // 
            this.inventory_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_productName.Location = new System.Drawing.Point(109, 92);
            this.inventory_productName.Name = "inventory_productName";
            this.inventory_productName.Size = new System.Drawing.Size(227, 28);
            this.inventory_productName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product name";
            // 
            // inventory_category
            // 
            this.inventory_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_category.FormattingEnabled = true;
            this.inventory_category.Location = new System.Drawing.Point(109, 140);
            this.inventory_category.Name = "inventory_category";
            this.inventory_category.Size = new System.Drawing.Size(227, 30);
            this.inventory_category.TabIndex = 2;
            // 
            // inventory_productID
            // 
            this.inventory_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_productID.Location = new System.Drawing.Point(109, 52);
            this.inventory_productID.Name = "inventory_productID";
            this.inventory_productID.Size = new System.Drawing.Size(227, 28);
            this.inventory_productID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product ID";
            // 
            // inventory_addBTN
            // 
            this.inventory_addBTN.BackColor = System.Drawing.Color.LimeGreen;
            this.inventory_addBTN.Location = new System.Drawing.Point(69, 189);
            this.inventory_addBTN.Name = "inventory_addBTN";
            this.inventory_addBTN.Size = new System.Drawing.Size(106, 43);
            this.inventory_addBTN.TabIndex = 14;
            this.inventory_addBTN.Text = "ADD";
            this.inventory_addBTN.UseVisualStyleBackColor = false;
            this.inventory_addBTN.Click += new System.EventHandler(this.inventory_addBTN_Click);
            // 
            // inventory_updateBTN
            // 
            this.inventory_updateBTN.BackColor = System.Drawing.Color.LimeGreen;
            this.inventory_updateBTN.Location = new System.Drawing.Point(231, 189);
            this.inventory_updateBTN.Name = "inventory_updateBTN";
            this.inventory_updateBTN.Size = new System.Drawing.Size(106, 43);
            this.inventory_updateBTN.TabIndex = 15;
            this.inventory_updateBTN.Text = "UPDATE";
            this.inventory_updateBTN.UseVisualStyleBackColor = false;
            this.inventory_updateBTN.Click += new System.EventHandler(this.inventory_updateBTN_Click);
            // 
            // inventory_clearBTN
            // 
            this.inventory_clearBTN.BackColor = System.Drawing.Color.LimeGreen;
            this.inventory_clearBTN.Location = new System.Drawing.Point(564, 189);
            this.inventory_clearBTN.Name = "inventory_clearBTN";
            this.inventory_clearBTN.Size = new System.Drawing.Size(106, 43);
            this.inventory_clearBTN.TabIndex = 17;
            this.inventory_clearBTN.Text = "CLEAR";
            this.inventory_clearBTN.UseVisualStyleBackColor = false;
            this.inventory_clearBTN.Click += new System.EventHandler(this.inventory_clearBTN_Click);
            // 
            // inventory_deleteBTN
            // 
            this.inventory_deleteBTN.BackColor = System.Drawing.Color.LimeGreen;
            this.inventory_deleteBTN.Location = new System.Drawing.Point(397, 189);
            this.inventory_deleteBTN.Name = "inventory_deleteBTN";
            this.inventory_deleteBTN.Size = new System.Drawing.Size(106, 43);
            this.inventory_deleteBTN.TabIndex = 16;
            this.inventory_deleteBTN.Text = "DELETE";
            this.inventory_deleteBTN.UseVisualStyleBackColor = false;
            this.inventory_deleteBTN.Click += new System.EventHandler(this.inventory_deleteBTN_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryForm";
            this.Size = new System.Drawing.Size(976, 687);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox inventory_category;
        private System.Windows.Forms.TextBox inventory_productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inventory_productName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inventory_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox inventory_status;
        private System.Windows.Forms.TextBox inventory_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button inventory_importBTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button inventory_clearBTN;
        private System.Windows.Forms.Button inventory_deleteBTN;
        private System.Windows.Forms.Button inventory_updateBTN;
        private System.Windows.Forms.Button inventory_addBTN;
    }
}
