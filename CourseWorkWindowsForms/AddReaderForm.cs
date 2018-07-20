using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWindowsForms
{
    public partial class AddReaderForm : Form
    {
        AddReaderDelegate ARD_sender;
        public AddReaderForm(AddReaderDelegate ar_sender)
        {
            ARD_sender = ar_sender;
            InitializeComponent();
            NameTextBox.Select();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || NameTextBox.Text == "Введите имя читателя")
            {
                MessageBox.Show("Необходмо ввести имя автора");
            }
            else
            {
                ARD_sender(new Reader(NameTextBox.Text));
                this.Close();
            }
        }
    }
}
