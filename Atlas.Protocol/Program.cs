

using Atlas.Protocol;


ServerboundPacket packet = new();

packet.Id = 0x00;
packet.Mode = Atlas.Protocol.Api.PacketMode.Ping;