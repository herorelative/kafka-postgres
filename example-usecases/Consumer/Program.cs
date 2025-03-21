using Confluent.Kafka;

class Program
{
    static void Main(string[] args)
    {
        string bootstrapServers = "host.docker.internal:29092";
        string topic = "test-topic";
        string groupId = "test-group";

        var config = new ConsumerConfig
        {
            BootstrapServers = bootstrapServers,
            GroupId = groupId,
            AutoOffsetReset = AutoOffsetReset.Earliest,
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe(topic);
        Console.WriteLine($"Consumer started...");

        try
        {
            while (true)
            {
                var consumeResult = consumer.Consume(CancellationToken.None);
                Console.WriteLine($"Consumed: {consumeResult.Message.Value}");
            }
        }
        catch (OperationCanceledException)
        {
            consumer.Close();
        }
    }
}