namespace ConnectFour.Test;

public class BoardTest
{
    [Fact]
    public void TestInvalidMoveReturnsInvalidPlaceholder()
    {
        int invalidColumnMove = 7;
        Board board = new Board();

        int result = board.MakeMove('x', invalidColumnMove);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void TestDifferentInvalidMoveReturnsInvalidPlaceholder()
    {
        int invalidColumnMove = -1;
        Board board = new Board();

        int result = board.MakeMove('x', invalidColumnMove);

        Assert.Equal(-1, result);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(6)]
    public void TestInvalidWinnerRowReturnsEmpty(int invalidRow)
    {
        Board board = new Board();

        char result = board.Winner('x', invalidRow, 0);

        Assert.Equal(Board.EMPTY, result);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(7)]
    public void TestInvalidWinnerColumnReturnsEmpty(int invalidCol)
    {
        Board board = new Board();

        char result = board.Winner('x', 0, invalidCol);

        Assert.Equal(Board.EMPTY, result);
    }

    [Theory]
    [InlineData(-1, -1)]
    [InlineData(-1, 7)]
    [InlineData(6, -1)]
    [InlineData(6, 7)]
    public void TestInvalidWinnerRowColumnReturnsEmpty(int invalidRow, int invalidCol)
    {
        Board board = new Board();

        char result = board.Winner('x', invalidRow, invalidCol);

        Assert.Equal(Board.EMPTY, result);
    }
}
