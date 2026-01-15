using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joske4
{
    internal class WekkerCode
    {
        private int _uren;
        private int _minuten;
        public WekkerCode() {
        _uren = 0;
        _minuten = 0;
        }

        public void UurOmhoog()
        {
           _uren+= 1;
        }

        public void UurOmLaag()
        {
            _uren -= 1;
        }

        public void MinutenOmhoog()
        {
            _minuten += 1;
        }

        public void MinutenOmLaag()
        {
            _minuten -= 1;
        }

        public String ToonUur()
        {
            String minuutString;
            String uurString;
            minuutString = DisplayTweeCijfers(_minuten);
            uurString = DisplayTweeCijfers(_uren);
            return uurString + ":" + minuutString;
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
