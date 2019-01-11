using BoulderDash.Model.Interfaces_Abstract;
using System;

namespace BoulderDash
{
    internal class Exit : NonMoveableObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.DarkYellow;
        }

        public override char GetSymbol()
        {
            return 'E';
        }
    }
}