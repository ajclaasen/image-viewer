namespace image_viewer
{
    partial class Tag
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tagLabel = new System.Windows.Forms.Label();
            this.removeTagButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.Font = new System.Drawing.Font("Linux Libertine O", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagLabel.Location = new System.Drawing.Point(3, 14);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(77, 18);
            this.tagLabel.TabIndex = 0;
            this.tagLabel.Text = "Empty Tag";
            // 
            // removeTagButton
            // 
            this.removeTagButton.Location = new System.Drawing.Point(115, 14);
            this.removeTagButton.Name = "removeTagButton";
            this.removeTagButton.Size = new System.Drawing.Size(20, 20);
            this.removeTagButton.TabIndex = 1;
            this.removeTagButton.Text = "X";
            this.removeTagButton.UseVisualStyleBackColor = true;
            // 
            // Tag
            // 
            this.Controls.Add(this.removeTagButton);
            this.Controls.Add(this.tagLabel);
            this.Name = "Tag";
            this.Size = new System.Drawing.Size(144, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tagLabel;
        private System.Windows.Forms.Button removeTagButton;
    }
}
