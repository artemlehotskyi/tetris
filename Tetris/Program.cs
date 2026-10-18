using Tetris;

var board = new Board(10, 20);

Console.WriteLine(board.IsInside(0,0));
Console.WriteLine(board.IsInside(9,19));
Console.WriteLine(board.IsInside(10,0));
Console.WriteLine(board.IsInside(0,20));
Console.WriteLine(board.IsInside(0,20));
Console.WriteLine(board.IsInside(-1,5));


board.Draw();

Console.WriteLine(board.SetCell(0,0,1));
Console.WriteLine(board.SetCell(9,19,1));
Console.WriteLine(board.SetCell(10,0,1));

board.Draw();

Console.WriteLine(board.IsEmpty(0,0));
Console.WriteLine(board.IsEmpty(5,5));
Console.WriteLine(board.IsEmpty(10,0));