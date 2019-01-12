using System;

namespace BoulderDash.Model.Interfaces_Abstract
{
    public abstract class NonMoveableObject : IGameObject
    {
        public Tile CurrentTile { get; set; }

        public virtual bool Sticks => false;

        public virtual bool Trigger(Direction dir)
        {
            return false;
        }

        public abstract ConsoleColor GetColor();
        public abstract char GetSymbol();

        public void Move(Direction dir)
        {

        }

        public IGameObject Fall()
        {
            return null;
        }

        public virtual void Destroy()
        {
            CurrentTile.TileContent = null;
        }

        public void Explode()
        {
        }
    }
}
