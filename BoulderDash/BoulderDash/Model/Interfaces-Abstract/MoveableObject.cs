﻿using System;

namespace BoulderDash.Model.Interfaces_Abstract
{
    public abstract class MoveableObject : IGameObject
    {
        public Tile CurrentTile { get; set; }

        public virtual IGameObject Fall()
        {
            return null;
        }

        public abstract ConsoleColor GetColor();

        public abstract char GetSymbol();

        public void Move(Direction dir)
        {
            if (Trigger(dir))
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

        public virtual bool Trigger(Direction dir)
        {
            switch (dir)
            {
                case Direction.Up:
                    return CurrentTile.Up.CanMoveOnTile(dir);
                case Direction.Right:
                    return CurrentTile.Right.CanMoveOnTile(dir);
                case Direction.Down:
                    return CurrentTile.Down.CanMoveOnTile(dir);
                case Direction.Left:
                    return CurrentTile.Left.CanMoveOnTile(dir);
            }
            return false;
        }
    }
}
