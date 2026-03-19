namespace Dobbelsteen
{
    partial class DobbelsteenForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DobbelsteenForm));
            dobbelsteenPictureBox = new PictureBox();
            dobbelsteenTextBox = new TextBox();
            werpenButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dobbelsteenPictureBox).BeginInit();
            SuspendLayout();
            // 
            // dobbelsteenPictureBox
            // 
            dobbelsteenPictureBox.Image = (Image)resources.GetObject("dobbelsteenPictureBox.Image");
            dobbelsteenPictureBox.Location = new Point(138, 12);
            dobbelsteenPictureBox.Name = "dobbelsteenPictureBox";
            dobbelsteenPictureBox.Size = new Size(193, 194);
            dobbelsteenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            dobbelsteenPictureBox.TabIndex = 0;
            dobbelsteenPictureBox.TabStop = false;
            // 
            // dobbelsteenTextBox
            // 
            dobbelsteenTextBox.Location = new Point(183, 68);
            dobbelsteenTextBox.Name = "dobbelsteenTextBox";
            dobbelsteenTextBox.ReadOnly = true;
            dobbelsteenTextBox.Size = new Size(100, 23);
            dobbelsteenTextBox.TabIndex = 1;
            // 
            // werpenButton
            // 
            werpenButton.Location = new Point(208, 235);
            werpenButton.Name = "werpenButton";
            werpenButton.Size = new Size(75, 23);
            werpenButton.TabIndex = 2;
            werpenButton.Text = "Werpen";
            werpenButton.UseVisualStyleBackColor = true;
            werpenButton.Click += werpenButton_Click_1;
            // 
            // DobbelsteenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(werpenButton);
            Controls.Add(dobbelsteenTextBox);
            Controls.Add(dobbelsteenPictureBox);
            Name = "DobbelsteenForm";
            Text = "Form1";
//            Load += DobbelsteenForm_Load;
            ((System.ComponentModel.ISupportInitialize)dobbelsteenPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox dobbelsteenPictureBox;
        private TextBox dobbelsteenTextBox;
        private Button werpenButton;
    }
}
