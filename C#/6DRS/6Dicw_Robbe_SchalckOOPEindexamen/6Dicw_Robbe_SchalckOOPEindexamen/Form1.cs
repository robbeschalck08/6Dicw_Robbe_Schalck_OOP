using DataLaag;
using Business;
namespace _6Dicw_Robbe_SchalckOOPEindexamen
{
    public partial class Form1 : Form
    {
        private BSGData _data;
        public Form1()
        {
            InitializeComponent();
            _data = new BSGData();
        }

        private void laadPersonage_button_Click(object sender, EventArgs e)
        {
            laadPersonages();

        }

        private void laadPlaneten_button_Click(object sender, EventArgs e)
        {
            laadPlaneten();
        }

        private void laadVloot_button_Click(object sender, EventArgs e)
        {
            laadVloten();
        }

        private void herlaadData_button_Click(object sender, EventArgs e)
        {
            _data.laadData();
            laadVloten();
            laadPlaneten();
            laadPersonages();
            textBox1.BackColor = Color.White;
        }

        private void laadVloten()
        {
            Schip_dataGridView.Columns.Clear();
            Schip_dataGridView.Rows.Clear();

            Schip_dataGridView.Columns.Add("NaamCol", "Naam");
            Schip_dataGridView.Columns.Add("TypeCol", "Type");
            Schip_dataGridView.Columns.Add("BouwjaarCol", "Bouwjaar");
            Schip_dataGridView.Columns.Add("AantalBemanningCol", "AantalBemanning");
            Schip_dataGridView.Columns.Add("StatusCol", "Status");

            List<Schip> schepen = _data.GeefLijstSchepen();
            foreach (Schip schip in schepen)
            {
                Schip_dataGridView.Rows.Add(schip.Naam, schip.Type, schip.Bouwjaar, schip.AantalBemanning, schip.Status);
            }
        }

        private void laadPlaneten()
        {
            Planeet_dataGridView1.Columns.Clear();
            Planeet_dataGridView1.Rows.Clear();

            Planeet_dataGridView1.Columns.Add("NaamCol", "Naam");
            Planeet_dataGridView1.Columns.Add("RolCol", "Rol");
            Planeet_dataGridView1.Columns.Add("LeeftijdCol", "Leeftijd");

            List<Planeet> planeten = _data.GeefLijstPlaneten();
            foreach (Planeet planeet in planeten)
            {
                Planeet_dataGridView1.Rows.Add(planeet.Naam, planeet.ZonneStelsel, planeet.Bewoonbaar);
            }
        }

        private void laadPersonages()
        {
            Personage_dataGridView.Columns.Clear();
            Personage_dataGridView.Rows.Clear();

            Personage_dataGridView.Columns.Add("NaamCol", "Naam");
            Personage_dataGridView.Columns.Add("RolCol", "Rol");
            Personage_dataGridView.Columns.Add("LeeftijdCol", "Leeftijd");

            List<Personage> personages = _data.GeefLijstPersonage();
            foreach (Personage personage in personages)
            {
                Personage_dataGridView.Rows.Add(personage.Naam, personage.Rol, personage.Leeftijd);
            }
        }

        private void detectCyclon_button_Click(object sender, EventArgs e)
        {
            List<Personage> personages = _data.geefCylon();
            if (Personage_dataGridView.CurrentRow == null)
            {
                MessageBox.Show("selecteer eerst een personage");
            }
            else
            {
                int index = Personage_dataGridView.CurrentRow.Index;
                Personage slachtoffer = _data.GeefLijstPersonage()[index];
                int aantal = 0;
                foreach (Personage personage in personages)
                {
                    if (personage.Naam == slachtoffer.Naam)
                    {
                        aantal += 1;

                    }
                }
                if (aantal > 0)
                {
                    textBox1.BackColor = Color.Red;
                    aantal = 0;
                }
                else
                {
                    textBox1.BackColor = Color.Green;
                    aantal = 0;
                }
            }
        }


        private void danku_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bedankt voor de afgelopen 2 jaar, het was fijn om u als leerkracht te hebben!");
        }

        private void verwijder_button_Click(object sender, EventArgs e)
        {
            List<Personage> personages = _data.geefCylon();
            if (Personage_dataGridView.CurrentRow == null)
            {
                MessageBox.Show("selecteer eerst een personage");
            }
            else
            {
                int index = Personage_dataGridView.CurrentRow.Index;
                Personage slachtoffer = _data.GeefLijstPersonage()[index];
                int aantal = 0;
                foreach (Personage personage in personages)
                {
                    if (personage.Naam == slachtoffer.Naam)
                    {
                        aantal += 1;

                    }
                }
                if (aantal > 0)
                {
                    Personage_dataGridView.Rows.RemoveAt(index);
                }
                else
                {
                    textBox1.BackColor = Color.Green;
                    aantal = 0;
                }
            }
        }
    }
}
