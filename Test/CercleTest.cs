using Xunit;
using System;

public class CercleTests
{
    [Fact]
    public void Perimetre_CalculatesCorrectly()
    {
        var c = new Cercle(new Point(0, 0), 10);
        Assert.Equal(2 * Math.PI * 10, c.Perimetre(), 10);
    }

    [Fact]
    public void Aire_CalculatesCorrectly()
    {
        var c = new Cercle(new Point(0, 0), 10);
        Assert.Equal(Math.PI * 100, c.Aire(), 10);
    }

    [Fact]
    public void Propriete_Rayon()
    {
        var c = new Cercle(new Point(0, 0), 5);
        Assert.Equal(5, c.Rayon);
    }
}
