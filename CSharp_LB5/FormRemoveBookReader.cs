using System;
using System.Windows.Forms;

namespace CSharp_LB5
{
    public partial class FormRemoveBookReader : Form
    {
        private Library _library;
        private string _mode;
        
        internal FormRemoveBookReader(Library library, string mode)
        {
            _library = library;
            _mode = mode;
            InitializeComponent();
            if (mode == "book")
            {
                this.Text = "Видалення книги";
                label1.Text = "Книга";
                comboBox.DataSource = _library.Books;
                comboBox.DisplayMember = "name";
            }
            else
            {
                this.Text = "Видалення читача";
                label1.Text = "Читач";
                comboBox.DataSource = _library.Readers;
                comboBox.DisplayMember = "surname";
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBox.Text == String.Empty)
                MessageBox.Show("Оберіть об'єкт видалення зі списку!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult dr = MessageBox.Show("Ви точно бажаєте видалити?", "Question", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (_mode == "book")
                    {
                        foreach (var t in _library.Readers)
                        {
                            var findID = t.idBooks.Find(x => x.Equals(_library.Books[comboBox.SelectedIndex].id));
                            if (findID != null)
                            {
                                var findIndexID = t.idBooks.FindIndex(x =>
                                    x.Equals(_library.Books[comboBox.SelectedIndex].id));
                                t.idBooks.RemoveAt(findIndexID);
                                t.countBooks--;
                                break;
                            }
                        }
                        _library.Books.RemoveAt(comboBox.SelectedIndex);
                    }
                    else
                    {
                        if (_library.Readers[comboBox.SelectedIndex].countBooks > 0)
                        {
                            foreach (var t in _library.Books)
                            {
                                foreach (var t1 in _library.Readers[comboBox.SelectedIndex].idBooks)
                                {
                                    if (t.id == t1)
                                    {
                                        t.isGive = false;
                                        break;
                                    }
                                }
                            }
                        }
                        _library.Readers.RemoveAt(comboBox.SelectedIndex);
                    }
                    this.Close();
                }
            }
        }
    }
}