using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Schip
    {
        private String _naam;
        private String _type;
        private int _bouwjaar;
        private int _aantalBemanning;
        private String _status;
        
        public Schip(String naam,String type,int bouwjaar,int aantalBemanning,String status)
        {
            _naam = naam;
            _type = type;
            _bouwjaar = bouwjaar;
            _aantalBemanning=aantalBemanning;
            _status = status;
        }

        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Bouwjaar
        { get { return _bouwjaar; }
          set { _bouwjaar = value; }
            
        }
            public int AantalBemanning
        {
            get{ return _aantalBemanning;}
            set {  _aantalBemanning = value;}
        }

        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

    }
}
