using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        /* {
             int a;
             Console.WriteLine("Podaj liczbę:");
             string b = Console.ReadLine();
             a = Convert.ToInt32(b);
             if (a % 2 == 0)
             {
                 Console.WriteLine("Liczba jest parzysta");
             }
             else
             {
                 Console.WriteLine("Liczba jest nieparzysta");
             }

             }
        } 

         } */
        {
            int odleglosc = -1;
            int suma = 0;
            int licznik = 0;
            float srednia;
            while (odleglosc != 0)
            {
                string odpowiedz = Console.ReadLine();
                odleglosc = Convert.ToInt32(odpowiedz);
                suma += odleglosc;
                licznik++;
            }
            srednia = (float)suma / (licznik - 1);
            Console.WriteLine("Srednia odleglosc to"+ " " + srednia);
        }
    }
}

