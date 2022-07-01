using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01DataCzas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            
            dateTime = new DateTime(1930, 12, 10); // rok, miesiąc, dzień
            dateTime = new DateTime(); // 1 stycznia 0001 roku


            // zadanie
            // w jaki dzień tygodnia rozpoczęła się nasza era?
            // ile dni upłynęło od Twoich urodzin?
            // kiedy skończysz/skończyłeś 90 lat?
            // wystawiasz dziś fakturę z 90dniowym terminem płatności. kiedy przyjdzie przelew?
            // jaka jest teraz godzina w czasie UTC?

            Console.WriteLine(DateTime.Now.Kind);
            // Local
            // UTC
            // Unspecified

            dateTime = new DateTime(2001,1,1);
            Console.WriteLine($"dzień tygodnia: {dateTime.DayOfWeek}");

            DateTime birthday = new DateTime(1900, 5, 20);
            TimeSpan timeSpan = DateTime.Now - birthday;
            Console.WriteLine($"ile dni: {timeSpan.TotalDays}");
            Console.WriteLine($"ile dni: {timeSpan.Days}");

            Console.WriteLine($"90te urodziny: {birthday.AddYears(90)}");
            Console.WriteLine($"przelew: {DateTime.Now.AddDays(90)}");
            Console.WriteLine($"UTC: {DateTime.UtcNow}");

            // 28*13 = 364  -- idealnie okrągły świat z miesiącami 4 tygodniowymi
            Console.ReadKey();

            //PRZERWA DO 10:50
        }
    }
}
