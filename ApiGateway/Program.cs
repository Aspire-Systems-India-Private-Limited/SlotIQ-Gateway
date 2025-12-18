using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json");

builder.Services.AddOcelot();
// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("ApiCorsPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:3000","https://localhost:3000") // Allow the frontend origin
              .AllowAnyMethod() // Allow all HTTP methods
              .AllowAnyHeader() // Allow all headers
              .AllowCredentials(); // Allow cookies/auth headers
    });
});

var app = builder.Build();

// IMPORTANT: CORS must be added BEFORE Ocelot
app.UseCors("ApiCorsPolicy");

await app.UseOcelot();
 
app.Run();
