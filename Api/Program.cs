
using Services.AutoMapper.Profiles;
using Services.Extensions;
using System.Text.Json.Serialization;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers()
                .AddJsonOptions(x =>
                        x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            //    .AddRazorRuntimeCompilation().AddJsonOptions(opt =>
            //{
            //    opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            //    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            //});
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddAutoMapper(typeof(ClientProfile));
            builder.Services.LoadMyServices(builder.Configuration.GetConnectionString("SHFT_AssignmentLocalDB"));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}
