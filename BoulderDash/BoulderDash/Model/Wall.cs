using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class Wall : NonMoveableObject
    {
        public override char GetSymbol()
        {
            return 'W';
        }
    }
}