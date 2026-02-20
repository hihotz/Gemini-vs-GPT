using ModelContextProtocol.Server;

var builder = WebApplication.CreateBuilder(args);

var urls = Environment.GetEnvironmentVariable("MCP_SERVER_URLS");
if (!string.IsNullOrWhiteSpace(urls))
{
    builder.WebHost.UseUrls(urls);
}

builder.Services
    .AddMcpServer()
    .WithHttpTransport()
    .WithToolsFromAssembly();

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { service = "LotHistoryMcp", status = "ok" }));
app.MapMcp("/mcp");

app.Run();
