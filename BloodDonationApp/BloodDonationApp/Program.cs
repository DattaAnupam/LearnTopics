using BloodDonationApp;

var builder = WebApplication.CreateBuilder(args);

// Declare Custom Startup class
Startup startUp = new Startup(builder.Configuration);
startUp.ConfigureServices(builder.Services);

var app = builder.Build();

startUp.Configure(app, app.Environment);

app.Run();
