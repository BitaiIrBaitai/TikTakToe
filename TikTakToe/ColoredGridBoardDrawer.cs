class ColoredGridBoardDrawer : BoardDrawer
{
	private ConsoleColor _borderColor;
	private ConsoleColor _player1Color;
	private ConsoleColor _player2Color;
	private char _player1Symbol;
	private char _player2Symbol;

	public ColoredGridBoardDrawer(	ConsoleColor borderColor,
									ConsoleColor player1Color,
									ConsoleColor player2Color,
									char player1Symbol,
									char player2Symbol)
	{
		_borderColor = borderColor;
		_player1Color = player1Color;
		_player2Color = player2Color;
		_player1Symbol = player1Symbol;
		_player2Symbol = player2Symbol;
	}

	public override void Draw(char[,] board)
	{
		Console.ForegroundColor = _borderColor;
		Console.WriteLine("┌───┬───┬───┐");
		Console.Write("| ");
		DrawElement(board[0, 0]);
		Console.Write(" | ");
		DrawElement(board[1, 0]);
		Console.Write(" | ");
		DrawElement(board[2, 0]);
		Console.WriteLine(" |");
		Console.WriteLine("├───┼───┼───┤");
		Console.Write("| ");
		DrawElement(board[0, 1]);
		Console.Write(" | ");
		DrawElement(board[1, 1]);
		Console.Write(" | ");
		DrawElement(board[2, 1]);
		Console.WriteLine(" |");
		Console.WriteLine("├───┼───┼───┤");
		Console.Write("| ");
		DrawElement(board[0, 2]);
		Console.Write(" | ");
		DrawElement(board[1, 2]);
		Console.Write(" | ");
		DrawElement(board[2, 2]);
		Console.WriteLine(" |");
		Console.WriteLine("└───┴───┴───┘");
		Console.ResetColor();
	}

	private void DrawElement(char element)
	{
		if (element == _player1Symbol)
		{
			Console.ForegroundColor = _player1Color;
			Console.Write(element);
		}
		else if (element == _player2Symbol)
		{
			Console.ForegroundColor = _player2Color;
			Console.Write(element);
		}
		else
		{
			Console.Write(' ');
		}

		Console.ForegroundColor = _borderColor;
	}
}