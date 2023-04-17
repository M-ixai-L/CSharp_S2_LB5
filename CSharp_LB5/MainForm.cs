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
        
        FormShowListBooks formShowListBooks;

        private Functions functions;
        public MainForm()
        {
            functions = new Functions(mainLibrary);
            functions.ReadLibrary();
            InitializeComponent();
            if (mainLibrary.Books.Count != 0)
            {
                buttonGiveReaderBook.Enabled = true;
                buttonListBooks.Enabled = true;
            }

            if (mainLibrary.Readers.Count != 0)
                buttonListReaders.Enabled = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви дійсно бажаєте завершити роботу?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                functions.WriteJSON();
                e.Cancel = false;
            }
            else
                e.Cancel = true;
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
            }

            if (formShowListBooks.formOpen)
            {
                ThreadStart threadStartUpdateDataGridView = new ThreadStart(formShowListBooks.UpdateDataGridView);
                Thread threadUpdateDataGridView = new Thread(threadStartUpdateDataGridView);
                threadUpdateDataGridView.Start();
            }
            ThreadStart threadStartWriteJSON = new ThreadStart(functions.WriteJSON);
            Thread threadWriteJSON = new Thread(threadStartWriteJSON);
            threadWriteJSON.Start();
        }
    }
}