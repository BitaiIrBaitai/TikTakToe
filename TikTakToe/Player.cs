

abstract class Player
{
    public char Symbol { get; private set; }

    public Player(char symbol)
    {
		Symbol = symbol;
	}

    public abstract (int x, int y) MakeMove(char[,] board);
}
