using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
namespace Codefolio.Logging
{
    public class MyClass
    {
        private readonly MyILogger<MyClass> _logger;

        public MyClass(ILoggerFactoryWrapper loggerFactory)
        {
            var myLoggerFactory = loggerFactory as MyLoggerFactory;
            _logger = myLoggerFactory.CreateLogger<MyClass>();
        }

        public void MyMethod()
        {
            _logger.LogInformation("MyMethod called");
        }
    }
}
