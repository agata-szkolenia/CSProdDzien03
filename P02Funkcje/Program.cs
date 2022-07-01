using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02Funkcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 30;
            int wynik;

            wynik = Dodaj(a, b);
            wynik = Dodaj(b, a);
            wynik = Dodaj(a, 90);

            Console.WriteLine(wynik);

            // 1.7f bo 1.7 z automatu by było typu double
            Console.WriteLine(PoliczBMI(80,1.7f));

            // wywołanie metody z jednyum argumentem pozycyjnym (zdanie)
            // i jednym argumentem wywoływanym po nazwie (caseSensitive)
            // pozycyjne argumenty muszą być przed nazwanymi dokładnie wg kolejności 
            // w definicji (nagłówku) metody
            // nazwane argumenty mogą być wymieniane w dowolnej kolejności
            Console.WriteLine(PoliczSłowa("Dokąd nocą tupta jeż?",caseSensitive:false));

            Console.WriteLine(NajdluzszeSlowo("Nie jeżdżę, po jeżu"));

            CiezkaPraca();
            CiezkaPraca();
            CiezkaPraca();
            CiezkaPraca();

            Console.ReadKey();
        }

        private static int Dodaj(int a, int b)
        {
            // bardzo skomplikowana logika
            return a + b;
        }

        // Zadanie
        // napisz fukcję liczącą BMI
        // waga[kg] / (wzrost[m])^2 => ~ 15-45 
        private static float PoliczBMI(float waga, float wzrost)
        {
            // biblioteka Math zawiera wiele przydatnych funkcji matematycznych
            // pow == power (potęga)
            // round (zaokrąglenie)
            // (float)liczba to rzutowanie liczby na typ float (jawna zmiana typu danych)
            // jawne rzutowanie jest wymagane, gdy docelowy typ danych ma mniejszą dokładność
            // niż oryginalny np double->float
            return (float)Math.Round((waga / Math.Pow(wzrost, 2)), 2);
        }

        // Zadanie
        // napisz fukcję, która w podanym zdaniu policzy słowa z literą 'a'
        // parametr opcjonalny wzorzec pozwala
        // 1. spełnić oczekiwania klienta teraz
        // 2. nie narobić się jak klient zmieni zdanie jutro ;)

        // przeciążenie metody PoliczSłowa
        // musi się różnić sygnaturą (liczbą i/lub typami przyjmowanych parametrów)
        private static int PoliczSłowa(string zdanie
                                        , bool caseSensitive = true)
        {
            return PoliczSłowa(zdanie, "a", caseSensitive);
        }
        private static int PoliczSłowa(string zdanie
                                        , string wzorzec)
        {
            return PoliczSłowa(zdanie, wzorzec);
        }
        private static int PoliczSłowa(string zdanie
                                        , string wzorzec = "a"
                                        , bool caseSensitive = true)
        {
            int licznik = 0;
            if (!caseSensitive)
            {
                zdanie = zdanie.ToUpper();
                wzorzec = wzorzec.ToUpper();
            }
            foreach (var słowo in zdanie.Split(' '))
            {
                if (słowo.Contains(wzorzec)) licznik++;
            }
            return licznik;
        }

        private static int PoliczLitery(string zdanie, char znak = 'a', bool caseSensitive = true)
        {
            // count potrafi zastosować dowolny filtr na elementach
            // tu liczymy znaki, które pasują do schematu 
            return zdanie.Count(x => (x==znak) || 
                (caseSensitive && (char.ToUpper(x)==char.ToUpper(znak))));

            // notacja: parametry => wynik
            // to odpowiednik funkcji, która ma tylko jedną komendę (return)
            // bool filtr(char x)
            // {
            //      return (x==znak) || 
            //             (caseSensitive && (char.ToUpper(x) == char.ToUpper(znak)))
            // }
        }

        // Zadanie
        // Napisz funkcję zwracającą najdłuższe słowo w zdaniu
        // uważaj na przecinki :)
        private static string NajdluzszeSlowo(string zdanie)
        {
            string[] slowa = zdanie.Split(' ', ';', '.', ',', '!', '?', '\t', '\n', '-',':');
            string najdluzsze = "";
            foreach (var slowo in slowa)
            {
                if (slowo.Length > najdluzsze.Length) najdluzsze = slowo;
            }
            return najdluzsze;
        }

        private static void CiezkaPraca()
        {
            Console.WriteLine("robię...");
            Console.WriteLine("skończone");
            Console.ReadKey();
        }

        // PRZERWA DO 13:30
    }
}
