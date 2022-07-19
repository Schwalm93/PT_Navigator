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
    public partial class KSS_Technik : Form
    {
        public KSS_Technik()
        {
            InitializeComponent();
        }

        private void BtnSchichtbuch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4400/Groups/z_Datenaustausch_WT/4492_KSS-Technik/00_Schichtbuch/PLT_Schichtbuch.xlsm");
        }

        private void BtnAnlagendaten_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/1_Anlagendaten_KSS/02_Anlagendaten_Halle_1_bis_6");
        }

        private void BtnAnlagenzustand_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/4_IT-Ablage_4492/Archiv/Anlagenzustand_2022/Schichtbuch_2022.xlsx");
        }

        private void BtnMaterialverbrauch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/1_Anlagendaten_KSS/01_Materialverbräuche_4492/Startdatei_Materialverbrauch.xlsx");
        }

        private void BtnKSS_M_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/KSS-M");
        }

        private void BtnNotfallmanagement_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Teamordner_Mitarbeiter/3_Notfallmanagement");
        }
    }
}
