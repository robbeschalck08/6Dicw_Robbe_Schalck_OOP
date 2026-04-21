using Business;

namespace Formulier
{
    public partial class DetailForm : Form
    {
        private Karakter _karakter;

        public DetailForm(Karakter karakter)
        {
            InitializeComponent();

            _karakter = karakter;

            naamTextBox.Text = _karakter.Naam;
            sterkteTextBox.Text = _karakter.Sterkte.ToString();

            naamTextBox.ReadOnly = true;
            sterkteTextBox.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
