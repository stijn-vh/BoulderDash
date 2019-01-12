using BoulderDash.Model.Interfaces_Abstract;
using System;

namespace BoulderDash
{
    internal class Rockford : MoveableObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Blue;
        }

        public override void Collect(Direction dir)
        {
            switch (dir)
            {
                case Direction.Up:
                    if (CurrentTile.Up.TileContent != null && CurrentTile.Up.TileContent is Diamond)
                    {
                        AmountOfDiamondsCollected++;
                    }
                    break;
                case Direction.Right:
                    if (CurrentTile.Right.TileContent != null && CurrentTile.Right.TileContent is Diamond)
                    {
                        AmountOfDiamondsCollected++;
                    }
                    break;
                case Direction.Down:
                    if (CurrentTile.Down.TileContent != null && CurrentTile.Down.TileContent is Diamond)
                    {
                        AmountOfDiamondsCollected++;
                    }
                    break;
                case Direction.Left:
                    if (CurrentTile.Left.TileContent != null && CurrentTile.Left.TileContent is Diamond)
                    {
                        AmountOfDiamondsCollected++;
                    }
                    break;
            }
        }

        public override char GetSymbol()
        {
            return 'R';
        }
    }
}