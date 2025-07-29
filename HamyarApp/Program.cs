using HamyarApp.NewFolder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MiddlewareClass>();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{


});

//app.MapGet("/", () => "Hello World!");

//app.Use(async (context, next) =>
//{

//    //context.Response.StatusCode = 400;
//    await context.Response.WriteAsync("Text1\n");
//    await next(context);

//});
//app.UseMiddleware<MiddlewareClass>();
//app.UseTests();
//app.Use(async (context, next) =>
//{

//    await context.Response.WriteAsync("Text3");
//    await next(context);

//});
//app.Use(async (HttpContext context, RequestDelegate next) =>
//{

//    await context.Response.WriteAsync("Text4");
//    //await next(context);

//});







app.Run();
