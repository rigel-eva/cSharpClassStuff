namespace _16._9._26___Craps
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
            this.actionButton = new System.Windows.Forms.Button();
            this.diceDisplay = new System.Windows.Forms.TextBox();
            this.pointBox = new System.Windows.Forms.TextBox();
            this.messages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(24, 12);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 0;
            this.actionButton.Text = "Start Game";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.gameStart);
            // 
            // diceDisplay
            // 
            this.diceDisplay.Location = new System.Drawing.Point(12, 41);
            this.diceDisplay.Name = "diceDisplay";
            this.diceDisplay.ReadOnly = true;
            this.diceDisplay.Size = new System.Drawing.Size(100, 20);
            this.diceDisplay.TabIndex = 1;
            // 
            // pointBox
            // 
            this.pointBox.Location = new System.Drawing.Point(12, 80);
            this.pointBox.Name = "pointBox";
            this.pointBox.ReadOnly = true;
            this.pointBox.Size = new System.Drawing.Size(100, 20);
            this.pointBox.TabIndex = 3;
            // 
            // messages
            // 
            this.messages.AutoSize = true;
            this.messages.Location = new System.Drawing.Point(12, 64);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(59, 13);
            this.messages.TabIndex = 4;
            this.messages.Text = "Point Set!: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 110);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.pointBox);
            this.Controls.Add(this.diceDisplay);
            this.Controls.Add(this.actionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.TextBox diceDisplay;
        private System.Windows.Forms.TextBox pointBox;
        private System.Windows.Forms.Label messages;
    }
}

