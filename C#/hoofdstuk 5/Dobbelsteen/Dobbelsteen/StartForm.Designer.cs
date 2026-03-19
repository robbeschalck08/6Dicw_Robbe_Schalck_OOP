namespace Presentation
{
    partial class StartForm
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
            dobbelsteen6Button = new Button();
            dobbelsteen12Button = new Button();
            dobbelsteenXButton = new Button();
            zijdenNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)zijdenNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // dobbelsteen6Button
            // 
            dobbelsteen6Button.Location = new Point(283, 57);
            dobbelsteen6Button.Name = "dobbelsteen6Button";
            dobbelsteen6Button.Size = new Size(147, 23);
            dobbelsteen6Button.TabIndex = 0;
            dobbelsteen6Button.Text = "Klassieke dobbelsteen";
            dobbelsteen6Button.UseVisualStyleBackColor = true;
            dobbelsteen6Button.Click += dobbelsteen6Button_Click_1;
            // 
            // dobbelsteen12Button
            // 
            dobbelsteen12Button.Location = new Point(283, 86);
            dobbelsteen12Button.Name = "dobbelsteen12Button";
            dobbelsteen12Button.Size = new Size(148, 23);
            dobbelsteen12Button.TabIndex = 1;
            dobbelsteen12Button.Text = "12-zijdige dobbelsteen";
            dobbelsteen12Button.UseVisualStyleBackColor = true;
            dobbelsteen12Button.Click += dobbelsteen12Button_Click_1;
            // 
            // dobbelsteenXButton
            // 
            dobbelsteenXButton.Location = new Point(283, 212);
            dobbelsteenXButton.Name = "dobbelsteenXButton";
            dobbelsteenXButton.Size = new Size(141, 23);
            dobbelsteenXButton.TabIndex = 2;
            dobbelsteenXButton.Text = "x-zijdige dobbelsteen";
            dobbelsteenXButton.UseVisualStyleBackColor = true;
            dobbelsteenXButton.Click += dobbelsteenXButton_Click_1;
            // 
            // zijdenNumericUpDown
            // 
            zijdenNumericUpDown.Location = new Point(283, 165);
            zijdenNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            zijdenNumericUpDown.Name = "zijdenNumericUpDown";
            zijdenNumericUpDown.Size = new Size(120, 23);
            zijdenNumericUpDown.TabIndex = 3;
            zijdenNumericUpDown.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(zijdenNumericUpDown);
            Controls.Add(dobbelsteenXButton);
            Controls.Add(dobbelsteen12Button);
            Controls.Add(dobbelsteen6Button);
            Name = "StartForm";
            Text = "StartForm";
//            Load += StartForm_Load;
            ((System.ComponentModel.ISupportInitialize)zijdenNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button dobbelsteen6Button;
        private Button dobbelsteen12Button;
        private Button dobbelsteenXButton;
        private NumericUpDown zijdenNumericUpDown;
    }
}