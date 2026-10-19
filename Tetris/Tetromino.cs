namespace Tetris;

public class Tetromino
{
    private (int x, int y)[] _cells;
    public int X { get; private set; }
    public int Y { get; private set; }


    public Tetromino((int x, int y)[] shape, int startX, int startY)
    {
        X = startX;
        Y = startY;

        _cells = new (int x, int y)[shape.Length];

        for (int i = 0; i < shape.Length; i++)
        {
            _cells[i] = shape[i];
        }
    }

    public void Move(int dx, int dy)
    {
        X += dx;
        Y += dy;
    }

    public void RotateRight()
    {
        for (int i = 0; i < _cells.Length; i++)
        {
            _cells[i] = (-_cells[i].y , _cells[i].x);
        }
    }

    public void RotateLeft()
    {
        for (int i = 0; i < _cells.Length; i++)
        {
            _cells[i] = (_cells[i].y, -_cells[i].x);
        }
    }

    public (int x, int y)[] GetAbsoluteCells()
    {
        (int x, int y)[] result = new (int x, int y)[_cells.Length];
        for (int i = 0; i < _cells.Length; i++)
        {
           result[i] = (X + _cells[i].x, Y + _cells[i].y);
        }
        return result;
    }
}