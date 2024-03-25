using Atlas.Protocol.Api;

namespace Atlas.Protocol;

public class ClientboundPacket
{
    public int Id;
    public PacketMode Mode;
    public IBuffer Buffer;
    public Handle Handle;
    public ClientboundPacket(int Id, PacketMode mode, IBuffer buffer, Handle handle, bool autoWrite = true)
    {
        this.Id = Id;
        this.Mode = mode;
        this.Buffer = buffer;
        this.Handle = handle;

        if (autoWrite)
            buffer.WriteVarInt(Id);
    }
}