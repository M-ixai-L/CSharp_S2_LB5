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
            this.SuspendLayout();
            // 
            // buttonListBooks
            // 
            this.buttonListBooks.Enabled = false;
            this.buttonListBooks.Location = new System.Drawing.Point(165, 179);
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
            this.buttonGiveReaderBook.Location = new System.Drawing.Point(438, 75);
            this.buttonGiveReaderBook.Name = "buttonGiveReaderBook";
            this.buttonGiveReaderBook.Size = new System.Drawing.Size(177, 98);
            this.buttonGiveReaderBook.TabIndex = 2;
            this.buttonGiveReaderBook.Text = "Видати книгу";
            this.buttonGiveReaderBook.UseVisualStyleBackColor = true;
            this.buttonGiveReaderBook.Click += new System.EventHandler(this.buttonGiveReaderBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(72, 75);
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
            this.buttonListReaders.Location = new System.Drawing.Point(348, 179);
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
            this.buttonReturnBook.Location = new System.Drawing.Point(255, 75);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(177, 98);
            this.buttonReturnBook.TabIndex = 1;
            this.buttonReturnBook.Text = "Повернути книгу";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 361);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.buttonListReaders);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonGiveReaderBook);
            this.Controls.Add(this.buttonListBooks);
            this.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(715, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(715, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бібліотека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonReturnBook;

        private System.Windows.Forms.Button buttonListReaders;

        private System.Windows.Forms.Button buttonAddBook;

        private System.Windows.Forms.Button buttonGiveReaderBook;

        private System.Windows.Forms.Button buttonListBooks;

        #endregion
    }
}