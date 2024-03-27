using Atlas.Protocol.Api;

namespace Atlas.Protocol;

public abstract class Handle
{
    public int SendId;
    public int ReadId;
    public readonly PacketMode Mode;
    public readonly PacketDirection Direction;
    public Handle(int id, PacketMode mode, PacketDirection direction)
    {
        this.SendId = id;
        this.ReadId = id;
        this.Mode = mode;
        this.Direction = direction;

        if (direction == PacketDirection.Determine)
        {
            string fullName = this.GetType().Namespace!;

            direction = fullName.Contains("Clientbound") ? PacketDirection.Clientbound : PacketDirection.Serverbound;
        }
    }
}

public abstract class Handle<T> : Handle where T : Handle<T>
{
    public Handle(int id, PacketMode mode, PacketDirection direction = PacketDirection.Determine) : base(id, mode, direction)
    {

    }

    public Handle(int sendId, int readId, PacketMode mode, PacketDirection direction = PacketDirection.Determine) : base(sendId, mode, direction)
    {
        this.SendId = sendId;
        this.ReadId = readId;
    }

    public T? Read(IProtocol protocol, ServerboundPacket packet)
    {
        if (Direction == PacketDirection.Clientbound)
        {
            protocol.HandleError("Tried to read a clientbound packet as a serverbound!");

            return default;
        }
        return protocol.HandlePacket<T>(packet);
    }

    public IBuffer? Write(IProtocolWriter writer)
    {
        if (Direction == PacketDirection.Serverbound)
        {
            writer.HandleError("Tried to write a serverbound packet to the client!");

            return null;
        }

        IBuffer buffer = writer.GetDefaultBuffer();

        return writer.UseWriter<T>(this, buffer);
    }
}