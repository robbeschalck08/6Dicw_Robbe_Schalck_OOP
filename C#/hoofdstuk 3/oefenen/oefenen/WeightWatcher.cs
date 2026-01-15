using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenen
{
    internal class WeightWatcher
    {
        private int _gewicht;
        private double _lengte;
        public WeightWatcher(int _gewicht, double _lengte)
        {
            this._gewicht = _gewicht;
            this._lengte = _lengte;
        }

        public int Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }
        public double Lengte
        {
            get { return _lengte; }
        }

        public double GeefBMI()
        {
            return _gewicht / (_lengte * _lengte);
        }

        public string GeefStatus()
        {
            double bmi = GeefBMI();

            if (bmi >= 0 && bmi < 20)
            {
                return "ondergewicht";
            }
            else if (bmi >= 20 && bmi <= 25)
            {
                return "ok";
            }
            else if (bmi > 25 && bmi <= 30)
            {
                return "overgewicht";
            }
            else //derest
            {
                return "obees";
            }
        }
    }
}
