using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wielertenue
{
    class BestellingWielertenue
    {
        private int _aantal;  // hoeveel stuks bestel je
        private bool _waterdichtZakje;  // is er in het truitje een waterdicht GSM-opbergzakje voorzien
        private bool _broek;  // neem je ook de wielerbroek (of anders enkel het wielertruitje)
        private bool _superZeem; // is de wielerbroek voorzien van een zeem met hogere kwaliteit

        public BestellingWielertenue(int aantal, bool waterdichtZakje, bool broek, bool superZeem)
        {
            _aantal = aantal;
            _waterdichtZakje = waterdichtZakje;
            _broek = broek;
            _superZeem = superZeem;
        }

        public int Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }

        public bool WaterdichtZakje
        {
            get { return _waterdichtZakje; }
            set { _waterdichtZakje = value; }
        }

        public bool Broek
        {
            get { return _broek; }
            set { _broek = value; }
        }

        public bool SuperZeem
        {
            get { return _superZeem; }
            set { _superZeem = value; }
        }

        public decimal Geefprijs()
        {
            decimal _hoeveelheid = 45;
            decimal _totaleHoeveelheid = 0;
            if (_broek && _waterdichtZakje && _superZeem)
            {
                _hoeveelheid += 49;
            }
            else if (_broek && _waterdichtZakje)
            {
                _hoeveelheid = _hoeveelheid + 43.50m;
            }
            else if (_broek && _superZeem)
            {
                _hoeveelheid = _hoeveelheid + 45.50m;
            }
            else if (_superZeem && _waterdichtZakje)
            {
                _hoeveelheid = _hoeveelheid + 9.00m;
            }
            else if (_broek)
            {
                _hoeveelheid += 40;
            }
            else if (_waterdichtZakje)
            {
                _hoeveelheid += 3.50m;
            }
            else if (_superZeem)
            {
                _hoeveelheid += 5.50m;
            }
            if (_aantal >= 5)
            {
                _totaleHoeveelheid = _hoeveelheid - (_hoeveelheid / 100 * 10);
                return _totaleHoeveelheid;
            }
            else
            {
                return _hoeveelheid*Aantal;
            }

        }
    }
}