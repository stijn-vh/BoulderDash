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
            Console.WriteLine("|                              |   Verzamel alle          |");
            Console.WriteLine("| Spatie: Outerspace           |   Diamanten en          |");
            Console.WriteLine("|      #: Muur                 |   Bereik de exit!       |");
            Console.WriteLine("|      .: Vloer                |                         |");
            Console.WriteLine("|      O: Krat                 |                         |");
            Console.WriteLine("|      0: Krat op bestemming   |                         |");
            Console.WriteLine("|      x: Bestemming           |                         |");
            Console.WriteLine("|      @: Speler               |                         |");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
