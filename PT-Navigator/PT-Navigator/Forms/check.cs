using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Navigator.Forms
{
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
        }

        private void Check_Load(object sender, EventArgs e)
        {
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btncheck_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string password = "12345";
            bool result = input.Equals(password);
            if (result)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                string message = "Ungültiges Passwort!";
                string title = "Passwort Eingabe";
                MessageBox.Show(message, title);
            }
        }
    }
}
