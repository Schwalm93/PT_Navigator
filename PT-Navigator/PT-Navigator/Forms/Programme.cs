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
    public partial class Programme : Form
    {
        public Programme()
        {
            InitializeComponent();
        }

        private void BtnDMS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vwdmsweb.wob.vw.vwg/groupdms/");
        }

        private void BtnMabon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://hod.wob.vw.vwg/");
        }

        private void BtnMaximo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://maximop.wob.vw.vwg/jctmaximo/maximo/");
        }

        private void BtnRemas_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://vwagksspk014/remas/index.php?uid=nein");
        }

        private void BtnVermon_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("file://vwagksspksip/vermon/bin/IH-Manager.exe");
        }

        private void BtnZenon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/4_IT-Ablage_4492/Zenon/Zenon.url");
        }

        private void BtnBeleuchtung_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4492/Groups/4492_Betrieb/4_IT-Ablage_4492/Störmeldung Beleuchtung.msg");
        }

        private void BtnKVS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kvs.wob.vw.vwg:8081/DE-script/webagent//DE/menu.html");
        }

        private void BtnPlanenBM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://http//planen.wob.vw.vwg/apps/PlanenBM/planen_64.htm");
        }

        private void BtnSAP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://p1p.wob.vw.vwg:50001/irj/portal");
        }

        private void BtnSaugwagen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://vwagksspk014/umweltschutz/");
        }

        private void BtnIdeen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://volkswagen-net.de/wikis/display/Ideenmanagement");
        }

        private void BtnSelfservice_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://selfservice.wob.vw.vwg/");
        }
    }
}
