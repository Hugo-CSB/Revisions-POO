using Xunit;

public class RectangleTests
{
    [Fact]
    public void Perimetre_CalculatesCorrectly()
    {
        var r = new Rectangle(new Point(0, 0), 10, 5);
        Assert.Equal(30, r.Perimetre());
    }

    [Fact]
    public void Aire_CalculatesCorrectly()
    {
        var r = new Rectangle(new Point(0, 0), 10, 5);
        Assert.Equal(50, r.Aire());
    }

    [Fact]
    public void Propriete_Longueur_Largeur()
    {
        var r = new Rectangle(new Point(0, 0), 10, 5);
        Assert.Equal(10, r.Longueur);
        Assert.Equal(5, r.Largeur);
    }
}
