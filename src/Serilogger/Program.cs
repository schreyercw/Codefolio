// Create logger configuration
using Serilog;
// Configure Serilog to write logs to the console
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger();

// Log some messages
Log.Information("Starting application");
Log.Debug("Debug message");
Log.Warning("Warning message");
Log.Error("Error message");

// Clean up Serilog
Log.CloseAndFlush();