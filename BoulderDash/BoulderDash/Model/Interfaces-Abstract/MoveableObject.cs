using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Model.Interfaces_Abstract
{
    public abstract class MoveableObject : IGameObject
    {
        public Tile CurrentTile { get; set; }

        public abstract char GetSymbol();

        public void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Up:
                    CurrentTile.Up.TileContent = this;
                    CurrentTile.TileContent = null;
                    CurrentTile = CurrentTile.Up;
                    break;
                case Direction.Right:
                    CurrentTile.Right.TileContent = this;
                    CurrentTile.TileContent = null;
                    CurrentTile = CurrentTile.Right;
                    break;
                case Direction.Down:
                    CurrentTile.Down.TileContent = this;
                    CurrentTile.TileContent = null;
                    CurrentTile = CurrentTile.Down;
                    break;
                case Direction.Left:
                    CurrentTile.Left.TileContent = this;
                    CurrentTile.TileContent = null;
                    CurrentTile = CurrentTile.Left;
                    break;
            }
        }
    }
}
