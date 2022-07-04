using MessagePack;
using ProtoBuf;

namespace SerialMemTest;

[MessagePackObject]
[ProtoContract(Name = nameof(Member))]
public record Member
{
    [Key(0)]
    [ProtoMember(1)]
    public Guid Id { get; set; }

    [Key(1)]
    [ProtoMember(2)]
    public ulong? DiscordId { get; set; }

    [Key(2)]
    [ProtoMember(3)]
    public ulong? SteamId { get; set; }

    [Key(3)]
    [ProtoMember(4)]
    public long? MicrosoftId { get; set; }

    [Key(4)]
    [ProtoMember(5)]
    public uint VkId { get; set; }

    [Key(5)]
    [ProtoMember(6)]
    public long? TelegramId { get; set; }

    [Key(6)]
    [ProtoMember(7)]
    public string Nickname { get; set; } = string.Empty;

    [Key(7)]
    [ProtoMember(8)]
    public string? RealName { get; set; }

    [Key(8)]
    [ProtoMember(9)]
    public short Rank { get; set; }

    [Key(9)]
    [ProtoMember(10)]
    public bool IsSquadCommander { get; set; }

    [Key(10)]
    [ProtoMember(11)]
    public short? SquadNumber { get; set; }

    [Key(11)]
    [ProtoMember(12)]
    public short SquadPartNumber { get; set; }

    [Key(12)]
    [ProtoMember(13)]
    public DateTime LastChanged { get; set; }

    [Key(13)]
    [ProtoMember(14)]
    public Guid ConcurrencyToken { get; set; }

    [Key(14)]
    [ProtoMember(15)]
    public string? Description { get; set; }
}