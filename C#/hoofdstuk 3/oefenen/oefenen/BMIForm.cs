using System.Security.Cryptography.X509Certificates;

namespace oefenen
{
    public partial class BMIForm : Form
    {
        private WeightWatcher _schrijven;
        public BMIForm()
        {
            InitializeComponent();

            _schrijven = new WeightWatcher(80, 1.85);
            ToonAlles();
        }

        public void ToonAlles()
        {
            gewichtTextBox.Text = _schrijven.Gewicht.ToString("0,0");
            lengteTextBox.Text = _schrijven.Lengte.ToString();
            bmiTextBox.Text = _schrijven.GeefBMI().ToString("0,0");
            statusTextBox.Text = _schrijven.GeefStatus();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            _schrijven.Gewicht = _schrijven.Gewicht - 1;
            ToonAlles();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            _schrijven.Gewicht = _schrijven.Gewicht + 1;
            ToonAlles();
        }

    }

}

