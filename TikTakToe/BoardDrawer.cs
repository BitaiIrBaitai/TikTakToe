

class BoardDrawer
{
    public virtual void Draw(char[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
			for (int j = 0; j < 3; j++)
                Console.Write(board[j, i]);
			Console.WriteLine();
		}
    }
}