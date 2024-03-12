namespace Atlas.Protocol;

using System.Linq.Expressions;
using System.Reflection;
using Atlas.Logger;
using Atlas.Protocol.Api;
public abstract class IProtocol
{
    public List<ProtocolMember> ProtocolMembers = new();
    public ProtocolInfo protocolInfo;
    public DebugLogger Logger;
    public IProtocol(ProtocolInfo info)
    {
        Logger = new(this.GetType().Name, true);

        protocolInfo = info;
    }

    public void Register(Func<ServerboundPacket, bool> func, int Id, PacketMode Mode)
    {
        ProtocolMembers.Add(new(func, Id, Mode));

        Logger.WriteDebug("Registering 0x" + Id.ToString("X2") + " with mode " + Mode);
    }

    private void SetProtocolInfo(ProtocolInfo info)
    {
        this.protocolInfo = info;
    }

    public void HandlePacket(ServerboundPacket packet)
    {
        ProtocolMember member = ProtocolMembers.Find(c => c.PacketId == packet.Id && c.Mode == packet.Mode)!;

        if (member == null)
        {
            Logger.WriteError("Invalud packet id requested!");

            return;
        }
        
        member.func(packet);
    }
}