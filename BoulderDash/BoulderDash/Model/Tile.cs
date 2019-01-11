﻿using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    public class Tile
    {
        public Tile(IGameObject content)
        {
            TileContent = content;
            if (content != null) // Als de tile niet leeg is
            {
                TileContent.CurrentTile = this;
            }
        }

        public IGameObject TileContent { get; set; }
        public Tile Up { get; set; }
        public Tile Right { get; set; }
        public Tile Down { get; set; }
        public Tile Left { get; set; }

        public bool CanMoveOnTile(Direction direction)
        {
            if (TileContent != null)
            {
                return TileContent.Trigger(direction);
            }
            else
            {
                return true;
            }
        }
    }
}