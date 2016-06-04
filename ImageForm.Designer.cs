namespace image_viewer
{
    partial class ImageForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.tagsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.controlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1004, 804);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(3, 3);
            this.openButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.openButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextButton.Location = new System.Drawing.Point(374, 7);
            this.nextButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.nextButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previousButton.Location = new System.Drawing.Point(293, 7);
            this.previousButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.previousButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsPanel.Controls.Add(this.previousButton);
            this.controlsPanel.Controls.Add(this.nextButton);
            this.controlsPanel.Controls.Add(this.openButton);
            this.controlsPanel.Location = new System.Drawing.Point(12, 822);
            this.controlsPanel.MaximumSize = new System.Drawing.Size(9999999, 30);
            this.controlsPanel.MinimumSize = new System.Drawing.Size(0, 30);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(1004, 30);
            this.controlsPanel.TabIndex = 0;
            // 
            // tagsPanel
            // 
            this.tagsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagsPanel.Location = new System.Drawing.Point(1022, 12);
            this.tagsPanel.MaximumSize = new System.Drawing.Size(150, 9999999);
            this.tagsPanel.MinimumSize = new System.Drawing.Size(150, 0);
            this.tagsPanel.Name = "tagsPanel";
            this.tagsPanel.Size = new System.Drawing.Size(150, 840);
            this.tagsPanel.TabIndex = 2;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.tagsPanel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.controlsPanel);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel tagsPanel;
    }
}