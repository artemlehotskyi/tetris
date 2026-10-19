using Tetris;

var t = new Tetromino([(-1, 0), (0, 0), (1, 0), (0, 1)], 4, 1);


var board1 = new Board(10, 5);
foreach (var cell in t.GetAbsoluteCells())
{
    board1.SetCell(cell.x, cell.y, 1);
}
board1.Draw();

Console.WriteLine("---");


t.RotateRight();

var board2 = new Board(10, 5);
foreach (var cell in t.GetAbsoluteCells())
{
    board2.SetCell(cell.x, cell.y, 1);
}
board2.Draw();