using System;

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

        internal void GameOver()
        {
            System.Console.Clear();
            System.Console.WriteLine("Game Over!");
        }

        public void PrintChar(Tile tile)
        {
            if (tile.TileContent != null)
            {
                System.Console.ForegroundColor = tile.TileContent.GetColor();
                System.Console.Write(tile.TileContent.GetSymbol());
            }
            else
            {
                System.Console.ForegroundColor = ConsoleColor.Black;
                System.Console.Write(" ");
            }
        }

        public void PrintTime(int time, int tick)
        {
            System.Console.WriteLine("");
            System.Console.ForegroundColor = System.ConsoleColor.DarkCyan;
            System.Console.WriteLine("Time left: " + time + " Tick: " + tick);
        }

        public void PrintMaze(Tile first)
        {
            Console.Clear();
            Tile current = first;
            while (current.Down != null) // Loop down the list
            {
                while (current.Right != null) // Loop to the last item
                {
                    PrintChar(current);
                    current = current.Right;
                }
                PrintChar(current);
                while (current.Left != null) // Loop back to begin
                {
                    current = current.Left;
                }
                System.Console.WriteLine("");
                current = current.Down;
            }
            while (current.Right != null) // Loop to the last item
            {
                PrintChar(current);
                current = current.Right;
            }
            PrintChar(current);
        }

        public void PrintScore(int score)
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            System.Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("Score: " + score);
        }
    }
}
