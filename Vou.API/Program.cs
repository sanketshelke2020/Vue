using Microsoft.EntityFrameworkCore;
using Vou.Application.AutoMapper;
using Vou.Application.Contracts;
using Vou.Application.Features.Voucher.Queries.GetVoucherList;
using Vou.Infrastructure.Context;
using Vou.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("TEst"));
//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetVoucherListQueryHandler).Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(GetVoucherListQueryHandler)));
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<IVoucherRepository,VoucherRepository>();

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
