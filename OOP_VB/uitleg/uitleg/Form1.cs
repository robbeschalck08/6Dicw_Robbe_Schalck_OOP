using System.ComponentModel.DataAnnotations;

namespace uitleg
{
    public partial class Form1 : Form //form kan opstarten/sluiten
    {
        private Lowie _lowie;


        public Form1()
        {
            InitializeComponent();
            _lowie = new Lowie(50);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = _lowie.Leeftijd.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _lowie.Leeftijd = 20;
            label2.Text = _lowie.KmPerUur.ToString();
        }
    }
}
