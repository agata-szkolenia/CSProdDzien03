using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03WlasneKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pojazd mojSamochod = new Pojazd("czerwony","elektryczny");
            Pojazd rower = new Pojazd("niebieski");

            mojSamochod.ileKol = 4;
            rower.ileKol = 2;
            Console.WriteLine(mojSamochod.ileKol);

            Console.WriteLine(mojSamochod);
            Console.WriteLine(rower);

            Samochod ferrari = new Samochod(2);
            Console.WriteLine($"na przejechanie 1000km wydano: {JazdaTestowa(ferrari)}PLN");
            Console.WriteLine($"na przejechanie 1000km wydano: {JazdaTestowa(ferrari, 10)}PLN");
        }

        public static int JazdaTestowa(Samochod autko, int naprawa = 100, int dystans = 1000)
        {
            int fundusze = 0;
            int kilometry = autko.przebieg + dystans;

            while (autko.przebieg < kilometry)
            {
                autko.Jedz(dystans);
                while (!autko.CzySprawny)
                {
                    fundusze += naprawa;
                    autko.Napraw(naprawa);
                }
            }
            return fundusze;
        }
        
    }
}
