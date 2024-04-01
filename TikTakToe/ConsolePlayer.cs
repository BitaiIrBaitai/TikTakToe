

class ConsolePlayer : Player
{
	public ConsolePlayer(char symbol) : base(symbol)
    {
		
	}

	public override (int x, int y) MakeMove(char[,] board)
    {
		Console.Write("Enter x: ");
		int x = int.Parse(Console.ReadLine());
		Console.Write("Enter y: ");
		int y = int.Parse(Console.ReadLine());

		return (x, y);
	}
}
