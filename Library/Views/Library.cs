using Library.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBook= new AddNewBook();
            this.Hide();
            addNewBook.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            this.Hide();
            customerView.ShowDialog();
            this.Show();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            this.Hide();
            searchBook.ShowDialog();
            this.Show();
        }

        private void btnShowAllBooks_Click(object sender, EventArgs e)
        {
            ShowAllBooks showAllbooks = new ShowAllBooks();
            this.Hide();
            showAllbooks.ShowDialog();
            this.Show();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            BorrowBook showAllbooks = new BorrowBook();
            this.Hide();
            showAllbooks.ShowDialog();
            this.Show();
        }
    }
}
