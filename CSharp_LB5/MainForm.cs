using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_LB5
{
    public partial class MainForm : Form
    {
        private Library library = new Library();

        private Functions functions;
        public MainForm()
        {
            library = functions.ReadLibrary();
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви дійсно бажаєте завершити роботу?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                functions.WriteJSON(library);
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
    }
}