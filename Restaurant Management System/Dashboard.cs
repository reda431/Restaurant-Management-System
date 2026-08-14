using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    public partial class Dashboard : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reda\Documents\restaurantsystem.mdf;Integrated Security=True;Connect Timeout=30";
        private UserControl dashboard1;
        private UserControl shopform1;
        private UserControl inventoryForm1;
        private UserControl customerForm1;
        private UserControl categoriesForm1;
        private UserControl dashusers1;

        public Dashboard()
        {
            InitializeComponent();

            displayTotalUsers();

            displayTodaysrevenue();
        }
        public void displayTotalUsers()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM users";


                using (SqlCommand cmd = new SqlCommand(selectData , connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        dashboard_totalusers.Text = count.ToString();
                    
                    }
                }

            }
        }

        public void displayTotalProducts()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM products";


                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        dashboard_menu.Text = count.ToString();

                    }
                }

            }
        }

        public void displayTodaysrevenue()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT SUM(CAST(total as INT)) FROM orders WHERE date_order =@date";


                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    DateTime today = DateTime.Now;
                    string gettoday = today.ToString("dd-MM-yyyy");

                    cmd.Parameters.AddWithValue("@date", gettoday);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader[0] != DBNull.Value)
                        {
                            int revenue = Convert.ToInt32(reader[0]);
                            dashboard_todaysrevenue.Text = revenue.ToString("0");
                        }
                        else
                        {
                            dashboard_todaysrevenue.Text = "0";
                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
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





    }
}
