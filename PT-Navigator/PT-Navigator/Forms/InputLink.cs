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
    public partial class InputLink : Form
    {
        public InputLink()
        {
            InitializeComponent();
        }

        private void BtnÄndern_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
