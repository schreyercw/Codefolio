using Codefolio.Logging;
using Microsoft.Extensions.Logging;

class Program
{
    static void Main(string[] args)
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        var myLoggerFactory = new MyLoggerFactory(loggerFactory);
        var myClass = new MyClass(myLoggerFactory);
        myClass.MyMethod();
    }
}