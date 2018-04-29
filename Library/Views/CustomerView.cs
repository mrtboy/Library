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
            customer = new Customer();
            customer.Name = txtName.Text;
            customer.Email = txtEmail.Text;
            customer.Phone = txtPhone.Text;
            customer.Address = txtAddress.Text;
            customerController = new CustomerController();
            bool result = customerController.AddNewCustomer(customer);

            if (result)
            {
                lblMessage.Text = "Seccessful";
            }
            else
            {
                lblAddress.Text = "Failed";
            }
        }
    }
}
