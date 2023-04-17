using System;
using System.Windows.Forms;

namespace CSharp_LB5
{
    public partial class FormAddBook : Form
    {
        private Library _library;
        internal FormAddBook(Library library)
        {
            _library = library;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxBookName.Text == String.Empty || textBoxAuthor.Text == String.Empty
                || numericUpDownCountPages.Value == 0 || textBoxId.Text == String.Empty)
                MessageBox.Show("Недостатньо інформації!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool checkFormatId = true;
                for (int i = 0; i < textBoxId.Text.Length; i++)
                {
                    if (textBoxId.Text[i] >= '0' && textBoxId.Text[i] <= '9')
                        continue;
                    else
                    {
                        MessageBox.Show("Невірний формат номера!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkFormatId = false;
                        break;
                    }
                }

                if (checkFormatId)
                {
                    Book checkIdRepeat = _library.Books.Find(x => x.id.Equals(textBoxId.Text));
                    if (checkIdRepeat != null)
                        MessageBox.Show("Книга з цим номером вже записана!", "Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    else
                    {
                        Book newBook = new Book();
                        newBook.name = textBoxBookName.Text;
                        newBook.author = textBoxAuthor.Text;
                        newBook.countPages = Convert.ToInt32(Math.Round(numericUpDownCountPages.Value, 0));
                        newBook.id = textBoxId.Text;
                        _library.Books.Add(newBook);
                        this.Close();
                    }
                }
            }
        }
    }
}