using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uitleg
{
    internal class Lowie
    {
        private int _leeftijd;
        private int _kmPerUur;
        public Lowie(int kmPerUur)
        {
            _leeftijd = 44;
            _kmPerUur = kmPerUur;
        }
        public int Leeftijd
        {
            get { return _leeftijd; }
            set { _leeftijd = value; }

        }
        public int KmPerUur
        {
            get { return _kmPerUur; }
            set { _kmPerUur = value; }
        }
    }
}
