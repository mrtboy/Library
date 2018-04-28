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
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnShowAllBooks = new System.Windows.Forms.Button();
            this.btnRegisteCustomer = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddNewBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewBook.Location = new System.Drawing.Point(116, 47);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(126, 110);
            this.btnAddNewBook.TabIndex = 0;
            this.btnAddNewBook.Text = "Add New Book";
            this.btnAddNewBook.UseVisualStyleBackColor = false;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchBook.Location = new System.Drawing.Point(324, 47);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(126, 110);
            this.btnSearchBook.TabIndex = 1;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnShowAllBooks
            // 
            this.btnShowAllBooks.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShowAllBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowAllBooks.Location = new System.Drawing.Point(547, 47);
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
            this.btnRegisteCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisteCustomer.Location = new System.Drawing.Point(116, 233);
            this.btnRegisteCustomer.Name = "btnRegisteCustomer";
            this.btnRegisteCustomer.Size = new System.Drawing.Size(126, 110);
            this.btnRegisteCustomer.TabIndex = 3;
            this.btnRegisteCustomer.Text = "Register Costumer";
            this.btnRegisteCustomer.UseVisualStyleBackColor = false;
            this.btnRegisteCustomer.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(324, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 110);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(547, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 110);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnRegisteCustomer);
            this.Controls.Add(this.btnShowAllBooks);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.btnAddNewBook);
            this.Name = "Library";
            this.Text = "Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnShowAllBooks;
        private System.Windows.Forms.Button btnRegisteCustomer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;

        

    }
}

