var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.UseAuthorization();
app.MapControllers();

app.Run("http://0.0.0.0:8080");
