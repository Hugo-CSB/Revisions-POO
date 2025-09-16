public class Point
{
    private int _x;
    private int _y;

    public int X => _x;
    public int Y => _y;

    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Point other)
            return _x == other._x && _y == other._y;
        return false;
    }

    public override int GetHashCode() => HashCode.Combine(_x, _y);

    public override string ToString() => $"({_x}, {_y})";
}
