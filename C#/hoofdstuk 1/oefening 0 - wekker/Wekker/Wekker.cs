using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wekker
{
    public class Wekker
    {
        private int _uur;
        private int _minuut;

        public Wekker()
        {
            _uur = 0;
            _minuut = 0;
        }

        public int getUur()
        {
            return _uur;
        }

        public int getMinuut()
        {
            return _minuut;
        }

        public void setUur(int uur)
        {
            this._uur = uur;
        }

        public void setMinuut(int minuut)
        {
            this._minuut = minuut;
        }

        public void urenPlus()
        {
            _uur++;
            if (_uur > 23)
            {
                _uur = _uur - 24;
            }
        }

        public void urenMin()
        {
            _uur--;
            if (_uur < 0)
            {
                _uur = _uur + 24;
            }
        }

        public void minutenPlus()
        {
            _minuut++;
            if (_minuut > 59)
            {
                _minuut = _minuut - 60;
            }
        }

        public void minutenMin()
        {
            _minuut--;
            if (_minuut < 0)
            {
                _minuut = _minuut + 60;
            }
        }

        public String alarmOm()
        {
            String minuutString;
            String uurString;

            minuutString = displayTweeCijfers(_minuut);
            uurString = displayTweeCijfers(_uur);

            return uurString + ":" + minuutString;
        }

        private String displayTweeCijfers(int getal)
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
