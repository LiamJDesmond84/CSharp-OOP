using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CSharpOOP {
    public class Program {
        public static void Main(string[] args) {

        //* Notice the type for the new object reference
        //* is the same as the class name
        Vehicle myVehicle = new Vehicle();
        Console.WriteLine($"My vehicle is holding {myVehicle.NumPassengers} people");


            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
