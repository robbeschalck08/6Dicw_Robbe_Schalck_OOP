using System.Security.Cryptography.X509Certificates;

namespace _3lagenmodel_test_h3_Schalck_Robbe
{
    public partial class Form1 : Form
    {
        private ComedyShow _comedyShow;
        public Form1()
        {
            InitializeComponent();

            _comedyShow = new ComedyShow();
        }

        public void Toonalles()
        {

        }
        public void Leegmaken()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double _aantal = Convert.ToDouble(textBox2.Text);
            Leegmaken();
            label5.Text = _comedyShow.BerekenGemiddelde(_aantal).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}

