namespace Exponents
{
    partial class uxExponentsDemo
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
            this.uxInputTextBox = new System.Windows.Forms.TextBox();
            this.uxInputLabel = new System.Windows.Forms.Label();
            this.uxOutputLabel = new System.Windows.Forms.Label();
            this.uxGoButton = new System.Windows.Forms.Button();
            this.uxResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxInputTextBox
            // 
            this.uxInputTextBox.Location = new System.Drawing.Point(92, 45);
            this.uxInputTextBox.Name = "uxInputTextBox";
            this.uxInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxInputTextBox.TabIndex = 0;
            // 
            // uxInputLabel
            // 
            this.uxInputLabel.AutoSize = true;
            this.uxInputLabel.Location = new System.Drawing.Point(92, 27);
            this.uxInputLabel.Name = "uxInputLabel";
            this.uxInputLabel.Size = new System.Drawing.Size(85, 13);
            this.uxInputLabel.TabIndex = 3;
            this.uxInputLabel.Text = "Enter an integer:";
            // 
            // uxOutputLabel
            // 
            this.uxOutputLabel.AutoSize = true;
            this.uxOutputLabel.Location = new System.Drawing.Point(102, 181);
            this.uxOutputLabel.Name = "uxOutputLabel";
            this.uxOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.uxOutputLabel.TabIndex = 4;
            this.uxOutputLabel.Visible = false;
            // 
            // uxGoButton
            // 
            this.uxGoButton.Location = new System.Drawing.Point(105, 96);
            this.uxGoButton.Name = "uxGoButton";
            this.uxGoButton.Size = new System.Drawing.Size(75, 67);
            this.uxGoButton.TabIndex = 6;
            this.uxGoButton.Text = "Go!";
            this.uxGoButton.UseVisualStyleBackColor = true;
            this.uxGoButton.Click += new System.EventHandler(this.xGoButton_Click);
            // 
            // uxResetButton
            // 
            this.uxResetButton.Location = new System.Drawing.Point(105, 212);
            this.uxResetButton.Name = "uxResetButton";
            this.uxResetButton.Size = new System.Drawing.Size(75, 23);
            this.uxResetButton.TabIndex = 7;
            this.uxResetButton.Text = "Reset";
            this.uxResetButton.UseVisualStyleBackColor = true;
            this.uxResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // uxExponentsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.uxResetButton);
            this.Controls.Add(this.uxGoButton);
            this.Controls.Add(this.uxOutputLabel);
            this.Controls.Add(this.uxInputLabel);
            this.Controls.Add(this.uxInputTextBox);
            this.Name = "uxExponentsDemo";
            this.Text = "Exponents Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxInputTextBox;
        private System.Windows.Forms.Label uxInputLabel;
        private System.Windows.Forms.Label uxOutputLabel;
        private System.Windows.Forms.Button uxGoButton;
        private System.Windows.Forms.Button uxResetButton;
    }
}

