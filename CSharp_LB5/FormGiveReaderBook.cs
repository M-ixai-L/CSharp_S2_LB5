using System;
using System.Windows.Forms;

namespace CSharp_LB5
{
    public partial class FormGiveReaderBook : Form
    {
        private Library _library;

        private void saveNewPerson()
        {
            Person newReader = new Person();
            newReader.surname = textBoxSurname.Text;
            newReader.name = textBoxName.Text;
            newReader.id = comboBoxID.Text;
            newReader.countBooks++;
            newReader.idBooks.Add(_library.Books[comboBoxBooks.SelectedIndex].id);
            newReader.dateTimeGetBooks.Add(DateTime.Now);
            _library.Readers.Add(newReader);
            _library.Books[comboBoxBooks.SelectedIndex].isGive = true;
            this.Close();
        }
        
        internal FormGiveReaderBook(Library library)
        {
            _library = library;
            InitializeComponent();
            comboBoxID.Items.Add("");
            for (int i = 0; i < _library.Readers.Count; i++)
                comboBoxID.Items.Add(_library.Readers[i].id);
            for (int i = 0; i < _library.Books.Count; i++)
                comboBoxBooks.Items.Add(_library.Books[i].name + " " + _library.Books[i].author + " " +
                                        _library.Books[i].id);
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxID.SelectedIndex == 0)
            {
                textBoxSurname.Enabled = true;
                textBoxSurname.Text = String.Empty;
                textBoxName.Enabled = true;
                textBoxName.Text = String.Empty;
            }
            else
            {
                textBoxSurname.Enabled = false;
                textBoxSurname.Text = _library.Readers[comboBoxID.SelectedIndex - 1].surname;
                textBoxName.Enabled = false;
                textBoxName.Text = _library.Readers[comboBoxID.SelectedIndex - 1].name;
            }
        }

        private void comboBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBooks.SelectedIndex != -1)
            {
                if (_library.Books[comboBoxBooks.SelectedIndex].isGive)
                {
                    MessageBox.Show("Ця книга вже видана!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBoxBooks.SelectedIndex = -1;
                }
            }
        }

        private void buttonGive_Click(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == String.Empty || textBoxName.Text == String.Empty ||
                comboBoxID.Text == String.Empty || comboBoxBooks.Text == String.Empty)
                MessageBox.Show("Недостатньо інформації!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (_library.Readers.Count != 0)
                {
                    Person findPerson = _library.Readers.Find(x => x.id.Equals(comboBoxID.Text));
                    if (findPerson != null)
                    {
                        if (findPerson.surname != textBoxSurname.Text || findPerson.name != textBoxName.Text)
                            MessageBox.Show("Людина з таким читатським номером вже записана!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (findPerson.countBooks == 2)
                            MessageBox.Show("В цього читача вже дві книги, це ліміт!", "Error!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        else
                        {
                            _library.Readers[comboBoxID.SelectedIndex - 1].countBooks++;
                            _library.Readers[comboBoxID.SelectedIndex - 1].idBooks
                                .Add(_library.Books[comboBoxBooks.SelectedIndex].id);
                            _library.Readers[comboBoxID.SelectedIndex - 1].dateTimeGetBooks.Add(DateTime.Now);
                            _library.Books[comboBoxBooks.SelectedIndex].isGive = true;
                            this.Close();
                        }
                    }
                    else
                        saveNewPerson();
                }
                else
                    saveNewPerson();
            }
        }
    }
}