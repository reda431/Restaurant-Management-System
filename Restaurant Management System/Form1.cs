using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    public partial class Form1 : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reda\Documents\restaurantsystem.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to close this app?","Confirmation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            using(SqlConnection Connect = new SqlConnection(connection))
            {
            Connect.Open();

                string query = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(query, Connect))
                {
                    cmd.Parameters.AddWithValue("@usern", Login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", Login_password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        string userStatus = table.Rows[0]["status"].ToString();

                       
                        Form targetForm;

                        switch (userStatus)
                        {
                            case "Admin":
                                targetForm = new Mainform(); 
                                targetForm.Show();
                                break;

                           /* case "Manager":
                                targetForm = new Mainform();
                                targetForm.Show();
                                break;*/

                            case "employee":
                                targetForm = new employeedash();
                                targetForm.Show();
                                break;

                           /* case "Suspended":
                                MessageBox.Show("Account suspended", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;*/

                        }

                     
                      
                        this.Hide();
                    }
                    else 
                    {
                        MessageBox.Show("Incorrect username or password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            Login_password.PasswordChar = login_showpassword.Checked ? '\0' : '*';
        }
    }
}
