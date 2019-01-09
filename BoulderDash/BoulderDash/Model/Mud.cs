using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    internal class Mud : NonMoveableObject
    {

        public override char GetSymbol()
        {
            return 'M';
        }
    }
}