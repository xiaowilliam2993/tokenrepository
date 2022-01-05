using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using TokenRepository.Backend.Extensions;

namespace TokenRepository.Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //System.Threading.Thread.Sleep(30000);

            bool isStartAsService = !(Debugger.IsAttached || args.Contains("--console"));

            if (isStartAsService)
            {
                var rootPath = AppContext.BaseDirectory;
                Directory.SetCurrentDirectory(rootPath);
            }

            var builder = CreateHostBuilder(args.Where(_ => _ != "--console").ToArray());
            IHost host;
            if (isStartAsService)
            {
                host = builder.UseWindowsService().Build();
            }
            else
            {
                host = builder.Build();
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();   
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<TokenRepositoryBackgroundService>();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .UseUrls(configuration["urls"])
                    .UseSerilog((ctx, config) => config.ReadFrom.Configuration(ctx.Configuration));
                });
        }
            
    }
}
