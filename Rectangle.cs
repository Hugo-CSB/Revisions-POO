public class Rectangle : Forme
{
    #region Attributs
    private double _longueur;
    private double _largeur;
    #endregion

    #region Constructeurs
    public Rectangle(Point position, double longueur, double largeur) : base(position)
    {
        _longueur = longueur;
        _largeur = largeur;
    }
    #endregion

    #region Propriétés
    public double Longueur => _longueur;
    public double Largeur => _largeur;
    #endregion

    #region Méthodes
    public override double Perimetre() => 2 * (_longueur + _largeur);

    public override double Aire() => _longueur * _largeur;
    #endregion
}
