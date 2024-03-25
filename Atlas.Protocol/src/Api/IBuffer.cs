using Atlas.DataTypes;

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
    public abstract Position ReadPosition();
    public abstract Guid ReadUuid();



    //Write Methods

    public abstract void WriteByte(byte value);
    public abstract void WriteBool(bool value);
    public abstract void WriteBytes(byte[] bytes);
    public abstract void WriteShort(short value);
    public abstract void WriteInt(int value);
    public abstract void WriteUInt(uint value);
    public abstract void WriteFloat(float value);
    public abstract void WriteDouble(double value);
    public abstract void WriteLong(long value);
    public abstract void WriteULong(ulong value);
    public abstract void WriteString(string value);
    public abstract void WriteVarInt(int value);
    public abstract void WriteVarLong(long value);
    public abstract void WritePosition(Position value);
    public abstract void WriteUuid(Guid value);

}