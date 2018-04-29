using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Controllers;

namespace Library
{
    public partial class AddNewBook : Form
    {
        IBookController bookController;
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book newBook = new Book();
            newBook.Name = txtName.Text;
            newBook.Isbn = txtIsbn.Text;
            newBook.Author = txtAuthor.Text;
            newBook.Publisher = txtPublisher.Text;
            newBook.Edition = Convert.ToInt16(txtEdition.Text);
            newBook.BookShell = txtBookShell.Text;
            newBook.RowNo = Convert.ToInt16(txtRowNo.Text);
            newBook.ColumnNo = Convert.ToInt16(txtColumnNo.Text);

            bookController = new BookController();
            bookController.AddNewBook(newBook);
        }
    }
}
