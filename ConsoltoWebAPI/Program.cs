using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>

     {
         await context.Response.WriteAsync("Hello from new Web API app");
     });
    endpoints.MapGet("/test", async context =>

     {
         await context.Response.WriteAsync("Hello from new Web API app test");
     });
});

app.UseStaticFiles();

app.Run();
