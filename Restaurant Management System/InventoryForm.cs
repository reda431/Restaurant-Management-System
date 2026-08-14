using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Restaurant_Management_System
{

    public partial class InventoryForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reda\Documents\restaurantsystem.mdf;Integrated Security=True;Connect Timeout=30";

        public InventoryForm()
        {
            InitializeComponent();

            displayCategories();
            displayProducts();
        }
        public void label2_Click(object sender, EventArgs e)
        {

        }

        private void displayProducts()
        {
            productList pList = new productList();
            List<productList> listData = pList.productListData();

            dataGridView1.DataSource = listData;
        }

        public void displayCategories()
        {
            inventory_category.Items.Clear();
            using(SqlConnection Connect = new SqlConnection(connection))
            {
                Connect.Open();
                string selectCat = "SELECT * FROM categories WHERE status = 'ACTIVE' ";

                using (SqlCommand cmd = new SqlCommand(selectCat, Connect)) 
                { 
                SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) 
                    {
                        inventory_category.Items.Add(reader["category"]);
                    }
                }
            }
        }
        private void inventory_addBTN_Click(object sender, EventArgs e)
        {
            if (inventory_productID.Text == "" || inventory_productName.Text == "" || inventory_category.SelectedIndex == -1 || inventory_stock.Text == "" || inventory_price.Text == "" || inventory_status.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Empty Field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {

                using (SqlConnection Connect = new SqlConnection(connection))
                {
                    Connect.Open();

                    string checkProductID = "SELECT * FROM products WHERE productid =@prodid";

                    using(SqlCommand checkProdID = new SqlCommand(checkProductID, Connect))
                    {
                        checkProdID.Parameters.AddWithValue("@prodid", inventory_productID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkProdID);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show($"{inventory_productID.Text.Trim()} exists already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else 
                        {

                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            string insertData = "INSERT INTO products (productid , productname , category , price , status , image , date_created)" +
                                                          " VALUES(@productid , @productname , @category  , @price , @status , @image , @date)";

                            string relativePath = Path.Combine("products_directory", inventory_productID.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(pictureBox1.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, Connect))
                            {

                                cmd.Parameters.AddWithValue("@productid", inventory_productID.Text.Trim());
                                cmd.Parameters.AddWithValue("@productname", inventory_productName.Text.Trim());
                                cmd.Parameters.AddWithValue("@category", inventory_category.SelectedItem.ToString());
                               // cmd.Parameters.AddWithValue("@stock", inventory_stock.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", inventory_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", inventory_status.SelectedText.ToString());
                                cmd.Parameters.AddWithValue("@image", path);

                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();


                            }
                        }
                    }

                }

            }
            displayProducts();
        }

        private void inventory_importBTN_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg ,*.png|*.jpg;*.png)";

                string imagepath = "";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imagepath = dialog.FileName;
                    pictureBox1.ImageLocation = imagepath;
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show($"ERROR:{ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void clearFields()
        {
            inventory_productID.Clear();
            inventory_productName.Clear();
            inventory_category.SelectedIndex = -1;
           // inventory_stock.Clear();
            inventory_price.Clear();
            inventory_status.SelectedIndex = -1;
            pictureBox1.Image = null;
            getID = 0;

        }

        private void inventory_clearBTN_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private int getID;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                inventory_productID.Text = row.Cells[1].Value.ToString();
                inventory_productName.Text = row.Cells[2].Value.ToString();
                inventory_category.Text = row.Cells[3].Value.ToString();
                //inventory_stock.Text = row.Cells[4].Value.ToString();
                inventory_price.Text = row.Cells[5].Value.ToString();
                inventory_status.Text = row.Cells[6].Value.ToString();

                string imagePath = row.Cells[7].Value.ToString();

                try
                {
                    if(imagePath != null) 
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                catch (Exception ex) 
                { 
                MessageBox.Show($"Error :{ex}" , "Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void inventory_updateBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to update ID {getID}?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                if (getID == 0)
                {
                    MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection Connect = new SqlConnection(connection))
                    {
                        Connect.Open();

                        string checkProductID = "SELECT * FROM products WHERE productid = @prodid ";

                        using (SqlCommand checkprod = new SqlCommand(checkProductID, Connect))
                        {
                            checkprod.Parameters.AddWithValue("@prodid", inventory_productID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkprod);
                            DataTable Table = new DataTable();

                            adapter.Fill(Table);

                            if (Table.Rows.Count >= 2)
                            {
                                MessageBox.Show(inventory_productID.Text.Trim() + "exists already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string updateData = "UPDATE products SET productid = @prodID ,productname = @productname ,category = @cat  , price = @price , status = @status, date_update = @date WHERE id = @id";

                                using (SqlCommand cmd = new SqlCommand(updateData, Connect))
                                {
                                    cmd.Parameters.AddWithValue("@prodID", inventory_productID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@productname", inventory_productName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cat", inventory_category.SelectedText.ToString());
                                   // cmd.Parameters.AddWithValue("@stock", inventory_stock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", inventory_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", inventory_status.SelectedText.ToString());

                                    DateTime today = DateTime.Now;
                                    cmd.Parameters.AddWithValue("@date", today);
                                    cmd.Parameters.AddWithValue("@id", getID);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Update Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();

                                }
                            }

                        }
                    }
                }
            }
            displayProducts();
        }

        private void inventory_deleteBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete ID {getID}?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (getID == 0)
                {
                    MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection Connect = new SqlConnection(connection))
                    {

                        Connect.Open();
                     
                        string updateData = "DELETE FROM products  WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, Connect))
                        {

                         cmd.Parameters.AddWithValue("@id", getID);

                         cmd.ExecuteNonQuery();

                         MessageBox.Show("Deleted Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         clearFields();

                        }
                    }
                }
            }
            displayProducts();
        }
    
    }
}
