namespace Atlas.DataTypes;

public class Vec2<T>
{
    T x;
    T z;
    public Vec2(T x, T z)
    {
        this.x = x;
        this.z = z;
    }

    public T GetX() => x;
    public T GetY() => z;

    public void SetX(T value) => x = value;
    public void SetZ(T value) => x = value;
}