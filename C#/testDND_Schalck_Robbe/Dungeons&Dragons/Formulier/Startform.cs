using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formulier
{
    public partial class Startform : Form
    {
        private DnD _dnd;
        public Startform()
        {
            InitializeComponent();
            _dnd = new DnD();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            _dnd.VoegToe(typeTextBox.Text, int.Parse(sterkteTextBox.Text));
      
            comboBox1.DataSource = null;
            comboBox1.DataSource = _dnd.GeefAlleKarakters();
            comboBox1.DisplayMember = "Naam";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = " "+comboBox1.SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Karakter karakter = (Karakter)comboBox1.SelectedItem;

            if (karakter != null)
            {
                DetailForm formulier = new DetailForm(karakter);
                formulier.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _dnd.VoegToe(typeTextBox.Text, int.Parse(sterkteTextBox.Text));

            comboBox1.DataSource = null;
            comboBox1.DataSource = _dnd.GeefAlleKarakters();
            comboBox1.DisplayMember = "Naam";
        }
    }
}