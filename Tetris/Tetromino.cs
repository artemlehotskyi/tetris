namespace Tetris;

public class Tetromino
{
    private (int x, int y)[] _cells;
    public int X { get; private set; }
    public int Y { get; private set; }


    public Tetromino((int x, int y)[] shape, int startX, int startY)
    {
        
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
}