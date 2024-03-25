using Atlas.Protocol.Api;

namespace Atlas.Protocol;

public class ServerboundPacket
{
    public int Id;
    public PacketMode Mode;
    public IBuffer Buffer;

    public ServerboundPacket(int id, PacketMode mode, IBuffer buffer, bool autoWrite = true)
    {
        this.Id = id;
        this.Mode = mode;
        this.Buffer = buffer;
    }
}