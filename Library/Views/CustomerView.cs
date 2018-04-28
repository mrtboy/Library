using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Controllers;
using Library.Models;

namespace Library
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        ICustomerController customerController;
        Customer customer;

        private void btnSave_Click(object sender, EventArgs e)
        {
            customerController = new CustomerController();
            bool result = customerController.AddNewCustomer(txtName.Text, txtAddress.Text);

            if (result)
            {
                lblMessage.Text = "Seccessful";
            }
        }
    }
}
