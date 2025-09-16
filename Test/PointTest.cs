using Xunit;

public class PointTests
{
    [Fact]
    public void ToString_ReturnsCorrectFormat()
    {
        var p = new Point(1, 2);
        Assert.Equal("(1, 2)", p.ToString());
    }

    [Fact]
    public void Equals_ReturnsTrueForSameCoordinates()
    {
        var p1 = new Point(2, 2);
        var p2 = new Point(2, 2);
        Assert.True(p1.Equals(p2));
    }

    [Fact]
    public void Equals_ReturnsFalseForDifferentCoordinates()
    {
        var p1 = new Point(2, 2);
        var p2 = new Point(3, 2);
        Assert.False(p1.Equals(p2));
    }
}
