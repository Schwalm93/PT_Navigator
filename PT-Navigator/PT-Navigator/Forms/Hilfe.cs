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
    public partial class Hilfe : Form
    {
        public Hilfe()
        {
            InitializeComponent();
        }
        private void MapNetworkDrive(string drive, string unc)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("net", "use " + drive + " " + unc);
            info.UseShellExecute = false;
            info.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            System.Diagnostics.Process.Start(info);
        }

        private void MapNetworkDriveDisconnect(string drive)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "net";
            p.StartInfo.Arguments = string.Format("use {0} /DELETE", drive);
            p.StartInfo.UseShellExecute = false;
            p.Start();
        }

        private void BtnDruckerFarbe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4400/Groups/z_Datenaustausch_WT/Schwalm/Drucker/Print2me Farbe.bat");
        }

        private void BtnDruckerSW_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4400/Groups/z_Datenaustausch_WT/Schwalm/Drucker/Print2me SW.bat");
        }

        private void BtnDruckerH3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4400/Groups/z_Datenaustausch_WT/Schwalm/Drucker/Drucker Labor H3.bat");
        }

        private void BtnNetzwerk_Click(object sender, EventArgs e)
        {
            MapNetworkDriveDisconnect("G:");
            MapNetworkDriveDisconnect("P:");
            MapNetworkDriveDisconnect("W:");
            MapNetworkDrive("G:", "\\\\vw.vwg\\vwdfs\\K-P");
            MapNetworkDrive("P:", "\\\\vw.vwg\\vwdfs\\K-P\\PK\\4400");
            MapNetworkDrive("W:", "\\\\vw.vwg\\vwdfs\\K-P\\PK\\4492");
            //System.Diagnostics.Process.Start("file://vw.vwg/vwdfs/K-P/PK/4400/Groups/z_Datenaustausch_WT/Schwalm/Netzwerk/Netzwerk 4492-Neu.bat");
        }
    }
}
