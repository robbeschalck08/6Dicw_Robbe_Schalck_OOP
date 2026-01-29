namespace drielagenmodel_kindvoorspeller_Robbe_Schalck
{
    public partial class Form1 : Form
    {
        private KindLengteVoorspeller _kindLengteVoorspeller; //het veld die verwijst naar de klasse KindLengteVoorspeller 
        public Form1()
        {
            InitializeComponent();
            _kindLengteVoorspeller = new KindLengteVoorspeller(); //het object aanmaken
            label4.Text = "Nog geen voorspellingen"; //label 4 een standaar zin geven
        }

        private void button1_Click(object sender, EventArgs e) //als knop 1 wordt aangeklikt
        {
            _kindLengteVoorspeller.LengteMan = Convert.ToDouble(textBox1.Text); //geeft het veld "_lengteMan" de waarde die in textbox1 staat maar omgezet in een double
            _kindLengteVoorspeller.LengteVrouw = Convert.ToDouble(textBox2.Text); //geeft het veld "_lengteVrouw" de waarde die in textbox2 staat maar omgezet in een double
            label3.Text = _kindLengteVoorspeller.BerekenDochter().ToString("0.00"); //berekent de lengte van de dochter omdat dit de knop is voor de dochter met 2 cijfers na de komma
            _kindLengteVoorspeller.AantalVoorspellingen += 1; //per keer dat deze knop wordt aangeklikt gaan de voorspellingen met 1 omhoog
            label4.Text = _kindLengteVoorspeller.AantalVoorspellingen.ToString(); //geeft het aantal voorspellingen aan de label 4
            label3.Visible = true; //als er op de knop geklikt wordt dan gaat label 3 zienbaar zijn
        }

        private void button2_Click(object sender, EventArgs e) //als knop 2 wordt aangeklikt
        {
            _kindLengteVoorspeller.LengteMan = Convert.ToDouble(textBox1.Text); //geeft het veld "_lengteMan" de waarde die in textbox1 staat maar omgezet in een double
            _kindLengteVoorspeller.LengteVrouw = Convert.ToDouble(textBox2.Text); //geeft het veld "_lengteVrouw" de waarde die in textbox2 staat maar omgezet in een double
            label3.Text = _kindLengteVoorspeller.BerekenZoon().ToString("0.00"); //berekent de lengte van de dochter omdat dit de knop is voor de dochter met 2 cijfers na de komma
            _kindLengteVoorspeller.AantalVoorspellingen += 1; //per keer dat deze knop wordt aangeklikt gaan de voorspellingen met 1 omhoog
            label4.Text = _kindLengteVoorspeller.AantalVoorspellingen.ToString(); //geeft het aantal voorspellingen aan de label 4
            label3.Visible = true; //als er op de knop geklikt wordt dan gaat label 3 zienbaar zijn
            ;
        }


    }
}
