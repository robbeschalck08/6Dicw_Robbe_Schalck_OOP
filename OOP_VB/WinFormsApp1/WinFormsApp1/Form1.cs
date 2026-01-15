namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Gebruiker _gebruiker;
        public Form1()
        {
            InitializeComponent();
            _gebruiker = new Gebruiker("Robbe");
            Updaten();
        }

        public void Updaten()
        {
            Naam.Text = _gebruiker.Naam.ToString();
            stappen.Text = _gebruiker.Stappen.ToString();
            kmBox.Text = _gebruiker.AfstadInKm.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _gebruiker.Stappen += 100;
            Updaten();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _gebruiker.Stappen -= 100;
            Updaten();
        }
    }
}
