namespace PT_Navigator.Forms
{
    partial class ASI
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
            this.MenuBetriebsanweisung = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verlinkungÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLock = new System.Windows.Forms.Button();
            this.BtnASILandkarte = new System.Windows.Forms.Button();
            this.BtnBGHM = new System.Windows.Forms.Button();
            this.BtnPSA = new System.Windows.Forms.Button();
            this.BtnArbeitsschutz = new System.Windows.Forms.Button();
            this.BtnUnterweisung = new System.Windows.Forms.Button();
            this.BtnGefährdungsbeurteilung = new System.Windows.Forms.Button();
            this.BtnDokumenteASI = new System.Windows.Forms.Button();
            this.BtnBetriebsanweisung = new System.Windows.Forms.Button();
            this.MenuBetriebsanweisung.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(709, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "© C.Schwalm";
            // 
            // MenuBetriebsanweisung
            // 
            this.MenuBetriebsanweisung.AccessibleName = "Test";
            this.MenuBetriebsanweisung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verlinkungÄndernToolStripMenuItem});
            this.MenuBetriebsanweisung.Name = "MenuBetriebsanweisung";
            this.MenuBetriebsanweisung.Size = new System.Drawing.Size(181, 48);
            // 
            // verlinkungÄndernToolStripMenuItem
            // 
            this.verlinkungÄndernToolStripMenuItem.Name = "verlinkungÄndernToolStripMenuItem";
            this.verlinkungÄndernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verlinkungÄndernToolStripMenuItem.Text = "Verlinkung ändern";
            this.verlinkungÄndernToolStripMenuItem.Click += new System.EventHandler(this.VerlinkungÄndernToolStripMenuItem_Click);
            // 
            // BtnLock
            // 
            this.BtnLock.FlatAppearance.BorderSize = 0;
            this.BtnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLock.Image = global::PT_Navigator.Properties.Resources.LockClosed;
            this.BtnLock.Location = new System.Drawing.Point(764, 496);
            this.BtnLock.Name = "BtnLock";
            this.BtnLock.Size = new System.Drawing.Size(37, 38);
            this.BtnLock.TabIndex = 14;
            this.BtnLock.UseVisualStyleBackColor = true;
            this.BtnLock.Click += new System.EventHandler(this.BtnLock_Click);
            // 
            // BtnASILandkarte
            // 
            this.BtnASILandkarte.BackColor = System.Drawing.Color.Transparent;
            this.BtnASILandkarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnASILandkarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnASILandkarte.FlatAppearance.BorderSize = 0;
            this.BtnASILandkarte.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnASILandkarte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnASILandkarte.Image = global::PT_Navigator.Properties.Resources.folder__1_;
            this.BtnASILandkarte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnASILandkarte.Location = new System.Drawing.Point(521, 163);
            this.BtnASILandkarte.Name = "BtnASILandkarte";
            this.BtnASILandkarte.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnASILandkarte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnASILandkarte.Size = new System.Drawing.Size(147, 108);
            this.BtnASILandkarte.TabIndex = 13;
            this.BtnASILandkarte.Text = "ASI Landkarte";
            this.BtnASILandkarte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnASILandkarte.UseVisualStyleBackColor = false;
            this.BtnASILandkarte.Click += new System.EventHandler(this.BtnASILandkarte_Click);
            // 
            // BtnBGHM
            // 
            this.BtnBGHM.BackColor = System.Drawing.Color.Transparent;
            this.BtnBGHM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBGHM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBGHM.FlatAppearance.BorderSize = 0;
            this.BtnBGHM.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBGHM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnBGHM.Image = global::PT_Navigator.Properties.Resources.folder__1_;
            this.BtnBGHM.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBGHM.Location = new System.Drawing.Point(368, 163);
            this.BtnBGHM.Name = "BtnBGHM";
            this.BtnBGHM.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnBGHM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnBGHM.Size = new System.Drawing.Size(147, 108);
            this.BtnBGHM.TabIndex = 12;
            this.BtnBGHM.Text = "BGHM";
            this.BtnBGHM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBGHM.UseVisualStyleBackColor = false;
            this.BtnBGHM.Click += new System.EventHandler(this.BtnBGHM_Click);
            // 
            // BtnPSA
            // 
            this.BtnPSA.BackColor = System.Drawing.Color.Transparent;
            this.BtnPSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPSA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPSA.FlatAppearance.BorderSize = 0;
            this.BtnPSA.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPSA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnPSA.Image = global::PT_Navigator.Properties.Resources.folder__1_;
            this.BtnPSA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPSA.Location = new System.Drawing.Point(215, 163);
            this.BtnPSA.Name = "BtnPSA";
            this.BtnPSA.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnPSA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnPSA.Size = new System.Drawing.Size(147, 108);
            this.BtnPSA.TabIndex = 11;
            this.BtnPSA.Text = "PSA";
            this.BtnPSA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPSA.UseVisualStyleBackColor = false;
            this.BtnPSA.Click += new System.EventHandler(this.BtnPSA_Click);
            // 
            // BtnArbeitsschutz
            // 
            this.BtnArbeitsschutz.BackColor = System.Drawing.Color.Transparent;
            this.BtnArbeitsschutz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnArbeitsschutz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnArbeitsschutz.FlatAppearance.BorderSize = 0;
            this.BtnArbeitsschutz.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArbeitsschutz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnArbeitsschutz.Image = global::PT_Navigator.Properties.Resources.vw__1_;
            this.BtnArbeitsschutz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnArbeitsschutz.Location = new System.Drawing.Point(62, 163);
            this.BtnArbeitsschutz.Name = "BtnArbeitsschutz";
            this.BtnArbeitsschutz.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.BtnArbeitsschutz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnArbeitsschutz.Size = new System.Drawing.Size(147, 108);
            this.BtnArbeitsschutz.TabIndex = 10;
            this.BtnArbeitsschutz.Text = "Arbeitsschutz";
            this.BtnArbeitsschutz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnArbeitsschutz.UseVisualStyleBackColor = false;
            this.BtnArbeitsschutz.Click += new System.EventHandler(this.BtnArbeitsschutz_Click);
            // 
            // BtnUnterweisung
            // 
            this.BtnUnterweisung.BackColor = System.Drawing.Color.Transparent;
            this.BtnUnterweisung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnUnterweisung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUnterweisung.FlatAppearance.BorderSize = 0;
            this.BtnUnterweisung.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnterweisung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnUnterweisung.Image = global::PT_Navigator.Properties.Resources.folder__1_;
            this.BtnUnterweisung.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnUnterweisung.Location = new System.Drawing.Point(521, 49);
            this.BtnUnterweisung.Name = "BtnUnterweisung";
            this.BtnUnterweisung.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnUnterweisung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnUnterweisung.Size = new System.Drawing.Size(147, 108);
            this.BtnUnterweisung.TabIndex = 9;
            this.BtnUnterweisung.Text = "Unterweisung";
            this.BtnUnterweisung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnUnterweisung.UseVisualStyleBackColor = false;
            this.BtnUnterweisung.Click += new System.EventHandler(this.BtnUnterweisung_Click);
            // 
            // BtnGefährdungsbeurteilung
            // 
            this.BtnGefährdungsbeurteilung.BackColor = System.Drawing.Color.Transparent;
            this.BtnGefährdungsbeurteilung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGefährdungsbeurteilung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGefährdungsbeurteilung.FlatAppearance.BorderSize = 0;
            this.BtnGefährdungsbeurteilung.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGefährdungsbeurteilung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnGefährdungsbeurteilung.Image = global::PT_Navigator.Properties.Resources.folder__1_;
            this.BtnGefährdungsbeurteilung.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGefährdungsbeurteilung.Location = new System.Drawing.Point(368, 49);
            this.BtnGefährdungsbeurteilung.Name = "BtnGefährdungsbeurteilung";
            this.BtnGefährdungsbeurteilung.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnGefährdungsbeurteilung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnGefährdungsbeurteilung.Size = new System.Drawing.Size(147, 108);
            this.BtnGefährdungsbeurteilung.TabIndex = 8;
            this.BtnGefährdungsbeurteilung.Text = "Gefährdungsb.";
            this.BtnGefährdungsbeurteilung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGefährdungsbeurteilung.UseVisualStyleBackColor = false;
            this.BtnGefährdungsbeurteilung.Click += new System.EventHandler(this.BtnGefährdungsbeurteilung_Click);
            // 
            // BtnDokumenteASI
            // 
            this.BtnDokumenteASI.BackColor = System.Drawing.Color.Transparent;
            this.BtnDokumenteASI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDokumenteASI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDokumenteASI.FlatAppearance.BorderSize = 0;
            this.BtnDokumenteASI.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDokumenteASI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnDokumenteASI.Image = global::PT_Navigator.Properties.Resources.folder__1_;
            this.BtnDokumenteASI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDokumenteASI.Location = new System.Drawing.Point(215, 49);
            this.BtnDokumenteASI.Name = "BtnDokumenteASI";
            this.BtnDokumenteASI.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnDokumenteASI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDokumenteASI.Size = new System.Drawing.Size(147, 108);
            this.BtnDokumenteASI.TabIndex = 7;
            this.BtnDokumenteASI.Text = "Dokumente ASI";
            this.BtnDokumenteASI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDokumenteASI.UseVisualStyleBackColor = false;
            this.BtnDokumenteASI.Click += new System.EventHandler(this.BtnDokumenteASI_Click);
            // 
            // BtnBetriebsanweisung
            // 
            this.BtnBetriebsanweisung.BackColor = System.Drawing.Color.Transparent;
            this.BtnBetriebsanweisung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBetriebsanweisung.ContextMenuStrip = this.MenuBetriebsanweisung;
            this.BtnBetriebsanweisung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBetriebsanweisung.FlatAppearance.BorderSize = 0;
            this.BtnBetriebsanweisung.Font = new System.Drawing.Font("Porsche News Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBetriebsanweisung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnBetriebsanweisung.Image = global::PT_Navigator.Properties.Resources.folder__1_;
            this.BtnBetriebsanweisung.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBetriebsanweisung.Location = new System.Drawing.Point(62, 49);
            this.BtnBetriebsanweisung.Name = "BtnBetriebsanweisung";
            this.BtnBetriebsanweisung.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnBetriebsanweisung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnBetriebsanweisung.Size = new System.Drawing.Size(147, 108);
            this.BtnBetriebsanweisung.TabIndex = 6;
            this.BtnBetriebsanweisung.Text = "Betriebsanw.";
            this.BtnBetriebsanweisung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBetriebsanweisung.UseVisualStyleBackColor = false;
            this.BtnBetriebsanweisung.Click += new System.EventHandler(this.BtnBetriebsanweisung_Click);
            // 
            // ASI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLock);
            this.Controls.Add(this.BtnASILandkarte);
            this.Controls.Add(this.BtnBGHM);
            this.Controls.Add(this.BtnPSA);
            this.Controls.Add(this.BtnArbeitsschutz);
            this.Controls.Add(this.BtnUnterweisung);
            this.Controls.Add(this.BtnGefährdungsbeurteilung);
            this.Controls.Add(this.BtnDokumenteASI);
            this.Controls.Add(this.BtnBetriebsanweisung);
            this.Controls.Add(this.label4);
            this.Name = "ASI";
            this.Text = "ASI";
            this.MenuBetriebsanweisung.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBetriebsanweisung;
        private System.Windows.Forms.Button BtnDokumenteASI;
        private System.Windows.Forms.Button BtnGefährdungsbeurteilung;
        private System.Windows.Forms.Button BtnUnterweisung;
        private System.Windows.Forms.Button BtnArbeitsschutz;
        private System.Windows.Forms.Button BtnPSA;
        private System.Windows.Forms.Button BtnBGHM;
        private System.Windows.Forms.Button BtnASILandkarte;
        private System.Windows.Forms.ContextMenuStrip MenuBetriebsanweisung;
        private System.Windows.Forms.ToolStripMenuItem verlinkungÄndernToolStripMenuItem;
        private System.Windows.Forms.Button BtnLock;
    }
}