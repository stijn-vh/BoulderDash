using System;
using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class FireFly : MoveableObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Red;
        }

        public override char GetSymbol()
        {
            return 'F';
        }
    }
}