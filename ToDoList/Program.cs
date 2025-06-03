using BusinessLogic.Services;
using DataAccess;
using BusinessLogic;
using DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddData();
builder.Services.AddLogic();
builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();


app.MapControllers();

app.Run();
