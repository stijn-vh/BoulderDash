using System;
using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class Wall : NonMoveableObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.DarkGray;
        }

        public override char GetSymbol()
        {
            return 'W';
        }
    }
}