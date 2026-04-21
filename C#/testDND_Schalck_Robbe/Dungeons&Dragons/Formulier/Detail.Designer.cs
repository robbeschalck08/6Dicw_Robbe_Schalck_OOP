namespace Formulier
{
    partial class DetailForm
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
            NaamLabel = new Label();
            SterkteLabel = new Label();
            NaamGegevensLabel = new Label();
            sterkteTextBox = new TextBox();
            naamTextBox = new TextBox();
            SuspendLayout();
            // 
            // NaamLabel
            // 
            NaamLabel.AutoSize = true;
            NaamLabel.Location = new Point(29, 20);
            NaamLabel.Name = "NaamLabel";
            NaamLabel.Size = new Size(39, 15);
            NaamLabel.TabIndex = 0;
            NaamLabel.Text = "Naam";
            // 
            // SterkteLabel
            // 
            SterkteLabel.AutoSize = true;
            SterkteLabel.Location = new Point(29, 63);
            SterkteLabel.Name = "SterkteLabel";
            SterkteLabel.Size = new Size(43, 15);
            SterkteLabel.TabIndex = 1;
            SterkteLabel.Text = "Sterkte";
            // 
            // NaamGegevensLabel
            // 
            NaamGegevensLabel.AutoSize = true;
            NaamGegevensLabel.Location = new Point(126, 20);
            NaamGegevensLabel.Name = "NaamGegevensLabel";
            NaamGegevensLabel.Size = new Size(0, 15);
            NaamGegevensLabel.TabIndex = 2;
            // 
            // sterkteTextBox
            // 
            sterkteTextBox.Location = new Point(173, 55);
            sterkteTextBox.Name = "sterkteTextBox";
            sterkteTextBox.ReadOnly = true;
            sterkteTextBox.Size = new Size(100, 23);
            sterkteTextBox.TabIndex = 3;
            // 
            // naamTextBox
            // 
            naamTextBox.Location = new Point(144, 12);
            naamTextBox.Name = "naamTextBox";
            naamTextBox.ReadOnly = true;
            naamTextBox.Size = new Size(100, 23);
            naamTextBox.TabIndex = 4;
            // 
            // DetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 139);
            Controls.Add(naamTextBox);
            Controls.Add(sterkteTextBox);
            Controls.Add(NaamGegevensLabel);
            Controls.Add(SterkteLabel);
            Controls.Add(NaamLabel);
            Name = "DetailForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NaamLabel;
        private Label SterkteLabel;
        private Label NaamGegevensLabel;
        private TextBox sterkteTextBox;
        private TextBox naamTextBox;
    }
}
