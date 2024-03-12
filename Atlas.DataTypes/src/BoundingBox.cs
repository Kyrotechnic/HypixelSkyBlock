namespace Atlas.DataTypes;

public class BoundingBox
{
    public Vec3<double> pos1;
    public Vec3<double> pos2;

    public BoundingBox(Vec3<double> pos1, Vec3<double> pos2)
    {
        this.pos1 = pos1;
        this.pos2 = pos2;
    }

    public bool IsWithin(Vec3<double> pos)
    {
        if (
            ((pos1.GetX() <= pos.GetX() || pos1.GetX() >= pos.GetX()) && (pos2.GetX() <= pos.GetX() || pos2.GetX() >= pos.GetX())) &&
            ((pos1.GetY() <= pos.GetY() || pos1.GetY() >= pos.GetY()) && (pos2.GetY() <= pos.GetY() || pos2.GetY() >= pos.GetY())) &&
            ((pos1.GetZ() <= pos.GetZ() || pos1.GetZ() >= pos.GetZ()) && (pos2.GetZ() <= pos.GetZ() || pos2.GetZ() >= pos.GetZ()))
        )
            return true;
        return false;
    }
}