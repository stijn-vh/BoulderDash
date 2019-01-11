using System;
using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class Rockford : MoveableObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Blue;
        }

        public override char GetSymbol()
        {
            return 'R';
        }
    }
}