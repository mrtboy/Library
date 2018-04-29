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

namespace Library
{
    public partial class SearchBook : Form
    {
        IBookController bookController;
        public SearchBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {          
            bookController = new BookController();
            DataSet books = bookController.SearchBook(txtSearch.Text);
            gridSearch.DataSource = books.Tables[0];
        }
    }
}
