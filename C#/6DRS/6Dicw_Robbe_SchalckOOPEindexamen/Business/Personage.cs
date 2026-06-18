using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Personage
    {
        private string _naam;
        private string _rol;
        private int _leeftijd;

        public Personage(string naam, string rol, int leeftijd)
        {
            _naam = naam;
            _rol = rol;
            _leeftijd = leeftijd;
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public string Rol
        { 
            get { return _rol; }
            set { _rol = value; }
        }

        public int Leeftijd
        {
            get { return _leeftijd; }
            set { _leeftijd = value; }
        }
    }
}
