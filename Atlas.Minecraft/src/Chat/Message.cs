namespace Atlas.Minecraft.Chat;

public class Message
{
    public Message(string message)
    {
        text = message;
    }

    public string text = string.Empty;
    public bool bold = false;
    public bool italic = false;
    public bool underlined = false;
    public bool strikethrough = false;
    public bool obfuscated = false;
}