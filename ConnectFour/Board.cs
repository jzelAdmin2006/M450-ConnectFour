namespace ConnectFour;

public class Board
{
    public const char PLAYER_1 = 'x';
    public const char PLAYER_2 = 'o';
    private const char EMPTY = '_';
    private const int ROWS = 6;
    private const int COLS = 7;
    public Board()
    {
        fields = new char[ROWS][];
        for (var r = 0; r < fields.Length; r++)
        {
            fields[r] = new char[COLS];
            for (var c = 0; c < fields[r].Length; c++)
            {
                fields[r][c] = EMPTY;
            }
        }
    }
    private char[][] fields;

    public void Output()
    {
        for (var c = 0; c < fields[0].Length; c++)
        {
            Console.Write($"{c+1} ");
            Console.WriteLine();
        }
        for (var r = 0; r < fields.Length; r++)
        {
            for (var c = 0; c < fields[r].Length; c++)
            {
                Console.Write($"{fields[r][c]} ");
            }
            Console.WriteLine();
        }
    }
}
