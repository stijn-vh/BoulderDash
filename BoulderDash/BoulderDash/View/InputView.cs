using System;

namespace BoulderDash.View
{
    public class InputView
    {
        private int input;
        private string input2;

        public InputView()
        {
        }

        public int WaitForInput()
        {
            return (int)Console.ReadKey().Key;
        }

        public int ReadLevel()
        {
            Console.WriteLine("Kies een level (1-3)");
            input2 = Console.ReadLine();

            if (Int32.TryParse(input2, out input))
            {
                if (input > 0 && input < 5)
                {
                    Console.WriteLine("Jij wil level " + input + " spelen");
                    return input;
                }
                else
                {
                    Console.WriteLine("Dat is geen geldige input!!");
                    ReadLevel();
                }
            }
            else
            {
                Console.WriteLine("Dat is geen geldige input!!");
                ReadLevel();
            }
            return 0;
        }
    }
}
