namespace MarketPlaceListing.EventHub.Models;


public class KafkaProducerConfig
{
    public string? BootstrapServers { get; set; }
    public string? SchemaRegistryUrl { get; set; }
    public string? Topic { get; set; }
}