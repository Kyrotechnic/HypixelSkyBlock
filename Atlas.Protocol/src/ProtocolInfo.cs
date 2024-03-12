namespace Atlas.Protocol;

public class ProtocolInfo
{
    public int reccomendedVersion;
    public int minimumVersion;
    public int maximumVersion;
    public ProtocolInfo(int reccomendedVersion, int minimumVersion, int maximumVersion)
    {
        this.reccomendedVersion = reccomendedVersion;
        this.minimumVersion = minimumVersion;
        this.maximumVersion = maximumVersion;
    }

    public ProtocolInfo(int reccomendedVersion)
    {
        this.reccomendedVersion = reccomendedVersion;
        this.minimumVersion = reccomendedVersion;
        this.maximumVersion = reccomendedVersion;
    }
}