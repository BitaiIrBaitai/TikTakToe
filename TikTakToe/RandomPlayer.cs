using System.Diagnostics;

class RandomPlayer : Player
{
	private readonly Random _random = new();
	private readonly Stopwatch _stopwatch = new();

	public RandomPlayer(char symbol) : base(symbol) { }

	public override (int x, int y) MakeMove(char[,] board)
	{
		int x, y;

		do
		{
			x = _random.Next(0, 3);
			y = _random.Next(0, 3);
		} while (board[x, y] != ' ');

		_stopwatch.Restart();
		while (_stopwatch.ElapsedMilliseconds < 1000);

		return (x, y);
	}
}