using BoulderDash.Model.Interfaces_Abstract;
using BoulderDash.View;

namespace BoulderDash.Controller
{
    public class GameController
    {
        private Maze _maze;
        private OutputView _outputView;
        private InputView _inputView;
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
                int dirInput = _inputView.WaitForInput();
                _maze.Player.Move((Direction)dirInput);
                LetLooseObjectsFall();
                _outputView.PrintMaze(_maze.FirstTile);
                _outputView.PrintScore((_maze.CountDiamondsCollected() * 10));
                _maze.CheckIfPlayerIsAlive();
            }
        }

        public void LetLooseObjectsFall()
        {
            _maze.LetLooseObjectFall();
        }
    }
}
