using BoulderDash.Model.Interfaces_Abstract;
using BoulderDash.View;

namespace BoulderDash.Controller
{
    public class GameController
    {
        private Maze _maze;
        private OutputView _outputView;
        private InputView _inputView;
        private static int _timer = 150;
        private int _tick = 0;
        public GameController()
        {
            _outputView = new OutputView();
            _inputView = new InputView();
            Parser p = new Parser();
            _maze = p.ReadFile(AskLevel());
            _outputView.PrintMaze(_maze.FirstTile);
            WaitForMove();
        }

        public int AskLevel()
        {
            return _inputView.ReadLevel();
        }

        public void WaitForMove()
        {
            while (true)
            {
                _maze.CollectedAllDiamonds();
                DoEveryTick();

                if (_tick == 2)
                {
                    LetLooseObjectsFall();
                    _timer--;
                    _tick = 0;
                }
                else
                {
                    _tick++;
                }

                if (_timer == 120)
                {
                    _maze.ExplodeAllTNT();
                };

                if (_maze.ExitGame())
                {
                    System.Console.Clear();
                    FinishGame();
                    break;
                }

                _maze.CheckIfFireFliesDied();

                if (!_maze.CheckIfPlayerIsAlive())
                {
                    _outputView.GameOver();
                    FinishGame();
                    break;
                }

                _outputView.PrintMaze(_maze.FirstTile);
                _outputView.PrintScore((_maze.DiamondsCollected * 10) + (_maze.AmountOfFireFliesKilled * 250));
                _outputView.PrintTime(_timer, _tick);

            }
            System.Console.ReadLine();
        }

        public void FinishGame()
        {
            _outputView.PrintScore((_maze.DiamondsCollected * 10) + (_timer * 10) + (_maze.AmountOfFireFliesKilled * 250));
        }

        public void DoEveryTick()
        {
            int dirInput = _inputView.WaitForInput();
            _maze.Player.Move((Direction)dirInput);
            MoveFireFlies();
        }

        public void LetLooseObjectsFall()
        {
            _maze.LetLooseObjectFall();
        }

        public void MoveFireFlies()
        {
            _maze.MoveFireFlies();
        }
    }
}
