using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3lagenmodel_test_h3_Schalck_Robbe
{
    internal class ComedyShow
    {
        private string _naam;
        private int _show;

        public ComedyShow()
        {
            _naam = "...";
            _show = 0;
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public int Show
        {
            get { return _show; }
            set { _show = value; }
        }

        public double BerekenGemiddelde(double _score)
        {
            int _aantal = 0;
            _aantal += 1;
            double _gemiddelde = _score / _aantal;
            return _gemiddelde;
        }

    }
}