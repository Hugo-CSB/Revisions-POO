public abstract class Forme
{
    #region Attributs
    /// <summary>
    /// Position (centre) de la forme.
    /// </summary>
    private Point _position;
    #endregion

    #region Constructeurs
    /// <summary>
    /// Initialise une nouvelle instance de la classe Forme.
    /// </summary>
    /// <param name="position">Position (centre) de la forme.</param>
    protected Forme(Point position)
    {
        _position = position;
    }
    #endregion

    #region Propriétés
    /// <summary>
    /// Obtient la position (centre) de la forme.
    /// </summary>
    public Point Position => _position;
    #endregion

    #region Méthodes
    /// <summary>
    /// Calcule le périmètre de la forme.
    /// </summary>
    /// <returns>Le périmètre.</returns>
    public abstract double Perimetre();

    /// <summary>
    /// Calcule l'aire de la forme.
    /// </summary>
    /// <returns>L'aire.</returns>
    public abstract double Aire();
    #endregion
}
