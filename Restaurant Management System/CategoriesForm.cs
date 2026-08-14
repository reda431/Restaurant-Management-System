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
    public partial class CategoriesForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reda\Documents\restaurantsystem.mdf;Integrated Security=True;Connect Timeout=30";

        public CategoriesForm()
        {
            InitializeComponent();
            displaycategories();
        }

        private void Categories_addBtn_Click(object sender, EventArgs e)
        {
            if (Categories_category.Text == "" || Categories_status.SelectedIndex == -1) 
            {
                MessageBox.Show( "Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                using (SqlConnection Connect = new SqlConnection(connection))
                {
                    Connect.Open();

                    string selectCategory = " Select * FROM categories WHERE category = @cat";

                    using (SqlCommand checkCat = new SqlCommand(selectCategory, Connect))
                    {
                        checkCat.Parameters.AddWithValue("@cat", Categories_category.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkCat);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(Categories_category.Text.Trim() + "is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            string insertData = "INSERT INTO categories(category ,status ,date_created) VALUES(@cat ,@status,@date)";
                            using (SqlCommand cmd = new SqlCommand(insertData, Connect))
                            {
                                cmd.Parameters.AddWithValue("@cat", Categories_category.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", Categories_status.SelectedItem.ToString());
                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();

                                
                            }
                        }
                    }
                }
            }

            displaycategories();
        }
        void clearFields() 
        {
            Categories_category.Clear();
            Categories_status.SelectedIndex = -1;
            getID = 0;
        }

        private void Categories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void displaycategories()
        {
           categorieslist cData = new categorieslist();
            List<categorieslist> listDta = cData.categoriesListData();
            dataGridView1.DataSource = listDta;
        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                Categories_category.Text = row.Cells[1].Value.ToString();
                Categories_status.Text = row.Cells[2].Value.ToString();

            }


        }

        private void Categories_updateBtn_Click(object sender, EventArgs e)
        {
            if(getID == 0)
            {
                MessageBox.Show("Select Category First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show($"Are you sure you want to update this ID:{getID}?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    using (SqlConnection Connect = new SqlConnection(connection))
                    {
                        Connect.Open();

                        string updateData = "UPDATE categories SET category = @cat, status = @status, WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(updateData,Connect)) 
                        { 
                            cmd.Parameters.AddWithValue("@ID", getID);
                            cmd.Parameters.AddWithValue("@cat", Categories_category.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", Categories_status.SelectedItem.ToString());

                            cmd.ExecuteNonQuery();
                            clearFields();
                            displaycategories();

                            MessageBox.Show("Update Successfully", "Informationm Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        Connect.Close();
                    }
                }
            }
            displaycategories();
        }

        private void Categories_deleteBtn_Click(object sender, EventArgs e)
        {
            if (getID == 0)
            {
                MessageBox.Show("Select Category First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to delete this ID:{getID}?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection Connect = new SqlConnection(connection))
                    {
                        Connect.Open();

                        string updateData = "DELETE FROM categories  WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(updateData, Connect))
                        {
                            cmd.Parameters.AddWithValue("@ID", getID);
                            

                            cmd.ExecuteNonQuery();
                            clearFields();
                            displaycategories();

                            MessageBox.Show("Update Successfully", "Informationm Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        Connect.Close();
                    }
                }
            }
            displaycategories();
        }
    
    }
}
