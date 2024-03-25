using Atlas.Protocol.Api;

namespace Atlas.Protocol.Handles.Clientbound;

public class KeepAliveClient : Handle<KeepAliveClient>
{
    public int KeepAliveId;
    public KeepAliveClient(int keepAliveId) : base(0x00, PacketMode.Play)
    {
        this.KeepAliveId = keepAliveId;
    }

    public override KeepAliveClient Read(IProtocol protocol)
    {
        throw new NotImplementedException();
    }

    public override IBuffer Write(IProtocolWriter writer)
    {
        throw new NotImplementedException();
    }
}