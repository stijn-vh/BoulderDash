namespace BoulderDash.Model.Interfaces_Abstract
{
    public abstract class LooseObject : MoveableObject
    {

        public override IGameObject Fall()
        {
            if (CurrentTile.Down.TileContent == null || CurrentTile.Down.TileContent is Rockford)
            {
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

        private IGameObject Slide()
        {
            if (CurrentTile.Down.TileContent != null && CurrentTile.Down.TileContent is LooseObject)
            {
                if (CurrentTile.Right.TileContent == null)
                {
                    if (CurrentTile.Right.Down.TileContent == null)
                    {
                        CurrentTile.Right.Down.TileContent = this;
                        CurrentTile.TileContent = null;
                        CurrentTile = CurrentTile.Right.Down;
                        return CurrentTile.TileContent;
                    }
                }
                else if (CurrentTile.Left.TileContent == null)
                {
                    if (CurrentTile.Left.Down.TileContent == null)
                    {
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
