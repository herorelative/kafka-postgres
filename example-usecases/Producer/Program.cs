using Confluent.Kafka;

class Program
{
    static async Task Main(string[] args)
    {
        string bootstrapServers = "host.docker.internal:29092";
        string topic = "test-topic";

        var config = new ProducerConfig { BootstrapServers = bootstrapServers };

        using var producer = new ProducerBuilder<Null, string>(config).Build();
        for (int i = 1; i <= 10; i++)
        {
            string message = $"Message {i} - {DateTime.Now}";
            await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
            Console.WriteLine($"Produced: {message}");
            await Task.Delay(1000);
        }
    }
}