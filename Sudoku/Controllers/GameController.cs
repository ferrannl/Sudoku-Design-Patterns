﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sudoku.Views;

namespace Sudoku
{
    public class GameController
    {
        private readonly InputView _input;
        private readonly OutputView _output;
        private readonly BoardFactory _boardFactory;
        private Board _board;
        private bool _levelSelected;
        private bool _playing;
        public GameController()
        {
            _input = new InputView();
            _output = new OutputView();
            _boardFactory = new BoardFactory(new FileReader());
            _levelSelected = false;
            _playing = false;
            start();
        }
        private void start()
        {
            while (!_levelSelected)
            {
                _output.SelectPath();
                try
                {
                    _board = _boardFactory.Build(_input.getLine());
                    if (_board != null)
                    {
                        _levelSelected = true;
                    }
                    else
                    {
                        _output.RetrySelection();
                    }
                }
                catch (Exception e)
                {
                    _output.RetrySelection();
                }

            }

            _playing = true;
            this.play();
        }

        private void InputCommandHandler(ConsoleKey key)
        {
            int value;
            bool isNumerical = int.TryParse(key.ToString().Split('D')[1], out value);
            if (!isNumerical)
            {
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        break;
                    case ConsoleKey.UpArrow:
                        break;
                    case ConsoleKey.RightArrow:
                        break;
                    case ConsoleKey.DownArrow:
                        break;

                }
            }
            else
            {
                if (value > 0 && value < 10)
                {
                    _board.CurrentCell.Value = value;
                    _output.DrawBoard(_board);
                }
                else
                {
                    _output.HelpCommands();
                }
            }
        }

        private void play()
        {
            _output.DrawBoard(_board);
            while (_playing)
            {
                InputCommandHandler(_input.GetKey());

            }

        }

        private FileReader _fileReader;

        public BoardFactory BoardFactory
        {
            get => default;
            set
            {
            }
        }

        internal Views.OutputView OutputView
        {
            get => default;
            set
            {
            }
        }

        internal Views.InputView InputView
        {
            get => default;
            set
            {
            }
        }
    }
}