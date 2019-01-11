using BoulderDash.Model.Interfaces_Abstract;
using System;

namespace BoulderDash
{
    internal class Boulder : LooseObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.DarkRed;
        }

        public override char GetSymbol()
        {
            return 'B';
        }
    }
}