using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_LB5
{
    public partial class MainForm : Form
    {
        private Library mainLibrary = new Library();
        
        private FormShowListBooks formShowListBooks;
        private FormShowListReaders formShowListReaders;

        private Functions functions;

        private void AllUpdate()
        {
            if (formShowListBooks != null)
            {
                if (formShowListBooks.formBooksOpen)
                {
                    ThreadStart threadStartUpdateDataGridView = new ThreadStart(formShowListBooks.UpdateDataGridView);
                    Thread threadUpdateDataGridView = new Thread(threadStartUpdateDataGridView);
                    threadUpdateDataGridView.Start();
                }
            }
            if (formShowListReaders != null)
            {
                if (formShowListReaders.formReadersOpen)
                {
                    ThreadStart threadStartUpdateDataGridView = new ThreadStart(formShowListReaders.UpdateDataGridView);
                    Thread threadUpdateDataGridView = new Thread(threadStartUpdateDataGridView);
                    threadUpdateDataGridView.Start();
                }
            }
            ThreadStart threadStartWriteJSON = new ThreadStart(functions.WriteJSON);
            Thread threadWriteJSON = new Thread(threadStartWriteJSON);
            threadWriteJSON.Start();
        }
        
        public MainForm()
        {
            functions = new Functions(mainLibrary);
            mainLibrary = functions.ReadLibrary();
            InitializeComponent();
            if (mainLibrary.Books.Count != 0)
            {
                buttonGiveReaderBook.Enabled = true;
                buttonListBooks.Enabled = true;
                buttonRemoveBook.Enabled = true;
            }

            if (mainLibrary.Readers.Count != 0)
            {
                buttonListReaders.Enabled = true;
                buttonRemoveReader.Enabled = true;
            }

            for (int i = 0; i < mainLibrary.Readers.Count; i++)
            {
                if (mainLibrary.Readers[i].countBooks > 0)
                {
                    buttonReturnBook.Enabled = true;
                    break;
                }
            }
        }

        private void buttonListBooks_Click(object sender, EventArgs e)
        {
            formShowListBooks = new FormShowListBooks(mainLibrary);
            formShowListBooks.Show();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook(mainLibrary); 
            formAddBook.ShowDialog();
            if (mainLibrary.Books.Count != 0)
            {
                buttonGiveReaderBook.Enabled = true;
                buttonListBooks.Enabled = true;
                buttonRemoveBook.Enabled = true;
            }

            AllUpdate();
        }

        private void buttonGiveReaderBook_Click(object sender, EventArgs e)
        {
            FormGiveReaderBook formGiveReaderBook = new FormGiveReaderBook(mainLibrary);
            formGiveReaderBook.ShowDialog();
            for (int i = 0; i < mainLibrary.Readers.Count; i++)
            {
                if (mainLibrary.Readers[i].countBooks > 0)
                {
                    buttonReturnBook.Enabled = true;
                    break;
                }
            }

            if (mainLibrary.Readers.Count > 0)
            {
                buttonListReaders.Enabled = true;
                buttonRemoveReader.Enabled = true;
            }
            
            AllUpdate();
        }

        private void buttonListReaders_Click(object sender, EventArgs e)
        {
            formShowListReaders = new FormShowListReaders(mainLibrary);
            formShowListReaders.Show();
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            FormReturnBook formReturnBook = new FormReturnBook(mainLibrary);
            formReturnBook.ShowDialog();
            AllUpdate();

            bool findGetBook = false;
            for (int i = 0; i < mainLibrary.Readers.Count; i++)
            {
                if (mainLibrary.Readers[i].countBooks > 0)
                {
                    findGetBook = true;
                    break;
                }
            }

            if (!findGetBook)
                buttonReturnBook.Enabled = false;
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви дійсно бажаєте завершити роботу?", "Warning!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                functions.WriteJSON();
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void buttonRemoveReader_Click(object sender, EventArgs e)
        {
            FormRemoveBookReader formRemoveReader = new FormRemoveBookReader(mainLibrary, "reader");
            formRemoveReader.ShowDialog();
            AllUpdate();
            if (mainLibrary.Readers.Count == 0)
            {
                buttonRemoveReader.Enabled = false;
                buttonListReaders.Enabled = false;
                buttonReturnBook.Enabled = false;
                if (formShowListReaders.formReadersOpen)
                    formShowListReaders.Close();
            }
        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            FormRemoveBookReader formRemoveBook = new FormRemoveBookReader(mainLibrary, "book");
            formRemoveBook.ShowDialog();
            AllUpdate();
            if (mainLibrary.Books.Count == 0)
            {
                buttonRemoveBook.Enabled = false;
                buttonListBooks.Enabled = false;
                buttonReturnBook.Enabled = false;
                buttonGiveReaderBook.Enabled = false;
                if (formShowListBooks.formBooksOpen)
                    formShowListBooks.Close();
            }
        }
    }
}
