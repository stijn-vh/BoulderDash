using BoulderDash.Model.Interfaces_Abstract;
using System;

namespace BoulderDash
{
    public class Exit : NonMoveableObject
    {
        public bool CanExit { get; set; }
        public Exit()
        {
            CanExit = false;
        }
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.DarkYellow;
        }

        public override char GetSymbol()
        {
            return 'E';
        }

        public override bool Trigger(Direction dir)
        {
            return CanExit;
        }
    }
}