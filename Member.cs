using MessagePack;

namespace SerialMemTest;

[MessagePackObject]
public record Member
{
    [Key(0)]
    public Guid Id { get; set; }

    [Key(1)]
    public ulong? DiscordId { get; set; }

    [Key(2)]
    public ulong? SteamId { get; set; }

    [Key(3)]
    public long? MicrosoftId { get; set; }

    [Key(4)]
    public uint VkId { get; set; }

    [Key(5)]
    public long? TelegramId { get; set; }

    [Key(6)]
    public string Nickname { get; set; } = string.Empty;

    [Key(7)]
    public string? RealName { get; set; }

    [Key(8)]
    public short Rank { get; set; }

    [Key(9)]
    public bool IsSquadCommander { get; set; }

    [Key(10)]
    public short? SquadNumber { get; set; }

    [Key(11)]
    public short SquadPartNumber { get; set; }

    [Key(12)]
    public DateTime LastChanged { get; set; }

    [Key(13)]
    public Guid ConcurrencyToken { get; set; }

    [Key(14)]
    public string? Description { get; set; }
}