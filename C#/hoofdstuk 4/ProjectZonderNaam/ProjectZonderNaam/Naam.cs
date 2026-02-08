using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZonderNaam
{
    public class Naam
    {
        private String _voornaam;
        private String _familienaam;

        public Naam(String voornaam, String familienaam)
        {
            _voornaam = voornaam;
            _familienaam = familienaam;
        }

        public String Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public String Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }

        public String Volledigenaam(bool formeel)
        {
            String naam;

            if (formeel == true)
            {
                naam = _familienaam + " " + _voornaam;
            }
            else
            {
                naam = _voornaam + " " + _familienaam;
            }

            return naam;
        }

        public String Initialen()
        {
            return Voornaam.Substring(0, 0) + "." + Familienaam.Substring(0, 0);
        }
        public String AlfaVoornaam()
        {
            String nieuweVoornaam = Voornaam.Replace(" ", "").Replace("-", "").Replace("é", "e").Replace("è", "e");
            return nieuweVoornaam.ToLower();
        }

        public String AlfaFamilienaam()
        {
            String nieuweFamilienaam = Familienaam.Replace(" ", "").Replace("-", "").Replace("é", "e").Replace("è", "e");
            return nieuweFamilienaam.ToLower();
        }
    }
}
