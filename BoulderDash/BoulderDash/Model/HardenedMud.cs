using System;
using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class HardenedMud : LooseObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.DarkMagenta;
        }

        public override char GetSymbol()
        {
            return 'H';
        }
    }
}