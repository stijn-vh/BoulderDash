using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.View
{
    public class OutputView
    {
        //TO-DO Update the symbols!!
        public OutputView()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("| Welkom bij BoulderDash!      |   Doel van het spel     |");
            Console.WriteLine("| Betekenis van de symbolen    |                         |");
            Console.WriteLine("|                              |   Verzamel alle         |");
            Console.WriteLine("| Spatie: Outerspace           |   Diamanten en          |");
            Console.WriteLine("|      S : SteelWall           |   Bereik de exit!       |");
            Console.WriteLine("|      R : Rockford            |                         |");
            Console.WriteLine("|      W : Wall                |   Elke diamant          |");
            Console.WriteLine("|      M : Mud                 |   Is 10 punten          |");
            Console.WriteLine("|      B : Boulder             |   Waard!                |");
            Console.WriteLine("|      D : Diamond             |                         |");
            Console.WriteLine("|      F : Firefly             |                         |");
            Console.WriteLine("|      E : Exit                |                         |");
            Console.WriteLine("|      H : Hardened mud        |                         |");
            Console.WriteLine("|      T : TNT                 |                         |");
            Console.WriteLine("----------------------------------------------------------");
        }

        public void PrintChar(Tile tile)
        {
            try
            {
                System.Console.Write(tile.TileContent.GetSymbol());
            }
            catch
            {
                System.Console.Write(" ");
            }
        }
    }
}
