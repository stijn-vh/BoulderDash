using System;
using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class HardenedMud : LooseObject
    {
        private int strength = 2;
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.DarkMagenta;
        }

        public override char GetSymbol()
        {
            return 'H';
        }

        public override bool Trigger(Direction dir)
        {
            if(strength == 0)
            {
                return true;
            }
            else
            {
                strength--;
                return false;
            }
        }
    }
}