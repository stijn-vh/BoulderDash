namespace BoulderDash.Model.Interfaces_Abstract
{
    public abstract class LooseObject : MoveableObject
    {
        protected bool _isFalling;
        public override IGameObject Fall()
        {
            if (CanFall())
            {
                _isFalling = true;
                CurrentTile.Down.TileContent = this;
                CurrentTile.TileContent = null;
                CurrentTile = CurrentTile.Down;
                return CurrentTile.TileContent;
            }
            else
            {
                return Slide();
            }
        }

        public virtual bool CanFall()
        {
            if (CurrentTile.Down.TileContent == null || CurrentTile.Down.TileContent is Rockford || CurrentTile.Down.TileContent is FireFly)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CanSlide()
        {
            if (CurrentTile.Down.TileContent != null && CurrentTile.Down.TileContent is LooseObject)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private IGameObject Slide()
        {
            if (CanSlide())
            {
                if (CurrentTile.Right.TileContent == null)
                {
                    if (CurrentTile.Right.Down.TileContent == null)
                    {
                        _isFalling = true;
                        CurrentTile.Right.Down.TileContent = this;
                        CurrentTile.TileContent = null;
                        CurrentTile = CurrentTile.Right.Down;
                        return CurrentTile.TileContent;
                    }
                }

                if (CurrentTile.Left.TileContent == null)
                {
                    if (CurrentTile.Left.Down.TileContent == null)
                    {
                        _isFalling = true;
                        CurrentTile.Left.Down.TileContent = this;
                        CurrentTile.TileContent = null;
                        CurrentTile = CurrentTile.Left.Down;
                        return CurrentTile.TileContent;
                    }
                }
            }
            return null;
        }
    }
}
