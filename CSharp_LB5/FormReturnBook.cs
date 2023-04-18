using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_LB5
{
    public partial class FormReturnBook : Form
    {
        private Library _library;
        internal FormReturnBook(Library library)
        {
            _library = library;
            InitializeComponent();
            for (int i = 0; i < _library.Readers.Count; i++)
                comboBoxReaders.Items.Add(_library.Readers[i].surname + " " + _library.Readers[i].id);
        }

        private void comboBoxReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_library.Readers[comboBoxReaders.SelectedIndex].countBooks == 0)
                MessageBox.Show("В цього читача немає книг з нашої бібліотеки!", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                comboBoxBooks.Items.Clear();
                for (var i = 0; i < _library.Readers[comboBoxReaders.SelectedIndex].countBooks; i++)
                {
                    foreach (var tempStr in from t in _library.Books 
                             where t.id == _library.Readers[comboBoxReaders.SelectedIndex].idBooks[i] 
                             select t.name + " " + t.author + " " + t.id)
                    {
                        comboBoxBooks.Items.Add(tempStr);
                        break;
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (comboBoxReaders.Text == String.Empty || comboBoxBooks.Text == String.Empty)
                MessageBox.Show("Недостатньо інформації!", "Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int index = _library.Books.FindIndex(i =>
                    i.id == _library.Readers[comboBoxReaders.SelectedIndex].idBooks[comboBoxBooks.SelectedIndex]);
                
                _library.Readers[comboBoxReaders.SelectedIndex].countBooks--;
                _library.Readers[comboBoxReaders.SelectedIndex].idBooks.RemoveAt(comboBoxBooks.SelectedIndex);
                //повідомлення про час перебування книги в читача

                _library.Books[index].isGive = false;
                this.Close();
            }
        }
    }
}