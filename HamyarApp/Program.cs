var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (HttpContext context, RequestDelegate next) =>
{

    //context.Response.StatusCode = 400;
    await context.Response.WriteAsync("Text1");
    await next(context);

});
app.Use(async (context, next) =>
{

    await context.Response.WriteAsync("Text2");
    await next(context);

});
app.Use(async (HttpContext context, RequestDelegate next) =>
{

    await context.Response.WriteAsync("Text3");
    await next(context);

});
app.Use(async (HttpContext context, RequestDelegate next) =>
{

    await context.Response.WriteAsync("Text4");
    //await next(context);

});







app.Run();
