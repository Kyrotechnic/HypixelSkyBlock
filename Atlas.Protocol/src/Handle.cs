using Atlas.Protocol.Api;

namespace Atlas.Protocol;

public abstract class Handle
{
    public int Id;
    public PacketMode Mode;
    public Handle(int id, PacketMode mode)
    {
        this.Id = id;
        this.Mode = mode;
    }
}

public abstract class Handle<T> : Handle where T : Handle
{
    public Handle(int id, PacketMode mode) : base(id, mode)
    {
            
    }

    public abstract T Read(IProtocol protocol);
    public abstract IBuffer Write(IProtocolWriter writer);
}