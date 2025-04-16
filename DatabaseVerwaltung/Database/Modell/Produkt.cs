using System;
using DataBase;

namespace Database.Modell
{
    public class Produkt
    {
        public int? ProduktId { get; private set; }

        public string Name { get; private set; }
        
        public string Beschreibung { get; private set; }

        public Kategorie Kategorie { get; private set; }

        public Decimal? Preis {  get; private set; }

        public int Stueckzahl { get; private set; }

        public int? Rabatt {  get; private set; }

        public Produkt (int? produktId, string name, string beschreibung, Kategorie kategorie, decimal? preis, int stueckzahl, int? rabatt)
        {
            ProduktId = produktId;
            Name = name;
            Beschreibung = beschreibung;
            Kategorie = kategorie;
            Preis = preis;
            Stueckzahl = stueckzahl;
            Rabatt = rabatt;
        }
    }
}
