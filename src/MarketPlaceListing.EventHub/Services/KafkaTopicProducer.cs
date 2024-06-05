using Confluent.Kafka;
using MarketPlaceListing.EventHub.Interfaces;
using MarketPlaceListing.EventHub.Models;
using Microsoft.Extensions.Options;

namespace MarketPlaceListing.EventHub.Services;

public class KafkaTopicProducer : ITopicProducer
{
    
    private readonly IProducer<Null, string> _producer;

    public KafkaTopicProducer()
    {
    }

    public async Task ProduceAsync(string topic, string key, string value)
    {
        throw new NotFiniteNumberException();
    }
}