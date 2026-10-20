using Tetris;

var board = new Board(10, 5);
var t = new Tetromino([(-1, 0), (0, 0), (1, 0), (0, 1)], 4, 1);


Console.WriteLine($"старт:          {board.CanPlace(t)}");


t.Move(0, 3);
Console.WriteLine($"за дном:        {board.CanPlace(t)}");


t.Move(0, -1);
Console.WriteLine($"після відкату:  {board.CanPlace(t)}");


board.Lock(t);
board.Draw();

var t2 = new Tetromino([(-1, 0), (0, 0), (1, 0), (0, 1)], 4, 1);
Console.WriteLine($"нова на старті: {board.CanPlace(t2)}");
t2.Move(0, 2);
Console.WriteLine($"накладання:     {board.CanPlace(t2)}");

var t3 = new Tetromino([(-1, 0), (0, 0), (1, 0), (0, 1)], 0, 1);
Console.WriteLine($"за лівою стіною: {board.CanPlace(t3)}");