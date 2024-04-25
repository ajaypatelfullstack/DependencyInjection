var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IResponseFormatter, TextResponseFormatter>();
var app = builder.Build();


//IResponseFormatter formatter = new TextResponseFormatter();

app.MapGet("format", async (HttpContext context, IResponseFormatter formatter) =>
{
    await formatter.Format(context, "This is function based middleware");
});
app.Run();
