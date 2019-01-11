using System;
using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class TNT : LooseObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Yellow;
        }

        public override char GetSymbol()
        {
            return 'T';
        }
    }
}