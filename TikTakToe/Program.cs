Player player1 = new ConsolePlayer('☻');
Player player2 = new RandomPlayer('☺');

BoardDrawer boardDrawer = new ColoredGridBoardDrawer(	ConsoleColor.Cyan,
														ConsoleColor.Magenta,
														ConsoleColor.Red,
														player1.Symbol,
														player2.Symbol);

TicTakToeGame game = new(player1, player2, boardDrawer);

game.Play();
