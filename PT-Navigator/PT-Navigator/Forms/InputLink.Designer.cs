namespace PT_Navigator.Forms
{
    partial class InputLink
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
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.BtnÄndern = new System.Windows.Forms.Button();
            this.BtnAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.BackColor = System.Drawing.Color.Transparent;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInput.Location = new System.Drawing.Point(12, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(143, 16);
            this.labelInput.TabIndex = 2;
            this.labelInput.Text = "Bitte Link anpassen";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLink.Location = new System.Drawing.Point(12, 37);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(310, 24);
            this.textBoxLink.TabIndex = 3;
            // 
            // BtnÄndern
            // 
            this.BtnÄndern.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnÄndern.FlatAppearance.BorderSize = 0;
            this.BtnÄndern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnÄndern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnÄndern.Location = new System.Drawing.Point(186, 86);
            this.BtnÄndern.Name = "BtnÄndern";
            this.BtnÄndern.Size = new System.Drawing.Size(110, 23);
            this.BtnÄndern.TabIndex = 4;
            this.BtnÄndern.Text = "Ändern";
            this.BtnÄndern.UseVisualStyleBackColor = false;
            this.BtnÄndern.Click += new System.EventHandler(this.BtnÄndern_Click);
            // 
            // BtnAbbrechen
            // 
            this.BtnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbbrechen.Location = new System.Drawing.Point(45, 86);
            this.BtnAbbrechen.Name = "BtnAbbrechen";
            this.BtnAbbrechen.Size = new System.Drawing.Size(110, 23);
            this.BtnAbbrechen.TabIndex = 5;
            this.BtnAbbrechen.Text = "Abbrechen";
            this.BtnAbbrechen.UseVisualStyleBackColor = true;
            this.BtnAbbrechen.Click += new System.EventHandler(this.BtnAbbrechen_Click);
            // 
            // InputLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 121);
            this.Controls.Add(this.BtnAbbrechen);
            this.Controls.Add(this.BtnÄndern);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.labelInput);
            this.Name = "InputLink";
            this.Text = "InputLink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Button BtnÄndern;
        private System.Windows.Forms.Button BtnAbbrechen;
    }
}