using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wielertenue
{
    public partial class BestellingForm : Form
    {

        private BestellingWielertenue _bestelling;
        public BestellingForm()
        {
            InitializeComponent();
            _bestelling = new BestellingWielertenue(1,false,false,false);
            prijsTextBox.Text = _bestelling.Geefprijs().ToString();
        }

        private void AantalnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _bestelling.Aantal = Convert.ToInt32(AantalnumericUpDown.Value);
            prijsTextBox.Text = _bestelling.Geefprijs().ToString();
        }

        private void SuperzeemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SuperzeemCheckBox.Checked)
            {
                _bestelling.SuperZeem = true;
               
            } else
            {
                _bestelling.SuperZeem = false;
            }
                prijsTextBox.Text = _bestelling.Geefprijs().ToString();
        }

        private void broekCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (broekCheckBox.Checked)
            {
                SuperzeemCheckBox.Visible = true;
                _bestelling.Broek = true;
                wielertenuePictureBox.Visible = true;
            }
            else { SuperzeemCheckBox.Visible = false;
                _bestelling.Broek = false;
                wielertenuePictureBox.Visible = false;
            }
            prijsTextBox.Text = _bestelling.Geefprijs().ToString();
        }

        private void waterdichtZakjeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (waterdichtZakjeCheckBox.Checked)
            {
                _bestelling.WaterdichtZakje = true;
            }
            else
            {
                _bestelling.WaterdichtZakje = false;
            }
            prijsTextBox.Text = _bestelling.Geefprijs().ToString();
        }
    }
}
