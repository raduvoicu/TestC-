namespace WindowsFormsApp1._0
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
            this.textButton = new System.Windows.Forms.Button();
            this.testPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textButton
            // 
            this.textButton.Location = new System.Drawing.Point(318, 159);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(75, 23);
            this.textButton.TabIndex = 0;
            this.textButton.Text = "Push me";
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // testPictureBox
            // 
            this.testPictureBox.Location = new System.Drawing.Point(217, 218);
            this.testPictureBox.Name = "testPictureBox";
            this.testPictureBox.Size = new System.Drawing.Size(306, 169);
            this.testPictureBox.TabIndex = 1;
            this.testPictureBox.TabStop = false;
            this.testPictureBox.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testPictureBox);
            this.Controls.Add(this.textButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button textButton;
        private System.Windows.Forms.PictureBox testPictureBox;
    }
}

