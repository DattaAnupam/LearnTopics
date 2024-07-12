using DependencyInjection;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add Serilog as Logger
var logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .CreateLogger();

// Clear existing logging provider
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

// Setup custom start up file
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();
