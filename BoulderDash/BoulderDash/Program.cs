using System;

namespace BoulderDash
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser p = new Parser();
            Console.Clear();
            Tile current = p.ReadFile(3);
            while (current.Down != null) // Loop down the list
            {
                while (current.Right != null) // Loop to the last item
                {
                    p.PrintChar(current);
                    current = current.Right;
                }
                p.PrintChar(current);
                while (current.Left != null) // Loop back to begin
                {
                    current = current.Left;
                }
                System.Console.WriteLine("");
                current = current.Down;
            }
            while (current.Right != null) // Loop to the last item
            {
                p.PrintChar(current);
                current = current.Right;
            }
            p.PrintChar(current);
            Console.ReadLine();
        }
    }
}
