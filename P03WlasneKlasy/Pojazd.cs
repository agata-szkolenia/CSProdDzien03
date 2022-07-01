using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03WlasneKlasy
{
    internal class Pojazd
    {
        // Fields 
        public int ileKol;
        private int _miejsca;
        private DateTime _dataProdukcji;

        // ręcznie pisane property
        private string _chip;
        public string get_chip()
        {
            // czy masz uprawnienia
            // czy moje dane są gotowe
            return this._chip;
        }
        public void set_chip(string Chip)
        {
            // czy masz uprawnienia
            // czy nowa wartość jest poprawna
            this._chip = Chip;
        }

        // Properties
        public string Kolor { get; set; } // można czytać, można nadpisywać
        public string Naped { get; } // tylko do odczytu
        public bool CzySprawny { get; protected set; } // tylko klasa i podklasy mogą modyfikować

        // Constructors

        // konstruktor domyślny bezargumentowy istnieje dopóki nie napiszę pierwszego 
        // konstruktora jawnego

        // prywatny konstruktor bez parametrów (widoczny tylko w tej klasie)
        private Pojazd()
        {
            this._dataProdukcji = DateTime.UtcNow;
        }

        // konstruktor z jednym parametrem
        // przed wykonaniem wywołuje jeszcze konstruktor bez parametrów
        public Pojazd(string kolor) : this()
        {
            this.Kolor = kolor;
            this.ileKol = 2;
            this.Naped = "nogi";
        }

        // konstruktor z podaniem koloru i napędu pojazdu
        // tu z wywołaniem konstruktora z jednym parametrem string
        public Pojazd(string kolor, string naped) : this(kolor)
        {
            this.Naped = naped;
        }

        // Methods
        public override string ToString()
        {
            return $"hej, jestem Pojazd i mam {this.ileKol} koła";
        }

    }
}
