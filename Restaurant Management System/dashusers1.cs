using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class dashusers1 : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reda\Documents\restaurantsystem.mdf;Integrated Security=True;Connect Timeout=30";

        public SqlConnection Connection { get; private set; }

        public dashusers1()
        {
            InitializeComponent();
            displayUsers();
        }
        private void displayUsers()
        {
            UList uList = new UList();
            List<UList> listData = uList.UListData();

            dataGridView2.DataSource = null;

            dataGridView2.DataSource = listData;

            if (dataGridView2.Columns["Password"] != null)
            {
                dataGridView2.Columns["Password"].Visible = false;
            }

            if (dataGridView2.Columns["Username"] != null)
            {
                dataGridView2.Columns["Username"].HeaderText = "User Name";
            }

            if (dataGridView2.Columns["Status"] != null)
            {
                dataGridView2.Columns["Status"].HeaderText = " Status";
            }

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public class UList
        {
            public int ID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Status { get; set; }


            public List<UList> UListData()
            {
                List<UList> list = new List<UList>();


                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reda\Documents\restaurantsystem.mdf;Integrated Security=True;Connect Timeout=30";

                string query = "SELECT id, username, password, status FROM users";

                using (SqlConnection connect = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        try
                        {
                            connect.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    UList user = new UList();

                                    user.ID = reader.GetInt32(reader.GetOrdinal("id"));
                                    user.Username = reader.GetString(reader.GetOrdinal("username")).Trim();
                                    user.Password = reader.GetString(reader.GetOrdinal("password")).Trim();
                                    user.Status = reader.GetString(reader.GetOrdinal("status")).Trim();

                                    list.Add(user);
                                }
                            }
                        }
                        catch (SqlException ex)
                        {

                            System.Windows.Forms.MessageBox.Show("Error loading users: " + ex.Message);
                        }
                    }
                }

                return list;
            }
        }

        private void User_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            User_Name.Clear();
            User_password.Clear();
            User_confirmpassword.Clear();
            user_status.SelectedIndex = -1;
        }


        private void User_addBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User_Name.Text) ||
                string.IsNullOrWhiteSpace(User_password.Text) ||
                string.IsNullOrWhiteSpace(User_confirmpassword.Text) ||
                user_status.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (User_password.Text.Trim() != User_confirmpassword.Text.Trim())
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO users (username, password, status) VALUES (@usern, @pass, @status)";
            
            if (Connection == null)
            {
                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reda\Documents\restaurantsystem.mdf;Integrated Security=True;Connect Timeout=30";

                Connection = new SqlConnection(connection);
            }

            using (SqlCommand cmd = new SqlCommand(query, Connection))
            {
                cmd.Parameters.AddWithValue("@usern", User_Name.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", User_password.Text.Trim());
                cmd.Parameters.AddWithValue("@status", user_status.SelectedItem.ToString());

                try
                {
                    if (Connection.State == ConnectionState.Closed)
                    {
                        Connection.Open();
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear_Click(sender, e);
                        displayUsers();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }
        }

        private void User_updateBTN_Click(object sender, EventArgs e)
        {

        }


    }

}
