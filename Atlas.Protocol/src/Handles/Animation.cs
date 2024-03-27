using Atlas.Minecraft.Enums;

namespace Atlas.Protocol.Handles;

public class Animation : Handle<Animation>
{
    public AnimationType Type;
    public int EntityId;
    public Animation(AnimationType animationType, int entityId) : base(0x0B, Api.PacketMode.Play)
    {
        this.Type = animationType;
        this.EntityId = entityId;
    }
}