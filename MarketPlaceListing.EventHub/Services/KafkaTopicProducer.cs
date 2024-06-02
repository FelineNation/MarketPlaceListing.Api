using Confluent.Kafka;
using MarketPlaceListing.EventHub.Interfaces;
using MarketPlaceListing.EventHub.Models;
using Microsoft.Extensions.Options;

namespace MarketPlaceListing.EventHub.Services;

public class KafkaTopicProducer : ITopicProducer
{
    
    private readonly IProducer<Null, string> _producer;

    public KafkaTopicProducer(KafkaProducerConfig config, IOptions<KafkaProducerConfig> producerConfig)
    {
        var configKafka = new ProducerConfig { BootstrapServers = config.BootstrapServers };
        _producer = new ProducerBuilder<Null, string>(configKafka).Build();
    }

    public async Task ProduceAsync(string topic, string key, string value)
    {
        try {
            var message = new Message<string, string> { Key = key, Value = value };
            await _producer.ProduceAsync(topic, message).ConfigureAwait(false);
        } catch (Exception e) {
            Console.WriteLine($"Delivery failed: {e.Message}");
        }
    }
}