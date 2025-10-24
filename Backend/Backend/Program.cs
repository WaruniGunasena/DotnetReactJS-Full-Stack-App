var builder = WebApplication.CreateBuilder(args);

// services
builder.Services.AddControllers();

var app = builder.Build();

// middlewares
app.MapControllers();

app.Run();
