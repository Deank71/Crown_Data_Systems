namespace Question3
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonSplitFile = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelFiles = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(24, 37);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 28);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate Document";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            this.buttonGenerate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonGenerate_KeyDown);
            // 
            // buttonSplitFile
            // 
            this.buttonSplitFile.Location = new System.Drawing.Point(132, 37);
            this.buttonSplitFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSplitFile.Name = "buttonSplitFile";
            this.buttonSplitFile.Size = new System.Drawing.Size(100, 28);
            this.buttonSplitFile.TabIndex = 1;
            this.buttonSplitFile.Text = "Split File";
            this.buttonSplitFile.UseVisualStyleBackColor = true;
            this.buttonSplitFile.Click += new System.EventHandler(this.buttonSplitFile_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(13, 273);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(133, 28);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(412, 37);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 244);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelFiles
            // 
            this.labelFiles.AutoSize = true;
            this.labelFiles.Location = new System.Drawing.Point(412, 14);
            this.labelFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(98, 16);
            this.labelFiles.TabIndex = 4;
            this.labelFiles.Text = "Current File List";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(285, 37);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 28);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear Directory";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(277, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(147, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click a file name to load file in Notepad.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelFiles);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonSplitFile);
            this.Controls.Add(this.buttonGenerate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Document Splitter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonSplitFile;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelFiles;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
    }
}

