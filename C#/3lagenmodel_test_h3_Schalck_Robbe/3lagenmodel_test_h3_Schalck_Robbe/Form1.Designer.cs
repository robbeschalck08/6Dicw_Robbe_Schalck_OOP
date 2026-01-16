namespace _3lagenmodel_test_h3_Schalck_Robbe
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 89);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 0;
            label1.Text = "voer de code van de comedyshow in: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 143);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "Score van de show";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(534, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(590, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(486, 189);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Show Toevoegen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(568, 251);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 291);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(586, 325);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 254);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 11;
            label6.Text = "Gemiddelde score";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 292);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 12;
            label7.Text = "Laatste show";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(259, 321);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 13;
            label8.Text = "Aantal Shows";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Show Toevoegen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
