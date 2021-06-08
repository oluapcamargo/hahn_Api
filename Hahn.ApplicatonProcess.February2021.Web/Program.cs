using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hahn.ApplicatonProcess.February2021.Data.Commands.AssetCommands;
using Hahn.ApplicatonProcess.February2021.Data.Context;
using Hahn.ApplicatonProcess.February2021.Data.Queries.AssetQueries;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Hahn.ApplicatonProcess.February2021.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();        
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).ConfigureServices((hostContext, services) =>
                {
                    //query Commmands
                    services.ConfigureDbContext(hostContext.Configuration);
                    services.AddMediatR(typeof(QueryGetByIdAssetCommandHandler));

                    //Commmands Handler
                    services.AddMediatR(typeof(CommandDeleteAssetHandler));
                    services.AddMediatR(typeof(CommandInsertAssetHandler));
                    services.AddMediatR(typeof(CommandUpdateAssetHandler));


                });
    }
}
