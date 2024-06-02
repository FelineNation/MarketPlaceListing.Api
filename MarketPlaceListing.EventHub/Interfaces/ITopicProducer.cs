namespace MarketPlaceListing.EventHub.Interfaces;

public interface ITopicProducer
{
    Task ProduceAsync(string topic, string key, string value);
}