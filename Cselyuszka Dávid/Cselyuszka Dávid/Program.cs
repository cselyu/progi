using System;
using System.Text;

namespace Cselyuszka_Dávid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Változók");
            Console.Write("Írd be a neved! ");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia " + nev + "!");
            Console.WriteLine("Számok és műveletek");
            byte kicsi; //deklaráció
            kicsi = 5; //inicializálás
            int nagy = 2002; //deklaráció és inicializálás
            Console.WriteLine("Összeg: " + nagy + " + "  + kicsi + " = " + (nagy+kicsi));
            int dif = nagy - kicsi;
            Console.WriteLine("Különbség: " + nagy + " - "  + kicsi + " = " + dif); // szövegösszefűzés konkatenáció
            int hanyados = nagy / kicsi;
            int mar = nagy % kicsi;
            Console.WriteLine("Hányados: {0} / {1} = {2} és a maradék {3}"
                , nagy, kicsi, hanyados, mar);
            Console.WriteLine("Szorzat: {0} * {1} = {2}"
                ,kicsi, nagy, kicsi*nagy);
            Console.WriteLine("Logikai változók");
            Console.ReadKey();
        }
    }
}
