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
    public partial class Reinigungstechnik : Form
    {
        public Reinigungstechnik()
        {
            InitializeComponent();
        }

        private void BtnAGA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/2_Reinigungstechnik/Vordrucke/BU-AGA%20Vordrucke/Analysenprotokolle%20Originalformular");
        }

        private void BtnSchichtbuch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/2_Reinigungstechnik/01_Schichtbuch/Schichtbuch-2022.xlsx");
        }

        private void BtnNachsatz_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/2_Reinigungstechnik/Vordrucke/Aushang_Nachsatz.xlsm");
        }

        private void BtnRundeRA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/2_Reinigungstechnik/WM-Runden-Neu-Aufteilung_Stand_30.06.2021.xlsx");
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.gs.vwgroup.com/unit/HKTW31/SharePointPVT/Reinigungstechnik");
        }
    }
}
