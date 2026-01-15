using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Gebruiker
    {
        private String _naam;
        private int _stappen;

        public Gebruiker(String _naam)
        {
            this._naam = _naam;
            this._stappen = 0;
        }

        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public int Stappen
        {
            get { return _stappen; }
            set { _stappen = value; }
        }

        public double AfstadInKm
        {
            get {
                return _stappen * 0.0008;
            } 
        }

    }
}
