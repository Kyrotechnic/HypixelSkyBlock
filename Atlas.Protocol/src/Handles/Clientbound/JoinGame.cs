using Atlas.Minecraft.Enums;
using Atlas.Protocol.Api;

namespace Atlas.Protocol.Handles.Clientbound;

public class JoinGame : Handle<JoinGame>
{
    public int EntityId;
    public Gamemode Gamemode;
    public Dimension Dimension;
    public Difficulty Difficulty;
    public byte MaxPlayers;
    string LevelType;
    bool ExtraDebugInfo;
    public JoinGame(int entityId, Gamemode gamemode, Dimension dimension, Difficulty difficulty, byte maxPlayers, string levelType, bool extraDebug) : base(0x01, PacketMode.Play)
    {
        this.EntityId = entityId;
        this.Gamemode = gamemode;
        this.Dimension = dimension;
        this.Difficulty = difficulty;
        this.MaxPlayers = maxPlayers;
        this.LevelType = levelType;
        this.ExtraDebugInfo = extraDebug;
    }
}