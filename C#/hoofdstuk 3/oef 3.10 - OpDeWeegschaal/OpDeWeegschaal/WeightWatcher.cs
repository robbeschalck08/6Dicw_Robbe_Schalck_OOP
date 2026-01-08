using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpDeWeegschaal
{
    public class WeightWatcher
    {
        private int _gewicht;
        private double _grootte;

        public WeightWatcher(int gewicht, double grootte) // Constructor
        {
            _gewicht = gewicht;
            _grootte = grootte;
        }

        public int Gewicht // Property Gewicht (read & write)
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }

        public double Grootte // Property Grootte (read-only)
        {
            get { return _grootte; }
        }

        public double GeefBMI()
        {
            return _gewicht / (_grootte * _grootte);
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
}
