using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using CoolHub.ViewModels;
using CoolHub.Entities;
using CoolHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;

namespace CoolHub
{
    public class Program
    {
        // private readonly SqliteConnection _connection;   

        public static async Task Main(string[] args)
        {   
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            builder.Services.AddScoped<IToDoViewModel, ToDoFinalViewModel>();
            builder.Services.AddScoped<ICategoriesViewModel, CategoriesViewModel>();

            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            
            builder.Services.AddScoped<ICoolHubContext, CoolHubContext>();
            // builder.Services.AddDbContext<CoolHubContext>(options => 
            //     options.UseSqlite("Data Source=:memory:"));
            
            // builder.Services.AddDbContextFactory<CoolHubContext>(opt =>
            //     opt.UseSqlite($"Data Source={nameof(CoolHubContext.CategoriesDb)}.db"));

            await builder.Build().RunAsync();
        }

        static SqliteConnection CreateConnection()
        {
    
            SqliteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SqliteConnection("Data Source=:memory:");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
    
            }
            return sqlite_conn;
      }

        private static async Task EnsureDbCreatedAndSeedWithCountOfAsync(DbContextOptions<CoolHubContext> options, int count)
        {
            // empty to avoid logging while inserting (otherwise will flood console)
            var factory = new LoggerFactory();
            var builder = new DbContextOptionsBuilder<CoolHubContext>(options)
                .UseLoggerFactory(factory);

            using var context = new CoolHubContext(builder.Options);
            // result is true if the database had to be created
            if (await context.Database.EnsureCreatedAsync())
            {
                // Seed context's data here
                // var seed = new SeedCategories();
                // await seed.SeedDatabaseWithContactCountOfAsync(context, count);
            }
        }
    }
}
