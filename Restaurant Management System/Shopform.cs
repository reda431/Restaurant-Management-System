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
using System.IO;


namespace Restaurant_Management_System
{
    public partial class Shopform : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reda\Documents\restaurantsystem.mdf;Integrated Security=True;Connect Timeout=30";

        public Shopform()
        {
            InitializeComponent();
            loadproducts();
        }


        public void carditems(int id , string productname , string price , string stock ,Image image , string productid , string category ,string quantity)
        {
            var card = new cardProduct
            {
                id = id,
                productName = productname,
                productID = productid,
                category = category,
                //productStock = stock,
                productPrice = price,
                productImage = image,
                productQuantity = quantity

            };

            flowLayoutPanel1.Controls.Add(card);

            card.selectCard += (q, w) =>
            {
                var selectedCard = (cardProduct)q;
                bool flag = false;

                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["id"].Value != null && (int)row.Cells["id"].Value == selectedCard.id)
                    {
                        int getPrice = Convert.ToInt32(selectedCard.productPrice.Replace("0",""));
                        int getQuantity = Convert.ToInt32(selectedCard.productQuantity);

                        row.Cells["Price"].Value = getPrice * getQuantity;
                        row.Cells["QTY"].Value = selectedCard.productQuantity;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    int getPrice = Convert.ToInt32(selectedCard.productPrice.Replace("0", ""));
                    int getQuantity = Convert.ToInt32(selectedCard.productQuantity);

                    dataGridView1.Rows.Add(selectedCard.id, selectedCard.productName, getQuantity , getPrice * getQuantity);

                }
                updateTotalprice();
            };
        }

        private void updateTotalprice()
        {
            int totalprice = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells["id"].Value != null)
                {
                    int price = Convert.ToInt32(row.Cells["Price"].Value);

                    totalprice += price;
                }
            }

            shop_total.Text = $"{totalprice:F2}";

        }

        public void loadproducts()
        {
            try
            {
                using (SqlConnection Connect = new SqlConnection(connection))
                {
                    Connect.Open();

                    string selectData = "SELECT * FROM products ";

                    using (SqlCommand cmd = new SqlCommand(selectData, Connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        flowLayoutPanel1.Controls.Clear();

                        foreach (DataRow row in table.Rows) 
                        { 
                        
                            int id = row["id"] != DBNull.Value ? (int)row["id"] : 0;
                            string productname = row["productname"] != DBNull.Value ? (string)row["productname"].ToString() : "N/A";
                            string stock = row["stock"] != DBNull.Value ? (string)row["stock"].ToString() : "0";
                            string price = row["price"] != DBNull.Value ? (string)row["price"].ToString() : "0";
                           
                            string productid = row["productid"] != DBNull.Value ? (string)row["productid"].ToString() : "N/A";
                            string category = row["category"] != DBNull.Value ? (string)row["category"].ToString() : "N/A";

                            Image image = null;

                            if (row["image"] != DBNull.Value)
                            {
                                string imagepath = row["image"].ToString();
                                if (!string.IsNullOrEmpty(imagepath) && File.Exists(imagepath))
                                {
                                    try
                                    {
                                        image = Image.FromFile(imagepath);
                                    }
                                    catch (Exception ex) 
                                    {
                                        image = null;
                                    }
                                }
                            }
                            carditems(id ,productname,price ,stock ,image ,productid ,category ,"");
                        }

                    }
                }
            }
            catch (Exception ex) 
            { 
            MessageBox.Show($"Error :{ex}" , "Error Message" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

        }

        private void shop_change_Enter(object sender, EventArgs e)
        {
            
        }
        bool check = false;

        private void shop_change_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int getTotal = Convert.ToInt32(shop_total.Text.ToString().Replace("0", ""));
                    int getChange = Convert.ToInt32(shop_change.Text);

                    if (getTotal < getChange)
                    {

                        MessageBox.Show("invalid: insuficient amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        check = true;
                        shop_amount.Text = $"{(getChange - getTotal):0}";

                    }
                    e.SuppressKeyPress = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error :{ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void shop_placeorderBTN_Click(object sender, EventArgs e)
        {
            if(! check)
            {
                MessageBox.Show("invalid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                if (MessageBox.Show("Are you sure you want to proceed", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection Connect = new SqlConnection())
                    {
                        Connect.Open();
                        string countData = "SELECT COUNT(*) FROM orders";

                        int count = 1;

                        using (SqlCommand cData = new SqlCommand(countData, Connect)) 
                        { 
                           count = Convert.ToInt32(cData.ExecuteScalar()) + 1;
                        }

                        List<String> productIds= new List<String>();
                        List<String> quantities = new List<String>();
                        List<String> prices = new List<String>();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["id"] != null && row.Cells["QTY"] != null && row.Cells["price"] != null) 
                            { 
                            
                                productIds.Add(row.Cells["id"].ToString());
                                quantities.Add(row.Cells["QTY"].ToString());
                                prices.Add(row.Cells["price"].ToString());
                            }
                        }

                        string productIdSTR = string.Join(",", productIds);
                        string quantitiesSTR = string.Join(",", quantities);
                        string pricesSTR = string.Join(",", prices);

                        int totalAmount = Convert.ToInt32(shop_total.Text.Replace("0",""));


                        string insertData = "INSERT INTO orders (customerId , productids , quantities , price ,total , date_order) VALUES(@cid , @pid ,@qty ,@price ,@total ,@date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, Connect))
                        {

                            cmd.Parameters.AddWithValue("@cid", $"@CID-{count}");
                            cmd.Parameters.AddWithValue("@pid", productIds);
                            cmd.Parameters.AddWithValue("@qty", quantities);
                            cmd.Parameters.AddWithValue("@prices", prices);
                            cmd.Parameters.AddWithValue("@total", totalAmount);


                            DateTime today = DateTime.Now;
                            cmd.Parameters.AddWithValue("@date", today);

                            int rowAffected = cmd.ExecuteNonQuery();

                            if (rowAffected > 0) 
                            {

                                for (int q = 0; q < productIds.Count; q++) 
                                {

                                    string getStockData = "SELECT stock FROM products WHERE id = @id";
                                    int currentStock = 0;

                                    using(SqlCommand getSD = new SqlCommand(getStockData, Connect))
                                    {
                                        getSD.Parameters.AddWithValue("id", productIds[q]);

                                        object result = getSD.ExecuteScalar();
                                        if (result != null) 
                                        { 
                                            currentStock = Convert.ToInt32(result);
                                        }
                                    }

                                    int newStock = currentStock - Convert.ToInt32(quantities[q]);

                                    if(newStock < 0)
                                    {
                                        MessageBox.Show($"Insufficient Stock for product ID {productIds[q]}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    string updateData = "UPDATE products SET stocks = @QTY WHERE id=@id";
                                    using(SqlCommand updateCmd = new SqlCommand(updateData,Connect))
                                    {
                                        updateCmd.Parameters.AddWithValue("@qty", newStock);
                                        updateCmd.Parameters.AddWithValue("@id", productIds[q]);

                                        updateCmd.ExecuteNonQuery();

                                    }
                                }
                                MessageBox.Show("Order placed successfully","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Order placement failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }
                    }
                }

            }

        }

        private int rowIndex = 0;
        private void shop_receiptBTN_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;

            Font font = new Font("Arial",12);
            Font bold = new Font("Arial", 12 ,FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headertext = "";
            y = (count + margin + headerMargin +headerFont.GetHeight(e.Graphics));
            e.Graphics.DrawString(headertext, headerFont, Brushes.Black, e.MarginBounds.Left + (dataGridView1.Columns.Count / 2)*colWidth,y,alignCenter);

            count++;
            y += tableMargin;

            string[] header = { "PID", "ProdName", "Qty", "Price" };

            for (int q = 0; q < header.Length; q++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[q], bold, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
            }
            count++;
            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                for (int q = 0; q < dataGridView1.Columns.Count; q++)
                {
                    object cellValue = row.Cells[q].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);


                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom) 
                { 
                    e.HasMorePages = true;
                    return;
                
                }
            }

            int labelMargin = (int)Math.Min(rSpace, 200);

            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------------",labelFont).Width;

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString($"total price: \t${shop_total.Text.Trim()}\nAmount:\t${shop_amount.Text.Trim()}\n\t\t----------\nChange: \t${shop_change.Text.Trim()}", labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black,e.MarginBounds.Right - e.Graphics.MeasureString("------------------------",labelFont).Width , y);

        }
    }
}
