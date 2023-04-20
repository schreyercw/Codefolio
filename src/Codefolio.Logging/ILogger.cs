using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefolio.Logging
{
    public interface ILogger
    {
        void Info(string message);
        void Warn(string message);
        void Error(string message);
        void Fatal(string message);
        void Debug(string message);
        void Fatal(string message, Exception exception);
        void Error(string message, Exception exception);
        //void Log(LogLevel logLevel, EventId eventId, object state, Exception exception, Func<object, Exception, string> formatter);
        bool IsEnabled(LogLevel logLevel);
        IDisposable BeginScope<TState>(TState state);
    }

    public interface ILogger<out TCatagoryName> : ILogger
    {
        TCatagoryName CategoryName { get; }
    }
}