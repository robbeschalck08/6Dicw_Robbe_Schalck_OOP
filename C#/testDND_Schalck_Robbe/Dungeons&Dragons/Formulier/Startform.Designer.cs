namespace Formulier
{
    partial class Startform
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
            typeTextBox = new TextBox();
            sterkteTextBox = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(115, 27);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(100, 23);
            typeTextBox.TabIndex = 0;
            // 
            // sterkteTextBox
            // 
            sterkteTextBox.Location = new Point(115, 74);
            sterkteTextBox.Name = "sterkteTextBox";
            sterkteTextBox.Size = new Size(100, 23);
            sterkteTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(240, 51);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(191, 162);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(191, 201);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 232);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // Startform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(sterkteTextBox);
            Controls.Add(typeTextBox);
            Name = "Startform";
            Text = "Startform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox typeTextBox;
        private TextBox sterkteTextBox;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}