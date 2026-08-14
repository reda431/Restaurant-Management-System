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
    public partial class cardProduct : UserControl
    {
        public cardProduct()
        {
            InitializeComponent();
        }

        public int id {  set; get; }
        public string productID { set; get; }
        public string productName{
            get 
            { 
            return productname.Text;
            }
            set
            {
                productname.Text = value;
            }
            
        }
        public string category {set; get;  }
       
         public string productPrice
         {
             get
             {
                 return price.Text;
             }
             set
             {
                 price.Text = value;
             }
         }

      
        public Image productImage
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public string productQuantity
        {
            get
            {
                return quantity.Text;
            }
            set
            {
                quantity.Text = value;
            }
        }

        public event EventHandler selectCard = null;
        private void add_BTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(quantity.Text))
            {
                MessageBox.Show("Please enter a quantity before adding the product.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                quantity.Focus(); 
                return; 
            }

            
            if (int.TryParse(quantity.Text, out int QTY) && QTY > 0)
            {
                selectCard?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Please enter a valid number greater than 0.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantity.Clear();
                quantity.Focus();
                return;
            }
        }


    }
}
