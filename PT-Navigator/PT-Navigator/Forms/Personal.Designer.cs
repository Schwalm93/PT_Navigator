namespace PT_Navigator.Forms
{
    partial class Personal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.ComAnwesenheit = new System.Windows.Forms.ToolTip(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BtnRufbereitschaft = new System.Windows.Forms.Button();
            this.BtnMitarbeiterliste = new System.Windows.Forms.Button();
            this.BtnMehrarbeit = new System.Windows.Forms.Button();
            this.BtnKommentare = new System.Windows.Forms.Button();
            this.BtnAnwesenheitsinfo = new System.Windows.Forms.Button();
            this.BtnAngestellte = new System.Windows.Forms.Button();
            this.BtnAnwesenheit = new System.Windows.Forms.Button();
            this.BtnSchichtpläne = new System.Windows.Forms.Button();
            this.BtnTelefonliste = new System.Windows.Forms.Button();
            this.BtnUnterweisung = new System.Windows.Forms.Button();
            this.BtnOrganigramm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(709, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "© C.Schwalm";
            // 
            // ComAnwesenheit
            // 
            this.ComAnwesenheit.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ComAnwesenheit_Draw);
            this.ComAnwesenheit.Popup += new System.Windows.Forms.PopupEventHandler(this.ComAnwesenheit_Popup);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(604, 346);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // BtnRufbereitschaft
            // 
            this.BtnRufbereitschaft.BackColor = System.Drawing.Color.Transparent;
            this.BtnRufbereitschaft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRufbereitschaft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRufbereitschaft.FlatAppearance.BorderSize = 0;
            this.BtnRufbereitschaft.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRufbereitschaft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnRufbereitschaft.Image = global::PT_Navigator.Properties.Resources.folder__1_;
            this.BtnRufbereitschaft.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRufbereitschaft.Location = new System.Drawing.Point(521, 179);
            this.BtnRufbereitschaft.Name = "BtnRufbereitschaft";
            this.BtnRufbereitschaft.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.BtnRufbereitschaft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnRufbereitschaft.Size = new System.Drawing.Size(147, 124);
            this.BtnRufbereitschaft.TabIndex = 16;
            this.BtnRufbereitschaft.Text = "Rufbereitschaft";
            this.BtnRufbereitschaft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRufbereitschaft.UseVisualStyleBackColor = false;
            this.BtnRufbereitschaft.Click += new System.EventHandler(this.BtnRufbereitschaft_Click);
            // 
            // BtnMitarbeiterliste
            // 
            this.BtnMitarbeiterliste.BackColor = System.Drawing.Color.Transparent;
            this.BtnMitarbeiterliste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMitarbeiterliste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMitarbeiterliste.FlatAppearance.BorderSize = 0;
            this.BtnMitarbeiterliste.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMitarbeiterliste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnMitarbeiterliste.Image = global::PT_Navigator.Properties.Resources.excel;
            this.BtnMitarbeiterliste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMitarbeiterliste.Location = new System.Drawing.Point(215, 179);
            this.BtnMitarbeiterliste.Name = "BtnMitarbeiterliste";
            this.BtnMitarbeiterliste.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.BtnMitarbeiterliste.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMitarbeiterliste.Size = new System.Drawing.Size(147, 124);
            this.BtnMitarbeiterliste.TabIndex = 15;
            this.BtnMitarbeiterliste.Text = "Mitarbeiterliste";
            this.BtnMitarbeiterliste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMitarbeiterliste.UseVisualStyleBackColor = false;
            this.BtnMitarbeiterliste.Click += new System.EventHandler(this.BtnMitarbeiterliste_Click);
            // 
            // BtnMehrarbeit
            // 
            this.BtnMehrarbeit.BackColor = System.Drawing.Color.Transparent;
            this.BtnMehrarbeit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMehrarbeit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMehrarbeit.FlatAppearance.BorderSize = 0;
            this.BtnMehrarbeit.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMehrarbeit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnMehrarbeit.Image = global::PT_Navigator.Properties.Resources.excel;
            this.BtnMehrarbeit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMehrarbeit.Location = new System.Drawing.Point(62, 179);
            this.BtnMehrarbeit.Name = "BtnMehrarbeit";
            this.BtnMehrarbeit.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.BtnMehrarbeit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMehrarbeit.Size = new System.Drawing.Size(147, 124);
            this.BtnMehrarbeit.TabIndex = 14;
            this.BtnMehrarbeit.Text = "Mehrarbeit WT (Meister)";
            this.BtnMehrarbeit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMehrarbeit.UseVisualStyleBackColor = false;
            this.BtnMehrarbeit.Click += new System.EventHandler(this.BtnMehrarbeit_Click);
            // 
            // BtnKommentare
            // 
            this.BtnKommentare.BackColor = System.Drawing.Color.Transparent;
            this.BtnKommentare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnKommentare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKommentare.FlatAppearance.BorderSize = 0;
            this.BtnKommentare.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKommentare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnKommentare.Image = global::PT_Navigator.Properties.Resources.excel;
            this.BtnKommentare.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnKommentare.Location = new System.Drawing.Point(521, 49);
            this.BtnKommentare.Name = "BtnKommentare";
            this.BtnKommentare.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnKommentare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnKommentare.Size = new System.Drawing.Size(147, 124);
            this.BtnKommentare.TabIndex = 12;
            this.BtnKommentare.Text = "Kommentare (Meister)";
            this.BtnKommentare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnKommentare.UseVisualStyleBackColor = false;
            this.BtnKommentare.Click += new System.EventHandler(this.BtnKommentare_Click);
            // 
            // BtnAnwesenheitsinfo
            // 
            this.BtnAnwesenheitsinfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnAnwesenheitsinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAnwesenheitsinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnwesenheitsinfo.FlatAppearance.BorderSize = 0;
            this.BtnAnwesenheitsinfo.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnwesenheitsinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnAnwesenheitsinfo.Image = global::PT_Navigator.Properties.Resources.excel;
            this.BtnAnwesenheitsinfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAnwesenheitsinfo.Location = new System.Drawing.Point(368, 49);
            this.BtnAnwesenheitsinfo.Name = "BtnAnwesenheitsinfo";
            this.BtnAnwesenheitsinfo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnAnwesenheitsinfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAnwesenheitsinfo.Size = new System.Drawing.Size(147, 124);
            this.BtnAnwesenheitsinfo.TabIndex = 11;
            this.BtnAnwesenheitsinfo.Text = "Anwesenheits Info";
            this.BtnAnwesenheitsinfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAnwesenheitsinfo.UseVisualStyleBackColor = false;
            this.BtnAnwesenheitsinfo.Click += new System.EventHandler(this.BtnAnwesenheitsinfo_Click);
            // 
            // BtnAngestellte
            // 
            this.BtnAngestellte.BackColor = System.Drawing.Color.Transparent;
            this.BtnAngestellte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAngestellte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAngestellte.FlatAppearance.BorderSize = 0;
            this.BtnAngestellte.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAngestellte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnAngestellte.Image = global::PT_Navigator.Properties.Resources.Ave;
            this.BtnAngestellte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAngestellte.Location = new System.Drawing.Point(215, 49);
            this.BtnAngestellte.Name = "BtnAngestellte";
            this.BtnAngestellte.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnAngestellte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAngestellte.Size = new System.Drawing.Size(147, 124);
            this.BtnAngestellte.TabIndex = 9;
            this.BtnAngestellte.Text = "AVE! Angestellte";
            this.BtnAngestellte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAngestellte.UseVisualStyleBackColor = false;
            this.BtnAngestellte.Click += new System.EventHandler(this.BtnAngestellte_Click);
            // 
            // BtnAnwesenheit
            // 
            this.BtnAnwesenheit.BackColor = System.Drawing.Color.Transparent;
            this.BtnAnwesenheit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAnwesenheit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnwesenheit.FlatAppearance.BorderSize = 0;
            this.BtnAnwesenheit.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnwesenheit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnAnwesenheit.Image = global::PT_Navigator.Properties.Resources.Ave;
            this.BtnAnwesenheit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAnwesenheit.Location = new System.Drawing.Point(62, 49);
            this.BtnAnwesenheit.Name = "BtnAnwesenheit";
            this.BtnAnwesenheit.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnAnwesenheit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAnwesenheit.Size = new System.Drawing.Size(147, 124);
            this.BtnAnwesenheit.TabIndex = 8;
            this.BtnAnwesenheit.Text = "AVE! Anwesenheit";
            this.BtnAnwesenheit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAnwesenheit.UseVisualStyleBackColor = false;
            this.BtnAnwesenheit.Click += new System.EventHandler(this.BtnAnwesenheit_Click);
            this.BtnAnwesenheit.MouseHover += new System.EventHandler(this.BtnAve_MouseHover);
            // 
            // BtnSchichtpläne
            // 
            this.BtnSchichtpläne.BackColor = System.Drawing.Color.Transparent;
            this.BtnSchichtpläne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSchichtpläne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSchichtpläne.FlatAppearance.BorderSize = 0;
            this.BtnSchichtpläne.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSchichtpläne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnSchichtpläne.Image = global::PT_Navigator.Properties.Resources.excel;
            this.BtnSchichtpläne.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSchichtpläne.Location = new System.Drawing.Point(62, 309);
            this.BtnSchichtpläne.Name = "BtnSchichtpläne";
            this.BtnSchichtpläne.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.BtnSchichtpläne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSchichtpläne.Size = new System.Drawing.Size(147, 124);
            this.BtnSchichtpläne.TabIndex = 5;
            this.BtnSchichtpläne.Text = "Schichtpläne";
            this.BtnSchichtpläne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSchichtpläne.UseVisualStyleBackColor = false;
            this.BtnSchichtpläne.Click += new System.EventHandler(this.BtnSchichtpläne_Click);
            // 
            // BtnTelefonliste
            // 
            this.BtnTelefonliste.BackColor = System.Drawing.Color.Transparent;
            this.BtnTelefonliste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnTelefonliste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTelefonliste.FlatAppearance.BorderSize = 0;
            this.BtnTelefonliste.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTelefonliste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnTelefonliste.Image = global::PT_Navigator.Properties.Resources.excel;
            this.BtnTelefonliste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnTelefonliste.Location = new System.Drawing.Point(215, 309);
            this.BtnTelefonliste.Name = "BtnTelefonliste";
            this.BtnTelefonliste.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.BtnTelefonliste.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnTelefonliste.Size = new System.Drawing.Size(147, 124);
            this.BtnTelefonliste.TabIndex = 10;
            this.BtnTelefonliste.Text = "Telefonliste";
            this.BtnTelefonliste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTelefonliste.UseVisualStyleBackColor = false;
            this.BtnTelefonliste.Click += new System.EventHandler(this.BtnTelefonliste_Click);
            // 
            // BtnUnterweisung
            // 
            this.BtnUnterweisung.BackColor = System.Drawing.Color.Transparent;
            this.BtnUnterweisung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnUnterweisung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUnterweisung.FlatAppearance.BorderSize = 0;
            this.BtnUnterweisung.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnterweisung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnUnterweisung.Image = global::PT_Navigator.Properties.Resources.excel;
            this.BtnUnterweisung.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnUnterweisung.Location = new System.Drawing.Point(368, 309);
            this.BtnUnterweisung.Name = "BtnUnterweisung";
            this.BtnUnterweisung.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.BtnUnterweisung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnUnterweisung.Size = new System.Drawing.Size(147, 124);
            this.BtnUnterweisung.TabIndex = 17;
            this.BtnUnterweisung.Text = "Unterweisung";
            this.BtnUnterweisung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnUnterweisung.UseVisualStyleBackColor = false;
            this.BtnUnterweisung.Click += new System.EventHandler(this.BtnUnterweisung_Click);
            // 
            // BtnOrganigramm
            // 
            this.BtnOrganigramm.BackColor = System.Drawing.Color.Transparent;
            this.BtnOrganigramm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnOrganigramm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrganigramm.FlatAppearance.BorderSize = 0;
            this.BtnOrganigramm.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrganigramm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnOrganigramm.Image = global::PT_Navigator.Properties.Resources.excel;
            this.BtnOrganigramm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnOrganigramm.Location = new System.Drawing.Point(368, 179);
            this.BtnOrganigramm.Name = "BtnOrganigramm";
            this.BtnOrganigramm.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.BtnOrganigramm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnOrganigramm.Size = new System.Drawing.Size(147, 124);
            this.BtnOrganigramm.TabIndex = 18;
            this.BtnOrganigramm.Text = "Organigramm";
            this.BtnOrganigramm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOrganigramm.UseVisualStyleBackColor = false;
            this.BtnOrganigramm.Click += new System.EventHandler(this.BtnOrganigramm_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOrganigramm);
            this.Controls.Add(this.BtnUnterweisung);
            this.Controls.Add(this.BtnRufbereitschaft);
            this.Controls.Add(this.BtnMitarbeiterliste);
            this.Controls.Add(this.BtnMehrarbeit);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.BtnKommentare);
            this.Controls.Add(this.BtnAnwesenheitsinfo);
            this.Controls.Add(this.BtnTelefonliste);
            this.Controls.Add(this.BtnAngestellte);
            this.Controls.Add(this.BtnAnwesenheit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSchichtpläne);
            this.Name = "Personal";
            this.Text = "Personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSchichtpläne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAnwesenheit;
        private System.Windows.Forms.Button BtnAngestellte;
        private System.Windows.Forms.ToolTip ComAnwesenheit;
        private System.Windows.Forms.Button BtnAnwesenheitsinfo;
        private System.Windows.Forms.Button BtnKommentare;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button BtnMehrarbeit;
        private System.Windows.Forms.Button BtnMitarbeiterliste;
        private System.Windows.Forms.Button BtnRufbereitschaft;
        private System.Windows.Forms.Button BtnTelefonliste;
        private System.Windows.Forms.Button BtnUnterweisung;
        private System.Windows.Forms.Button BtnOrganigramm;
    }
}