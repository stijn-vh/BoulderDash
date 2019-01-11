using System;

namespace BoulderDash.Model.Interfaces_Abstract
{
    public abstract class LooseObject : IGameObject
    {
        public Tile CurrentTile { get; set; }

        public abstract ConsoleColor GetColor();

        public abstract char GetSymbol();
    }
}
