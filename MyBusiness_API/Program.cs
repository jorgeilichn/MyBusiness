using Microsoft.EntityFrameworkCore;
using MyBusiness_API;
using MyBusiness_DB;
using MyBusiness_DB.Repositories;

internal class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<BusinessContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("BusinessConnection"))
        );

        builder.Services.AddAutoMapper(typeof(MappingConfig));

        builder.Services.AddScoped<IProductRepository, ProductRepository>();

        var app = builder.Build();
        
        using (var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<BusinessContext>();
            context.Database.Migrate();
        }

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
    }
}