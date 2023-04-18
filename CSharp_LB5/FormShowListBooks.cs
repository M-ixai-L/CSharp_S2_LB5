using System;
using System.Windows.Forms;

namespace CSharp_LB5
{
    public partial class FormShowListBooks : Form
    {
        private Library library;

        public bool formBooksOpen = false;

        private void ShowData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < library.Books.Count; i++)
            {
                String signAccess = String.Empty;
                if (library.Books[i].isGive)
                    signAccess = "-";
                else
                    signAccess = "+";
                dataGridView1.Rows.Add(i + 1, library.Books[i].name, library.Books[i].author,
                    library.Books[i].countPages, library.Books[i].id, signAccess);
            }
        }

        internal FormShowListBooks(Library library)
        {
            formBooksOpen = true;
            this.library = library;
            InitializeComponent();
            ShowData();
        }

        internal void UpdateDataGridView()
        {
            ShowData();
        }

        private void FormShowListBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            formBooksOpen = false;
        }
    }
}