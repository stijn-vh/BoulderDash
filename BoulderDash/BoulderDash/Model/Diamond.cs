using System;
using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class Diamond : LooseObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Cyan;
        }

        public override char GetSymbol()
        {
            return 'D';
        }
    }
}