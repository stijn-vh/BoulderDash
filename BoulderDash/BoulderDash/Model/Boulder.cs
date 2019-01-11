using BoulderDash.Model.Interfaces_Abstract;
using System;

namespace BoulderDash
{
    internal class Boulder : LooseObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.DarkRed;
        }

        public override char GetSymbol()
        {
            return 'B';
        }

        public override bool Trigger(Direction dir)
        {
            switch (dir)
            {
                case Direction.Right:
                    if (CurrentTile.Right.TileContent == null)
                    {
                        CurrentTile.Right.TileContent = this;
                        CurrentTile.TileContent = null;
                        CurrentTile = CurrentTile.Right;
                        return true;
                    }
                    break;
                case Direction.Left:
                    if (CurrentTile.Left.TileContent == null)
                    {
                        CurrentTile.Left.TileContent = this;
                        CurrentTile.TileContent = null;
                        CurrentTile = CurrentTile.Left;
                        return true;
                    }
                    break;
            }
            return false;
        }
    }
}