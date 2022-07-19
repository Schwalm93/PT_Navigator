using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Navigator
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
            if(currentButton!=(Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelHome.Controls.Add(childForm);
            this.panelHome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void BtnAnlagentechnik_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.KSS_Technik(), sender);
        }

        private void BtnRT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Reinigungstechnik(), sender);
        }

        private void PanelTitlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnASI_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ASI(), sender);
        }

        private void BtnRohrleitungspruefung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Rohrleitungspruefung(), sender);
        }

        private void BtnASI_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ASI(), sender);
        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Personal(), sender);
        }
        private void BtnTeamarbeit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Teamarbeit(), sender);
        }
        private void BtnProgramme_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Programme(), sender);
        }

        private void BtnHilfe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Hilfe(), sender);
        }

        private void PanelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        /*  Handle close and minimize Button */
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
