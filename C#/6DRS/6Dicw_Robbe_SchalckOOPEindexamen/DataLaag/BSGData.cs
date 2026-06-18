using Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLaag
{
    public class BSGData
    {
        private String _connString;
        private MySqlConnection _mySqlConnection;
        private Personage _personage;
        public BSGData()
        {
            // connectiestring voor de MySQL-databank wandelroutes 
            _connString = "server=localhost;user id=root;Password=YyUR3R5w; database = cylondetector";
            // initialiseer de connectie op basis van de connectiestring 
            _mySqlConnection = new MySqlConnection(_connString);
        }

        public List<Personage> GeefLijstPersonage()
        {
            List<Personage> lijst = new List<Personage>();

            // SQL-statement om alle personages op te vragen  
            String sql = "SELECT * FROM Personages;";

            // SQL-commando aanmaken op basis van ons SQL-statement 
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // de connectie met de databank openen 
            _mySqlConnection.Open();

            // met ExecuteReader laat je een leescommando opstarten 
            // de ingelezen informatie komt in mySqlDataReader terecht 
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            // lusje om alle records in mySqlDataReader te overlopen 
            while (mySqlDataReader.Read() == true)
            {
                // nieuw personage maken met de actieve record in mySqlDataReader 
                Personage personage =
                     new Personage(mySqlDataReader["Naam"].ToString(),
                                     mySqlDataReader["Rol"].ToString(),
                                     (int)(mySqlDataReader["Leeftijd"]));

                // voeg de personage toe aan de lijst 
                lijst.Add(personage);
            }

            // de connectie met de databank terug sluiten 
            _mySqlConnection.Close();

            // lijst met alle personages retourneren 
            return lijst;
        }

        public List<Planeet> GeefLijstPlaneten()
        {
            List<Planeet> lijst = new List<Planeet>();

            // SQL-statement om alle planeten op te vragen  
            String sql = "SELECT * FROM Planeten;";

            // SQL-commando aanmaken op basis van ons SQL-statement 
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // de connectie met de databank openen 
            _mySqlConnection.Open();

            // met ExecuteReader laat je een leescommando opstarten 
            // de ingelezen informatie komt in mySqlDataReader terecht 
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            // lusje om alle records in mySqlDataReader te overlopen 
            while (mySqlDataReader.Read() == true)
            {
                // nieuwe planeet maken met de actieve record in mySqlDataReader 
                Planeet planeet =
                     new Planeet(mySqlDataReader["Naam"].ToString(),
                                     mySqlDataReader["Zonnestelsel"].ToString(),
                                     Convert.ToBoolean(mySqlDataReader["Bewoonbaar"]));
                lijst.Add(planeet);
            }

            // de connectie met de databank terug sluiten 
            _mySqlConnection.Close();

            // lijst met alle planeten retourneren 
            return lijst;
        }

        public List<Schip> GeefLijstSchepen()
        {
            List<Schip> lijst = new List<Schip>();

            // SQL-statement om alle schepen op te vragen  
            String sql = "SELECT * FROM Vloot;";

            // SQL-commando aanmaken op basis van ons SQL-statement 
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // de connectie met de databank openen 
            _mySqlConnection.Open();

            // met ExecuteReader laat je een leescommando opstarten 
            // de ingelezen informatie komt in mySqlDataReader terecht 
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            // lusje om alle records in mySqlDataReader te overlopen 
            while (mySqlDataReader.Read() == true)
            {
                // nieuw schip maken met de actieve record in mySqlDataReader 
                Schip schip =
                     new Schip(mySqlDataReader["Naam"].ToString(),
                                     mySqlDataReader["Type"].ToString(),
                                     (int)(mySqlDataReader["Bouwjaar"]),
                                     (int)(mySqlDataReader["Bouwjaar"]),
                                     mySqlDataReader["Status"].ToString()
                                     );
        // voeg het schip toe aan de lijst 
        lijst.Add(schip);
            }

            // de connectie met de databank terug sluiten 
            _mySqlConnection.Close();

            // lijst met alle schepen retourneren 
            return lijst;
        }

        public List<Personage> geefCylon()
        {
            List<Personage> lijst = new List<Personage>();

            // SQL-statement om alle personages op te vragen  
            String sql = "SELECT * FROM Personages where IsCylon=true;";

            // SQL-commando aanmaken op basis van ons SQL-statement 
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // de connectie met de databank openen 
            _mySqlConnection.Open();

            // met ExecuteReader laat je een leescommando opstarten 
            // de ingelezen informatie komt in mySqlDataReader terecht 
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            // lusje om alle records in mySqlDataReader te overlopen 
            while (mySqlDataReader.Read() == true)
            {
                // nieuw personage maken met de actieve record in mySqlDataReader 
                Personage personage =
                     new Personage(mySqlDataReader["Naam"].ToString(),
                                     mySqlDataReader["Rol"].ToString(),
                                     (int)(mySqlDataReader["Leeftijd"]));

                // voeg de personage toe aan de lijst 
                lijst.Add(personage);
            }

            // de connectie met de databank terug sluiten 
            _mySqlConnection.Close();

            // lijst met alle personages retourneren 
            return lijst;
        }

        public void laadData() //dit doet alle 3 de functies van hierboven in 1 keer
        {
            GeefLijstPersonage();
            GeefLijstPlaneten();
            GeefLijstSchepen();
        }

    }
}