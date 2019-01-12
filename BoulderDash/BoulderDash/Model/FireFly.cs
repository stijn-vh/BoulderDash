using BoulderDash.Model.Interfaces_Abstract;
using System;

namespace BoulderDash
{
    public class FireFly : MoveableObject
    {
        private Direction _previousDirection;

        public FireFly()
        {
            _previousDirection = Direction.Left;
        }

        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Red;
        }

        public override char GetSymbol()
        {
            return 'F';
        }

        public void CalculateMove()
        {
            if (_previousDirection == Direction.Left)
            {
                if (Trigger(Direction.Down))
                {
                    Move(Direction.Down);
                    _previousDirection = Direction.Down;
                }
                else if (Trigger(Direction.Left))
                {
                    Move(Direction.Left);
                    _previousDirection = Direction.Left;
                }
                else if (Trigger(Direction.Up))
                {
                    Move(Direction.Up);
                    _previousDirection = Direction.Up;
                }
                else if (Trigger(Direction.Right))
                {
                    Move(Direction.Right);
                    _previousDirection = Direction.Right;
                }
            }
            else if (_previousDirection == Direction.Up)
            {
                if (Trigger(Direction.Left))
                {
                    Move(Direction.Left);
                    _previousDirection = Direction.Left;
                }
                else if (Trigger(Direction.Up))
                {
                    Move(Direction.Up);
                    _previousDirection = Direction.Up;
                }
                else if (Trigger(Direction.Right))
                {
                    Move(Direction.Right);
                    _previousDirection = Direction.Right;
                }
                else if (Trigger(Direction.Down))
                {
                    Move(Direction.Down);
                    _previousDirection = Direction.Down;
                }
            }
            else if (_previousDirection == Direction.Right)
            {
                if (Trigger(Direction.Up))
                {
                    Move(Direction.Up);
                    _previousDirection = Direction.Up;
                }
                else if (Trigger(Direction.Right))
                {
                    Move(Direction.Right);
                    _previousDirection = Direction.Right;
                }
                else if (Trigger(Direction.Down))
                {
                    Move(Direction.Down);
                    _previousDirection = Direction.Down;
                }
                else if (Trigger(Direction.Left))
                {
                    Move(Direction.Left);
                    _previousDirection = Direction.Left;
                }
            }
            else if (_previousDirection == Direction.Down)
            {
                if (Trigger(Direction.Right))
                {
                    Move(Direction.Right);
                    _previousDirection = Direction.Right;
                }
                else if (Trigger(Direction.Down))
                {
                    Move(Direction.Down);
                    _previousDirection = Direction.Down;
                }
                else if (Trigger(Direction.Left))
                {
                    Move(Direction.Left);
                    _previousDirection = Direction.Left;
                }
                else if (Trigger(Direction.Up))
                {
                    Move(Direction.Up);
                    _previousDirection = Direction.Up;
                }
            }
        }

        public override bool Trigger(Direction dir)
        {
            switch (dir)
            {
                case Direction.Up:
                    if (CurrentTile.Up.TileContent == null || CurrentTile.Up.TileContent is Rockford)
                    {
                        return true;
                    }
                    break;
                case Direction.Right:
                    if (CurrentTile.Right.TileContent == null || CurrentTile.Right.TileContent is Rockford)
                    {
                        return true;
                    }
                    break;
                case Direction.Down:
                    if (CurrentTile.Down.TileContent == null || CurrentTile.Down.TileContent is Rockford)
                    {
                        return true;
                    }
                    break;
                case Direction.Left:
                    if (CurrentTile.Left.TileContent == null || CurrentTile.Left.TileContent is Rockford)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
    }
}