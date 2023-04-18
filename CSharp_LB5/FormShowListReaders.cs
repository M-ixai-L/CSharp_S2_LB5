using System.Windows.Forms;

namespace CSharp_LB5
{
    public partial class FormShowListReaders : Form
    {
        private Library _library;
        
        public bool formReadersOpen = false;
        
        private void ShowData()
        {
            dataGridViewReaders.Rows.Clear();
            for (int i = 0; i < _library.Readers.Count; i++)
                dataGridViewReaders.Rows.Add(i + 1, _library.Readers[i].surname, _library.Readers[i].name,
                    _library.Readers[i].id, _library.Readers[i].countBooks);
        }
        
        internal void UpdateDataGridView()
        {
            ShowData();
        }
        
        internal FormShowListReaders(Library library)
        {
            _library = library;
            InitializeComponent();
            formReadersOpen = true;
            ShowData();
        }
        
        private void FormShowListReaders_FormClosing(object sender, FormClosingEventArgs e)
        {
            formReadersOpen = false;
        }
    }
}