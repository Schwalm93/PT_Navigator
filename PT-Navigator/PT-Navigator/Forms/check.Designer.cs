namespace PT_Navigator.Forms
{
    partial class check
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelcheck = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(197, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(125, 24);
            this.textBox1.TabIndex = 0;
            // 
            // labelcheck
            // 
            this.labelcheck.AutoSize = true;
            this.labelcheck.BackColor = System.Drawing.Color.Transparent;
            this.labelcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelcheck.Location = new System.Drawing.Point(12, 14);
            this.labelcheck.Name = "labelcheck";
            this.labelcheck.Size = new System.Drawing.Size(179, 16);
            this.labelcheck.TabIndex = 1;
            this.labelcheck.Text = "Bitte Passwort eingeben:";
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.Transparent;
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(209, 49);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(103, 23);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "Abschicken";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.Btncheck_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(209, 87);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(103, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Abbrechen";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(334, 121);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.labelcheck);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "check";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Check_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelcheck;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button BtnClose;
    }
}