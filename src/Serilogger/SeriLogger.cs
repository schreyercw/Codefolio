using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Events;

namespace Codefolio.Logging
{
    public class SeriLogger<T> : ILogger<T> where T : SeriLogger<T>
    {
        private readonly Serilog.Core.Logger _logger;

        public T CategoryName => throw new NotImplementedException();

        public Serilogger()
        {
            _logger = logger;
        }
        public void Info(string message)
        {
            Log.Information(message);
        }

        public void Warn(string message)
        {
            Log.Warning(message);
        }

        public void Error(string message)
        {
            Log.Error(message);
        }

        public void Fatal(string message)
        {
            Log.Fatal(message);
        }

        public void Debug(string message)
        {
            Log.Debug(message);
        }

        public void Fatal(string message, Exception exception)
        {
            Log.Fatal(exception, message);
        }

        public void Error(string message, Exception exception)
        {
            Log.Error(exception, message);
        }

        

        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }
    }
}
