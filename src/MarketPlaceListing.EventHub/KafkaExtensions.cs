using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MarketPlaceListing.EventHub.Models;
using MarketPlaceListing.EventHub.Interfaces;
using MarketPlaceListing.EventHub.Services;

namespace MarketPlaceListing.EventHub;

public static class EventHubExtensions
{
    public static IServiceCollection AddKafkaTopicProducer(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<KafkaProducerConfig>(configuration.GetSection(EventHubConstants.KafkaConfigurationSection));
        services.AddSingleton<ITopicProducer, KafkaTopicProducer>();
        return services;
    }
}