namespace Question2
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
            this.Submit = new System.Windows.Forms.Button();
            this.textBoxNumbers = new System.Windows.Forms.TextBox();
            this.labelNumbers = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(224, 41);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // textBoxNumbers
            // 
            this.textBoxNumbers.Location = new System.Drawing.Point(75, 41);
            this.textBoxNumbers.MaximumSize = new System.Drawing.Size(400, 400);
            this.textBoxNumbers.MinimumSize = new System.Drawing.Size(50, 200);
            this.textBoxNumbers.Multiline = true;
            this.textBoxNumbers.Name = "textBoxNumbers";
            this.textBoxNumbers.Size = new System.Drawing.Size(119, 200);
            this.textBoxNumbers.TabIndex = 1;
            // 
            // labelNumbers
            // 
            this.labelNumbers.AutoSize = true;
            this.labelNumbers.Location = new System.Drawing.Point(91, 25);
            this.labelNumbers.Name = "labelNumbers";
            this.labelNumbers.Size = new System.Drawing.Size(77, 13);
            this.labelNumbers.TabIndex = 2;
            this.labelNumbers.Text = "Enter Numbers";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(337, 41);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(120, 199);
            this.listBoxResult.TabIndex = 3;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(357, 25);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(84, 13);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output Numbers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 287);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.labelNumbers);
            this.Controls.Add(this.textBoxNumbers);
            this.Controls.Add(this.Submit);
            this.Name = "Form1";
            this.Text = "Reverse Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox textBoxNumbers;
        private System.Windows.Forms.Label labelNumbers;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label labelOutput;
    }
}

