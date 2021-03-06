using ConsoletoWebAPI;
using ConsoletoWebAPI.Repository;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient<CustomerMiddleware>();

builder.Services.TryAddScoped<IProductRepository, ProductRepository>();
builder.Services.TryAddScoped<IProductRepository, TestRepository>();

var app = builder.Build();

//app.UseMiddleware<CustomerMiddleware>();

//app.Run(context =>
// context.Response.WriteAsync("Hello from Use-1 1\n"));

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseStaticFiles();

app.Run();
