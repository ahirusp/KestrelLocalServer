using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace KestrelLocalServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running demo with kestrel.");

            var dict = new Dictionary<string, string>();

            var config = new ConfigurationBuilder()
                .AddInMemoryCollection(dict)
                .Build();

            var builder = new WebHostBuilder()
                .UseConfiguration(config)
                .UseStartup<Startup>()
                .UseKestrel(options =>
                {

                })
                .UseUrls("http://localhost:5000")
                .UseContentRoot(Directory.GetCurrentDirectory());

            var host = builder.Build();
            host.Run();
        }
    }
}