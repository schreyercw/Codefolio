using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefolio.DependencyInjection
{
    public class MessageService
    {
        private readonly IMessageSender _sender;

        public MessageService(IMessageSender sender)
        {
            _sender = sender;
        }

        public void SendMessage(string message)
        {
            _sender.SendMessage(message);
        }
    }
}
