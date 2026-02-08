using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aftelklok
{
    public class Aftelklok
    {
        private int _minuten;
        private int _seconden;

        public Aftelklok(int minuten, int seconden)
        {
            _minuten = minuten;
            _seconden = seconden;
        }

        public int GetMinuten()
        {
            return _minuten;
        }

        public int GetSeconden()
        {
            return _seconden;
        }

        public void SetMinuten(int minuten)
        {
            _minuten = minuten;
        }

        public void SetSeconden(int seconden)
        {
            _seconden = seconden;
        }

        public void TijdInstellen(int minuten, int seconden)
        {
            _minuten = minuten;
            _seconden = seconden;
        }

        public void Aftellen()
        {
            if (_seconden > 0)
            {
                _seconden--;
            }
            else
            {
                if (_minuten > 0)
                {
                    _minuten--;
                    _seconden = 59;
                }
            }
        }
        
        public String ResterendeTijd()
        {
            String minuutString;
            String secondenString;

            minuutString = DisplayTweeCijfers(_minuten);
            secondenString = DisplayTweeCijfers(_seconden);

            return minuutString + ":" + secondenString;
        }

        private String DisplayTweeCijfers(int getal)
        {
            String displayString;

            if (getal < 10)
            {
                displayString = "0" + getal.ToString();
            }
            else
            {
                displayString = getal.ToString();
            }

            return displayString;
        }
    }
}

