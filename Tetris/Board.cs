namespace Tetris;

public class Board
{

    private int[,] _grid;
    public int Width { get; }
    public int Height { get; }
    
    public Board(int width, int height)
    {
        Width = width;
        Height = height;
        _grid = new int[height, width];
    }
    
    public bool IsInside(int x, int y)
    {
        return x >= 0 && x < Width && y >= 0 && y < Height;
    }
    
    public bool IsEmpty(int x, int y)
    {
        return IsInside(x, y) && _grid[y, x] == 0;
    }

    public void Draw()
    {
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                if (_grid[y, x] == 0)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write('#');
                }
            }
            Console.WriteLine();
        }
    }
    public bool SetCell(int x, int y, int value)
    {
        if (!IsInside(x, y))
        {
            return false;
        }
        _grid[y, x] = value;
        return true;
    }
}