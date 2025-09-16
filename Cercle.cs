public class Cercle : Forme
{
    private double _rayon;

    public double Rayon => _rayon;

    public Cercle(Point position, double rayon) : base(position)
    {
        _rayon = rayon;
    }

    public override double Perimetre() => 2 * Math.PI * _rayon;

    public override double Aire() => Math.PI * _rayon * _rayon;
}
