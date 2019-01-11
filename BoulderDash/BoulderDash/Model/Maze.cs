using BoulderDash.Model.Interfaces_Abstract;
using System.Collections.Generic;

namespace BoulderDash
{
    public class Maze
    {
        private int _originalAmountOfDiamonds;
        private List<IGameObject> _fallenObjects;
        public Maze(Tile firstTile, MoveableObject player, int originalAmountOfDiamonds)
        {
            _originalAmountOfDiamonds = originalAmountOfDiamonds;
            FirstTile = firstTile;
            Player = player;
        }
        public Tile FirstTile { get; set; }
        public MoveableObject Player { get; set; }

        public int CountDiamondsCollected()
        {
            int amountOfDiamonds = 0;
            Tile current = FirstTile;
            while (current.Down != null) // Loop down the list
            {
                while (current.Right != null) // Loop to the last item
                {
                    amountOfDiamonds += HasDiamond(current);
                    current = current.Right;
                }
                amountOfDiamonds += HasDiamond(current);
                while (current.Left != null) // Loop back to begin
                {
                    current = current.Left;
                }
                current = current.Down;
            }
            while (current.Right != null) // Loop to the last item
            {
                amountOfDiamonds += HasDiamond(current);
                current = current.Right;
            }
            amountOfDiamonds += HasDiamond(current);
            return (_originalAmountOfDiamonds - amountOfDiamonds);
        }

        public bool CheckIfPlayerIsAlive()
        {
            if (Player.CurrentTile.TileContent != Player)
            {
                System.Console.WriteLine("dooooooooooood");
                return false;
            }
            else
            {
                return true;
            }
        }

        private int HasDiamond(Tile tile)
        {
            if (tile.TileContent != null)
            {
                Diamond checkDiamond = new Diamond();
                if (tile.TileContent.GetSymbol().Equals(checkDiamond.GetSymbol()))
                {
                    return 1;
                }
            }
            return 0;
        }

        public void LetLooseObjectFall()
        {
            _fallenObjects = new List<IGameObject>();
            Tile current = FirstTile;
            while (current.Down != null) // Loop down the list
            {
                while (current.Right != null) // Loop to the last item
                {
                    LetTileContentFall(current);
                    current = current.Right;
                }
                LetTileContentFall(current);
                while (current.Left != null) // Loop back to begin
                {
                    current = current.Left;
                }
                current = current.Down;
            }
            while (current.Right != null) // Loop to the last item
            {
                LetTileContentFall(current);
                current = current.Right;
            }
            LetTileContentFall(current);
        }

        private void LetTileContentFall(Tile tile)
        {
            if (tile.TileContent != null && !_fallenObjects.Contains(tile.TileContent))
            {
                var currentObject = tile.TileContent.Fall();
                if (currentObject != null)
                {
                    _fallenObjects.Add(currentObject);
                }
            }
        }
    }
}