using Atlas.Protocol.Api;

namespace Atlas.Protocol;

public class ProtocolMember
{
    public PacketMode Mode;
    public int PacketId;
    public Func<ServerboundPacket, bool> func;
    public ProtocolMember(Func<ServerboundPacket, bool> func, int Id, PacketMode mode)
    {
        this.func = func;
        this.PacketId = Id;
        this.Mode = mode;
    }
}