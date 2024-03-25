using Atlas.Protocol.Api;

namespace Atlas.Protocol;

public class WriterMember
{
    public Type Type;
    public Func<Handle, IBuffer, IBuffer> func;

    public WriterMember(Type type, Func<Handle, IBuffer, IBuffer> func)
    {
        this.Type = type;
        this.func = func;
    }
}