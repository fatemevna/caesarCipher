namespace Caesar_Cipher2
{
    partial class Form1
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
            this.tbDecrypted = new System.Windows.Forms.TextBox();
            this.tbEncrypted = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.cbChoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbDecrypted
            // 
            this.tbDecrypted.Location = new System.Drawing.Point(46, 156);
            this.tbDecrypted.Multiline = true;
            this.tbDecrypted.Name = "tbDecrypted";
            this.tbDecrypted.Size = new System.Drawing.Size(286, 94);
            this.tbDecrypted.TabIndex = 0;
            // 
            // tbEncrypted
            // 
            this.tbEncrypted.Location = new System.Drawing.Point(389, 156);
            this.tbEncrypted.Multiline = true;
            this.tbEncrypted.Name = "tbEncrypted";
            this.tbEncrypted.Size = new System.Drawing.Size(286, 94);
            this.tbEncrypted.TabIndex = 1;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(287, 301);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(165, 24);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "Encode / Decode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // cbChoice
            // 
            this.cbChoice.FormattingEnabled = true;
            this.cbChoice.Location = new System.Drawing.Point(97, 37);
            this.cbChoice.Name = "cbChoice";
            this.cbChoice.Size = new System.Drawing.Size(121, 24);
            this.cbChoice.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbChoice);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.tbEncrypted);
            this.Controls.Add(this.tbDecrypted);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDecrypted;
        private System.Windows.Forms.TextBox tbEncrypted;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.ComboBox cbChoice;
    }
}

