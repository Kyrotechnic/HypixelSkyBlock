namespace Atlas.DataTypes;

public class Position
{
    public float yaw;
    public float pitch;

    Vec3<double> coordinates;

    public Position(Vec3<double> position, float yaw, float pitch)
    {
        this.coordinates = position;
        this.yaw = yaw;
        this.pitch = pitch;
    }
}