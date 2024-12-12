using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Golf_Warehouse_WebAPI
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<GolfWarehouseContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("GolfWarehouseDb")));

        services.AddTransient<IGolfWarehouseRepository, IGolfWarehouseRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();

        services.AddControllers();

        services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.AddSerilog();
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Golf Warehouse API v1"));
        }

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
