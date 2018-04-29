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

namespace Library.Views
{
    public partial class BorrowBook : Form
    {
        IBorrowController BorrowController;
        IBookController bookController;
        public BorrowBook()
        {
            InitializeComponent();
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            bookController = new BookController();
            DataSet books = bookController.ShowBooks();
            DataTable tb = books.Tables[0];
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                string theValue = tb.Rows[i].ItemArray[1].ToString();

                cmbbox_Book.Items.Add(theValue);
            }
            cmbbox_member.Items.Add("55");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BorrowController = new BorrowController();

            int CId = Convert.ToInt32(cmbbox_Book.Text);
            int BId = Convert.ToInt32(cmbbox_member.Text);
            bool result = BorrowController.borrowBook(CId,BId,DateTime.Now,DateTime.Now);
            if (result)
            {
                lblMessage.Text = String.Format("The Book is borrowd.");
            }
            else
            {
               lblMessage.Text = "Failed";
            }
        } 
    }
}
