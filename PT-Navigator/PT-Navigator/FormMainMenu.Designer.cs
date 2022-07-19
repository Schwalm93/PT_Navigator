namespace PT_Navigator
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHilfe = new System.Windows.Forms.Button();
            this.BtnProgramme = new System.Windows.Forms.Button();
            this.BtnTeamarbeit = new System.Windows.Forms.Button();
            this.BtnPersonal = new System.Windows.Forms.Button();
            this.BtnASI = new System.Windows.Forms.Button();
            this.BtnRohrleitungspruefung = new System.Windows.Forms.Button();
            this.BtnRT = new System.Windows.Forms.Button();
            this.btnAnlagentechnik = new System.Windows.Forms.Button();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PT NAVIGATOR";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnHilfe);
            this.panelMenu.Controls.Add(this.BtnProgramme);
            this.panelMenu.Controls.Add(this.BtnTeamarbeit);
            this.panelMenu.Controls.Add(this.BtnPersonal);
            this.panelMenu.Controls.Add(this.BtnASI);
            this.panelMenu.Controls.Add(this.BtnRohrleitungspruefung);
            this.panelMenu.Controls.Add(this.BtnRT);
            this.panelMenu.Controls.Add(this.btnAnlagentechnik);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 650);
            this.panelMenu.TabIndex = 0;
            // 
            // btnHilfe
            // 
            this.btnHilfe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHilfe.FlatAppearance.BorderSize = 0;
            this.btnHilfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHilfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHilfe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHilfe.Image = global::PT_Navigator.Properties.Resources.Hilfe__1_;
            this.btnHilfe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHilfe.Location = new System.Drawing.Point(0, 535);
            this.btnHilfe.Name = "btnHilfe";
            this.btnHilfe.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnHilfe.Size = new System.Drawing.Size(240, 65);
            this.btnHilfe.TabIndex = 13;
            this.btnHilfe.Text = "    Hilfe";
            this.btnHilfe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHilfe.UseVisualStyleBackColor = true;
            this.btnHilfe.Click += new System.EventHandler(this.BtnHilfe_Click);
            // 
            // BtnProgramme
            // 
            this.BtnProgramme.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProgramme.FlatAppearance.BorderSize = 0;
            this.BtnProgramme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProgramme.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnProgramme.Image = global::PT_Navigator.Properties.Resources.programme__2_;
            this.BtnProgramme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProgramme.Location = new System.Drawing.Point(0, 470);
            this.BtnProgramme.Name = "BtnProgramme";
            this.BtnProgramme.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.BtnProgramme.Size = new System.Drawing.Size(240, 65);
            this.BtnProgramme.TabIndex = 12;
            this.BtnProgramme.Text = "    Programme";
            this.BtnProgramme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProgramme.UseVisualStyleBackColor = true;
            this.BtnProgramme.Click += new System.EventHandler(this.BtnProgramme_Click);
            // 
            // BtnTeamarbeit
            // 
            this.BtnTeamarbeit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTeamarbeit.FlatAppearance.BorderSize = 0;
            this.BtnTeamarbeit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeamarbeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeamarbeit.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnTeamarbeit.Image = global::PT_Navigator.Properties.Resources.Bild3__1_;
            this.BtnTeamarbeit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTeamarbeit.Location = new System.Drawing.Point(0, 405);
            this.BtnTeamarbeit.Name = "BtnTeamarbeit";
            this.BtnTeamarbeit.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.BtnTeamarbeit.Size = new System.Drawing.Size(240, 65);
            this.BtnTeamarbeit.TabIndex = 11;
            this.BtnTeamarbeit.Text = "    Teamarbeit";
            this.BtnTeamarbeit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTeamarbeit.UseVisualStyleBackColor = true;
            this.BtnTeamarbeit.Click += new System.EventHandler(this.BtnTeamarbeit_Click);
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonal.FlatAppearance.BorderSize = 0;
            this.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonal.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnPersonal.Image = global::PT_Navigator.Properties.Resources.Personal_gelb;
            this.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonal.Location = new System.Drawing.Point(0, 340);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnPersonal.Size = new System.Drawing.Size(240, 65);
            this.BtnPersonal.TabIndex = 7;
            this.BtnPersonal.Text = "    Personal";
            this.BtnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPersonal.UseVisualStyleBackColor = true;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click);
            // 
            // BtnASI
            // 
            this.BtnASI.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnASI.FlatAppearance.BorderSize = 0;
            this.BtnASI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnASI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnASI.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnASI.Image = global::PT_Navigator.Properties.Resources.ASI;
            this.BtnASI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnASI.Location = new System.Drawing.Point(0, 275);
            this.BtnASI.Name = "BtnASI";
            this.BtnASI.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnASI.Size = new System.Drawing.Size(240, 65);
            this.BtnASI.TabIndex = 6;
            this.BtnASI.Text = "    Arbeitssicherheit";
            this.BtnASI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnASI.UseVisualStyleBackColor = true;
            this.BtnASI.Click += new System.EventHandler(this.BtnASI_Click_1);
            // 
            // BtnRohrleitungspruefung
            // 
            this.BtnRohrleitungspruefung.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRohrleitungspruefung.FlatAppearance.BorderSize = 0;
            this.BtnRohrleitungspruefung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRohrleitungspruefung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRohrleitungspruefung.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnRohrleitungspruefung.Image = global::PT_Navigator.Properties.Resources.Rohrleitungspruefung;
            this.BtnRohrleitungspruefung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRohrleitungspruefung.Location = new System.Drawing.Point(0, 210);
            this.BtnRohrleitungspruefung.Name = "BtnRohrleitungspruefung";
            this.BtnRohrleitungspruefung.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.BtnRohrleitungspruefung.Size = new System.Drawing.Size(240, 65);
            this.BtnRohrleitungspruefung.TabIndex = 5;
            this.BtnRohrleitungspruefung.Text = "    Rohrleitungsprüfung";
            this.BtnRohrleitungspruefung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRohrleitungspruefung.UseVisualStyleBackColor = true;
            this.BtnRohrleitungspruefung.Click += new System.EventHandler(this.BtnRohrleitungspruefung_Click);
            // 
            // BtnRT
            // 
            this.BtnRT.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRT.FlatAppearance.BorderSize = 0;
            this.BtnRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRT.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnRT.Image = global::PT_Navigator.Properties.Resources.RT;
            this.BtnRT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRT.Location = new System.Drawing.Point(0, 145);
            this.BtnRT.Name = "BtnRT";
            this.BtnRT.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.BtnRT.Size = new System.Drawing.Size(240, 65);
            this.BtnRT.TabIndex = 2;
            this.BtnRT.Text = "   Reinigungstechnik";
            this.BtnRT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRT.UseVisualStyleBackColor = true;
            this.BtnRT.Click += new System.EventHandler(this.BtnRT_Click);
            // 
            // btnAnlagentechnik
            // 
            this.btnAnlagentechnik.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnlagentechnik.FlatAppearance.BorderSize = 0;
            this.btnAnlagentechnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnlagentechnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnlagentechnik.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnlagentechnik.Image = global::PT_Navigator.Properties.Resources.gear;
            this.btnAnlagentechnik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnlagentechnik.Location = new System.Drawing.Point(0, 80);
            this.btnAnlagentechnik.Name = "btnAnlagentechnik";
            this.btnAnlagentechnik.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAnlagentechnik.Size = new System.Drawing.Size(240, 65);
            this.btnAnlagentechnik.TabIndex = 1;
            this.btnAnlagentechnik.Text = "    KSS-Technik";
            this.btnAnlagentechnik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnlagentechnik.UseVisualStyleBackColor = true;
            this.btnAnlagentechnik.Click += new System.EventHandler(this.BtnAnlagentechnik_Click);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitlebar.Controls.Add(this.btnMinimize);
            this.panelTitlebar.Controls.Add(this.btnClose);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(240, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(817, 80);
            this.panelTitlebar.TabIndex = 1;
            this.panelTitlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTitlebar_Paint);
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitlebar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Akhbar MT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.Location = new System.Drawing.Point(749, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "__";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Akhbar MT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(782, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(618, 500);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelHome.Controls.Add(this.label4);
            this.panelHome.Controls.Add(this.lblTitle);
            this.panelHome.Controls.Add(this.pictureBox2);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(240, 80);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(817, 570);
            this.panelHome.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(709, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "© C.Schwalm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PT_Navigator.Properties.Resources.Bild21;
            this.pictureBox2.Location = new System.Drawing.Point(235, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PT_Navigator.Properties.Resources.Bild3;
            this.pictureBox1.Location = new System.Drawing.Point(320, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "v1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(279, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "PT NAVIGATOR";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1057, 650);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelTitlebar.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnAnlagentechnik;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnRT;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPersonal;
        private System.Windows.Forms.Button BtnASI;
        private System.Windows.Forms.Button BtnRohrleitungspruefung;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnTeamarbeit;
        private System.Windows.Forms.Button btnHilfe;
        private System.Windows.Forms.Button BtnProgramme;
    }
}

