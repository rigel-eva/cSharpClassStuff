namespace _14._8___Guess_The_Number
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
            this.gameInfo = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feedback = new System.Windows.Forms.Label();
            this.actingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameInfo
            // 
            this.gameInfo.Location = new System.Drawing.Point(12, 23);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(260, 60);
            this.gameInfo.TabIndex = 0;
            this.gameInfo.Text = "I have a number between 1 and 1000 -- can you guess my number?\n\nPlease enter your" +
    " first guess";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(77, 86);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 1;
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.runCheck);//This is unsightly ...
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // feedback
            // 
            this.feedback.AutoSize = true;
            this.feedback.Location = new System.Drawing.Point(77, 69);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(54, 13);
            this.feedback.TabIndex = 2;
            this.feedback.Text = "Too High!";
            // 
            // actingButton
            // 
            this.actingButton.Location = new System.Drawing.Point(77, 112);
            this.actingButton.Name = "actingButton";
            this.actingButton.Size = new System.Drawing.Size(100, 23);
            this.actingButton.TabIndex = 3;
            this.actingButton.Text = "Guess";
            this.actingButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 157);
            this.Controls.Add(this.actingButton);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.gameInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameInfo;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label feedback;
        private System.Windows.Forms.Button actingButton;
    }
}

