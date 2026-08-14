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
    public partial class employeedash : Form
    {
        public employeedash()
        {
            InitializeComponent();
        }

        private void Shop_btn_Click(object sender, EventArgs e)
        {
           
            if (shopform1 == null)
            {
                
                shopform1 = new Shopform();
                shopform1.Dock = DockStyle.Fill;
                this.Controls.Add(shopform1);
            }

            
            shopform1.BringToFront();
            shopform1.Visible = true;
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want Logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 LoginForm = new Form1();
                LoginForm.Show();

                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to close this app?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
