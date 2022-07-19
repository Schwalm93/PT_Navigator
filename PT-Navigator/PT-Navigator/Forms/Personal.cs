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
    public partial class Personal : Form
    {
        string buttontooltip = "AVE";

        public Personal()
        {
            InitializeComponent();
        }

        private void BtnAve_MouseHover(object sender, EventArgs e)
        {
            ComAnwesenheit.SetToolTip(BtnAnwesenheit, buttontooltip);
            ComAnwesenheit.OwnerDraw = true;
            ComAnwesenheit.ForeColor = Color.Black;
            ComAnwesenheit.BackColor = Color.LightGray;
            ComAnwesenheit.Draw += new DrawToolTipEventHandler(ComAnwesenheit_Draw);
            ComAnwesenheit.Popup += new PopupEventHandler(ComAnwesenheit_Popup);
        }

        private void ComAnwesenheit_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font tooltipFont = new Font("calibri", 16.0f);
            e.DrawBackground();
            e.DrawBorder();
            //buttontooltip = e.ToolTipText;
            e.Graphics.DrawString(e.ToolTipText, tooltipFont, Brushes.Black, new PointF(2, 2));
        }

        private void ComAnwesenheit_Popup(object sender, PopupEventArgs e)
        {
            //Font tooltipFont = new Font("calibri", 18.0f);
            e.ToolTipSize = TextRenderer.MeasureText(buttontooltip, new Font("calibri", 16.0f));
        }

        private void BtnAnwesenheit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Teamordner_Mitarbeiter/2_Ave_An+Abwesenheitssteuerung/AVE_2022/Ave_2022.exe");
        }

        private void BtnAngestellte_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4400/Groups/28_Anwesenheit_4597/Ave_4597_4599_LW32");
        }

        private void BtnSchichtpläne_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Teamordner_Mitarbeiter/1_Schichtpläne/Schichtplan 2022.xlsm");
        }

        private void BtnTelefonliste_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Teamordner_Teamsprecher/0_Team_1-5/20_Datein_Sharepoint/Handys%204492.xlsx");
        }

        private void BtnAnwesenheitsinfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Teamordner_Mitarbeiter/2_Ave_An+Abwesenheitssteuerung/Anwesenheitsinformationen.xlsm");
        }

        private void BtnKommentare_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Teamordner_Mitarbeiter/2_Ave_An+Abwesenheitssteuerung/Kommentare/Erfasste_Kommentare.xlsm");
        }

        private void BtnMehrarbeit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4352/Groups/20_Global/Mehrarbeitsbeantragung_Werktechnik");
        }

        private void BtnMitarbeiterliste_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Teamordner_Teamsprecher/0_Team_1-5/20_Datein_Sharepoint/Liste%20Mitarbeiter.xlsx");
        }

        private void BtnRufbereitschaft_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Teamordner_Teamsprecher/0_Team_1-5/4_Rufbereitschaft/");
        }

        private void BtnUnterweisung_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/PVT_ASI_Konzept/01_PVT_allgemein/08_Unterweisungen/Unterweisungen%204492.xlsm");
        }

        private void BtnOrganigramm_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.gs.vwgroup.com/unit/HKTW31/Lists/Fuehrungskraefteordner/AllItems.aspx");
        }
    }
}
