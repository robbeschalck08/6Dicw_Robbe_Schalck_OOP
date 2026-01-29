using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drielagenmodel_kindvoorspeller_Robbe_Schalck
{
    internal class KindLengteVoorspeller
    {
        private double _lengteMan; //dit veld houd de lengte van de man bij
        private double _lengteVrouw; //dit veld houd de lengte van de vrouw bij
        private int _aantalVoorspellingen; //dit veld houd het aantal voorspellingen bij

        public KindLengteVoorspeller() //de constructor
        {
            _lengteMan = 0;
            _lengteVrouw = 0;
            _aantalVoorspellingen = 0;
        }

        public double LengteMan //property voor het veld "_lengteMan"
        {
            get { return _lengteMan; }
            set { _lengteMan = value; }
        }

        public double LengteVrouw //property voor het veld "_lengteVrouw"
        {
            get { return _lengteVrouw; }
            set { _lengteVrouw = value; }
        }

        public int AantalVoorspellingen //property voor het veld "_aantalVoorspellingen"
        {
            get { return _aantalVoorspellingen; }
            set { _aantalVoorspellingen = value; }
        }

        public double GemiddeldeOuders() //deze methode berekent de gemiddelde lengte van de ouders
        {
            double _gemiddelde = (_lengteMan + _lengteVrouw) / 2;
            return _gemiddelde;
        }

        public double BerekenDochter() //deze methode berekent hoe lang de dochter ongeveer gaat zijn
        {
            double _lengteDochter = GemiddeldeOuders() - 6.5;
            return _lengteDochter;
            
        }

        public double BerekenZoon() //deze methode berekent hoe lang de zoon ongeveer gaat zijn
        {
            double _lengteZoon = GemiddeldeOuders() + 6.5;
            return _lengteZoon;

        }


    }
}
