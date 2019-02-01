using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Animaatio_testi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = Console.WindowHeight = 20;
            Console.BufferWidth = Console.WindowWidth = 50;
            Console.CursorVisible = false;

            string eka = "  _______                             _    _ ";
            string toka = " |__   __|                      /\\   | |  (_)";
            string kolmas = "    | | ___ _ ____   _____     /  \\  | | ___ ";
            string neljäs = "    | |/ _ \\ '__\\ \\ / / _ \\   / /\\ \\ | |/ / |";
            string viides = "    | |  __/ |   \\ V /  __/  / ____ \\|   <| |";
            string kuudes = "    |_|\\___|_|    \\_/ \\___| /_/    \\_\\_|\\_\\_|";

            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine(eka);
            Console.WriteLine(toka);
            Console.WriteLine(kolmas);
            Console.WriteLine(neljäs);
            Console.WriteLine(viides);
            Console.WriteLine(kuudes);

            for (int i = 0; i > 30; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(5);
            }

            Console.ReadKey();
        }
    }
}
