public class TextResponseFormatter : IResponseFormatter
{
    private int responseInt = 0;
    private static TextResponseFormatter? _singleton;
    public static TextResponseFormatter Singleton
    {
        get
        {
            if (_singleton == null)
            {
                _singleton = new TextResponseFormatter();
            }
            return _singleton;
        }
    }
    public async Task Format(HttpContext context, string content)
    {
        if (context.Request.Path == "/format")
        {
            await context.Response.WriteAsync($"Response: {++responseInt} \n {content}");
        }
    }
}