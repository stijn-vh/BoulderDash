using System;
using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class SteelWall : NonMoveableObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Gray;
        }

        public override char GetSymbol()
        {
            return 'S';
        }

        public override void Destroy()
        {

        }
    }
}