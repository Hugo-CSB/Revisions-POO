public class Point
{
    #region Attributs
    /// <summary>
    /// Coordonnée X du point.
    /// </summary>
    private int _x;

    /// <summary>
    /// Coordonnée Y du point.
    /// </summary>
    private int _y;
    #endregion

    #region Constructeurs
    /// <summary>
    /// Crée un point de coordonnées (x, y).
    /// </summary>
    /// <param name="x">Coordonnée X.</param>
    /// <param name="y">Coordonnée Y.</param>
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }
    #endregion

    #region Propriétés
    /// <summary>
    /// Obtient la coordonnée X du point.
    /// </summary>
    public int X => _x;

    /// <summary>
    /// Obtient la coordonnée Y du point.
    /// </summary>
    public int Y => _y;
    #endregion

    #region Méthodes
    /// <summary>
    /// Détermine si deux points sont égaux.
    /// </summary>
    /// <param name="obj">Objet à comparer.</param>
    /// <returns>Vrai si les points ont les mêmes coordonnées, sinon faux.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is Point other)
            return _x == other._x && _y == other._y;
        return false;
    }

    /// <summary>
    /// Retourne le code de hachage du point.
    /// </summary>
    /// <returns>Code de hachage.</returns>
    public override int GetHashCode() => HashCode.Combine(_x, _y);

    /// <summary>
    /// Retourne une représentation textuelle du point.
    /// </summary>
    /// <returns>Chaîne de caractères représentant le point.</returns>
    public override string ToString() => $"({_x}, {_y})";
    #endregion
}
