namespace CSharp_LB5
{
    partial class MainForm
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
            this.buttonListBooks = new System.Windows.Forms.Button();
            this.buttonGiveReaderBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonListReaders = new System.Windows.Forms.Button();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.buttonRemoveReader = new System.Windows.Forms.Button();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListBooks
            // 
            this.buttonListBooks.Enabled = false;
            this.buttonListBooks.Location = new System.Drawing.Point(172, 181);
            this.buttonListBooks.Name = "buttonListBooks";
            this.buttonListBooks.Size = new System.Drawing.Size(177, 98);
            this.buttonListBooks.TabIndex = 3;
            this.buttonListBooks.Text = "Список книг";
            this.buttonListBooks.UseVisualStyleBackColor = true;
            this.buttonListBooks.Click += new System.EventHandler(this.buttonListBooks_Click);
            // 
            // buttonGiveReaderBook
            // 
            this.buttonGiveReaderBook.Enabled = false;
            this.buttonGiveReaderBook.Location = new System.Drawing.Point(445, 77);
            this.buttonGiveReaderBook.Name = "buttonGiveReaderBook";
            this.buttonGiveReaderBook.Size = new System.Drawing.Size(177, 98);
            this.buttonGiveReaderBook.TabIndex = 2;
            this.buttonGiveReaderBook.Text = "Видати книгу";
            this.buttonGiveReaderBook.UseVisualStyleBackColor = true;
            this.buttonGiveReaderBook.Click += new System.EventHandler(this.buttonGiveReaderBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(79, 77);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(177, 98);
            this.buttonAddBook.TabIndex = 0;
            this.buttonAddBook.Text = "Додати книгу";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonListReaders
            // 
            this.buttonListReaders.Enabled = false;
            this.buttonListReaders.Location = new System.Drawing.Point(355, 181);
            this.buttonListReaders.Name = "buttonListReaders";
            this.buttonListReaders.Size = new System.Drawing.Size(177, 98);
            this.buttonListReaders.TabIndex = 4;
            this.buttonListReaders.Text = "Список читачів";
            this.buttonListReaders.UseVisualStyleBackColor = true;
            this.buttonListReaders.Click += new System.EventHandler(this.buttonListReaders_Click);
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Enabled = false;
            this.buttonReturnBook.Location = new System.Drawing.Point(262, 77);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(177, 98);
            this.buttonReturnBook.TabIndex = 1;
            this.buttonReturnBook.Text = "Повернути книгу";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // buttonRemoveReader
            // 
            this.buttonRemoveReader.Enabled = false;
            this.buttonRemoveReader.Location = new System.Drawing.Point(172, 285);
            this.buttonRemoveReader.Name = "buttonRemoveReader";
            this.buttonRemoveReader.Size = new System.Drawing.Size(177, 98);
            this.buttonRemoveReader.TabIndex = 5;
            this.buttonRemoveReader.Text = "Видалити читача";
            this.buttonRemoveReader.UseVisualStyleBackColor = true;
            this.buttonRemoveReader.Click += new System.EventHandler(this.buttonRemoveReader_Click);
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Enabled = false;
            this.buttonRemoveBook.Location = new System.Drawing.Point(355, 285);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(177, 98);
            this.buttonRemoveBook.TabIndex = 6;
            this.buttonRemoveBook.Text = "Видалити книгу";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 446);
            this.Controls.Add(this.buttonRemoveBook);
            this.Controls.Add(this.buttonRemoveReader);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.buttonListReaders);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonGiveReaderBook);
            this.Controls.Add(this.buttonListBooks);
            this.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(715, 485);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(715, 485);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бібліотека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonRemoveReader;
        private System.Windows.Forms.Button buttonRemoveBook;

        private System.Windows.Forms.Button buttonReturnBook;

        private System.Windows.Forms.Button buttonListReaders;

        private System.Windows.Forms.Button buttonAddBook;

        private System.Windows.Forms.Button buttonGiveReaderBook;

        private System.Windows.Forms.Button buttonListBooks;

        #endregion
    }
}