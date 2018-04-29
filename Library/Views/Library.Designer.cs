using Library.Controllers;

namespace Library
{
    partial class Library
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnShowAllBooks = new System.Windows.Forms.Button();
            this.btnRegisteCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewBook.Location = new System.Drawing.Point(235, 181);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(126, 110);
            this.btnAddNewBook.TabIndex = 0;
            this.btnAddNewBook.Text = "Add New Book";
            this.btnAddNewBook.UseVisualStyleBackColor = false;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnShowAllBooks
            // 
            this.btnShowAllBooks.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShowAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowAllBooks.Location = new System.Drawing.Point(557, 181);
            this.btnShowAllBooks.Name = "btnShowAllBooks";
            this.btnShowAllBooks.Size = new System.Drawing.Size(126, 110);
            this.btnShowAllBooks.TabIndex = 2;
            this.btnShowAllBooks.Text = "Show All Books";
            this.btnShowAllBooks.UseVisualStyleBackColor = false;
            this.btnShowAllBooks.Click += new System.EventHandler(this.btnShowAllBooks_Click);
            // 
            // btnRegisteCustomer
            // 
            this.btnRegisteCustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegisteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisteCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisteCustomer.Location = new System.Drawing.Point(79, 181);
            this.btnRegisteCustomer.Name = "btnRegisteCustomer";
            this.btnRegisteCustomer.Size = new System.Drawing.Size(126, 110);
            this.btnRegisteCustomer.TabIndex = 3;
            this.btnRegisteCustomer.Text = "Register customer";
            this.btnRegisteCustomer.UseVisualStyleBackColor = false;
            this.btnRegisteCustomer.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(146, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Public Bookstore";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(718, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 110);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Borrow.Location = new System.Drawing.Point(396, 181);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Size = new System.Drawing.Size(126, 110);
            this.btn_Borrow.TabIndex = 6;
            this.btn_Borrow.Text = "Borrow Book";
            this.btn_Borrow.UseVisualStyleBackColor = false;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.btn_Borrow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisteCustomer);
            this.Controls.Add(this.btnShowAllBooks);
            this.Controls.Add(this.btnAddNewBook);
            this.Name = "Library";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnShowAllBooks;
        private System.Windows.Forms.Button btnRegisteCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Borrow;
    }
}

