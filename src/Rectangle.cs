public class Rectangle : Forme
{
    #region Attributs
    /// <summary>
    /// Longueur du rectangle.
    /// </summary>
    private double _longueur;

    /// <summary>
    /// Largeur du rectangle.
    /// </summary>
    private double _largeur;
    #endregion

    #region Constructeurs
    /// <summary>
    /// Crée un rectangle à partir d'un centre, d'une longueur et d'une largeur.
    /// </summary>
    /// <param name="position">Centre du rectangle.</param>
    /// <param name="longueur">Longueur du rectangle.</param>
    /// <param name="largeur">Largeur du rectangle.</param>
    public Rectangle(Point position, double longueur, double largeur) : base(position)
    {
        _longueur = longueur;
        _largeur = largeur;
    }
    #endregion

    #region Propriétés
    /// <summary>
    /// Obtient la longueur du rectangle.
    /// </summary>
    public double Longueur => _longueur;

    /// <summary>
    /// Obtient la largeur du rectangle.
    /// </summary>
    public double Largeur => _largeur;
    #endregion

    #region Méthodes
    /// <summary>
    /// Calcule le périmètre du rectangle.
    /// </summary>
    /// <returns>Le périmètre.</returns>
    public override double Perimetre() => 2 * (_longueur + _largeur);

    /// <summary>
    /// Calcule l'aire du rectangle.
    /// </summary>
    /// <returns>L'aire.</returns>
    public override double Aire() => _longueur * _largeur;
    #endregion
}
