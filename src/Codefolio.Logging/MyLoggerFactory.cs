using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
namespace Codefolio.Logging
{
    public class MyLoggerFactory : ILoggerFactoryWrapper
    {
        private readonly ILoggerFactory _loggerFactory;

        public MyLoggerFactory(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public MyILogger<T> CreateLogger<T>()
        {
            return new MyLoggerAdapter<T>(_loggerFactory.CreateLogger<T>());
        }
    }
}
