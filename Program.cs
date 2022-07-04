using Apex.Serialization;
using MessagePack;
using SerialMemTest;

Member member = new()
{
    ConcurrencyToken = Guid.NewGuid(),
    DiscordId = 266672873882648577UL,
    Id = Guid.NewGuid(),
    IsSquadCommander = true,
    LastChanged = DateTime.UtcNow,
    MicrosoftId = null,
    Nickname = "MoryakSPb",
    Rank = 452,
    RealName = "Александр",
    SquadNumber = 0,
    SteamId = 1215,
    TelegramId = 24352154,
    VkId = 0,
    SquadPartNumber = 1,
    Description = null
};

long messagePackLength = MessagePackSerializer.Serialize(member).LongLength;

IBinary serializer = Binary.Create(new Settings().MarkSerializable(typeof(Member)));
await using MemoryStream stream = new();
serializer.Write(member, stream);
long apexLength = stream.Position;

Console.WriteLine($"MessagePackLength = {messagePackLength:D5}");
Console.WriteLine($"ApexLength = {apexLength:D5}");