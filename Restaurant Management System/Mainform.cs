using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class Mainform : Form
    {
        private dashusers1 dashusers1;
        public Mainform()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this app?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want Logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 LoginForm = new Form1();
                LoginForm.Show();

                this.Hide();
            }
        }

     

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            if (shopform1 != null) shopform1.Visible = false;
            if (inventoryForm1 != null) inventoryForm1.Visible = false;
            if (categoriesForm1 != null) categoriesForm1.Visible = false;
            if (customerForm1 != null) customerForm1.Visible = false;
            if (dashusers1 != null) dashusers1.Visible = false;

            if (dashboard1 == null)
            {
                dashboard1 = new Dashboard();
                dashboard1.Dock = DockStyle.Fill;
                this.Controls.Add(dashboard1);
            }

            dashboard1.BringToFront();
            dashboard1.Visible = true;
        }


        private void Shop_btn_Click(object sender, EventArgs e)
        {
            if (dashboard1 != null) dashboard1.Visible = false;
            if (inventoryForm1 != null) inventoryForm1.Visible = false;
            if (categoriesForm1 != null) categoriesForm1.Visible = false;
            if (customerForm1 != null) customerForm1.Visible = false;
            if (dashusers1 != null) dashusers1.Visible = false; 

            if (shopform1 == null)
            {
                shopform1 = new Shopform();
                shopform1.Dock = DockStyle.Fill;
                this.Controls.Add(shopform1);
            }

            
            shopform1.BringToFront();
            shopform1.Visible = true;
        }



         private void Button2_Click(object sender, EventArgs e)
         {
             
          
            if (dashboard1 != null) dashboard1.Visible = false;
            if (shopform1 != null) shopform1.Visible = false;
            if (inventoryForm1 != null) inventoryForm1.Visible = false;
            if (categoriesForm1 != null) categoriesForm1.Visible = false;
            if (customerForm1 != null) customerForm1.Visible = false;

          
            if (dashusers1 == null)
            {
               
                dashusers1 = new dashusers1();
                dashusers1.Dock = DockStyle.Fill;
                this.Controls.Add(dashusers1);
            }

            
            dashusers1.BringToFront();
            dashusers1.Visible = true;
            
        }

        private void Inventory_btn_Click(object sender, EventArgs e)
        {
            
            if (dashboard1 != null) dashboard1.Visible = false;
            if (shopform1 != null) shopform1.Visible = false;
            if (categoriesForm1 != null) categoriesForm1.Visible = false;
            if (customerForm1 != null) customerForm1.Visible = false;
            if (dashusers1 != null) dashusers1.Visible = false;

           
            if (inventoryForm1 == null)
            {
                
                inventoryForm1 = new InventoryForm();
                inventoryForm1.Dock = DockStyle.Fill;
                this.Controls.Add(inventoryForm1);
            }

            
            inventoryForm1.BringToFront();
            inventoryForm1.Visible = true;
        }

        private void Categories_btn_Click(object sender, EventArgs e)
        {
            
            if (dashboard1 != null) dashboard1.Visible = false;
            if (shopform1 != null) shopform1.Visible = false;
            if (inventoryForm1 != null) inventoryForm1.Visible = false;
            if (customerForm1 != null) customerForm1.Visible = false;
            if (dashusers1 != null) dashusers1.Visible = false;

            
            if (categoriesForm1 == null)
            {
                
                categoriesForm1 = new CategoriesForm();
                categoriesForm1.Dock = DockStyle.Fill;
                this.Controls.Add(categoriesForm1);
            }

            
            categoriesForm1.BringToFront();
            categoriesForm1.Visible = true;
        }

        private void Customers_btn_Click(object sender, EventArgs e)
        {
            
            if (dashboard1 != null) dashboard1.Visible = false;
            if (shopform1 != null) shopform1.Visible = false;
            if (inventoryForm1 != null) inventoryForm1.Visible = false;
            if (categoriesForm1 != null) categoriesForm1.Visible = false;
            if (dashusers1 != null) dashusers1.Visible = false;

           
            if (customerForm1 == null)
            {
                
                customerForm1 = new CustomerForm();
                customerForm1.Dock = DockStyle.Fill;
                this.Controls.Add(customerForm1);
            }

            
            customerForm1.BringToFront();
            customerForm1.Visible = true;
        }

       

    }
}
