namespace _14._6___Temperature_Conversions
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
            this.celsius_text = new System.Windows.Forms.Label();
            this.farIn = new System.Windows.Forms.TextBox();
            this.farenheit_text = new System.Windows.Forms.Label();
            this.celOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // celsius_text
            // 
            this.celsius_text.AutoSize = true;
            this.celsius_text.Location = new System.Drawing.Point(12, 34);
            this.celsius_text.Name = "celsius_text";
            this.celsius_text.Size = new System.Drawing.Size(46, 13);
            this.celsius_text.TabIndex = 0;
            this.celsius_text.Text = "Celsius: ";
            // 
            // farIn
            // 
            this.farIn.Location = new System.Drawing.Point(81, 6);
            this.farIn.Name = "farIn";
            this.farIn.Size = new System.Drawing.Size(100, 20);
            this.farIn.TabIndex = 1;
            this.farIn.TextChanged += new System.EventHandler(this.tempConvert);
            // 
            // farenheit_text
            // 
            this.farenheit_text.AutoSize = true;
            this.farenheit_text.Location = new System.Drawing.Point(12, 9);
            this.farenheit_text.Name = "farenheit_text";
            this.farenheit_text.Size = new System.Drawing.Size(63, 13);
            this.farenheit_text.TabIndex = 2;
            this.farenheit_text.Text = "Fahrenheit: ";
            // 
            // celOut
            // 
            this.celOut.Location = new System.Drawing.Point(78, 34);
            this.celOut.Name = "celOut";
            this.celOut.Size = new System.Drawing.Size(100, 13);
            this.celOut.TabIndex = 3;
            this.celOut.Text = "0°C";
            this.celOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 61);
            this.Controls.Add(this.celOut);
            this.Controls.Add(this.farenheit_text);
            this.Controls.Add(this.farIn);
            this.Controls.Add(this.celsius_text);
            this.Name = "Form1";
            this.Text = "Temprature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label celsius_text;
        private System.Windows.Forms.TextBox farIn;
        private System.Windows.Forms.Label farenheit_text;
        private System.Windows.Forms.Label celOut;
    }
}

