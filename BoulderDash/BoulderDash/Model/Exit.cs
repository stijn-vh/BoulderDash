using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class Exit : NonMoveableObject
    {
        public override char GetSymbol()
        {
            return 'E';
        }
    }
}