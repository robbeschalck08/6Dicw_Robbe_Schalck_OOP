using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    internal class Bankrekening
    {
        private string _rekeninghouder;
        private double _saldo;

        public Bankrekening(string rekeninghouder, double saldo)
        {
            _rekeninghouder = rekeninghouder;
            if (saldo < 0)
            {
                _saldo = 0;
            }        
        }

        public string Rekeninghouder
        {
            get { return _rekeninghouder; }
            set { _rekeninghouder = value;}
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public bool IsRood
        {
           get{ return _saldo > 0; }
        }

        public void Stort(double bedrag) { 
        if (bedrag > 0)
            {
                _saldo += bedrag;
            }
        }

        public void HaalAf(double bedrag)
        {
            if (bedrag > 0 && _saldo - bedrag >= 0)
            {
                _saldo -= bedrag;
            }
        }
    }
}
