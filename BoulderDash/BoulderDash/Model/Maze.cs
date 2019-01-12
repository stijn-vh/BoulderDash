using BoulderDash.Model.Interfaces_Abstract;
using System.Collections.Generic;

namespace BoulderDash
{
    public class Maze
    {
        private int _originalAmountOfDiamonds;
        private List<IGameObject> _fallenObjects;
        public Maze(Tile firstTile, MoveableObject player, List<FireFly> fireFlies, int originalAmountOfDiamonds, Exit exit)
        {
            _originalAmountOfDiamonds = originalAmountOfDiamonds;
            FirstTile = firstTile;
            Player = player;
            Exit = exit;
            FireFlies = fireFlies;
        }
        public Tile FirstTile { get; set; }
        public Exit Exit { get; set; }
        public MoveableObject Player { get; set; }
        public List<FireFly> FireFlies { get; set; }
        public int DiamondsCollected { get => Player.AmountOfDiamondsCollected; }
        public int AmountOfFireFliesKilled { get; set; }

        internal void MoveFireFlies()
        {
            foreach (var f in FireFlies)
            {
                f.CalculateMove();
            }
        }

        public void CheckIfFireFliesDied()
        {
            foreach (var f in FireFlies.ToArray())
            {
                if (f.CurrentTile.TileContent != f)
                {
                    AmountOfFireFliesKilled++;
                    FireFlies.Remove(f);
                }
            }
        }

        public bool CheckIfPlayerIsAlive()
        {
            if (Player.CurrentTile.TileContent != Player)
            {
                if (Player.CurrentTile.TileContent is Diamond)
                {
                    Player.CurrentTile.TileContent = Player;
                    Player.AmountOfDiamondsCollected++;
                    return true;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ExplodeAllTNT()
        {
            Tile current = FirstTile;
            while (current.Down != null) // Loop down the list
            {
                while (current.Right != null) // Loop to the last item
                {
                    LetTileConentExplode(current);
                    current = current.Right;
                }
                LetTileConentExplode(current);
                while (current.Left != null) // Loop back to begin
                {
                    current = current.Left;
                }
                current = current.Down;
            }
            while (current.Right != null) // Loop to the last item
            {
                LetTileConentExplode(current);
                current = current.Right;
            }
            LetTileConentExplode(current);
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

        public void LetTileConentExplode(Tile tile)
        {
            if (tile.TileContent != null)
            {
                tile.TileContent.Explode();
            }
        }

        public bool ExitGame()
        {
            if (Exit != null && Exit.CurrentTile.TileContent is Rockford)
            {
                return true;
            }
            return false;
        }

        public void CollectedAllDiamonds()
        {
            if (_originalAmountOfDiamonds == Player.AmountOfDiamondsCollected && Exit != null)
            {
                Exit.CanExit = true;
            }
        }
    }
}