using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefolio.Logging
{
    public class MyLoggerAdapter<T> : MyILogger<T>
    {
        private readonly ILogger<T> _logger;

        public MyLoggerAdapter(ILogger<T> logger)
        {
            _logger = logger;
        }

        public void LogInformation(string message)
        {
            _logger.LogInformation(message);
        }

        // Add other methods here as needed
    }
}
