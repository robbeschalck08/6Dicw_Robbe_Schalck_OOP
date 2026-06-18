using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Planeet
    {
        private String _naam;
        private String _zonneStelsel;
        private Boolean _bewoonbaar;

        public Planeet(String naam, String zonneStelsel, Boolean bewoonbaar)
        {
            _naam = naam;
            _zonneStelsel = zonneStelsel;
            _bewoonbaar = bewoonbaar;
        }

        public String Naam
        { 
            get { return _naam; } 
            set { _naam = value; } 
        }

        public String ZonneStelsel
        {
            get { return _zonneStelsel; }
            set { _zonneStelsel= value; }
        }

        public Boolean Bewoonbaar
        {
            get { return _bewoonbaar; }
            set { _bewoonbaar = value; }
        }
    }
}
