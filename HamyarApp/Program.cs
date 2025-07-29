using HamyarApp.ConstraintFolder;
using HamyarApp.NewFolder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//builder.Services.AddTransient<MiddlewareClass>();
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


//app.MapGet("/", () => "Hello World!");

app.Run();


//builder.Services.AddRouting(option =>
//{

//    option.ConstraintMap.Add("month", typeof(MyConstraints));
//});

//app.UseRouting();
//app.UseEndpoints(endpoints =>
//{


//});


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







