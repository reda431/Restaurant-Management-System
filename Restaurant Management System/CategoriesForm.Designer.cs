namespace Restaurant_Management_System
{
    partial class CategoriesForm
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
            this.Categories_clearBtn = new System.Windows.Forms.Button();
            this.Categories_deleteBtn = new System.Windows.Forms.Button();
            this.Categories_updateBtn = new System.Windows.Forms.Button();
            this.Categories_addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Categories_status = new System.Windows.Forms.ComboBox();
            this.Categories_category = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Categories_clearBtn);
            this.panel1.Controls.Add(this.Categories_deleteBtn);
            this.panel1.Controls.Add(this.Categories_updateBtn);
            this.panel1.Controls.Add(this.Categories_addBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Categories_status);
            this.panel1.Controls.Add(this.Categories_category);
            this.panel1.Location = new System.Drawing.Point(22, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 654);
            this.panel1.TabIndex = 0;
            // 
            // Categories_clearBtn
            // 
            this.Categories_clearBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Categories_clearBtn.Location = new System.Drawing.Point(29, 348);
            this.Categories_clearBtn.Name = "Categories_clearBtn";
            this.Categories_clearBtn.Size = new System.Drawing.Size(199, 55);
            this.Categories_clearBtn.TabIndex = 7;
            this.Categories_clearBtn.Text = "CLEAR";
            this.Categories_clearBtn.UseVisualStyleBackColor = false;
            this.Categories_clearBtn.Click += new System.EventHandler(this.Categories_clearBtn_Click);
            // 
            // Categories_deleteBtn
            // 
            this.Categories_deleteBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Categories_deleteBtn.Location = new System.Drawing.Point(29, 287);
            this.Categories_deleteBtn.Name = "Categories_deleteBtn";
            this.Categories_deleteBtn.Size = new System.Drawing.Size(199, 55);
            this.Categories_deleteBtn.TabIndex = 6;
            this.Categories_deleteBtn.Text = "DELETE";
            this.Categories_deleteBtn.UseVisualStyleBackColor = false;
            this.Categories_deleteBtn.Click += new System.EventHandler(this.Categories_deleteBtn_Click);
            // 
            // Categories_updateBtn
            // 
            this.Categories_updateBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Categories_updateBtn.Location = new System.Drawing.Point(29, 226);
            this.Categories_updateBtn.Name = "Categories_updateBtn";
            this.Categories_updateBtn.Size = new System.Drawing.Size(199, 55);
            this.Categories_updateBtn.TabIndex = 5;
            this.Categories_updateBtn.Text = "UPDATE";
            this.Categories_updateBtn.UseVisualStyleBackColor = false;
            this.Categories_updateBtn.Click += new System.EventHandler(this.Categories_updateBtn_Click);
            // 
            // Categories_addBtn
            // 
            this.Categories_addBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Categories_addBtn.Location = new System.Drawing.Point(29, 165);
            this.Categories_addBtn.Name = "Categories_addBtn";
            this.Categories_addBtn.Size = new System.Drawing.Size(199, 55);
            this.Categories_addBtn.TabIndex = 4;
            this.Categories_addBtn.Text = "ADD";
            this.Categories_addBtn.UseVisualStyleBackColor = false;
            this.Categories_addBtn.Click += new System.EventHandler(this.Categories_addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // Categories_status
            // 
            this.Categories_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories_status.FormattingEnabled = true;
            this.Categories_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.Categories_status.Location = new System.Drawing.Point(29, 113);
            this.Categories_status.Name = "Categories_status";
            this.Categories_status.Size = new System.Drawing.Size(199, 30);
            this.Categories_status.TabIndex = 1;
            // 
            // Categories_category
            // 
            this.Categories_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories_category.Location = new System.Drawing.Point(29, 50);
            this.Categories_category.Name = "Categories_category";
            this.Categories_category.Size = new System.Drawing.Size(199, 28);
            this.Categories_category.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(287, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 654);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(638, 589);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Categories";
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CategoriesForm";
            this.Size = new System.Drawing.Size(976, 687);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Categories_addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Categories_status;
        private System.Windows.Forms.TextBox Categories_category;
        private System.Windows.Forms.Button Categories_clearBtn;
        private System.Windows.Forms.Button Categories_deleteBtn;
        private System.Windows.Forms.Button Categories_updateBtn;
    }
}
