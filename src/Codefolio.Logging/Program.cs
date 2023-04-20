using Codefolio.Logging;
using Microsoft.Extensions.Logging;

Codefolio.Logging.ILogger<MessageSender> logger = new ILogger<MessageSender>();
MessageSender messageSender = new MessageSender(logger);

Message message = new Message
{
    From = "sender@example.com",
    To = "recipient@example.com",
    Body = "Hello, world!"
};

messageSender.SendMessage(message);
