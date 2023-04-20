using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Codefolio.Logging
{
    public class Message
    {
        public string? From { get; set; }
        public string? To { get; set; }
        public string? Body { get; set; }
    }

    public class MessageSender
    {
        private readonly ILogger<MessageSender> _logger;

        public MessageSender(ILogger<MessageSender> logger)
        {
            _logger = logger;
        }

        public void SendMessage(Message message)
        {
            _logger.Info($"Sending message from {message.From} to {message.To}: {message.Body}");
            // Code to send message goes here
        }
    }
}
