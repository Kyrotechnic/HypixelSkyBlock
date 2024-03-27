using Atlas.Minecraft.Enums;
using Atlas.Protocol.Api;

namespace Atlas.Protocol.Handles;

public class ChatMessage : Handle<ChatMessage>
{
    public ChatMessage Message;
    public ChatMessageType MessageType;
    public ChatMessage(ChatMessage message, ChatMessageType messageType) : base(0x02, 0x01, PacketMode.Play)
    {
        this.Message = message;
        this.MessageType = messageType;
    }
}