public class Cercle : Forme
{
    #region Attributs
    /// <summary>
    /// Rayon du cercle.
    /// </summary>
    private double _rayon;
    #endregion

    #region Constructeurs
    /// <summary>
    /// Crée un cercle à partir d'un centre et d'un rayon.
    /// </summary>
    /// <param name="position">Centre du cercle.</param>
    /// <param name="rayon">Rayon du cercle.</param>
    public Cercle(Point position, double rayon) : base(position)
    {
        _rayon = rayon;
    }
    #endregion

    #region Propriétés
    /// <summary>
    /// Obtient le rayon du cercle.
    /// </summary>
    public double Rayon => _rayon;
    #endregion

    #region Méthodes
    /// <summary>
    /// Calcule le périmètre du cercle.
    /// </summary>
    /// <returns>Le périmètre.</returns>
    public override double Perimetre() => 2 * Math.PI * _rayon;

    /// <summary>
    /// Calcule l'aire du cercle.
    /// </summary>
    /// <returns>L'aire.</returns>
    public override double Aire() => Math.PI * _rayon * _rayon;
    #endregion
}
