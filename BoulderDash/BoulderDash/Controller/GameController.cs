﻿using BoulderDash.Model.Interfaces_Abstract;
using BoulderDash.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Controller
{
    public class GameController
    {
        private Maze _maze;
        private OutputView _outputView;
        public GameController()
        {
            _outputView = new OutputView();
            Parser p = new Parser();
            _maze = p.ReadFile(1);
            _outputView.PrintMaze(_maze.FirstTile); // TODO Get first tile from Maze-Model
            WaitForMove();
        }

        public void WaitForMove()
        {
            while (true)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("Input Direction:");
                int dirInput = Int32.Parse(System.Console.ReadLine());
                _maze.Player.Move((Direction)dirInput);
                _outputView.PrintMaze(_maze.FirstTile);
            }
        }
    }
}
