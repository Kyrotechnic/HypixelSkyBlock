using Atlas.Protocol.Api;

namespace Atlas.Protocol.Handles;

public class KeepAlive : Handle<KeepAlive>
{
    public int KeepAliveId;
    public KeepAlive(int keepAliveId) : base(0x00, PacketMode.Play, PacketDirection.Both)
    {
        this.KeepAliveId = keepAliveId;
    }
}