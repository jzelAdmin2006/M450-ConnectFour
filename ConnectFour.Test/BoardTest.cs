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
}
