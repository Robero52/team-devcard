var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
var app = builder.Build();
app.UseCors();

var team = new[]
{
    new { name = "Боб", role = "Tech Lead", fact = "Делаю всё сам" },
};

app.MapGet("/api/team", () => Results.Ok(team));

app.MapGet("/api/ping", () => Results.Ok(new
{
    status = "ok",
    time = DateTime.Now.ToString("HH:mm:ss"),
    team = "team-devcard"
}));

app.Run();