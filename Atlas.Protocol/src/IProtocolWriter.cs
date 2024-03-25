using System.Reflection;
using Atlas.Protocol.Api;
using Atlas.Protocol.Handles.Clientbound;

namespace Atlas.Protocol;

public abstract class IProtocolWriter
{
    public List<WriterMember> Writers;
    public IProtocolWriter()
    {
        Writers = new();
    }

    public abstract IBuffer GetDefaultBuffer();
    public abstract void HandleError(string message);

    public void Register<T1>(Func<T1, IBuffer, IBuffer> func) where T1 : Handle
    {
        Type type = func.GetMethodInfo().GetParameters()[0].GetType();

        Func<Handle, IBuffer, IBuffer> func1 = (handle, buffer) => func((T1) handle, buffer);

        Writers.Add(new(type, func1));
    }

    public ClientboundPacket WritePacket<T>(T packetClass) where T : Handle<T>
    {
        IBuffer buffer = this.GetDefaultBuffer();
        ClientboundPacket packet = new(packetClass.Id, packetClass.Mode, buffer, packetClass, true);

        buffer = this.UseWriter<T>(packetClass, buffer);
        packet.Buffer = buffer;

        return packet;
    }

    public IBuffer UseWriter<T>(T packetClass, IBuffer buffer) where T : Handle<T>
    {
        int id = packetClass.Id;
        PacketMode mode = packetClass.Mode;

        WriterMember writer = Writers.Find(c => c.Type == typeof(T))!;

        if (writer == null)
        {
            this.HandleError("Could not find writer requested! Maybe invalid protocol?");
            return buffer;
        }

        buffer.WriteBytes(writer.func(packetClass, buffer).Bytes.ToArray());

        return buffer;
    }
}