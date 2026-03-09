using GymFinderApi.Web;
using GymFinderApi.Web.Seeders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddProgramDependencies();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json","GymFinderApi"));
}

app.MapControllers();

app.Run();
