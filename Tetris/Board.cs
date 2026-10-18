namespace Tetris;

public class Board
{

    private int[,] grid;
    public int Width { get; }
    public int Height { get; }
    
    
    public Board(int width, int height)
    {
        Width = width;
        Height = height;
        grid = new int[height, width];
    }
    
    public bool isInside(int x, int y)
    {
        return x >= 0 && x < Width && y >= 0 && y < Height;
    }

    public bool IsEmpty(int x, int y)
    {
        return isInside(x, y) && grid[y, x] == 0;
    }

    public void Draw()
    {
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                if (grid[y, x] == 0)
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
    
}