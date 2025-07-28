
namespace HamyarApp.NewFolder
{
    public class MiddlewareClass : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Started");
            await next(context);
            await context.Response.WriteAsync("Finished");
        }
    }
}
