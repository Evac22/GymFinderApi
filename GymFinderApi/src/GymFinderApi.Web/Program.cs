var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json","GymFinderApi"));
}

app.MapControllers();

app.Run();
