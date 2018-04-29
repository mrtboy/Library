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
    public partial class ShowAllBooks : Form
    {
        IBookController bookController;
        public ShowAllBooks()
        {
            InitializeComponent();
        }

        private void ShowAllBooks_Load(object sender, EventArgs e)
        {

            bookController = new BookController();
            DataSet books = bookController.ShowBooks();
            dataGrid_Showbooks.DataSource = books.Tables[0];
            

            
        }
    }
}
