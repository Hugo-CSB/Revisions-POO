public abstract class Forme
{
    private Point _position;

    public Point Position => _position;

    protected Forme(Point position)
    {
        _position = position;
    }

    public abstract double Perimetre();
    public abstract double Aire();
}
