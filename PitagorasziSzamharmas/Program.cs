using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitagorasziSzamharmas
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Ez a program arról szól, hogy bekér 3 egész számot a felhasználótól, és megmondja, hogy a három szám pitagoraszi számhármas-e. (tehát kijön-e velük a Pitagorasz-tétel)


            Console.WriteLine("Kedves Felhasználó! Adj meg két befogót és egy átfogót ebben a sorrendben. Mindegyik legyen pozitív egész szám!");

            Console.WriteLine("Add meg az első befogót: ");
            
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg az második befogót: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg az átfogót: ");
            int c = int.Parse(Console.ReadLine());

            if (a * a + b * b == c * c)
            {
                Console.WriteLine("Ez bizony egy derékszögű háromszög! Gratulálok!");
            }
            else
            {
                Console.WriteLine("Sajnálom, rossz számoKAt adtál meg, ez itt nem egy derékszögű háromszög. Kössél belém.");
            }



        }
    }
}
