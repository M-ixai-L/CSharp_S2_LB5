using System.Windows.Forms;

namespace CSharp_LB5
{
    public partial class FormShowListBooks : Form
    {
        private Library library;

        public bool formOpen = false;
        private void ShowData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < library.Books.Count; i++)
                dataGridView1.Rows.Add(i + 1, library.Books[i].name, library.Books[i].author,
                    library.Books[i].countPages, library.Books[i].id);
        }
        internal FormShowListBooks(Library library)
        {
            formOpen = true;
            this.library = library;
            InitializeComponent();
            ShowData();
        }

        internal void UpdateDataGridView()
        {
            //this.library = library;
            ShowData();
        }
        private void FormShowListBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            formOpen = false;
        }
    }
}