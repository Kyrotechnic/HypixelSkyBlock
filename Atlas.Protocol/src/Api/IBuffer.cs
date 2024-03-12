namespace Atlas.Protocol.Api;

public abstract class IBuffer
{
    public List<byte> Bytes;
    public BufferMode BufferMode;
    public IBuffer(byte[] buffer, BufferMode mode)
    {
        Bytes = buffer.ToList();
        BufferMode = mode;
    }

    //Read Methods
    public abstract byte ReadByte();
    public abstract bool ReadBool();
    public abstract byte[] ReadBytes(int length);
    public abstract short ReadShort();
    public abstract ushort ReadUShort();
    public abstract int ReadInt();
    public abstract uint ReadUInt();
    public abstract float ReadFloat();
    public abstract double ReadDouble();
    public abstract long ReadLong();
    public abstract ulong ReadULong();
    public abstract string ReadString();
    public abstract int ReadVarInt();
    public abstract long ReadVarLong();


    //Write Methods



}