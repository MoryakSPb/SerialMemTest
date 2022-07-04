using System.Diagnostics;
using Apex.Serialization;
using MessagePack;
using ProtoBuf;
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

Stopwatch stopwatch = new Stopwatch();
for (int i = 0; i < 10; i++)
{
    stopwatch.Restart();
    long messagePackLength = MessagePackSerializer.Serialize(member).LongLength;
    stopwatch.Stop();
    Console.WriteLine($"MessagePack time = {stopwatch.Elapsed.TotalMilliseconds:F4} ms");

    IBinary serializer = Binary.Create(new Settings().MarkSerializable(typeof(Member)));
    await using MemoryStream stream = new();
    stopwatch.Restart();
    serializer.Write(member, stream);
    stopwatch.Stop();
    Console.WriteLine($"Apex time = {stopwatch.Elapsed.TotalMilliseconds:F4} ms");
    long apexLength = stream.Position;

    await using MemoryStream stream2 = new();
    Serializer.PrepareSerializer<Member>();
    stopwatch.Restart();
    Serializer.Serialize(stream2, member);
    stopwatch.Stop();
    Console.WriteLine($"ProtoBuf time = {stopwatch.Elapsed.TotalMilliseconds:F4} ms");
    long protobufLength = stream2.Position;


    Console.WriteLine($"messagePackLength = {messagePackLength}");
    Console.WriteLine($"apexLength = {apexLength}");
    Console.WriteLine($"protobufLength = {protobufLength}");
    Console.WriteLine("----------");
}

