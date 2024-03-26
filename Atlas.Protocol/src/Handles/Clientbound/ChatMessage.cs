using System.Text.Json.Nodes;
using Atlas.Json.Serialization;
using Atlas.Protocol.Api;

namespace Atlas.Protocol.Handles.Clientbound;

public class ChatMessage : Handle<ChatMessage>
{
    public ChatMessage() : base(0x02, PacketMode.Play)
    {
        JsonValue value = JsonValue.Create(this);
    }
}