using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class SteelWall : NonMoveableObject
    {
        public override char GetSymbol()
        {
            return 'S';
        }
    }
}