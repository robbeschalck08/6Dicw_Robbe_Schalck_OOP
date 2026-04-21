using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DnD
    {
        private List<Karakter> _lstKarakters;

        public DnD()
        {
            _lstKarakters= new List<Karakter>();
        }

        public List<Karakter> GeefAlleKarakters()
        {
            return _lstKarakters;
        }

        public bool Aanwezig(String naam)
        {
            foreach (Karakter karakter in _lstKarakters)
            {
                if (karakter.Naam == naam)
                {
                    return true;
                }
            }
            return false;
        }

        public Karakter GeefKarakter(String naam)
        {
            foreach (Karakter karakter in _lstKarakters)
            {
                if (karakter.Naam == naam)
                {
                    return karakter;
                }
            }
            return null;
        }

        public void VoegToe(String naam, int sterkte)
        {
            int _controleren = 0;
            foreach(Karakter karakter in _lstKarakters)
            {
                if (karakter.Naam == naam)
                {
                    _controleren += 1;
                }
            }
            if (_controleren == 0)
            {
                Karakter karakter = new Karakter(naam, sterkte);
                _lstKarakters.Add(karakter);
            }
        }
    }
}
