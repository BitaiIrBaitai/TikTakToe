

class TicTakToeGame
{
    private char[,] _board;
    private Player _player1;
    private Player _player2;

    private BoardDrawer _boardDrawer;

    public TicTakToeGame(Player player1, Player player2) : this(player1, player2, new BoardDrawer())
    {
        
	}

    public TicTakToeGame(Player player1, Player player2, BoardDrawer drawer)
    {
		_board = new char[3, 3]
		{
			{ ' ', ' ', ' ' },
			{ ' ', ' ', ' ' },
			{ ' ', ' ', ' ' }
		};

		_player1 = player1;
		_player2 = player2;

		_boardDrawer = drawer;
	}

    public void Play()
    {
        bool player1Turn = true;
        bool gameEnded = false;

        while (!gameEnded)
        {
            Console.Clear();
            _boardDrawer.Draw(_board);

            Player currentPlayer = player1Turn ? _player1 : _player2;
			Console.WriteLine($"Player {currentPlayer.Symbol} turn");
			(int x, int y) = currentPlayer.MakeMove(_board);

            if (_board[x, y] != ' ')
            {
				player1Turn = !player1Turn;
                continue;
			}

            _board[x, y] = currentPlayer.Symbol;

			if (CheckWin(currentPlayer.Symbol))
            {
				Console.Clear();
				_boardDrawer.Draw(_board);
				Console.WriteLine($"Player {currentPlayer.Symbol} wins!");
                gameEnded = true;
            }

            if (CheckDraw())
            {
				Console.Clear();
				_boardDrawer.Draw(_board);
				Console.WriteLine("Draw!");
				gameEnded = true;
			}

            player1Turn = !player1Turn;
        }
    }

    private bool CheckWin(char symbol)
    {
		for (int i = 0; i < 3; i++)
        {
            if (_board[i, 0] == symbol && _board[i, 1] == symbol && _board[i, 2] == symbol)
				return true;

			if (_board[0, i] == symbol && _board[1, i] == symbol && _board[2, i] == symbol)
                return true;
        }

        if (_board[0, 0] == symbol && _board[1, 1] == symbol && _board[2, 2] == symbol)
			return true;

        if (_board[0, 2] == symbol && _board[1, 1] == symbol && _board[2, 0] == symbol)
            return true;

        return false;
    }

    private bool CheckDraw()
    {
        foreach (var cell in _board)
        {
			if (cell == ' ')
				return false;
        }

        return true;
    }
}
