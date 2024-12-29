using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore; // Importa o Entity Framework Core
using ProjetoCadastro.Data; // Namespace do seu DbContext
using AutoMapper;

namespace ProjetoCadastro
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Este m�todo adiciona os servi�os necess�rios ao container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup)); // Adiciona o AutoMapper e escaneia os perfis

            // Configurando o DbContext com a string de conex�o
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); // Atualize para a string correta

            // Adiciona suporte para controladores e views
            services.AddControllersWithViews();
        }

        // Este m�todo configura o pipeline de requisi��es HTTP
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Contatos}/{action=Index}/{id?}");
            });
        }
    }
}
