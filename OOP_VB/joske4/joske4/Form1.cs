namespace joske4
{
    public partial class Form1 : Form
    {

        private WekkerCode _wekker;
        public Form1()
        {

            InitializeComponent();
            _wekker = new WekkerCode();
            _wekker.ToonUur();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            _wekker.UurOmhoog();
            textBox1.Text = _wekker.ToonUur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _wekker.MinutenOmhoog();
            textBox1.Text = _wekker.ToonUur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _wekker.UurOmLaag();
            textBox1.Text = _wekker.ToonUur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _wekker.MinutenOmLaag();
            textBox1.Text = _wekker.ToonUur();
        }
    }
}
