public class Cercle : Forme
{
    #region Attributs
    private double _rayon;
    #endregion

    #region Constructeurs
    public Cercle(Point position, double rayon) : base(position)
    {
        _rayon = rayon;
    }
    #endregion

    #region Propriétés
    public double Rayon => _rayon;
    #endregion

    #region Méthodes
    public override double Perimetre() => 2 * Math.PI * _rayon;

    public override double Aire() => Math.PI * _rayon * _rayon;
    #endregion
}
