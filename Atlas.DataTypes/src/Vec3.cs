namespace Atlas.DataTypes;

public class Vec3<T>
{
    T x;
    T y;
    T z;
    public Vec3(T x, T y, T z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public T GetX() => x;
    public T GetY() => y;
    public T GetZ() => z;

    public void SetX(T value) => x = value;
    public void SetY(T value) => y = value;
    public void SetZ(T value) => z = value;
}