using BoulderDash.Model.Interfaces_Abstract;

namespace BoulderDash
{
    public class Maze
    {
        public Maze(Tile firstTile, MoveableObject player)
        {
            FirstTile = firstTile;
            Player = player;
        }
        public Tile FirstTile { get; set; }
        public MoveableObject Player { get; set; }
    }
}