using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Turner_demo_server.Entities.Award;
using Turner_demo_server.Entities.Genre;
using Turner_demo_server.Entities.OtherName;
using Turner_demo_server.Entities.Participant;
using Turner_demo_server.Entities.StoryLine;
using Turner_demo_server.Entities.Title;
using Turner_demo_server.Entities.TitleGenre;
using Turner_demo_server.Entities.TitleParticipant;

namespace Turner_demo_server
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            services.AddTransient<TitleContext>();
            services.AddTransient<AwardContext>();
            services.AddTransient<GenreContext>();
            services.AddTransient<OtherNameContext>();
            services.AddTransient<ParticipantContext>();
            services.AddTransient<StoryLineContext>();
            services.AddTransient<TitleGenreContext>();
            services.AddTransient<TitleParticipantContext>();

            var connectionString = @"Server=localhost\SQLEXPRESS;Database=Titles;Trusted_Connection=True;";
            services.AddDbContext<TitleContext>( o => o.UseSqlServer(connectionString));
            services.AddDbContext<AwardContext>( o => o.UseSqlServer(connectionString));
            services.AddDbContext<GenreContext>( o => o.UseSqlServer(connectionString));
            services.AddDbContext<OtherNameContext>( o => o.UseSqlServer(connectionString));
            services.AddDbContext<ParticipantContext>( o => o.UseSqlServer(connectionString));
            services.AddDbContext<StoryLineContext>( o => o.UseSqlServer(connectionString));
            services.AddDbContext<GenreContext>( o => o.UseSqlServer(connectionString));
            services.AddDbContext<TitleGenreContext>( o => o.UseSqlServer(connectionString));
            services.AddDbContext<TitleParticipantContext>( o => o.UseSqlServer(connectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
