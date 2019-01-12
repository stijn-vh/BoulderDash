using BoulderDash.Model.Interfaces_Abstract;
using System.Collections.Generic;

namespace BoulderDash
{
    public class Parser : LevelData
    {
        private char[,] levelArray;
        private Tile[,] tileArray;
        private MoveableObject player;
        private List<FireFly> _fireFlies;
        private Exit _exit;
        private int amountOfDiamonds;

        public void GenerateTilesWithContent()
        {
            tileArray = new Tile[Level_height, Level_width];
            for (int y = 0; y < Level_height; y++)
            {
                for (int x = 0; x < Level_width; x++)
                {
                    tileArray[y, x] = new Tile(CreateTileContent(levelArray[y, x]));
                }
            }
        }

        public IGameObject CreateTileContent(char symbol)
        {
            switch (symbol)
            {
                case 'R':
                    player = new Rockford();
                    return player;
                case 'M':
                    return new Mud();
                case 'B':
                    return new Boulder();
                case 'D':
                    amountOfDiamonds++;
                    return new Diamond();
                case 'W':
                    return new Wall();
                case 'S':
                    return new SteelWall();
                case 'F':
                    FireFly f = new FireFly();
                    _fireFlies.Add(f);
                    return f;
                case 'E':
                    _exit = new Exit();
                    return _exit;
                case 'H':
                    return new HardenedMud();
                case 'T':
                    return new TNT();
            }
            return null;
        }

        public Maze ReadFile(int level)
        {
            _fireFlies = new List<FireFly>();
            switch (level)
            {
                case 1:
                    levelArray = Level1;
                    break;
                case 2:
                    levelArray = Level2;
                    break;
                case 3:
                    levelArray = Level3;
                    break;
                default:
                    levelArray = Level1;
                    break;
            }

            GenerateTilesWithContent();

            Tile first = null;
            Tile newTile = null;
            for (int y = 0; y < Level_height; y++)
            {
                for (int x = 0; x < Level_width; x++)
                {
                    if (first == null)
                    {
                        first = tileArray[0, 0];
                        first.Right = tileArray[0, 1];
                        first.Down = tileArray[1, 0];
                    }
                    else
                    {
                        newTile = tileArray[y, x];
                        if (y - 1 >= 0)
                        {
                            newTile.Up = tileArray[y - 1, x];
                        }

                        if (x + 1 < Level_width)
                        {
                            newTile.Right = tileArray[y, x + 1];
                        }

                        if (y + 1 < Level_height)
                        {
                            newTile.Down = tileArray[y + 1, x];
                        }

                        if (x - 1 >= 0)
                        {
                            newTile.Left = tileArray[y, x - 1];
                        }
                    }
                }
            }
            Maze maze = new Maze(first, player, _fireFlies, amountOfDiamonds, _exit);
            return maze;
        }
    }
}
