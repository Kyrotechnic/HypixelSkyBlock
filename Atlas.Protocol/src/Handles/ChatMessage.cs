using Atlas.Protocol.Api;

namespace Atlas.Protocol.Handles;

public class ChatMessage : Handle<ChatMessage>
{
    public ChatMessage() : base(0x01, PacketMode.Play, PacketDirection.Both)
    {
        
    }
}