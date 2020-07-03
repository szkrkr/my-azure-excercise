using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace appconfiguration {
    public class Program {
        public static void Main (string[] args) {
            CreateHostBuilder (args).Build ().Run ();
        }

        public static IHostBuilder CreateHostBuilder (string[] args) =>
            Host.CreateDefaultBuilder (args)
            .ConfigureWebHostDefaults (webBuilder =>
                webBuilder.ConfigureAppConfiguration ((hostingContext, config) => {
                    var settings = config.Build ();
                    config.AddAzureAppConfiguration (settings["ConnectionStrings:AppConfig"]);
                })
                .UseStartup<Startup> ());
    }
}