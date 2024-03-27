namespace Atlas.Protocol;

using System.Linq.Expressions;
using System.Net.Sockets;
using System.Reflection;
using Atlas.Logger;
using Atlas.Protocol.Api;
//using Atlas.Protocol.Handles.Serverbound;

public abstract class IProtocol
{
    public List<ProtocolMember> ProtocolMembers = new();
    public ProtocolInfo protocolInfo;
    public DebugLogger Logger;
    public bool HasWriter {get; private set;}
    public IProtocolWriter? Writer;
    public IProtocol(ProtocolInfo info, IProtocolWriter? writer = null)
    {
        Logger = new(this.GetType().Name, true);

        protocolInfo = info;

        this.HasWriter = writer == null;
        
        if (HasWriter)
        {
            this.Writer = writer;
        }
    }

    public void Register<T>(Func<ServerboundPacket, T> func, int Id = -1, PacketMode Mode = PacketMode.Ping) where T : Handle<T>
    {
        Func<ServerboundPacket, Handle> func1 = (packet) => func(packet);

        //Check if not overrided the id and mode.
        if (Id == -1)
        {
            ConstructorInfo info = typeof(T).GetConstructors()[0];

            T destine = (T) info.Invoke(null);

            Id = destine.ReadId;
            Mode = destine.Mode;
        }

        ProtocolMembers.Add(new(func1, Id, Mode));

        Logger.WriteDebug("Registering 0x" + Id.ToString("X2") + " with mode " + Mode);
    }

    private void SetProtocolInfo(ProtocolInfo info)
    {
        this.protocolInfo = info;
    }

    public T HandlePacket<T>(ServerboundPacket packet) where T : Handle
    {
        ProtocolMember member = ProtocolMembers.Find(c => c.PacketId == packet.Id && c.Mode == packet.Mode)!;

        if (member == null)
        {
            Logger.WriteError("Invalid packet id requested!");

            return default!;
        }
        
        return (T) member.func(packet);
    }

    public ClientboundPacket? WritePacket<T>(T packet) where T : Handle<T>
    {
        if (HasWriter)
            return Writer!.WritePacket(packet);
        return null;
    }

    public abstract void HandleNewClient(TcpClient client, int protocolVersion);
    public abstract void HandleError(string message);
}