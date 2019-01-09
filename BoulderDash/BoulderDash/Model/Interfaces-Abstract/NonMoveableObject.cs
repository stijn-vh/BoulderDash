using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Model.Interfaces_Abstract
{
    public abstract class NonMoveableObject : IGameObject
    {
        public Tile CurrentTile { get; set; }

        public abstract char GetSymbol();
    }
}
