public class Point
{
    #region Attributs
    private int _x;
    private int _y;
    #endregion

    #region Constructeurs
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }
    #endregion

    #region Propriétés
    public int X => _x;
    public int Y => _y;
    #endregion

    #region Méthodes
    public override bool Equals(object? obj)
    {
        if (obj is Point other)
            return _x == other._x && _y == other._y;
        return false;
    }

    public override int GetHashCode() => HashCode.Combine(_x, _y);

    public override string ToString() => $"({_x}, {_y})";
    #endregion
}

