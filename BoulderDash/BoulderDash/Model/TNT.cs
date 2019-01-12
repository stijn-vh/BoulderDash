using BoulderDash.Model.Interfaces_Abstract;
using System;

namespace BoulderDash
{
    internal class TNT : LooseObject
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Yellow;
        }

        public override char GetSymbol()
        {
            return 'T';
        }

        public override void Collect(Direction dir)
        {
            base.Collect(dir);
        }

        public override IGameObject Fall()
        {
            if (CurrentTile.Down.TileContent != null && _isFalling)
            {
                Explode();
                return null;
            }

            var gameObject = base.Fall();
            return gameObject;
        }

        public override void Explode()
        {
            CurrentTile.Left.Up.ExplodeContent();
            CurrentTile.Up.ExplodeContent();
            CurrentTile.Up.Right.ExplodeContent();
            CurrentTile.Right.ExplodeContent();
            CurrentTile.Right.Down.ExplodeContent();
            CurrentTile.Down.ExplodeContent();
            CurrentTile.Down.Left.ExplodeContent();
            CurrentTile.Left.ExplodeContent();
            CurrentTile.ExplodeContent();
        }
    }
}