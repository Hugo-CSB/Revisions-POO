public abstract class Forme
{
    #region Attributs
    private Point _position;
    #endregion

    #region Constructeurs
    protected Forme(Point position)
    {
        _position = position;
    }
    #endregion

    #region Propriétés
    public Point Position => _position;
    #endregion

    #region Méthodes
    public abstract double Perimetre();
    public abstract double Aire();
    #endregion
}
