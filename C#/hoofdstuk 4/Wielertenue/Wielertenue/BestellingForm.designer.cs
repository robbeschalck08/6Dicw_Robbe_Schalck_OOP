namespace Wielertenue
{
    partial class BestellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestellingForm));
            this.wielertruiPictureBox = new System.Windows.Forms.PictureBox();
            this.wielertenuePictureBox = new System.Windows.Forms.PictureBox();
            this.AantalnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.waterdichtZakjeCheckBox = new System.Windows.Forms.CheckBox();
            this.broekCheckBox = new System.Windows.Forms.CheckBox();
            this.SuperzeemCheckBox = new System.Windows.Forms.CheckBox();
            this.prijsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AantalnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // wielertruiPictureBox
            // 
            this.wielertruiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertruiPictureBox.Image")));
            this.wielertruiPictureBox.Location = new System.Drawing.Point(16, 9);
            this.wielertruiPictureBox.Name = "wielertruiPictureBox";
            this.wielertruiPictureBox.Size = new System.Drawing.Size(358, 345);
            this.wielertruiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertruiPictureBox.TabIndex = 0;
            this.wielertruiPictureBox.TabStop = false;
            // 
            // wielertenuePictureBox
            // 
            this.wielertenuePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertenuePictureBox.Image")));
            this.wielertenuePictureBox.Location = new System.Drawing.Point(16, 9);
            this.wielertenuePictureBox.Name = "wielertenuePictureBox";
            this.wielertenuePictureBox.Size = new System.Drawing.Size(358, 345);
            this.wielertenuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertenuePictureBox.TabIndex = 0;
            this.wielertenuePictureBox.TabStop = false;
            this.wielertenuePictureBox.Visible = false;
//            this.wielertenuePictureBox.Click += new System.EventHandler(this.wielertenuePictureBox_Click);
            // 
            // AantalnumericUpDown
            // 
            this.AantalnumericUpDown.Location = new System.Drawing.Point(479, 60);
            this.AantalnumericUpDown.Name = "AantalnumericUpDown";
            this.AantalnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.AantalnumericUpDown.TabIndex = 1;
            this.AantalnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AantalnumericUpDown.ValueChanged += new System.EventHandler(this.AantalnumericUpDown_ValueChanged);
            // 
            // waterdichtZakjeCheckBox
            // 
            this.waterdichtZakjeCheckBox.AutoSize = true;
            this.waterdichtZakjeCheckBox.Location = new System.Drawing.Point(490, 121);
            this.waterdichtZakjeCheckBox.Name = "waterdichtZakjeCheckBox";
            this.waterdichtZakjeCheckBox.Size = new System.Drawing.Size(108, 17);
            this.waterdichtZakjeCheckBox.TabIndex = 2;
            this.waterdichtZakjeCheckBox.Text = "Waterdicht Zakje";
            this.waterdichtZakjeCheckBox.UseVisualStyleBackColor = true;
            this.waterdichtZakjeCheckBox.CheckedChanged += new System.EventHandler(this.waterdichtZakjeCheckBox_CheckedChanged);
            // 
            // broekCheckBox
            // 
            this.broekCheckBox.AutoSize = true;
            this.broekCheckBox.Location = new System.Drawing.Point(490, 166);
            this.broekCheckBox.Name = "broekCheckBox";
            this.broekCheckBox.Size = new System.Drawing.Size(54, 17);
            this.broekCheckBox.TabIndex = 3;
            this.broekCheckBox.Text = "Broek";
            this.broekCheckBox.UseVisualStyleBackColor = true;
            this.broekCheckBox.CheckedChanged += new System.EventHandler(this.broekCheckBox_CheckedChanged);
            // 
            // SuperzeemCheckBox
            // 
            this.SuperzeemCheckBox.AutoSize = true;
            this.SuperzeemCheckBox.Location = new System.Drawing.Point(490, 201);
            this.SuperzeemCheckBox.Name = "SuperzeemCheckBox";
            this.SuperzeemCheckBox.Size = new System.Drawing.Size(79, 17);
            this.SuperzeemCheckBox.TabIndex = 4;
            this.SuperzeemCheckBox.Text = "Superzeem";
            this.SuperzeemCheckBox.UseVisualStyleBackColor = true;
            this.SuperzeemCheckBox.Visible = false;
            this.SuperzeemCheckBox.CheckedChanged += new System.EventHandler(this.SuperzeemCheckBox_CheckedChanged);
            // 
            // prijsTextBox
            // 
            this.prijsTextBox.Location = new System.Drawing.Point(490, 277);
            this.prijsTextBox.Name = "prijsTextBox";
            this.prijsTextBox.ReadOnly = true;
            this.prijsTextBox.Size = new System.Drawing.Size(100, 20);
            this.prijsTextBox.TabIndex = 5;
            // 
            // BestellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 369);
            this.Controls.Add(this.prijsTextBox);
            this.Controls.Add(this.SuperzeemCheckBox);
            this.Controls.Add(this.broekCheckBox);
            this.Controls.Add(this.waterdichtZakjeCheckBox);
            this.Controls.Add(this.AantalnumericUpDown);
            this.Controls.Add(this.wielertenuePictureBox);
            this.Controls.Add(this.wielertruiPictureBox);
            this.Name = "BestellingForm";
            this.Text = "BestellingWielertenueForm";
//            this.Load += new System.EventHandler(this.BestellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AantalnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wielertruiPictureBox;
        private System.Windows.Forms.PictureBox wielertenuePictureBox;
        private System.Windows.Forms.NumericUpDown AantalnumericUpDown;
        private System.Windows.Forms.CheckBox waterdichtZakjeCheckBox;
        private System.Windows.Forms.CheckBox broekCheckBox;
        private System.Windows.Forms.CheckBox SuperzeemCheckBox;
        private System.Windows.Forms.TextBox prijsTextBox;
    }
}