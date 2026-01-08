using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartphone
{
    internal class Program
    {
        public class Smartphone
        { 
            private String _telnummer;
            private String _pincode;
            public Smartphone(String telnummer, String pincode) 
            {
                _telnummer = telnummer;
                _pincode = pincode;            
            }
            public String Telnummer
            {
                get { return _telnummer; }
                set { _telnummer = value; }
            }
            public String Pincode
            { 
                get { return _pincode; } 
                set { _pincode = value; }
            }         
        }
        static void Main(string[] args)
        {
            Smartphone smartPhone = new Smartphone("nummer", "1234");
            smartPhone.Telnummer = "0479394021";
            smartPhone.Pincode = "5678";
            Console.WriteLine(smartPhone.Pincode);
            Console.WriteLine(smartPhone.Telnummer);
            Console.ReadLine();
        }
    }
}
