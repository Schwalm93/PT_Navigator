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
    public partial class Teamarbeit : Form
    {
        public Teamarbeit()
        {
            InitializeComponent();
        }

        private void BtnTeamtafel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/5_Teamarbeit/01_Teamtafel online");
        }

        private void BtnSOSBegehung_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/PVT_2/08_SOS/04_4492_Betrieb/06_SOS- Begehungen durch Team 1/SOS- Audits 2022");
        }

        private void BtnSOS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/PVT_2/08_SOS/");
        }

        private void BtnQualimaßnahme_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Teamordner_Teamsprecher/0_Team_1-5/3_Qualifizierung/Qualifikationsmaßnahmen_Betriebneu.xls");
        }
    }
}
