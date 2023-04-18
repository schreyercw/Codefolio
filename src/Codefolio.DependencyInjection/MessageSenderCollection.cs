using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefolio.DependencyInjection
{
    public class MessageSenderCollection : IMessageSender
    {
        private readonly IEnumerable<IMessageSender> _senders;

        public MessageSenderCollection(IEnumerable<IMessageSender> senders)
        {
            _senders = senders;
        }

        public void SendMessage(string message)
        {
            foreach (var sender in _senders)
            {
                sender.SendMessage(message);
            }
        }
    }
}
