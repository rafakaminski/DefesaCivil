using Microsoft.EntityFrameworkCore;
using defesaCivil.Repository.Context;
using defesaCivil.Repository.Interfaces;
using defesaCivil.Repository.Repositories;
using defesaCivil.Service.Interfaces;
using defesaCivil.Service.Services;


namespace defesaCivil
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            #region Injeção de Dependência

            builder.Services.AddDbContext<defesaCivilContext>(options =>
                options.UseNpgsql(builder.Configuration.GetValue<string>("ConnectionStrings:defesaCivil")));

            builder.Services.AddScoped<IOcorrenciaService, OcorrenciaService>();

            builder.Services.AddScoped<IOcorrenciaRepository, OcorrenciaRepository>();

            #endregion



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Ocorrencia}/{action=Form}/{id?}");

            app.Run();

        }
    }

}



