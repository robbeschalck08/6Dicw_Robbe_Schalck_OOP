using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Reisbureau
{
    public class Groepsreis
    {
        private string _bestemming;
        private int _maxDeelnemers;
        private int _inschrijvingen;
        private double _prijsPerPersoon;
        private bool _kinderenToegelaten;
        private char _klasseVerblijf;
        public Groepsreis(String _bestemming, int _maxDeelnemers, double _prijsPerPersoon)
        {
            this._bestemming = _bestemming;
            this._maxDeelnemers= _maxDeelnemers;
            this._prijsPerPersoon = _prijsPerPersoon;
            this._inschrijvingen = 1;
            this._kinderenToegelaten = true;
            this._klasseVerblijf = 'B';
        }

        public string getBestemming()
        {
            return _bestemming;
        }
        public int getMaxDeelnemers()
        {
            return _maxDeelnemers;
        }
        public int getInschrijvingen()
        {
            return _inschrijvingen;
        }
        public double getPrijsPerPersoon()
        {
            return _prijsPerPersoon;
        }
        public bool getkinderenToegelaten()
        {
            return _kinderenToegelaten;
        }
        public char getKlasseVerblijf()
        {
            return _klasseVerblijf;
        }

        public void SetPrijsPerPersoon( int _prijsPerPersoon)
        {
            this._prijsPerPersoon = _prijsPerPersoon;
        }

        public void setKinderenToegelaten(bool _kinderenToegelaten)
        {
            this._kinderenToegelaten= _kinderenToegelaten;
        }

        public void setKlasseVerblijf( char _klasseVerblijf)
        {
            this._klasseVerblijf = _klasseVerblijf;
        }

        public void VolwasseneInschrijven()
        {
            if (this._maxDeelnemers != _inschrijvingen) {
                this._inschrijvingen += 1;
        }
    }

}
