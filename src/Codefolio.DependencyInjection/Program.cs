using Codefolio.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        // Create a new service collection
        var services = new ServiceCollection();

        // Register the IMessageSender implementations as singleton services
        services.AddSingleton<IMessageSender, EmailSender>();
        services.AddSingleton<IMessageSender, SmsSender>();

        // Register the MessageSenderCollection class as a transient service that contains all registered IMessageSender instances
        services.AddTransient<MessageSenderCollection>(provider => new MessageSenderCollection(provider.GetServices<IMessageSender>()));

        // Register the MessageService class as a transient service that depends on an IMessageSender instance
        services.AddTransient<MessageService>();

        // Build the service provider
        var serviceProvider = services.BuildServiceProvider();

        // Use constructor injection to resolve a MessageService instance from the service provider
        var messageService = serviceProvider.GetService<MessageService>();

        // Use the MessageService instance to send a message using the registered IMessageSender implementation
        messageService.SendMessage("Hello, world!");

        // Use constructor injection to resolve a MessageSenderCollection instance from the service provider
        var messageSenderCollection = serviceProvider.GetService<MessageSenderCollection>();

        // Use the MessageSenderCollection instance to send a broadcast message using all registered IMessageSender implementations
        messageSenderCollection.SendMessage("This is a broadcast message.");
    }
}


