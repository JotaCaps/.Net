var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/banana", () => 
{
    return Results.Ok("Hello World!");
});

app.MapGet("/{nome}", (string nome) => 
{
    return Results.Ok($"Hello {nome}");
});

app.MapPost("/", (User user)=>{
    return Results.Ok(user);
});

app.Run();

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
}
