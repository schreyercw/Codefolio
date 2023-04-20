using Microsoft.Extensions.Logging;

namespace Codefolio.Logging
{
    public interface ILoggerFactoryWrapper
    {
        MyILogger<T> CreateLogger<T>();
    }
}
