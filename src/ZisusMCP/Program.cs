using ZisusMCP.Functions.FileSystem;
using ZisusMCP.Functions.Samples;
using ZisusMCP.Setup;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerSetup();

var app = builder.Build();

app.UseSwaggerSetup();
app.MapZisusMCPSamples();
app.MapZisusMCPFileSystem();

app.Run("http://localhost:6767");