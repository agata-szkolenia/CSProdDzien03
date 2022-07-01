using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03WlasneKlasy
{
    internal class Samochod : Pojazd
    {
        // Field 
        // static oznacza pole wspólne dla wszystich obiektów w klasie
        private static readonly Random rnd = new Random();

        public int IleDrzwi { get; }
        public int przebieg { get; private set; }
        public Samochod(int ileDrzwi) : base("czerwony", "benzyna")
        {
            this.ileKol = 4;
            this.CzySprawny = true;
            this.IleDrzwi = ileDrzwi;
            this.przebieg = 0;
        }

        public void Jedz(int kilometry)
        {
            if (this.CzySprawny)
            {
                while (this.CzySprawny && kilometry > 0)
                {
                    int dystans = kilometry > 100 ? 100 : kilometry ;
                    this.przebieg += dystans;
                    kilometry -= dystans;
                    if (rnd.Next(100) < 30)
                        this.CzySprawny = false;
                }               
            }
        } 

        public bool Napraw(int kwota)
        {
            if (rnd.Next(100) < kwota)
                this.CzySprawny = true;
            return this.CzySprawny;
        }

        // Zadanie:
        // napisz program, który przejedzie samochodem 1000km
        // kto wyda najmniej ten wygrywa :)
    }
}
