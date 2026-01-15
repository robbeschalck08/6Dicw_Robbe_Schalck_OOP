namespace oefenen
{
    partial class BMIForm
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
            minButton = new Button();
            plusButton = new Button();
            gewichtTextBox = new TextBox();
            label1 = new Label();
            lengteTextBox = new TextBox();
            label2 = new Label();
            bmiTextBox = new TextBox();
            statusTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // minButton
            // 
            minButton.Location = new Point(312, 92);
            minButton.Name = "minButton";
            minButton.Size = new Size(33, 23);
            minButton.TabIndex = 0;
            minButton.Text = "-";
            minButton.UseVisualStyleBackColor = true;
            minButton.Click += minButton_Click;
            // 
            // plusButton
            // 
            plusButton.Location = new Point(425, 92);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(33, 23);
            plusButton.TabIndex = 1;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // gewichtTextBox
            // 
            gewichtTextBox.Location = new Point(351, 92);
            gewichtTextBox.Name = "gewichtTextBox";
            gewichtTextBox.Size = new Size(68, 23);
            gewichtTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 95);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 3;
            label1.Text = "Gewicht (in kg)";
            // 
            // lengteTextBox
            // 
            lengteTextBox.Location = new Point(351, 33);
            lengteTextBox.Name = "lengteTextBox";
            lengteTextBox.Size = new Size(100, 23);
            lengteTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 41);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 5;
            label2.Text = "hoogte (in meter)";
            // 
            // bmiTextBox
            // 
            bmiTextBox.Location = new Point(351, 140);
            bmiTextBox.Name = "bmiTextBox";
            bmiTextBox.Size = new Size(100, 23);
            bmiTextBox.TabIndex = 6;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(351, 189);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(100, 23);
            statusTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 143);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 8;
            label3.Text = "bmi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 197);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 317);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(statusTextBox);
            Controls.Add(bmiTextBox);
            Controls.Add(label2);
            Controls.Add(lengteTextBox);
            Controls.Add(label1);
            Controls.Add(gewichtTextBox);
            Controls.Add(plusButton);
            Controls.Add(minButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button minButton;
        private Button plusButton;
        private TextBox gewichtTextBox;
        private Label label1;
        private TextBox lengteTextBox;
        private Label label2;
        private TextBox bmiTextBox;
        private TextBox statusTextBox;
        private Label label3;
        private Label label4;
    }
}
