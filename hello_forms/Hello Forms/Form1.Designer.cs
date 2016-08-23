namespace Hello_Forms
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
            this.generateQuote = new System.Windows.Forms.Button();
            this.quote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateQuote
            // 
            this.generateQuote.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.generateQuote.Location = new System.Drawing.Point(103, 226);
            this.generateQuote.Name = "generateQuote";
            this.generateQuote.Size = new System.Drawing.Size(75, 23);
            this.generateQuote.TabIndex = 0;
            this.generateQuote.Text = "MemeMe";
            this.generateQuote.UseVisualStyleBackColor = true;
            this.generateQuote.Click += new System.EventHandler(this.button1_Click);
            // 
            // quote
            // 
            this.quote.AutoSize = true;
            this.quote.Location = new System.Drawing.Point(124, 81);
            this.quote.Name = "quote";
            this.quote.Size = new System.Drawing.Size(35, 13);
            this.quote.TabIndex = 1;
            this.quote.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.quote);
            this.Controls.Add(this.generateQuote);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateQuote;
        private System.Windows.Forms.Label quote;
    }
}

