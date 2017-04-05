namespace ehf
{
    partial class Form_main
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
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.listBox_attachments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_email
            // 
            this.textBox_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_email.Location = new System.Drawing.Point(12, 12);
            this.textBox_email.MaxLength = 0;
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_email.Size = new System.Drawing.Size(1398, 380);
            this.textBox_email.TabIndex = 0;
            this.textBox_email.Click += new System.EventHandler(this.textBox_email_Click);
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // listBox_attachments
            // 
            this.listBox_attachments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_attachments.FormattingEnabled = true;
            this.listBox_attachments.ItemHeight = 25;
            this.listBox_attachments.Location = new System.Drawing.Point(12, 398);
            this.listBox_attachments.Name = "listBox_attachments";
            this.listBox_attachments.Size = new System.Drawing.Size(1398, 204);
            this.listBox_attachments.TabIndex = 1;
            this.listBox_attachments.DoubleClick += new System.EventHandler(this.listBox_attachments_DoubleClick);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 614);
            this.Controls.Add(this.listBox_attachments);
            this.Controls.Add(this.textBox_email);
            this.Name = "Form_main";
            this.ShowIcon = false;
            this.Text = "ehf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.ListBox listBox_attachments;
    }
}

