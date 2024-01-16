namespace ImageAnalyzer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.buttonAnalyzeImage = new System.Windows.Forms.Button();
            this.textBoxAnalysis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.Location = new System.Drawing.Point(20, 305);
            this.buttonSelectImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(300, 32);
            this.buttonSelectImage.TabIndex = 1;
            this.buttonSelectImage.Text = "Select Image";
            this.buttonSelectImage.UseVisualStyleBackColor = true;
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // buttonAnalyzeImage
            // 
            this.buttonAnalyzeImage.Location = new System.Drawing.Point(20, 346);
            this.buttonAnalyzeImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnalyzeImage.Name = "buttonAnalyzeImage";
            this.buttonAnalyzeImage.Size = new System.Drawing.Size(300, 32);
            this.buttonAnalyzeImage.TabIndex = 2;
            this.buttonAnalyzeImage.Text = "Analyze Image";
            this.buttonAnalyzeImage.UseVisualStyleBackColor = true;
            this.buttonAnalyzeImage.Click += new System.EventHandler(this.buttonAnalyzeImage_Click);
            // 
            // textBoxAnalysis
            // 
            this.textBoxAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnalysis.Location = new System.Drawing.Point(331, 18);
            this.textBoxAnalysis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAnalysis.Multiline = true;
            this.textBoxAnalysis.Name = "textBoxAnalysis";
            this.textBoxAnalysis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnalysis.Size = new System.Drawing.Size(688, 358);
            this.textBoxAnalysis.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 392);
            this.Controls.Add(this.textBoxAnalysis);
            this.Controls.Add(this.buttonAnalyzeImage);
            this.Controls.Add(this.buttonSelectImage);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Image Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSelectImage;
        private System.Windows.Forms.Button buttonAnalyzeImage;
        private System.Windows.Forms.TextBox textBoxAnalysis;
    }
}
