public class Rectangle : Forme
{
    private double _longueur;
    private double _largeur;

    public double Longueur => _longueur;
    public double Largeur => _largeur;

    public Rectangle(Point position, double longueur, double largeur) : base(position)
    {
        _longueur = longueur;
        _largeur = largeur;
    }

    public override double Perimetre() => 2 * (_longueur + _largeur);

    public override double Aire() => _longueur * _largeur;
}
