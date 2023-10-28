using Lajada.Domain.Context;
using Lajada.Domain.IRepository;
using Lajada.Domain.IRepository.IGenericRepository;
using Lajada.Domain.Repository;
using Lajada.Domain.Repository.GenericRepository;
using Lajada.Services;
using Lajada.Services.IServiceRepository;
using Lajada.Services.ServiceRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(
//    options =>
//{
//    options.ReturnHttpNotAcceptable = true;
//}
)
//.AddXmlDataContractSerializerFormatters()
.AddNewtonsoftJson();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LajadaDbContext>(
        dbContextOptions => dbContextOptions.UseSqlServer(
            builder.Configuration["ConnectionStrings:DBConnectionString"]));

builder.Services.AddScoped<IPersonalInformationRepository, PersonalInformationRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddTransient(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddTransient<IPersonalInformationService, PersonalInformationService>();
builder.Services.lajadaServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
