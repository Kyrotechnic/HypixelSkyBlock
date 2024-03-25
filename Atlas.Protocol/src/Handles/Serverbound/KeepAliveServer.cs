using Atlas.Protocol.Api;

namespace Atlas.Protocol.Handles.Serverbound;

public class KeepAliveServer : Handle<KeepAliveServer>
{
    public int KeepAliveId;
    public KeepAliveServer(int aliveId) : base(0x00, PacketMode.Play)
    {
        this.KeepAliveId = aliveId;
    }

    public override KeepAliveServer Read(IProtocol protocol)
    {
        throw new NotImplementedException();
    }

    public override IBuffer Write(IProtocolWriter writer)
    {
        throw new NotImplementedException();
    }
}