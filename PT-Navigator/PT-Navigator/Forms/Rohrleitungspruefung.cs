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
    public partial class Rohrleitungspruefung : Form
    {
        public Rohrleitungspruefung()
        {
            InitializeComponent();
        }

        private void BtnAnmeldung_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://volkswagen-net.de/wikis/display/SFWIKI/SF-W+Werkschutz+KS+Besucheranmeldung");
        }

        private void BtnAblage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/3_Rohrleitungsprüfung");
        }

        private void BtnPrüfergebnisse_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4400/Groups/z_Datenaustausch_WT/Wolff F/Liste Rohrleitungshalterungen/Rohrprüfung Mastertabelle.xlsm");
        }

        private void BtnPrüffristen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vwdmsweb.wob.vw.vwg/groupdms/?docbase=vwdms&locateId=0b0045158ad66d31");
        }

        private void BtnRohrpläne_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/3_Rohrleitungsprüfung/0_Rohrleitungspläne\003_Illustrator");
        }
    }
}
