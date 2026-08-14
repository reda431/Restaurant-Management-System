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
    public partial class CustomerForm : UserControl
    {
        public CustomerForm()
        {
            InitializeComponent();

            displayCustomers();
        }

        public void displayCustomers()
        {
            customersList cData = new customersList();

            List<customersList> listData = cData.customerListData();

            dataGridView1.DataSource = listData;
        }
    }
}
