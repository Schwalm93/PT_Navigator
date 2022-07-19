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
    public partial class ASI : Form
    {
        public ASI()
        {
            InitializeComponent();
        }

        public int Key = 0;
        bool CanOpenFile(string file)
        {
            try
            {
                using (System.IO.File.Open(file, System.IO.FileMode.Open))
                { return true; }
            }
            catch
            { return false; }
        }

        private string get_link(int n)
        {
            if (CanOpenFile(@"Ressourcen/As/As.csv"))
            {
                string[] Link = System.IO.File.ReadAllLines(@"Ressourcen/As/As.csv");
                return (Link[n]);
            }
            return ("FileisOpen");
        }

        public string InputUser()
        {
            Form frm2 = new InputLink();

            if (frm2.ShowDialog() == DialogResult.OK)
            {

            }
            return ("test");
        }
        /********************************BUTTON**********************************/
        private void BtnBetriebsanweisung_Click(object sender, EventArgs e)
        {
            string Link = get_link(0);
            if (Link != "FileisOpen")
            {
                System.Diagnostics.Process.Start(Link);
            }
        }

        private void BtnDokumenteASI_Click(object sender, EventArgs e)
        {
            string Link = get_link(1);
            if (Link != "FileisOpen")
            {
                System.Diagnostics.Process.Start(Link);
            }
        }

        private void BtnGefährdungsbeurteilung_Click(object sender, EventArgs e)
        {
            string Link = get_link(2);
            if (Link != "FileisOpen")
            {
                System.Diagnostics.Process.Start(Link);
            }
        }

        private void BtnUnterweisung_Click(object sender, EventArgs e)
        {
            string Link = get_link(3);
            if (Link != "FileisOpen")
            {
                System.Diagnostics.Process.Start(Link);
            }
        }

        private void BtnArbeitsschutz_Click(object sender, EventArgs e)
        {
            string Link = get_link(4);
            if (Link != "FileisOpen")
            {
                System.Diagnostics.Process.Start(Link);
            }
        }

        private void BtnPSA_Click(object sender, EventArgs e)
        {
            string Link = get_link(5);
            if (Link != "FileisOpen")
            {
                System.Diagnostics.Process.Start(Link);
            }
        }

        private void BtnBGHM_Click(object sender, EventArgs e)
        {
            string Link = get_link(6);
            if (Link != "FileisOpen")
            {
                System.Diagnostics.Process.Start(Link);
            }
        }

        private void BtnASILandkarte_Click(object sender, EventArgs e)
        {
            string Link = get_link(7);
            if (Link != "FileisOpen")
            {
                System.Diagnostics.Process.Start(Link);
            }
        }

        /*********************************STRIPE***********************************/
        private void VerlinkungÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Key == 1)
            {
                string[] Link = System.IO.File.ReadAllLines(@"Ressourcen/As/As.csv");
                // Link[0] = InputUser();
                InputUser();
               // System.IO.File.WriteAllLines(@"Ressourcen/As/As.csv", Link);
            }
            else
            {
                string message = "Anpassung ist nicht Freigegeben!";
                string title = "Berechtigung";
                MessageBox.Show(message, title);
            }
        }

        /*********************************LOCK***********************************/
        private void BtnLock_Click(object sender, EventArgs e)
        {
            if (Key != 1)
            {
                Form frm2 = new check();
                if (frm2.ShowDialog() == DialogResult.OK)
                {
                    this.BtnLock.Image = Properties.Resources.LockOpen__2_;
                    Key = 1;
                }
            }
            else
            {
                this.BtnLock.Image = Properties.Resources.LockClosed;
                Key = 0;
            }
        }
    }
}
