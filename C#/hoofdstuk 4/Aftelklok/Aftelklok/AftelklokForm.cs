using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aftelklok
{
    public partial class AftelklokForm : Form
    {
        private Aftelklok _klokje;  // het veld _klokje declareren

        public AftelklokForm()
        {
            InitializeComponent();

            // het veld _klokje initialiseren als een nieuw Aftelklok-object
            // _klokje wordt hierbij ingesteld op 1 minuut 30 seconden
            _klokje = new Aftelklok(1, 30);

            // de tijd van _klokje in het tekstvak tonen
            displayTextBox.Text = _klokje.ResterendeTijd();
        }

        private void aftelklokTimer_Tick(object sender, EventArgs e)
        {
            // _klokje met één seconde verminderen
            _klokje.Aftellen();

            // nieuwe resterende tijd van _klokje in tekstvak zetten
            displayTextBox.Text = _klokje.ResterendeTijd();
        }

        private void opnieuwOpStarttijd_Click(object sender, EventArgs e)
        {
            // _klokje opnieuw instellen op 1 minuut en 30 seconden
            _klokje.TijdInstellen(1, 30);

            // tekstvak vernieuwen
            displayTextBox.Text = _klokje.ResterendeTijd();
            aftelklokTimer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aftelklokTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aftelklokTimer.Stop();
        }
    }
}
