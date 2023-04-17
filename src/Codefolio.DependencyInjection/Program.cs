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

        // Register the MessageService class as a transient service
        services.AddTransient<MessageService>();

        // Build the service provider
        var serviceProvider = services.BuildServiceProvider();

        // Resolve a MessageService instance from the service provider
        var messageService = serviceProvider.GetService<MessageService>();

        // Use the MessageService instance to send a message using one of the IMessageSender implementations
        messageService.SendMessage("Hello, world!");
    }
}