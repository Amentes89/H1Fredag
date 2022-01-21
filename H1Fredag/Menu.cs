using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Fredag
{
    internal class Menu
    {
        static void Menue()
        {
            Console.WriteLine("Tast 1 for at tilgå X. /nTast 2 for at tilgå Y. /nTast 3 for at tilgå Z. /n");
            var input = Console.ReadKey();

            switch (input.Key) //Switch on Key enum
            {
                case ConsoleKey.D1:

                    break;
                case ConsoleKey.D2:

                    break;
                case ConsoleKey.D3:

                    break;
                default:

                    break;
            }
        }
    }
}




