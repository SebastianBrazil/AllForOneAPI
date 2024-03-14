using AllForOneAPI.Services.HelloThere;
using AllForOneAPI.Services.AdditionCalculator;
using AllForOneAPI.Services.SomeQuestions;
using AllForOneAPI.Services.GOLT;
using AllForOneAPI.Services.MadLib;
using AllForOneAPI.Services.OddOrEven;
using AllForOneAPI.Services.ReverseText;
using AllForOneAPI.Services.ReverseNum;
using AllForOneAPI.Services.Magic8Ball;
using AllForOneAPI.Services.RP;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy",
    builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    }
    );
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IHelloThereService, HelloThereService>();
builder.Services.AddScoped<IAdditionCalculatorService, AdditionCalculatorService>();
builder.Services.AddScoped<ISomeQuestionsService, SomeQuestionsService>();
builder.Services.AddScoped<IGOLTService, GOLTService>();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseTextService, ReverseTextService>();
builder.Services.AddScoped<IReverseNumService, ReverseNumService>();
builder.Services.AddScoped<IMagic8BallService, Magic8BallService>();
builder.Services.AddScoped<IRPService, RPService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CORSPolicy");

app.MapControllers();

app.Run();
